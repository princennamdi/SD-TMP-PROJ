using Microsoft.AspNetCore.Mvc.Rendering;
using ncs1.Models.Location;
using ncs1.Models.Zones;

namespace ncs1.Models.CommandNg
{
    public class CommandNg
    {
        public Guid Id { get; set; }
        public string CommandName { get; set; }

        public ZoneNg? CommandZone { get; set; }

        public LocationNg? CommandLocation { get; set; }

    }
}
