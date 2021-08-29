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
   
    public partial class frmGroupAttendance : Form
    {
        CourseCenterEntities context;
        public frmGroupAttendance()
        {
            InitializeComponent();
            context = new CourseCenterEntities();
        }

        private void frmAllStudents_Load(object sender, EventArgs e)
        {
           
            
        }

    
        private void grdGroupAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (grdGroupAttendance.Columns[e.ColumnIndex].HeaderText == "تفاصيل")
                {
                    int AttendanceID = Convert.ToInt32(grdGroupAttendance.Rows[e.RowIndex].Cells["ID"].Value);
                    frmStudentAttendance f = new frmStudentAttendance();
                    //  = context.StudentAttendances.Where(x => x.AttendanceID == AttendanceID).ToList();
                    List<StdAttendanceToGrd> attenacesToGrd = new List<StdAttendanceToGrd>();
                    List<StudentAttendance> studentAttendancelst = context.StudentAttendances.Where(x => x.AttendanceID == AttendanceID).Include(x => x.Student).ToList();
                    foreach (var item in studentAttendancelst)
                    {
                        StdAttendanceToGrd attenaceToGrd = new StdAttendanceToGrd();
                        attenaceToGrd.StudentName = item.Student.Name;
                        attenaceToGrd.Attend = item.Attend ?? true;
                        attenaceToGrd.AttendanceTime = item.AttendanceTime.ToShortTimeString();
                        attenaceToGrd.HomeWork = item.HomeWork;
                        attenaceToGrd.Sheet = item.Sheet;
                        attenaceToGrd.ID = item.ID;
                        attenaceToGrd.StudentName = item.Student.Name;
                        attenacesToGrd.Add(attenaceToGrd);
                    }
                    Program.DashbordRunningForm.ContainerPnl.Controls.Clear();
                    f.grdStudentsAttendance.DataSource = attenacesToGrd;
                    f.txtClassName.Text = context.Attendences.Where(x => x.ID == AttendanceID).Select(x => x.ClassName).FirstOrDefault();
                    DateTime d = new DateTime();
                    d = context.Attendences.Where(x => x.ID == AttendanceID).Select(x => x.ClassDate).FirstOrDefault();
                    f.txtClassDate.Text = d.ToString("yyyy/MM/dd");
                    Program.DashbordRunningForm.ContainerPnl.Controls.Add(f.pnlStudentAttendance);
                }
            }
        }
    }
    public class StdAttendanceToGrd
    {
        public string StudentName { get; set; }
        public bool Attend { get; set; }
        public string AttendanceTime { get; set; }
        public bool HomeWork { get; set; }
        public bool Sheet { get; set; }
        public long ID { get; set; }


    }
}
