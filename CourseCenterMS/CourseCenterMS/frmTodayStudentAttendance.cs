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
    public partial class frmTodayStudentAttendance : Form
    {
        List<StudentAttendance> TodayAttendance;
        CourseCenterEntities context = new CourseCenterEntities();
        public frmTodayStudentAttendance()
        {
            InitializeComponent();
            TodayAttendance = new List<StudentAttendance>();
        }

        private void frmAllStudents_Load(object sender, EventArgs e)
        {


        }

        private void pnlAllStudents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grdTodayStudentsAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long stdID=0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                stdID = Convert.ToInt32(grdTodayStudentsAttendance.Rows[e.RowIndex].Cells["ID"].Value);

                if (grdTodayStudentsAttendance.Columns[e.ColumnIndex].HeaderText == "الحضور")
                {

                    grdTodayStudentsAttendance.Rows[e.RowIndex].Cells["AttendTime"].Value = DateTime.Now.ToShortTimeString();
                    grdTodayStudentsAttendance.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =true;
                    //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)grdTodayStudentsAttendance.Rows[e.RowIndex].Cells["Att"];
                    //if (chk.Value == chk.TrueValue)
                    //{
                    //    chk.Value = chk.FalseValue;
                    //}
                    //else
                    //{
                    //    chk.Value = chk.TrueValue;
                    //}
                   

          
                }
                if (grdTodayStudentsAttendance.Columns[e.ColumnIndex].HeaderText == "تفاصيل")
                {
                    frmsheet fsh = new frmsheet();
                    fsh.lblStudentName.Text = context.Students.Where(x => x.ID == stdID).Select(x => x.Name).FirstOrDefault();
                    fsh.ShowDialog();


                }

            }
        }

        private void grdTodayStudentsAttendance_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           Attendence att = new Attendence();
            att.ClassDate = Convert.ToDateTime(txtClassDate.Text);
            att.ClassName = txtClassName.Text;
            att.GroupID = Convert.ToInt64(lblGroupID.Text);
            context.Attendences.Add(att);
            context.SaveChanges();
            
            foreach (DataGridViewRow item in grdTodayStudentsAttendance.Rows)
            {
                StudentAttendance newattende = new StudentAttendance();
                //AttendTime Homework sheet id Attendance
                newattende.ID = 0;
                newattende.HomeWork =Convert.ToBoolean( item.Cells["Homework"].Value);
                newattende.Sheet =Convert.ToBoolean( item.Cells["sheet"].Value);
                newattende.Attend =Convert.ToBoolean( item.Cells["Attendance"].Value);
                newattende.StudentID =Convert.ToInt64( item.Cells["ID"].Value);
                 newattende.AttendanceTime = Convert.ToDateTime(item.Cells["AttendTime"].Value);
                newattende.AttendanceTime = DateTime.Now;
                newattende.AttendanceID = att.ID;
                newattende.AdditionalHomeWork = false;
                newattende.SheetMarks = 0;
                context.StudentAttendances.Add(newattende);
                context.SaveChanges();
            }
            Attendence newSTdAttendace = new Attendence();
            newSTdAttendace.ClassDate = Convert.ToDateTime(txtClassDate.Text);
            newSTdAttendace.ClassName = txtClassName.Text;
        }
    }
}