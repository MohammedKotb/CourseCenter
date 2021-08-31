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
 
    public partial class frmTodayAtendanceGroups : Form
    {
        CourseCenterEntities context;
        public frmTodayAtendanceGroups()
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
                if (grdTodayAttendanceGroup.Columns[e.ColumnIndex].HeaderText == "تفاصيل")
                {
                    long GroupID = Convert.ToInt32(grdTodayAttendanceGroup.Rows[e.RowIndex].Cells["ID"].Value);
                    frmTodayStudentAttendance f = new frmTodayStudentAttendance();
                    //  = context.StudentAttendances.Where(x => x.AttendanceID == AttendanceID).ToList();
                    List<StdAttendanceToGrd> attenacesToGrd = new List<StdAttendanceToGrd>();

                    List<Student> students = context.Students.Where(x => x.GroupID==GroupID&&x.IsActive==true&&x.IsDeleted==false).ToList();
                    //foreach (var item in studentAttendancelst)
                    //{
                    //    StdAttendanceToGrd attenaceToGrd = new StdAttendanceToGrd();
                    //    attenaceToGrd.StudentName = item.Student.Name;
                    //    attenaceToGrd.Attend = item.Attend ?? true;
                    //    attenaceToGrd.AttendanceTime = item.AttendanceTime.ToShortTimeString();
                    //    attenaceToGrd.HomeWork = item.HomeWork;
                    //    attenaceToGrd.Sheet = item.Sheet;
                    //    attenaceToGrd.ID = item.ID;
                    //    attenaceToGrd.StudentName = item.Student.Name;
                    //    attenacesToGrd.Add(attenaceToGrd);
                    //}
                    List<STdNameAndID> Names = new List<STdNameAndID>();
                    foreach (var item in students)
                    {
                        STdNameAndID newObj = new STdNameAndID();
                        newObj.ID = item.ID;
                        newObj.Name = item.Name;
                        Names.Add(newObj);
                    }

                    Program.DashbordRunningForm.ContainerPnl.Controls.Clear();
                    f.lblGroupID.Text = GroupID.ToString();
                    f.grdTodayStudentsAttendance.DataSource = Names;
                   // f.txtClassName.Text = context.Attendences.Where(x => x.ID == AttendanceID).Select(x => x.ClassName).FirstOrDefault();
                    DateTime d =DateTime.Now;
                  //  d = context.Attendences.Where(x => x.ID == AttendanceID).Select(x => x.ClassDate).FirstOrDefault();
                    f.txtClassDate.Text = d.ToString("yyyy/MM/dd");
                    f.lblGroupName.Text = context.Groups.Where(x => x.ID == GroupID).Select(x => x.Name).FirstOrDefault();
                    Program.DashbordRunningForm.ContainerPnl.Controls.Add(f.pnlTodayStudentAttendance);
                }
            }
        }
       
    }
    public class STdNameAndID
    {
        public long ID { get; set; }
        public string Name { get; set; }

    }

}
