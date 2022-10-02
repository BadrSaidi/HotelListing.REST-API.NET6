using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repositories
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        public CountriesRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
