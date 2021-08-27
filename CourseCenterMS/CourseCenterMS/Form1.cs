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
        public Dashbord()
        {
            InitializeComponent();
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
            f.grdAllStudents.DataSource = context.Students.Select(x => new { x.Name, x.GroupID, x.Classroom, x.Phone,x.ID }).ToList(); ;
            ContainerPnl.Controls.Add(f.pnlAllStudents);
        }

        private void btnMenuAddStudent_Click(object sender, EventArgs e)
        {
            frmNewStudent f = new frmNewStudent();
            ContainerPnl.Controls.Clear();
            ContainerPnl.Controls.Add(f.pnlNewStudent);
        }
    }
}
