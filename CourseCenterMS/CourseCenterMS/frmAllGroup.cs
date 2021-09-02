using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        CourseCenterEntities context;
        public frmAllGroup()
        { 
            InitializeComponent();
            context = new CourseCenterEntities();

        }

        private void frmAllStudents_Load(object sender, EventArgs e)
        {
           
            
        }

        private void grdAllStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            { 
                if (grdAllGroups.Columns[e.ColumnIndex].HeaderText=="تفاصيل")
            {
                    
                    long grpid = Convert.ToInt64(grdAllGroups.Rows[e.RowIndex].Cells["ID"].Value);
                    Group group = context.Groups.Where(x => x.ID == grpid).FirstOrDefault();
                    frmEditGroup groupdata = new frmEditGroup();
                    groupdata.txtGroupName.Text = group.Name;
                    groupdata.txtClassroom.Text = group.Classroom;
                    groupdata.dtpkrStartYear.Value =Convert.ToDateTime( group.StartDate);
                    groupdata.dtPkrEndDate.Value = Convert.ToDateTime(group.EndDate);
                    groupdata.chkIsActive.Checked = group.IsActive;
                    GroupDay grpday = new GroupDay();
                    groupdata.cmboTimeFrom.Text = grpday.TimeFrom.ToString();
                    groupdata.cmboTimeTo.Text = grpday.TimeTo.ToString();
                    


                 
                }
            }
        }

        private void pnlAllStudents_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
