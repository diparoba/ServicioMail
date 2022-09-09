using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ServiceMail_ClassLibrary;

namespace ServicioMail
{
    internal class CorreoClass
    {
        public static bool EnviarCorreo(DBO_SERVER configuration, List<string> destinatarios, string asunto, string plantilla, DBO_EMAIL correo)
        {
            bool res = false;

          
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            
            mmsg.IsBodyHtml = true;
            foreach (var item in destinatarios)
            {
                mmsg.To.Add(item);
            }
            mmsg.Subject = asunto;

            plantilla = plantilla.Replace("@User", correo.CORREO);

           
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(plantilla, null, MediaTypeNames.Text.Html);


            LinkedResource imageHtmlBanner1 = new LinkedResource("C:\\Plantilla\\header.jpg", MediaTypeNames.Image.Jpeg);
            imageHtmlBanner1.ContentId = "idBanner1";

            LinkedResource imageHtmlBanner2 = new LinkedResource("C:\\Plantilla\\footer.jpg", MediaTypeNames.Image.Jpeg);
            imageHtmlBanner2.ContentId = "idBanner2";

            htmlView.LinkedResources.Add(imageHtmlBanner1);
            htmlView.LinkedResources.Add(imageHtmlBanner2);

            mmsg.AlternateViews.Add(htmlView);

       
            mmsg.From = new System.Net.Mail.MailAddress(configuration.USERNAME);
          
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential(configuration.USERNAME, configuration.PASSWORD);

            
            cliente.Port = int.Parse(configuration.PORT.ToString());
            
            cliente.EnableSsl = true;
            
            cliente.Host = configuration.SMTP;


            try
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate
                   (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                { return true; };
                
                cliente.Send(mmsg);
                
                mmsg.Dispose();

                res = true;
                return res;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                mmsg.Dispose();
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
