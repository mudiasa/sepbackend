using System;
using System.ComponentModel.DataAnnotations;
using sepbackend.Core.Models;

namespace sepbackend.Controllers.Resources
{
    public class CreateEventResource
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Type { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime FinishDate { get; set; }

        [Required]
        public int ClientId { get; set; }
        [Required]
        public int UserId { get; set; }

        
    }
}