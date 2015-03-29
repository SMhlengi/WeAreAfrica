using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Configuration;

namespace WeAreAfrica
{
    public class utils
    {
        public static void SendSuccessfullyRegisteredMail(string firstname, string lastname, string emailAddress, string url)
        {
            try
            {
                MailMessage message = new MailMessage("No-Reply@lscms.socialengine.co.za", emailAddress);
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 25;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Host = "freeza.aserv.co.za";
                NetworkCredential networkCredential = new NetworkCredential("No-Reply@socialengine.co.za", "N0-R3ply");
                smtpClient.Credentials = (ICredentialsByHost)networkCredential;
                message.Subject = "Successfully Registered with We are Africa";
                message.IsBodyHtml = true;
                string emailMessage = ReturnRegistrationMail(firstname, lastname, emailAddress);

                message.Body = emailMessage;
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
            }
        }

        public static bool SendContactUsMail(string name, string emailAddress, string messageDetails)
        {
            try
            {
                MailMessage message = new MailMessage("No-Reply@lscms.socialengine.co.za", ConfigurationManager.AppSettings["contactUsEmailAddress"]);
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 25;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Host = "freeza.aserv.co.za";
                NetworkCredential networkCredential = new NetworkCredential("No-Reply@socialengine.co.za", "N0-R3ply");
                smtpClient.Credentials = (ICredentialsByHost)networkCredential;
                message.Subject = "Contact Us Message";
                message.IsBodyHtml = true;
                string emailMessage = ReturnContactUsMessage(name, emailAddress, messageDetails);

                message.Body = emailMessage;
                smtpClient.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static string ReturnContactUsMessage(string firstname, string emailaddress, string message)
        {
            string EmailMessage = "";

            EmailMessage += "<html>" + Environment.NewLine;
            EmailMessage += "<head>" + Environment.NewLine;
            EmailMessage += "<style>" + Environment.NewLine;
            EmailMessage += "body { margin: 10px; }" + Environment.NewLine;
            EmailMessage += "body { font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px;}" + Environment.NewLine;
            EmailMessage += "</style>" + Environment.NewLine;
            EmailMessage += "</head>" + Environment.NewLine;
            EmailMessage += "<body style\"margin: 5px 0 0 0;\">" + Environment.NewLine;

            // new code 
            EmailMessage += "Howzit, My Name is " + firstname + " <br /><br />";
            EmailMessage += message + "<br /><br />";
            // end of new code 
            EmailMessage += "</body>" + Environment.NewLine;
            EmailMessage += "</html>";

            return EmailMessage;
        }

        private static string ReturnRegistrationMail(string firstname, string lastname, string emailaddress)
        {
            string EmailMessage = "";

            EmailMessage += "<html>" + Environment.NewLine;
            EmailMessage += "<head>" + Environment.NewLine;
            EmailMessage += "<style>" + Environment.NewLine;
            EmailMessage += "body { margin: 10px; }" + Environment.NewLine;
            EmailMessage += "body { font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px;}" + Environment.NewLine;
            EmailMessage += "</style>" + Environment.NewLine;
            EmailMessage += "</head>" + Environment.NewLine;
            EmailMessage += "<body style\"margin: 5px 0 0 0;\">" + Environment.NewLine;

            // new code 
            EmailMessage += "Howzit " + firstname + " <br /><br />";
            EmailMessage += " Thank you for registering for We Are Africa.<br />";
            EmailMessage += "You can login to your account <a href='http://waa.socialengine.co.za/login'> here </a> with your username ( " + firstname + " ). <br /><br />" +  ReturnEmailSignature();
            // end of new code 
            EmailMessage += "</body>" + Environment.NewLine;
            EmailMessage += "</html>";

            return EmailMessage;
        }

        public static bool SendForgottonPasswordEmail(string emailAddress)
        {
            bool mailSent = false;
            string url = ConfigurationManager.AppSettings["forgottenPasswordUrl"].ToString();
            url += emailAddress;
            try
            {
                MailMessage message = new MailMessage("No-Reply@lscms.socialengine.co.za", emailAddress);
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 25;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Host = "freeza.aserv.co.za";
                NetworkCredential networkCredential = new NetworkCredential("No-Reply@socialengine.co.za", "N0-R3ply");
                smtpClient.Credentials = (ICredentialsByHost)networkCredential;
                message.Subject = "Latest Sightings Reset Password";
                message.IsBodyHtml = true;
                string emailMessage = ReturnResetPasswordMail(url);

                message.Body = emailMessage;
                smtpClient.Send(message);
                mailSent = true;
            }
            catch (Exception ex)
            {
            }
            return mailSent;
        }

        private static string ReturnResetPasswordMail(string url)
        {
            string EmailMessage = "";

            EmailMessage += "<html>" + Environment.NewLine;
            EmailMessage += "<head>" + Environment.NewLine;
            EmailMessage += "<style>" + Environment.NewLine;
            EmailMessage += "body { margin: 10px; }" + Environment.NewLine;
            EmailMessage += "body { font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px;}" + Environment.NewLine;
            EmailMessage += "</style>" + Environment.NewLine;
            EmailMessage += "</head>" + Environment.NewLine;
            EmailMessage += "<body style\"margin: 5px 0 0 0;\">" + Environment.NewLine;
            EmailMessage += "Howzit <br /><br />";
            EmailMessage += "Please click on the below link to reset your password <br />" + url;
            EmailMessage += ReturnEmailSignature();
            EmailMessage += "</body>" + Environment.NewLine;
            EmailMessage += "</html>";

            return EmailMessage;
        }

        public static bool SendVideoEmailLinkToAdministrator(string userid, string fullname, string title, string videoId)
        {
            bool mailSent = false;
            string url = ConfigurationManager.AppSettings["viewVideoUrl"].ToString();
            url += string.Format("{0}&video={1}", userid, videoId);
            try
            {
                MailMessage message = new MailMessage("No-Reply@lscms.socialengine.co.za", ConfigurationManager.AppSettings["videoAdministratorEmailAddress"].ToString());
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 25;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Host = "freeza.aserv.co.za";
                NetworkCredential networkCredential = new NetworkCredential("No-Reply@socialengine.co.za", "N0-R3ply");
                smtpClient.Credentials = (ICredentialsByHost)networkCredential;
                message.Subject = "New Video Upload called " + title;

                string str = "Howzit" + Environment.NewLine + Environment.NewLine +
                             fullname + " has uploaded a video. " + Environment.NewLine + Environment.NewLine +
                             "Title : " + title + Environment.NewLine + Environment.NewLine +
                             "Please click on the below link to view / download the video." + Environment.NewLine + Environment.NewLine +
                             url;

                message.Body = str;
                smtpClient.Send(message);
                mailSent = true;
            }
            catch (Exception ex)
            {
            }
            return mailSent;
        }

        public static string AddTwoStrings(string one, string two)
        {
            return one + " " + two;
        }

        /// <summary>
        /// Gets the MIME type of the file name specified based on the file name's
        /// extension.  If the file's extension is unknown, returns "octet-stream"
        /// generic for streaming file bytes.
        /// </summary>
        /// <param name="sFileName">The name of the file for which the MIME type
        /// refers to.</param>
        public static string GetMimeTypeByFileName(string sFileName)
        {
            string sMime = "application/octet-stream";

            string sExtension = System.IO.Path.GetExtension(sFileName);
            if (!string.IsNullOrEmpty(sExtension))
            {
                sExtension = sExtension.Replace(".", "");
                sExtension = sExtension.ToLower();

                if (sExtension == "pdf")
                {
                    sMime = "application/pdf";
                }
                else if (sExtension == "webm")
                {
                    sMime = "video/webm";
                }
                else if (sExtension == "flv")
                {
                    sMime = "video/x-flv";
                }
                else if (sExtension == "ogv")
                {
                    sMime = "video/ogg";
                }
                else if (sExtension == "ogg")
                {
                    sMime = "video/ogg";
                }
                else if (sExtension == "avi")
                {
                    sMime = "video/x-msvideo";
                }
                else if (sExtension == "wmv")
                {
                    sMime = "video/x-ms-wmv";
                }
                else if (sExtension == "mp4")
                {
                    sMime = "video/mp4";
                }
                else if (sExtension == "m4v")
                {
                    sMime = "video/mp4";
                }
                else if (sExtension == "mpg")
                {
                    sMime = "video/mpeg";
                }
                else if (sExtension == "mpeg")
                {
                    sMime = "video/mpeg";
                }
                else if (sExtension == "mpe")
                {
                    sMime = "video/mpeg";
                }
                else if (sExtension == "svi")
                {
                    sMime = "video/x-msvideo";
                }
                else if (sExtension == "mov")
                {
                    sMime = "video/quicktime";
                }
            }

            return sMime;
        }

        /// <summary>
        /// Streams the bytes specified as a file with the name specified using HTTP to the 
        /// calling browser.
        /// </summary>
        /// <param name="sFileName">The name of the file as it will apear when the user
        /// clicks either open or save as in their browser to accept the file
        /// download.</param>
        /// <param name="fileBytes">The file as a byte array to be streamed.</param>
        public static void StreamFileToBrowser(string sFileName, byte[] fileBytes)
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            context.Response.Clear();
            context.Response.ClearHeaders();
            context.Response.ClearContent();
            context.Response.AppendHeader("content-length", fileBytes.Length.ToString());
            context.Response.ContentType = GetMimeTypeByFileName(sFileName);
            context.Response.AppendHeader("content-disposition", "attachment; filename=" + sFileName);
            context.Response.BinaryWrite(fileBytes);

            // use this instead of response.end to avoid thread aborted exception (known issue):
            // http://support.microsoft.com/kb/312629/EN-US
            context.ApplicationInstance.CompleteRequest();
        }

        internal static void SendAcceptedVideoEmail(string useremail, string filename, string firstname)
        {
            try
            {
                MailMessage message = new MailMessage("No-Reply@lscms.socialengine.co.za", useremail);
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 25;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Host = "freeza.aserv.co.za";
                NetworkCredential networkCredential = new NetworkCredential("No-Reply@socialengine.co.za", "N0-R3ply");
                smtpClient.Credentials = (ICredentialsByHost)networkCredential;
                message.Subject = "Latest Sightings Video Upload";
                message.IsBodyHtml = true;
                string emailMessage = ReturnAcceptedVideoEmail(firstname, filename);

                message.Body = emailMessage;
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
            }
        }

        private static string ReturnAcceptedVideoEmail(string firstname, string filename)
        {
            string EmailMessage = "";

            EmailMessage += "<html>" + Environment.NewLine;
            EmailMessage += "<head>" + Environment.NewLine;
            EmailMessage += "<style>" + Environment.NewLine;
            EmailMessage += "body { margin: 10px; }" + Environment.NewLine;
            EmailMessage += "body { font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px;}" + Environment.NewLine;
            EmailMessage += "</style>" + Environment.NewLine;
            EmailMessage += "</head>" + Environment.NewLine;
            EmailMessage += "<body style\"margin: 5px 0 0 0;\">" + Environment.NewLine;

            EmailMessage += "Howzit " + firstname + " <br /><br />";
            EmailMessage += "Great news, your video <strong>" + filename + "</strong> has been accepted. We are editing it and queueing it for publication. This might take some time.<br />Please be patient. We will let you know when it is online.";
            EmailMessage += "<br />Please note that only once your video is online, we will ask you to log in to provide your banking details. You will also then be able to start viewing your earnings.";
            EmailMessage += ReturnEmailSignature();
            EmailMessage += "</body>" + Environment.NewLine;
            EmailMessage += "</html>";

            return EmailMessage;
        }

        internal static void SendDeclineEmailMessage(string useremail, string filename, string firstname, string declindedOptions, string adviceSuggestions)
        {
            try
            {
                MailMessage message = new MailMessage("No-Reply@lscms.socialengine.co.za", useremail);
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Port = 25;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Host = "freeza.aserv.co.za";
                NetworkCredential networkCredential = new NetworkCredential("No-Reply@socialengine.co.za", "N0-R3ply");
                smtpClient.Credentials = (ICredentialsByHost)networkCredential;
                message.Subject = "Latest Sightings Video Upload ";
                message.IsBodyHtml = true;
                string emailMessage = ReturnDeclineVideoMail(firstname, declindedOptions, adviceSuggestions, filename);

                message.Body = emailMessage;
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
            }
        }

        private static string ReturnDeclineVideoMail(string firstname, string declindedOptions, string adviceSuggestions, string filename)
        {
            string EmailMessage = "";

            EmailMessage += "<html>" + Environment.NewLine;
            EmailMessage += "<head>" + Environment.NewLine;
            EmailMessage += "<style>" + Environment.NewLine;
            EmailMessage += "body { margin: 10px; }" + Environment.NewLine;
            EmailMessage += "body { font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 12px;}" + Environment.NewLine;
            EmailMessage += "</style>" + Environment.NewLine;
            EmailMessage += "</head>" + Environment.NewLine;
            EmailMessage += "<body style\"margin: 5px 0 0 0;\">" + Environment.NewLine;

            // new code 
            EmailMessage += "Howzit " + firstname + " <br /><br />";
            EmailMessage += " We regret to inform you that your video <strong> " + filename + "</strong> has been declined ";
            if (!String.IsNullOrEmpty(declindedOptions))
            {
                EmailMessage += "for the following reasons. <br />";
                EmailMessage += "<ol>";
                string[] reasons = declindedOptions.Split(':');
                Array.Resize(ref reasons, reasons.Length - 1);

                foreach (var reason in reasons)
                {
                    EmailMessage += "<li>" + reason + "</li>";
                }
                EmailMessage += "</ol><br />";
            }

            if (!String.IsNullOrEmpty(adviceSuggestions))
            {
                EmailMessage += adviceSuggestions;
            }
            EmailMessage += "<br /><br />Should you wish to discuss this further, please get in touch with us by emailing <strong>videos@latestsightings.com.</strong><br /><br />";
            EmailMessage += "Keep on sending in your videos.";
            EmailMessage += ReturnEmailSignature();
            EmailMessage += "</body>" + Environment.NewLine;
            EmailMessage += "</html>";

            return EmailMessage;
        }

        private static string ReturnEmailSignature()
        {
            return "<br /><br /> Warm regards <br />We Are Africa Team";
        }

        public static string FullyQualifiedMonthName(int intMonth)
        {
            switch (intMonth)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "January";
            }
        }

        public static Dictionary<string, string> CleanUpArticleForBloglist(Dictionary<string, string> CateogryArticle)
        {
            CateogryArticle["body"] = CateogryArticle["body"].Remove(0, 2);
            int startIndex = CateogryArticle["body"].IndexOf('>');
            if (startIndex == 0)
            {
                CateogryArticle["body"] = CateogryArticle["body"].Remove(0, 2);
                startIndex = CateogryArticle["body"].IndexOf('>');
            }
            int endIndex = CateogryArticle["body"].IndexOf('<');
            int substract = endIndex - startIndex;
            CateogryArticle["body"] = CateogryArticle["body"].Substring(startIndex + 1, substract - 1);
            if (CateogryArticle["body"].Length > 84)
                CateogryArticle["body"] = CateogryArticle["body"].Substring(0, 80) + " [...]";
            else
                CateogryArticle["body"] += " [...]";
            return CateogryArticle;
        }
    }
}