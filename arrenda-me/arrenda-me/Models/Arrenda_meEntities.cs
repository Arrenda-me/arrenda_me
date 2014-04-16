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
        
        public DbSet<Tipology> Tipologies { get; set; }

        public DbSet<User> Users { get; set; }

        public Arrenda_meEntities()
        {
           
            Services.ArrendaService service = new Services.ArrendaService();

            service.createUser("mail", "password", 123);
            service.createUser("mail2", "password2", 123);
            service.createAdvertisement("description", "title", 1, 300, (float)300.05, (float)51.008,
            1, 2, 4, 1, 59);
            service.createAdvertisement("description2", "title2", 2, 350, (float)300.05, (float)51.008,
1, 2, 4, 2, 51);


           this.Tipologies.Add(new Tipology { title = "T1" });
           this.Tipologies.Add(new Tipology { title = "T2" });
           this.Tipologies.Add(new Tipology { title = "T3" });
           this.Tipologies.Add(new Tipology { title = "T4" });
           this.Tipologies.Add(new Tipology { title = "T5" });
           this.Tipologies.Add(new Tipology { title = ">T5" });
            
            this.SaveChanges();
           
        }

    }
}