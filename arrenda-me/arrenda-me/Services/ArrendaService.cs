using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace arrenda_me.Services
{
    public  class ArrendaService
    {
        private Models.Arrenda_meEntities arrendaDB = new Models.Arrenda_meEntities();



        public void sendNotification()
        {


        }

        public void createUser(string email, string password, int contact){            
            arrendaDB.Users.Add( new Models.User { email=email, password=password, contact=contact});
            arrendaDB.SaveChanges();
        }

        public void createAdvertisement(string description, string title, int idProperty, int price, float latitude, float longitude, 
            int idTipology, int idLocality, int idCity, int idOwner, int area)
        {
            arrendaDB.Properties.Add(new Models.Property {          
             id=idProperty, price=price, latitude=latitude, 
             longitude=longitude, startDate=DateTime.Today, endDate=DateTime.Today.AddDays(30),
             active=true, title=title, description=description, area=area, idCity=idCity, idOwner=idOwner,
             idLocality=idLocality, idTipology = idTipology
            });
            arrendaDB.SaveChanges();
        }


        public void deactivateAdvertisement(int idProperty)
        {
            Models.Property adv = arrendaDB.Properties.First(i => i.id == idProperty);
            adv.active = false;
            arrendaDB.SaveChanges();
        }


        public void editAdvertisementPrice(int idProperty, int price)
        {
            Models.Property adv = arrendaDB.Properties.First(i => i.id == idProperty);
            adv.price = price;
            arrendaDB.SaveChanges();
        }


        public void editAdvertisementDescription(int idProperty, string description)
        {
            Models.Property adv = arrendaDB.Properties.First(i => i.id == idProperty);
            adv.description = description;
            arrendaDB.SaveChanges();
        }

        public void changeUserPassword(int idUser, string oldPassword, string newPassword){
            Models.User user = arrendaDB.Users.First(i => i.id == idUser);
            if (oldPassword == user.password)
                user.password = newPassword;
            else
                return;
            //TODO: cifrar isto
            arrendaDB.SaveChanges();
        }

        public void changeUserContact(int idUser, int newContact){
            Models.User user = arrendaDB.Users.First(i => i.id == idUser);
            user.contact = newContact;
            arrendaDB.SaveChanges();
        }

        public void changeUserEmail(int idUser, string newEmail)
        {
            Models.User user = arrendaDB.Users.First(i => i.id == idUser);
            user.email = newEmail;
            arrendaDB.SaveChanges();
        }

    }
}