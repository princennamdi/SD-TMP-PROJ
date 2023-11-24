using System.ComponentModel.DataAnnotations;
using ncs1.Data.Enums;

namespace ncs1.Models
{
    public class Wish
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="Please insert your name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please insert your wish")]
        [StringLength(500)]
        public string Wishes { get; set; }

        [Required(ErrorMessage = "Incorrect")]
        public Relationship Relationship { get; set; }

        public long DateTime { get; set; }


    }   
}
