using ncs1.Models.Location;
using ncs1.Models.Zones;

namespace ncs1.Models.StationNg
{
    public class StationNg
    {
        public Guid Id { get; set; }
        public string StationName { get; set; }
        public Guid? Command { get; set; }
    }
}
