using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace arrenda_me.Controllers
{
    public class PropertyController : Controller
    {

        private Models.Arrenda_meEntities arrendaDB = new Models.Arrenda_meEntities();

        public ActionResult ListProperties()
        {

            var properties = arrendaDB.Properties.ToList();
            return View(properties);
        }

        public ActionResult Index()
        {
            return View("~/Views/Property/ListProperty.cshtml");
        }
	}
}