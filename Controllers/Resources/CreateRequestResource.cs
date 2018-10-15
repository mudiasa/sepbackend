using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sepbackend.Controllers.Resources
{
    public class CreateRequestResource
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string RecordNumber { get; set; }
        [Required]
        [StringLength(255)]
        public string ClientName { get; set; }
        [Required]
        [StringLength(255)]
        public string EventType { get; set; }
        [StringLength(400)]
        public string Description { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string FinishDate { get; set; }
        [Required]
        public int numberOfAttendees { get; set; }
        [Required]
        public int ExpectedBudget { get; set; }
        [Required]
        public int UserId { get; set; }
        
    }
}