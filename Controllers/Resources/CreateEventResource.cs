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
        public int NumberOfAttendees { get; set; }
        public string Description { get; set; }
        [StringLength(255)]
        public string ClientName { get; set; }
        [StringLength(255)]
        public string ClientPhone { get; set; }
        [Required]
        public int Budget { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string FinishDate { get; set; }

        [Required]
        public int ClientId { get; set; }
        [Required]
        public int UserId { get; set; }
        public Boolean isCreated { get; set; }
        public Boolean isSentToCSManager { get; set; }
        public Boolean isSentToProdManagers { get; set; }
        public Boolean isSentToSubTeams { get; set; }

        
    }
}