using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace LeadTrumpet.Web
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapRoute("home", "{controller}/{action}", new { controller = "home", action = "index" });
        }
    }
}