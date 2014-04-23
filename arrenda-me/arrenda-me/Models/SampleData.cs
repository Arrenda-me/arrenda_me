using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace arrenda_me.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<Arrenda_meEntities>
    {


        protected override void Seed(Arrenda_meEntities context)
        {
            new List<Notification>
            {
                new Notification { id=1, senderName="Tania", phoneNumber=91333, email="sds", body="Quero comprar", idUser=1, idAdvertisement=1 },
            }.ForEach(notifications => context.Notifications.Add(notifications));


        }
    }
}