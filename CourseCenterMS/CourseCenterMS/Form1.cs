using CourseCenterMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCenterMS
{
    public partial class Dashbord : Form
    {
        int ph; bool hided;
        public Dashbord()
        {
            InitializeComponent();
            ph = pnlStudent.Height;
            hided = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Helper.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Helper.Minimaize(this);
        }

        private void btnAllStudents_Click(object sender, EventArgs e)
        {
            CourseCenterEntities context = new CourseCenterEntities();
            frmAllStudents f = new frmAllStudents();
            ContainerPnl.Controls.Clear();
            f.grdAllStudents.DataSource = context.Students.Select(x => new { x.Name, x.GroupID, x.Classroom, x.Phone, x.ID }).ToList(); ;
            ContainerPnl.Controls.Add(f.pnlAllStudents);
        }

        private void btnMenuAddStudent_Click(object sender, EventArgs e)
        {
            frmNewStudent f = new frmNewStudent();
            ContainerPnl.Controls.Clear();
            ContainerPnl.Controls.Add(f.pnlNewStudent);
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            //timer1.Start();
           // Helper.ShowSubMenu(pnlStudent);
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  Show(pnlGroups);
            //Helper.ShowSubMenu(pnlGroups);

        }

        private void button4_Click(object sender, EventArgs e)
        {
           // Helper.ShowSubMenu(pnlPresence);

        }
        public void Show(Panel subMenu)
        {
            if (hided)
            {
                subMenu.Height = subMenu.Height + 5;
                if (subMenu.Height >= ph)
                {
                   // timer1.Stop();
                    hided = false;
                  
                }
            }
            else
            {
                subMenu.Height = subMenu.Height - 5;
                if (subMenu.Height <= 0)
                {
                    //timer1.Stop();
                    hided = true;
            
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Show(pnlStudent);
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            pnlStudent.Height = 0;
           // pnlGroups.Height = 0;
           // pnlPresence.Height = 0;
        }
    }
}
