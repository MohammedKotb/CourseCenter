using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCenterMS
{
    public static class Helper
    {
        static public void Exit()
        {

            Application.Exit();

        }

        static public void Minimaize(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }
            else
            {
                form.WindowState = FormWindowState.Minimized;
            }
        }
        public static void hideSubMenu()
        {
        }
        public static void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
               // hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
    }
}