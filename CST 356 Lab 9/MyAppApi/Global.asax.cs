using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace MyAppApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            AppDomain.CurrentDomain.SetData("DataDirectory", @"C: \Users\David\Documents\GitHub\CST - 356\CST 356 Lab 9\CST356_Lab_3\App_Data");
        }
    }
}
