using System;
using System.Collections.Generic;

namespace sepbackend.Controllers.Resources
{
    public class RequestResource
    {
        public int Id { get; set; }
        public string RecordNumber { get; set; }
        
        public string ClientName { get; set; }
        public string EventType { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
        public int numberOfAttendees { get; set; }
        public int ExpectedBudget { get; set; }
        public int UserId { get; set; }
        
    }
}