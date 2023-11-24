using Microsoft.AspNetCore.Mvc.Rendering;

namespace ncs1.Models.CommandNg
{
    public class CommandNgViewModel
    {
        public string? Command { get; set; }
        public List<SelectListItem>? Commands { get; set; }
    }
}
