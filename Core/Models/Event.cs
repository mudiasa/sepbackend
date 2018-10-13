using System;
using System.ComponentModel.DataAnnotations;

namespace sepbackend.Core.Models
{
    public class Event
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
        public Client Client { get; set; }


        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}