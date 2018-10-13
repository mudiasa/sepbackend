using System.ComponentModel.DataAnnotations;

namespace sepbackend.Controllers.Resources
{
    public class CreatePreferenceResource
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Required]
        public int RequestId { get; set; }

    }
}