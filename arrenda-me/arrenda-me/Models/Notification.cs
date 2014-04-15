using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace arrenda_me.Models
{
    public class Notification
    {


        public virtual User ParentUser { get; set; }

        public virtual Advertisement ParentAd { get; set; }

        public int id { get; set; }
        public string senderName { get; set; }
        public int phoneNumber { get; set; }
        public string email { get; set; }
        public string body { get; set; }
        
        [ForeignKey("ParentUser")]
        public int idUser { get; set; }
                [ForeignKey("ParentAd")]
        public int idAdvertisement { get; set; }


    }
}