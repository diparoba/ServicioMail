using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceMail_ClassLibrary;

namespace ServicioMail
{
    internal class LogicaClass
    {
        private static dcServiceMailDataContext dc = new dcServiceMailDataContext();

        public static DBO_SERVER getConfigurationServer()
        {
            try
            {
                dc = new dcServiceMailDataContext();
                var configuration = dc.DBO_SERVERs.FirstOrDefault(data => data.ID.Equals(1));
                return configuration;
            }
            catch
            {

                return null;
            }
        }
        public static List<DBO_EMAIL> getAllEmails()
        {
            try
            {
                dc = new dcServiceMailDataContext();
                var emails = dc.DBO_EMAILs.Where(data => data.STATUS.Equals("A")
                                                        && data.STATUSSEND.Equals(false)
                                                        && data.STATUSERROR.Equals(false));
                return emails.ToList();
            }
            catch
            {

                return null;
            }
        }

        private static bool updateStatusEmail(int codeMail)
        {
            try
            {
                DBO_EMAIL email = dc.DBO_EMAILs.Single(data => data.ID.Equals(codeMail));
                email.STATUSSEND = true;
             
                dc.SubmitChanges();
                
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public static bool sendEmail(DBO_SERVER configuration, DBO_EMAIL correo)
        {

            List<string> destinatarios = new List<string>();
            destinatarios.Add(correo.CORREO);
            if (destinatarios.Count > 0)
            {
                bool resSend = CorreoClass.EnviarCorreo(configuration, destinatarios, "Registro de Usuario", renderHtml(), correo);
                if (resSend)
                {
                    updateStatusEmail(correo.ID);
                    return true;
                }
            }
            return false;
        }

        private static string renderHtml()
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(@"C:\Plantilla\plantilla.html"))
            {
                body = reader.ReadToEnd();
            }
            return body;
        }
    }
}
