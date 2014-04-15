using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;



namespace arrenda_me.Models
{
    public class Attribute
    {

        public virtual Property Parent { get; set; }

        [ForeignKey("Parent")]
        public int id { get; set; }
        public bool furnished { get; set; }
        public bool equipped { get; set; }
        public bool elevator { get; set; }
        public bool petsAllowed { get; set; }
        public bool pool { get; set; }
    }
}