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
        CourseCenterEntities context;
        public frmAllAtendance()
        {
            InitializeComponent();
            context = new CourseCenterEntities();
        }

        private void frmAllStudents_Load(object sender, EventArgs e)
        {
           
            
        }
        private void grdAllAttendanceGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (grdAllAttendanceGroup.Columns[e.ColumnIndex].HeaderText == "تفاصيل")
                {
                    long groupID = Convert.ToInt64(grdAllAttendanceGroup.Rows[e.RowIndex].Cells["ID"].Value);
                    frmGroupAttendance frmGroupAttendance = new frmGroupAttendance();
                    frmGroupAttendance.lblGroupID.Text = groupID.ToString();
                    List<Attendence> attendencelst = context.Attendences.Where(x => x.GroupID == groupID && x.IsDeleted == false).ToList();
                    List<AttenaceToGrd> AttenacesToGrd = new List<AttenaceToGrd>();
                    foreach (var item in attendencelst)
                    {
                        AttenaceToGrd attenToGrd = new AttenaceToGrd();
                       
                        //attenToGrd.ClassName = item.ClassName;
                       attenToGrd.ClassDate = item.ClassDate;
                        attenToGrd.AttendanceNumber = context.StudentAttendances.Where(x=>x.AttendanceID==item.ID&&x.Attend==true).Count();
                        attenToGrd.AbsenceNumber = context.StudentAttendances.Where(x=>x.AttendanceID==item.ID && x.Attend == false).Count();
                        attenToGrd.ID = item.ID;
                        AttenacesToGrd.Add(attenToGrd);
                    }
                    frmGroupAttendance.grdGroupAttendance.DataSource = AttenacesToGrd;
                    Program.DashbordRunningForm.ContainerPnl.Controls.Clear();
                    Program.DashbordRunningForm.ContainerPnl.Controls.Add(frmGroupAttendance.pnlGroupAttendance);
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            grdAllAttendanceGroup.ClearSelection();
            SearchOnGrd(txtSearch.Text);
        }

        public void SearchOnGrd(string searchTxt)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in grdAllAttendanceGroup.Rows)
            {
                if (row.Cells["GroupName"].Value.ToString().Equals(searchTxt))
                {
                    rowIndex = row.Index;

                    grdAllAttendanceGroup.Rows[rowIndex].Selected = true;
                    grdAllAttendanceGroup.FirstDisplayedScrollingRowIndex = rowIndex;
                    break;
                }
            }
        }

       
    }
    public class AttenaceToGrd
    {
        public long ID { get; set; }
       // public string ClassName { get; set; }
        public DateTime ClassDate { get; set; }
        public int AttendanceNumber { get; set; }
        public int AbsenceNumber { get; set; }
    }
   
}
