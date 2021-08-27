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
    public partial class frmNewStudent : Form
    {
        public frmNewStudent()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            btnAddPicture.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnAddPicture.Visible = false;

        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("h");
        }

        private void frmNewStudent_Load(object sender, EventArgs e)
        {
            

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
