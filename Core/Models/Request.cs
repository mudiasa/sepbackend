using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sepbackend.Core.Models
{
    public class Request
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
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime FinishDate { get; set; }
        [Required]
        public int NumberOfAttendees { get; set; }
        [Required]
        public int ExpectedBudget { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}