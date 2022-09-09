using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using ServiceMail_ClassLibrary;
using ServicioMail;

namespace ServicioMail
{
    public partial class Service1 : ServiceBase
    {
        private DBO_SERVER configurationSmtp { get; set; }
        Timer timer1 = new Timer();
        private int time = 10000;
        public Service1()
        {
            InitializeComponent();
            test();
        }

        private void loadConfigServerSmtp()
        {
            try
            {
                var dataSmtp = LogicaClass.getConfigurationServer();
                if (dataSmtp != null)
                {
                    configurationSmtp = dataSmtp;
                }
                else
                {
                    this.Stop();
                }
            }
            catch
            {

                this.Stop();
            }
        }

        protected override void OnStart(string[] args)
        {
            loadConfigServerSmtp();
            timer1.Elapsed += new ElapsedEventHandler(timer1_Event);
            timer1.Interval = time;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void test()
        {
            loadConfigServerSmtp();
            var listEmail = LogicaClass.getAllEmails();
            if (listEmail.Count > 0)
            {
                foreach (var item in listEmail)
                {
                    bool resSendEmail = LogicaClass.sendEmail(configurationSmtp, item);
                    if (resSendEmail)
                    {
                        //correo enviado
                    }
                }
            }

        }
        private void timer1_Event(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                timer1.Enabled = false;
                var listEmail = LogicaClass.getAllEmails();
                if (listEmail.Count > 0)
                {
                    foreach (var item in listEmail)
                    {
                        bool resSendEmail = LogicaClass.sendEmail(configurationSmtp, item);
                        if (resSendEmail)
                        {
                            //correo enviado
                        }
                    }
                }
                timer1.Enabled = true;
                timer1.Start();
            }
            catch
            {
                //Log
            }
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            //Log Servicio detenido
        }
    }
}
