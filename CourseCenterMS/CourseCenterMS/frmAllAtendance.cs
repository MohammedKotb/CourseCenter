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
    public partial class frmAllAtendance : Form
    {
        public frmAllAtendance()
        {
            InitializeComponent();
        }

        private void frmAllStudents_Load(object sender, EventArgs e)
        {
           
            
        }

        private void grdAllStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{ 
            //    if (grdAllGroups.Columns[e.ColumnIndex].HeaderText=="تفاصيل")
            //{
            //        int stdID = Convert.ToInt32(grdAllGroups.Rows[e.RowIndex].Cells["ID"].Value);
            //        MessageBox.Show(stdID.ToString());
            //    }
            //}
        }

        private void pnlAllStudents_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
