using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeAreAfrica
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["loggedIn"] == null && HttpContext.Current.Request.Url.AbsolutePath != "/default.aspx" && HttpContext.Current.Request.Url.AbsolutePath != "/login")
                Response.Redirect("/");
            else if (HttpContext.Current.Session["loggedIn"] != null && HttpContext.Current.Request.Url.AbsolutePath == "/default.aspx")
                Response.Redirect("/home");
            else if (HttpContext.Current.Session["loggedIn"] != null && HttpContext.Current.Request.Url.AbsolutePath == "/login")
                Response.Redirect("/home");
        }
    }
}