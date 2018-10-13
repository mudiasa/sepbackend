using System.ComponentModel.DataAnnotations;

namespace sepbackend.Core.Models
{
    public class Preference
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Required]
        public int RequestId { get; set; }
        public Request Request { get; set; }
        
    }
}