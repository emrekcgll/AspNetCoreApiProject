using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Address { get; set; }

        public List<Hotel> Hotels { get; set; }
    }
}
