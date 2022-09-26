namespace HotelListing.API.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }


        public virtual IList<Hotel> Hotels { get; set; }

    }
}
