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
                  
                    DateTime today = DateTime.Now.Date;
                    Attendence checkAttendanceFound = context.Attendences.Where(x => x.GroupID == GroupID && x.ClassDate == today).FirstOrDefault();
                    List<STdAttToGrd> Names = new List<STdAttToGrd>();

                    if (checkAttendanceFound == null)
                    {
                    foreach (var item in students)
                    {
                         STdAttToGrd newObj = new STdAttToGrd();
                        newObj.ID = item.ID;
                        newObj.StudentName = item.Name;
                        newObj.QR = item.QR;
                        Names.Add(newObj);
                    }

                    f.lblGroupID.Text = GroupID.ToString();
                    Program.DashbordRunningForm.ContainerPnl.Controls.Clear();

                    f.grdTodayStudentsAttendance.DataSource = Names;
                    }
                    else //if  checkAttendanceFound not null mean that today attendance has been created befor
                    {
                        List<STdAttToGrd> AllStudentsAttendance = new List<STdAttToGrd>();
                        List<StudentAttendance> todayStdAttendances = context.StudentAttendances.Where(x=>x.AttendanceID==checkAttendanceFound.ID).Include(x=>x.Student).ToList();
                        foreach (var item in students)
                        {
                            StudentAttendance checkStdAttend = todayStdAttendances.Where(x => x.StudentID == item.ID&&x.AttendanceTime!=null).FirstOrDefault();
                            STdAttToGrd newObj = new STdAttToGrd();
                            newObj.StudentName = item.Name;
                            if (checkStdAttend == null)
                            {      
                            newObj.Sheet = false;       
                            newObj.Homework = false;       
                            //newObj.AdditionalHomework = false;       
                            //newObj.SheetMark = 0.0m;
                            }
                            else
                            {
                                newObj.Attend = checkStdAttend.Attend ?? false;
                                newObj.AttendanceTime = checkStdAttend.AttendanceTime.ToShortTimeString();
                                newObj.Homework = checkStdAttend.HomeWork;

                                newObj.Sheet = checkStdAttend.Sheet;
                                //newObj.AdditionalHomework = checkStdAttend.Sheet;
                                //newObj.SheetMark = checkStdAttend.SheetMarks;
                                //newObj.SheetNote = checkStdAttend.SheetNotes;
                                //newObj.StdNote = checkStdAttend.Note;

                            }
                            newObj.ID = item.ID;
                            newObj.QR = item.QR;

                            AllStudentsAttendance.Add(newObj);
                          
                        }
                        Program.DashbordRunningForm.ContainerPnl.Controls.Clear();
                        f.grdTodayStudentsAttendance.DataSource = AllStudentsAttendance;

                    }
                    // f.txtClassName.Text = context.Attendences.Where(x => x.ID == AttendanceID).Select(x => x.ClassName).FirstOrDefault();
                    DateTime d =DateTime.Now;
                  //  d = context.Attendences.Where(x => x.ID == AttendanceID).Select(x => x.ClassDate).FirstOrDefault();
                    f.txtClassDate.Text = d.ToString("yyyy/MM/dd");
                    f.lblGroupName.Text = context.Groups.Where(x => x.ID == GroupID).Select(x => x.Name).FirstOrDefault();
                    f.lblGroupID.Text = GroupID.ToString();

                    Program.DashbordRunningForm.ContainerPnl.Controls.Add(f.pnlTodayStudentAttendance);
                }
            }
        }
       
    }
    public class STdAttToGrd
    {
        
        public string StudentName { get; set; }
        public bool Attend { get; set; }
        public string AttendanceTime { get; set; }

        public bool Homework { get; set; }

        public bool Sheet { get; set; }
        public long ID { get; set; }
        public string QR { get; set; }
       
        //public bool AdditionalHomework { get; set; }
        //public decimal SheetMark { get; set; }
        //public string SheetNote { get; set; }
        //public string StdNote { get; set; }
 

    }

}
