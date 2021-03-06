using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool freeDelivery { get; set; }
        public double Price { get; set; }
        public DateTime dateOfLaunch { get; set; }
        public bool Active { get; set; }
    }
}
