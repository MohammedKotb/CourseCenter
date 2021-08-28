using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseCenterMS.Models;
namespace CourseCenterMS
{
    public partial class frmAllGroup : Form
    {
        public frmAllGroup()
        {
            InitializeComponent();
        }

        private void frmAllStudents_Load(object sender, EventArgs e)
        {
           
            
        }

        private void grdAllStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdAllStudents.Columns[e.ColumnIndex].HeaderText=="تفاصيل")
            {
                if (e.RowIndex>=0) {
                    int stdID = Convert.ToInt32(grdAllStudents.Rows[e.RowIndex].Cells["ID"].Value);
                    MessageBox.Show(stdID.ToString());
                }
            }
        }

        private void pnlAllStudents_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
