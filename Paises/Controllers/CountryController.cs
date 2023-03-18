using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Paises.Services;
using System.Net;
using System.Text.Json;


namespace Paises.Controllers
{
    [Route("/country")]
    public class CountryController : Controller
    {
        private readonly ICountryService _service;
        private readonly ILogger<CountryController> logger;

        public CountryController(ICountryService service, IMapper mapper, ILogger<CountryController> logger)
        {
            _service = service;
            this.logger = logger;
        }
        [HttpGet]
        public async Task<ActionResult<string>> GetAll (int pageNumber, int recordsPerPage,string filter)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(await _service.GetAll(pageNumber, recordsPerPage,filter));
                var response = Ok(jsonString);
                HttpContext.Response.Headers.Add("X-records-Total-Count",  _service.GetTotalRecords(filter).ToString());
                return Ok(response);
            }
            catch(Exception ex)
            {
                logger.LogError("Error", ex);
                return NoContent();
            }
        }
    }
}
