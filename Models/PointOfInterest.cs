namespace CityBlazor.Models
{
    public class PointOfInterest
    {
        public int PointOfInterestId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }
    }
}