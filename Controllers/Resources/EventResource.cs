using System;

namespace sepbackend.Controllers.Resources
{
    public class EventResource
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
    }
}