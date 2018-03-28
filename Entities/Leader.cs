using System;
using System.Collections.Generic;

namespace OakwoodApp.Entities 
{
    public class Leader 
    {
        public Leader()
        {
            Ministries = new List<Ministry>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public string ImageUrl { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Ministry> Ministries { get; set; }
    }
}