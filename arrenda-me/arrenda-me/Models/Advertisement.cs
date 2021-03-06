﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace arrenda_me.Models
{
    public class Advertisement
    {
        public int id { get; set; }


        public virtual Property Parent { get; set; }

     //           [ForeignKey("Parent")]
        public int idProperty { get; set; }
        public int price { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public bool active { get; set; }

        public string title { get; set; }

        public string description { get; set; }


    }
}