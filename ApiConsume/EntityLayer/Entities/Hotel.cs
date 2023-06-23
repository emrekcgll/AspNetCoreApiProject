﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Hotel
    {
        public int HotelID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int LocationID { get; set; }
        public Location Location { get; set; }

        //public List<Comment> Comments { get; set; }
    }
}
