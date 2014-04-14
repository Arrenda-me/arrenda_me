using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace arrenda_me.Controllers
{
    public class NotificationController : Controller
    {

        Models.Arrenda_meEntities arrendaDB = new Models.Arrenda_meEntities();

     
        public ActionResult Details()
        {
           arrendaDB.Notifications.Add( new Models.Notification { id=1, senderName="Tania"});
            var notifications = arrendaDB.Notifications.ToList();
            return View(notifications);
        }
     

        public string Index()
        {
            return "okok";
        }
	}
}