using System.ComponentModel.DataAnnotations;

namespace sepbackend.Controllers.Resources
{
    public class CreateUserResource
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string UserName { get; set; }
        [Required]
        [StringLength(255)]
        public string Password { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(255)]
        public string LastName { get; set; }
        [Required]
        [StringLength(255)]
        public string Department { get; set; }
        [Required]
        [StringLength(255)]
        public string Type { get; set; }
    }
}