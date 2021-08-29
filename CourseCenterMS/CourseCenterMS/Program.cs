using LoginScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCenterMS
{
    static class Program
    {
        public static Dashbord DashbordRunningForm;
        public static frmTest Message;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DashbordRunningForm = new Dashbord();
            Message = new frmTest();
             //Application.Run(new frmLogin());
             Application.Run(DashbordRunningForm);
        }
    }
}
