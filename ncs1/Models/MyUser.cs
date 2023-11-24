using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ncs1.Models
{
    public class MyUser : IdentityUser
    {

        [Required]
        public string SvcNo { get; set; }

        public string OfficialName { get; set; }
        public Guid? Command { get; set; } = new Guid("48f01282-c019-4bb6-92b8-36c85d650370");
        public Guid? Station { get; set; }
        //public string State { get; set; }


    }
}
