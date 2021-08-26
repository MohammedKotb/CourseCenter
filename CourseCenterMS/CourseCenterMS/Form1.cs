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

            frmAllStudents f = new frmAllStudents();
            ContainerPnl.Controls.Clear();

            //Form2 f = new Form2();
      
            ContainerPnl.Controls.Add(f.pnlAllStudents);
        }
    }
}
