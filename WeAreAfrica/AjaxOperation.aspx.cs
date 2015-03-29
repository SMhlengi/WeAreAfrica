using lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeAreAfrica
{
    public partial class AjaxOperation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        [WebMethod]
        public static bool validateCredentials(string username, string password)
        {
            return library.ValidateCredentials(username, password);
        }

        [WebMethod]
        public static Boolean DoesEmailExistgs(string email)
        {
            return library.DoesEmailExists(email);
        }

        [WebMethod]
        public static bool SaveRegistrationData(string firstname, string email, string telephone, string password)
        {
            Person person = new Person();
            person.name = firstname;
            person.email = email;
            person.telephone = telephone;
            person.password = password;
            if (library.SaveRegistrationDetails(person))
            {
                HttpContext.Current.Session["loggedIn"] = "true";
                utils.SendSuccessfullyRegisteredMail(person.name, "", person.email, "");
                return true;
            }
            else
                return false;
        }

        [WebMethod]
        public static bool ValidateCredentials(string username, string password)
        {
            Person person = new Person();
            person.name = username;
            person.password = password;
            if (library.LoginValidation(username, password))
            {
                HttpContext.Current.Session["loggedIn"] = "true";
                return true;
            }
            else
                return false;
        }
    }
}