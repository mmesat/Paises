using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Paises.Data;
using Paises.DTOs;
using Paises.Entity;

namespace Paises.Services
{
    public class CountryService : ICountryService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public CountryService(ApplicationContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<CountryDTO>> GetAll(int pageNumber, int recordsPerPage, string filter)
        {

            if (filter is null || filter == string.Empty) 
            {
                var resultQuery = await _context.Countries
                 .Include(c => c.CountryRestaurants)
                 .ThenInclude(cr => cr.restaurant)
                 .Include(c => c.CountryHotels)
                 .ThenInclude(ch => ch.hotel).ToListAsync();

                return _mapper.Map<List<CountryDTO>>(resultQuery);
            }
            else { 
            var resultQuery = await _context.Countries
                             .Include(c => c.CountryRestaurants)
                             .ThenInclude(cr => cr.restaurant)
                             .Include(c => c.CountryHotels)
                             .ThenInclude(ch => ch.hotel).ToListAsync();
            var resultFilter = resultQuery.Where(x => x.Name.Contains(filter) ||
                                        x.Code.Contains(filter) ||
                                        x.CountryHotels.Any(y => y.hotel.Name.Contains(filter)) ||
                                        x.CountryRestaurants.Any(z => z.restaurant.Name.Contains(filter))
                                        )
                                        .ToList()
                                        .Skip((pageNumber - 1) * recordsPerPage)
                                        .Take(recordsPerPage).ToList();
            return _mapper.Map<List<CountryDTO>>(resultFilter);
            }
        }

        public int GetTotalRecords(string filter)
        {
            if (filter is null || filter == string.Empty) 
            {
               return  _context.Countries.Count();
            }
            else
            {
                return _context.Countries.Where(x => x.Name.Contains(filter) ||
                       x.Code.Contains(filter) ||
                       x.CountryHotels.Any(y => y.hotel.Name.Contains(filter)) ||
                       x.CountryRestaurants.Any(z => z.restaurant.Name.Contains(filter))).Count();
            }
        }
            
    }
}
