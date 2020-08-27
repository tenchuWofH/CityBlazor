using System.Collections.Generic;

namespace CityBlazor.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCapital { get; set; }

        public ICollection<PointOfInterest> PointsOfInterest { get; set; } = new List<PointOfInterest>();
    }
}