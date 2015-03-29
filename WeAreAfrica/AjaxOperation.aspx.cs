using lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

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

        [WebMethod]
        public static void downloadNews()
        {
            // the file name to get
            string fileName = ConfigurationManager.AppSettings["file1"];
            // get the file bytes to download to the browser
            byte[] fileBytes = System.IO.File.ReadAllBytes(ConfigurationManager.AppSettings["fileDownloadPath"] + fileName);
            // NOTE: You could also read the file bytes from a database as well.

            // download this file to the browser
            utils.StreamFileToBrowser(fileName, fileBytes);
        }
    }
}