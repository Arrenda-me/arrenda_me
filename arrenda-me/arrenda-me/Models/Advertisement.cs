using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace arrenda_me.Models
{
    public class Advertisement
    {
        public int id { get; set; }
        public int idProperty { get; set; }
        public int price { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public int startDate { get; set; }
        public int endDate { get; set; }


    }
}