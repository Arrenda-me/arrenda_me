using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace arrenda_me.Models
{
    public class Notification
    {
        public int id { get; set; }
        public string senderName { get; set; }
        public int phoneNumber { get; set; }
        public string email { get; set; }
        public string body { get; set; }
        public int idUser { get; set; }
        public int idAdvertisement { get; set; }


    }
}