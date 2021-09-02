using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using CourseCenterMS.Models;
using ZXing;

namespace CourseCenterMS
{
    public partial class frmTodayStudentAttendance : Form
    {
        List<StudentAttendance> TodayAttendance;
        CourseCenterEntities context = new CourseCenterEntities();
        FilterInfoCollection filterinfocollection;
        VideoCaptureDevice captureDevice;
        public frmTodayStudentAttendance()
        {
            InitializeComponent();
           
            TodayAttendance = new List<StudentAttendance>();
            filterinfocollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterinfocollection)
            {
                cmbDevice.Items.Add(filterInfo.Name);
            }
            cmbDevice.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice(filterinfocollection[cmbDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += captureDevice_Newframe;
        }
    
        SoundPlayer player = new SoundPlayer(@"D:\Work\CourseCenter Cloud\CourseCenter\CourseCenterMS\CourseCenterMS\Resources\Scanner.wav");
        private void frmAllStudents_Load(object sender, EventArgs e)
        {
           

        }

        private void pnlAllStudents_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void captureDevice_Newframe(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();

        }
        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterinfocollection[cmbDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += captureDevice_Newframe;
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
        Attendence att = new Attendence();
        private void btnSave_Click(object sender, EventArgs e)
        {
           
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

        private void btnUsingQR_Click(object sender, EventArgs e)
        {
            Attendence att = new Attendence();
            if (txtClassName.Text!=""&&txtClassDate.Text!="")
            {
                
                att.ClassDate = Convert.ToDateTime(txtClassDate.Text);
                att.ClassName = txtClassName.Text;
                att.GroupID =long.Parse( lblGroupID.Text);
                context.Attendences.Add(att);
                context.SaveChanges();
                btnSave.Visible = false;
                startQR();
              
            }
            else
            {
                Program.Message.lblMessage.Text = "يجب تسجيل اسم ووقت الحصه قبل استخدام QR";
            txtClassDate.Enabled = true;
                txtClassName.Enabled = true;
                Program.Message.ShowDialog();
            }
            frmTodayStudentAttendance f = new frmTodayStudentAttendance();
            //  = context.StudentAttendances.Where(x => x.AttendanceID == AttendanceID).ToList();
            List<StdAttendanceToGrd> attenacesToGrd = new List<StdAttendanceToGrd>();

            List<StudentAttendance> studentsAtted = context.StudentAttendances.Where(x => x.AttendanceID == 42).Include(x=>x.Student).ToList();
         
         
            foreach (var item in studentsAtted)
            {
                StdAttendanceToGrd newObj = new StdAttendanceToGrd();
                newObj.ID = item.ID;
                newObj.StudentName = item.Student.Name;
                newObj.Sheet = item.Sheet;
                newObj.HomeWork = item.HomeWork;
                newObj.Attend = item.Attend??true;
                newObj.AttendanceTime = item.AttendanceTime.ToShortTimeString();

                attenacesToGrd.Add(newObj);
            }

            // Program.DashbordRunningForm.ContainerPnl.Controls.Clear();
            // f.lblGroupID.Text = GroupID.ToString();
         
            f.grdTodayStudentsAttendance.DataSource = attenacesToGrd;
            Program.DashbordRunningForm.ContainerPnl.Controls.Clear();
            Program.DashbordRunningForm.ContainerPnl.Controls.Add(f.pnlTodayStudentAttendance);
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                //BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode((Bitmap)pictureBox1.Image);

                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                long GropID = long.Parse(lblGroupID.Text);
               


                if (result != null)
                {
                   
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                    player.Play();
                    string r = result.Text;
                    startQR();
                    Student student = context.Students.Where(x => x.GroupID == GropID && x.QR == r).FirstOrDefault();

                    if (student!=null)
                    {
                        frmTodayStudentAttendance f = new frmTodayStudentAttendance();
                        //  = context.StudentAttendances.Where(x => x.AttendanceID == AttendanceID).ToList();
                        List<StdAttendanceToGrd> attenacesToGrd = new List<StdAttendanceToGrd>();

                        List<StudentAttendance> studentsAtted = context.StudentAttendances.Include(x => x.Student).ToList();

                       
                            //studentsAtted.Add(new StudentAttendance { AttendanceID = 42, StudentID = 878 });
                        
                        foreach (var item in studentsAtted)
                        {
                            StdAttendanceToGrd newObj = new StdAttendanceToGrd();
                            newObj.ID = item.ID;
                            newObj.StudentName = item.Student.Name;
                            newObj.Sheet = item.Sheet;
                            newObj.HomeWork = item.HomeWork;
                            newObj.Attend = item.Attend ?? true;
                            newObj.AttendanceTime = item.AttendanceTime.ToShortTimeString();

                            attenacesToGrd.Add(newObj);
                        }
                        if (r == "12345")
                        {
                            attenacesToGrd.Add(new StdAttendanceToGrd { StudentName = "newwwwwwwwww",Attend=true,AttendanceTime="09:55" });
                            attenacesToGrd.Add(new StdAttendanceToGrd { StudentName = "newwwwwwwwww", Attend = true, AttendanceTime = "09:55" });

                            // Program.DashbordRunningForm.ContainerPnl.Controls.Clear();
                            // f.lblGroupID.Text = GroupID.ToString();
                        }
                        f.grdTodayStudentsAttendance.DataSource = attenacesToGrd;
                        string classdate = f.txtClassDate.Text;
                        string className = f.txtClassName.Text;
                        string gropID = f.lblGroupID.Text;
                        string gropName = f.lblGroupName.Text;
                        Program.DashbordRunningForm.ContainerPnl.Controls.Remove(f.grdTodayStudentsAttendance);
                        Program.DashbordRunningForm.ContainerPnl.Controls.Remove(f.txtClassName);
                        Program.DashbordRunningForm.ContainerPnl.Controls.Remove(f.txtClassDate);
                        Program.DashbordRunningForm.ContainerPnl.Controls.Remove(f.lblGroupName);
                        Program.DashbordRunningForm.ContainerPnl.Controls.Remove(f.lblGroupID);
                        f.txtClassDate.Text = classdate;
                        f.txtClassName.Text = className;
                        f.lblGroupID.Text = gropID;
                        f.lblGroupName.Text = gropName;
                      
                        Program.DashbordRunningForm.ContainerPnl.Controls.Add(f.grdTodayStudentsAttendance);
                        Program.DashbordRunningForm.ContainerPnl.Controls.Add(f.txtClassName);
                        Program.DashbordRunningForm.ContainerPnl.Controls.Add(f.txtClassDate);
                        Program.DashbordRunningForm.ContainerPnl.Controls.Add(f.lblGroupName);
                        Program.DashbordRunningForm.ContainerPnl.Controls.Add(f.lblGroupID);
                       
                    }

                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
             captureDevice.Start();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
            timer1.Stop();
        }
       public void startQR()
        {
            captureDevice.Start();
            timer1.Start();
        }
       
    }
}