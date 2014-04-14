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

        public Arrenda_meEntities()
        {

            Property a = new Property { id=1, idTipology=1, idOwner=1, idDistrict=1, idLocality=1, active=true,
                area=43, description="apartamento mobilado na margem sul", idCity=1, 
                title="apartamento"};


            Property b = new Property
            {
                id = 3,
                idTipology = 1,
                idOwner = 1,
                idDistrict = 1,
                idLocality = 1,
                active = true,
                area = 43,
                description = "aparteste",
                idCity = 1,
                title = "teste"
            };


            Property c = new Property
            {
                id = 2,
                idTipology = 1,
                idOwner = 1,
                idDistrict = 1,
                idLocality = 1,
                active = true,
                area = 43,
                description = "apartamento teste",
                idCity = 1,
                title = "apartamento 43"
            };

            this.Properties.Add(a);
            this.Properties.Add(b);
            this.Properties.Add(c);


           this.Notifications.Add(new Notification { id=1, senderName="Tania", phoneNumber=91333, email="sds", body="Quero comprar", idUser=1, idAdvertisement=1 });
           this.SaveChanges();
           
            
        }

    }
}