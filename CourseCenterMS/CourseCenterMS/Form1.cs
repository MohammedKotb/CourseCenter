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
            List<Student> students = context.Students.ToList();
            frmAllStudents f = new frmAllStudents();
            ContainerPnl.Controls.Clear();
            ContainerPnl.Controls.Add(f.pnlAllStudents);
            DataTable table = new DataTable();
            foreach (var student in students)
            {
                string[] s = { student.Name, student.GroupID.ToString(), student.Classroom, student.Phone, "Details" };
                f.grdAllStudents.Rows.Add(s);
            }
            //f.grdAllStudents.DataSource = table;

        }

        private void btnMenuAddStudent_Click(object sender, EventArgs e)
        {
            frmNewStudent f = new frmNewStudent();
            ContainerPnl.Controls.Clear();
            ContainerPnl.Controls.Add(f.pnlNewStudent);
        }
    }
}
