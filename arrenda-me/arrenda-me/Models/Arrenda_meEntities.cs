using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace arrenda_me.Models
{
    public class Arrenda_meEntities : DbContext
    {

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Property> Properties { get; set; }

        public DbSet<Attribute> Attributes { get; set; }

        public DbSet<User> Users { get; set; }

        public Arrenda_meEntities()
        {

            this.Properties.Add(new Property
            {
                
                idTipology = 1,
                idOwner = 1,
                description = "descriçao",
               title = "titulo",
               active = true,
               endDate = new DateTime(),
               startDate = new DateTime(),
              
               latitude = 3,
               longitude = (float)3.55,
               price = 50,
                idLocality = 1,
                area = 43,
                idCity = 1
            });
            this.Properties.Add(new Property
            {
                  
                idTipology = 1,
                idOwner = 1,              
                description = "descriçao",
               title = "titulo",
               active = true,
               endDate = new DateTime(),
               startDate = new DateTime(),
           
               latitude = 3,
               longitude = (float)3.55,
               price = 50,
                idLocality = 1,           
                area = 43,
                idCity = 1
            });


           this.Notifications.Add(new Notification { senderName="sender", phoneNumber=91333, email="sds", body="Quero comprar", idUser=1, idProperty=1 });


           this.Users.Add(new User { password = "pass", email = "mail@mail.com", contact = 3 });
            
            this.SaveChanges();
           
        }

    }
}