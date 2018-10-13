using System.ComponentModel.DataAnnotations;

namespace sepbackend.Controllers.Resources
{
    public class CreateClientResource
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Phone { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
    }
}