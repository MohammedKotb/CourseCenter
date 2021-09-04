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
                    groupdata.lblgroupid.Text = (group.ID).ToString();
                    groupdata.txtGroupName.Text = group.Name;
                    groupdata.txtClassroom.Text =  (group.Classroom).ToString();
                    groupdata.dtpkrStartYear.Value =Convert.ToDateTime( group.StartDate);
                    groupdata.dtPkrEndDate.Value = Convert.ToDateTime(group.EndDate);
                    groupdata.chkIsActive.Checked = group.IsActive;

                  List<GroupDay> grpdays = context.GroupDays.Where(x => x.GroupID == grpid).ToList();
                    foreach (var grpday in grpdays)
                    {


                        if (grpday.Day == "السبت")
                        {
                            groupdata.chkSaturay.Checked = true;
                        }
                        if (grpday.Day == "الاحد")
                        {
                            groupdata.chkSunday.Checked = true;
                        }
                        if (grpday.Day == "الاثنين")
                        { 
                            groupdata.chkMonday.Checked = true;
                        }
                        if (grpday.Day == "الثلاثاء")
                        {
                            groupdata.chkTuesday.Checked = true;
                        }
                        if (grpday.Day == "الاربعاء")
                        {
                            groupdata.chkWednesday.Checked = true;
                        }
                        if (grpday.Day == "الخميس")
                        {
                            groupdata.chkThursday.Checked = true;
                        }
                        if (grpday.Day == "الجمعه")
                        {
                            groupdata.chkFriday.Checked = true;
                        }
                    }

                    int fromhour = grpdays.FirstOrDefault().TimeFrom.Hour;
                    int tohour = grpdays.FirstOrDefault().TimeTo.Hour;

                    if (fromhour<=12)
                    {
                        groupdata.cmboTimeFrom.SelectedItem = fromhour.ToString();
                        groupdata.RadAmFrom.Checked = true;
                    }else
                    {
                        fromhour = fromhour - 12;
                        groupdata.cmboTimeFrom.SelectedItem = fromhour.ToString();
                        groupdata.RadPmFrom.Checked = true;
                    }
                    if (tohour <= 12)
                    {
                        groupdata.cmboTimeTo.SelectedItem = tohour.ToString();
                        groupdata.RadAmTo.Checked = true;
                    }
                    else
                    {
                        tohour = tohour - 12;
                        groupdata.cmboTimeTo.SelectedItem = tohour.ToString();
                        groupdata.RadPmTo.Checked = true;
                    }
 
                    Program.DashbordRunningForm.ContainerPnl.Controls.Clear();
                    Program.DashbordRunningForm.ContainerPnl.Controls.Add(groupdata.pnlEditgroup);




                }
            }
        }

        private void pnlAllStudents_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            grdAllGroups.ClearSelection();
            SearchOnGrd(txtSearch.Text);
        }
        public void SearchOnGrd(string searchTxt)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in grdAllGroups.Rows)
            {
                if (row.Cells["GroupName"].Value.ToString().Equals(searchTxt))
                {
                    rowIndex = row.Index;

                    grdAllGroups.Rows[rowIndex].Selected = true;
                    grdAllGroups.FirstDisplayedScrollingRowIndex = rowIndex;
                    break;
                }
            }
        }

       
    }
}
