using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace arrenda_me.Models
{
    public class Property
    {
        public int id { get; set; }

        public int idTipology { get; set; }

        public int idOwner { get; set; }

        public int idDistrict { get; set; }

        public int idCity { get; set; }

        public int idLocality { get; set; }

        public int area { get; set; }

    }
}