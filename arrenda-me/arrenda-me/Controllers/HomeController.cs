using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace arrenda_me.Controllers
{
    public class HomeController : Controller
    {

        private Models.Arrenda_meEntities arrendaDB = new Models.Arrenda_meEntities();

        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string email, string password)
        {
            if (ModelState.IsValid)
            {

                var users = arrendaDB.Users.ToList();

                foreach(var u in users)
                    if((u.email == email) && (u.password == password))
                        return RedirectToAction("UserPanel", "Users");
                    
             }
             return View();
        }

	}
}