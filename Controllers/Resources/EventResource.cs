using System;

namespace sepbackend.Controllers.Resources
{
    public class EventResource
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int NumberOfAttendees { get; set; }
        public int Budget { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
    }
}