using System;
using System.Collections.Generic;

namespace CityBlazor.Shared.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsCapital { get; set; }

        public Country Country { get; set; }
        public ICollection<PointOfInterest> PointsOfInterest { get; set; } = new List<PointOfInterest>();
    }
}