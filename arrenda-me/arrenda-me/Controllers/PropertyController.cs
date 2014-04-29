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

            return View();
        }

        public ActionResult Index()
        {

            return View();
        }



        public ActionResult ViewProperty()
        {
            return View();
        }

        public ActionResult AddProperty()
        {
            return View();
        }



        public ActionResult test()
        {
            return View();
        }

    }
}