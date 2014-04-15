using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace arrenda_me.Models
{
    public class Property
    {
        public int id { get; set; }

        public int idTipology { get; set; }


        public virtual User Parent { get; set; }

        [ForeignKey("Parent")]

        public int idOwner { get; set; }

        public int idDistrict { get; set; }

        public int idCity { get; set; }

        public int idLocality { get; set; }

        public int area { get; set; }

        public bool active { get; set; }

        public string title { get; set; }

        public string description { get; set; }
    }
}