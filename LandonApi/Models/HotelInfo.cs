using System;
namespace LandonApi.Models
{
    public class HotelInfo : Resources
    {
        public string Title { get; set; }

        public string Tagline { get; set; }

        public string Email { get; set; }

        public string Webiste { get; set; }

        public Address Location { get; set; }

    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
