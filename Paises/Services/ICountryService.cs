using Paises.DTOs;

namespace Paises.Services
{
    public interface ICountryService
    {
        Task<List<CountryDTO>> GetAll(int pageNumber, int recordsPerPage, string filter);
        int GetTotalRecords(string filter);
    }
}
