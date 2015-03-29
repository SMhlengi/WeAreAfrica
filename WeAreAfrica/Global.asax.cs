using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WeAreAfrica
{
    public class Global : System.Web.HttpApplication
    {

        protected void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Home",
                "home",
                "~/home.aspx", true,
            new RouteValueDictionary { });

            routes.MapPageRoute("News",
                "news",
                "~/news.aspx", true,
            new RouteValueDictionary { });

            routes.MapPageRoute("Login",
                "login",
                "~/login.aspx", true,
            new RouteValueDictionary { });

            routes.MapPageRoute("Register",
                "register",
                "~/register.aspx", true,
            new RouteValueDictionary { });           

            routes.Ignore("Language/assets/{*pathInfo}");
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}