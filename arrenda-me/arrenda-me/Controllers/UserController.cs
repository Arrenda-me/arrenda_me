using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace arrenda_me.Controllers
{
    public class UsersController : Controller
    {
        Models.Arrenda_meEntities arrendaDB = new Models.Arrenda_meEntities();
        //
        // GET: /Users/
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult ViewAnouncement()
        { 
            return View();
        }

        public ActionResult ChangeData()
        {
            return View();
        }

        public ActionResult UserPanel(string email)
        {
            return View(email);
        }

        private bool isRegisterInputValid(string email, string contact, string password, string password2){

               if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(password)
                    || string.IsNullOrEmpty(password2) || string.IsNullOrEmpty(contact))
                   return false; //at least one of the input fields is null

                if(password != password2)
                    return false; //passwords don't match

                var users = arrendaDB.Users.ToList();

                foreach (var u in users) 
                    if (u.email == email)
                        return false; //there is already an account registered with this email
               
                try
                {
                   int contactInt = Convert.ToInt32(contact);
                }
                catch (FormatException e)
                {
                    return false; //contact is not a number
                }
                return true;

        }

        [HttpPost]
        public ActionResult Register(string email, string contact, string password, string password2)
        {
            if (ModelState.IsValid)
            {
                if (!isRegisterInputValid(email, contact, password, password2))
                    return View();
                arrendaDB.Users.Add(new Models.User { email = email, password = password, contact = Convert.ToInt32(contact) });
                arrendaDB.SaveChanges();
                return UserPanel(email);

            }
            return View();
        }


        [HttpPost]
        public ActionResult UserPanel(string newEmail, string password, string password2)
        {
            if (ModelState.IsValid)
            {
                string dummy="123";
                if (!isRegisterInputValid(newEmail, dummy , password, password2))
                    return View();

                 Models.User user = arrendaDB.Users.First(i => i.email == newEmail);
                 user.email = newEmail;
                 user.password = password;
                 arrendaDB.SaveChanges();
                return UserPanel(newEmail);

            }
            return View(newEmail);
        }

	}
}
