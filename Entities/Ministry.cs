using System;
using System.Collections.Generic;

namespace OakwoodApp.Entities
{
    public class Ministry
    {
        public Ministry()
        {
            Leaders = new List<Leader>();
            OakwoodEvents = new List<OakwoodEvent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Mission { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Leader> Leaders { get; set; }
        public ICollection<OakwoodEvent> OakwoodEvents { get; set; }
    }
}