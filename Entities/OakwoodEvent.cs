using System;

namespace OakwoodApp.Entities
{
    public class OakwoodEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int MinistryId { get; set; }
    }
}