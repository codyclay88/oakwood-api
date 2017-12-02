using System;
using System.Collections.Generic;

namespace OakwoodApp.Entities
{
    public class Ministry
    {
        public Ministry()
        {
            OakwoodEvents = new List<OakwoodEvent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<OakwoodEvent> OakwoodEvents { get; set; }
    }
}