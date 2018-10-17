using System;

namespace sepbackend.Controllers.Resources
{
    public class EventResource
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int NumberOfAttendees { get; set; }
        public string Description { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public int Budget { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public Boolean isCreated { get; set; }
        public Boolean isSentToCSManager { get; set; }
        public Boolean isSentToProdManagers { get; set; }
        public Boolean isSentToSubTeams { get; set; }
    }
}