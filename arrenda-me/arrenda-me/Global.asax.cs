﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace arrenda_me
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
   //      System.Data.Entity.Database.SetInitializer(  new arrenda_me.Models.SampleData());


            System.Data.Entity.Database.SetInitializer<arrenda_me.Models.Arrenda_meEntities>(
new System.Data.Entity.DropCreateDatabaseIfModelChanges<arrenda_me.Models.Arrenda_meEntities>());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }




    }
}
