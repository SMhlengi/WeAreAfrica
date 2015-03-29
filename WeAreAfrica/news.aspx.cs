using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WeAreAfrica
{
    public partial class news : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void newslinks_Click(object sender, EventArgs e)
        {
            // the file name to get
            string fileName = ConfigurationManager.AppSettings["file1"];
            // get the file bytes to download to the browser
            byte[] fileBytes = System.IO.File.ReadAllBytes(ConfigurationManager.AppSettings["fileDownloadPath"] + fileName);
            // NOTE: You could also read the file bytes from a database as well.

            // download this file to the browser
            utils.StreamFileToBrowser(fileName, fileBytes);
        }

        //protected void download_Click(object sender, EventArgs e)
        //{
        //    // the file name to get
        //    string fileName = ConfigurationManager.AppSettings["file1"];
        //    // get the file bytes to download to the browser
        //    byte[] fileBytes = System.IO.File.ReadAllBytes(ConfigurationManager.AppSettings["fileDownloadPath"] + fileName);
        //    // NOTE: You could also read the file bytes from a database as well.

        //    // download this file to the browser
        //    utils.StreamFileToBrowser(fileName, fileBytes);
        //}
    }
}