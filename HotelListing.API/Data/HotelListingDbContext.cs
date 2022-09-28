using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Canada",
                    CountryCode = "CAN"
                },
                new Country
                {
                    Id = 2,
                    Name = "United States of America",
                    CountryCode = "USA"
                },
                 new Country
                 {
                     Id = 3,
                     Name = "Morocco",
                     CountryCode = "MAR"
                 });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Queen's Hotel",
                    Address = "Montreal",
                    CountryId = 1,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Washington Resort",
                    Address = "New York",
                    CountryId = 2,
                    Rating = 4.5
                },
                 new Hotel
                 {
                     Id = 3,
                     Name = "Royal Palace",
                     Address = "Marrakech",
                     CountryId = 3,
                     Rating = 4.9
                 });
        }
    }
}
