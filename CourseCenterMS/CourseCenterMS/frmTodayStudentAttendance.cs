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
        string GropIDVal;
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
            try
            {
                att.ClassDate = Convert.ToDateTime(txtClassDate.Text);
                //  att.ClassName = txtClassName.Text;
                att.GroupID = Convert.ToInt64(lblGroupID.Text);
                GropIDVal = lblGroupID.Text;
                Attendence checkAttendanceFound = context.Attendences.Where(x => x.GroupID == att.GroupID && x.ClassDate == att.ClassDate).FirstOrDefault();
                if (checkAttendanceFound == null)
                {
                    context.Attendences.Add(att);
                    context.SaveChanges();
                }


                foreach (DataGridViewRow item in grdTodayStudentsAttendance.Rows)
                {
                    if (checkAttendanceFound == null)
                    {
                        StudentAttendance newattende = new StudentAttendance();
                        //AttendTime Homework sheet id Attendance
                        newattende.ID = 0;
                        newattende.HomeWork = Convert.ToBoolean(item.Cells["Homework"].Value);
                        newattende.Sheet = Convert.ToBoolean(item.Cells["sheet"].Value);
                        newattende.Attend = Convert.ToBoolean(item.Cells["Attendance"].Value);
                        newattende.StudentID = Convert.ToInt64(item.Cells["ID"].Value);
                        newattende.AttendanceTime = Convert.ToDateTime(item.Cells["AttendTime"].Value);
                        newattende.AttendanceTime = DateTime.Now;
                        if (checkAttendanceFound == null)
                            newattende.AttendanceID = att.ID;
                        else
                            newattende.AttendanceID = checkAttendanceFound.ID;

                        newattende.AdditionalHomeWork = false;
                        newattende.SheetMarks = 0;
                        context.StudentAttendances.Add(newattende);
                        context.SaveChanges();
                    }
                    else
                    {
                        long STDID = Convert.ToInt64(item.Cells["ID"].Value);
                        StudentAttendance StdAttendance = context.StudentAttendances.Where(x => x.AttendanceID == checkAttendanceFound.ID && x.StudentID == STDID).FirstOrDefault();
                        if (StdAttendance == null)
                        {
                            StudentAttendance newattende = new StudentAttendance();
                            //AttendTime Homework sheet id Attendance
                            newattende.ID = 0;
                            newattende.HomeWork = Convert.ToBoolean(item.Cells["Homework"].Value);
                            newattende.Sheet = Convert.ToBoolean(item.Cells["sheet"].Value);
                            newattende.Attend = Convert.ToBoolean(item.Cells["Attendance"].Value);
                            newattende.StudentID = Convert.ToInt64(item.Cells["ID"].Value);
                            newattende.AttendanceTime = Convert.ToDateTime(item.Cells["AttendTime"].Value);
                            newattende.AttendanceTime = DateTime.Now;
                            if (checkAttendanceFound == null)
                                newattende.AttendanceID = att.ID;
                            else
                                newattende.AttendanceID = checkAttendanceFound.ID;

                            newattende.AdditionalHomeWork = false;
                            newattende.SheetMarks = 0;
                            context.StudentAttendances.Add(newattende);
                            context.SaveChanges();
                        }
                        else
                        {

                            StdAttendance.HomeWork = Convert.ToBoolean(item.Cells["Homework"].Value);
                            StdAttendance.Sheet = Convert.ToBoolean(item.Cells["sheet"].Value);
                            context.SaveChanges();

                        }

                    }

                }
                Program.SuccessMessage.lblMessage.Text = "تم حفظ بيانات الحضور بنجاح";
                Program.SuccessMessage.ShowDialog();
               
                Program.DashbordRunningForm.btnMenuAttendanceRecord.PerformClick();
                
            }
            catch
            {
                Program.Message.lblMessage.Text = "حدث خطا اثناء حفظ بيانات الحضور";
                txtClassDate.Enabled = true;

                Program.Message.ShowDialog();
            }

            
  
        }
        Attendence atta = new Attendence();
        private void btnUsingQR_Click(object sender, EventArgs e)
        {
          
            if (txtClassDate.Text!="")
            {

                atta.ClassDate = Convert.ToDateTime(txtClassDate.Text);

                atta.GroupID = long.Parse(lblGroupID.Text);
                Attendence checkAttendanceFound = context.Attendences.Where(x => x.GroupID == atta.GroupID && x.ClassDate == atta.ClassDate).FirstOrDefault();
                if (checkAttendanceFound == null)
                {
                    context.Attendences.Add(atta);
                    context.SaveChanges();
                }
                else
                {
                    atta = checkAttendanceFound;
                }
               
                startQR();
              
            }
            else
            {
                Program.Message.lblMessage.Text = "يجب تسجيل وقت الحصه قبل استخدام QR";
                txtClassDate.Enabled = true;
        
                Program.Message.ShowDialog();
            }
       

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
          

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
                    Student student = context.Students.Where(x=>x.GroupID==GropID&&x.QR==r).FirstOrDefault();
                    txtSearch.Text = r;
                  
                    

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
       public void SearchOnGrdAndMakeAttend( string searchTxt)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in grdTodayStudentsAttendance.Rows)
            {
                if (row.Cells["StudentName"].Value.ToString().Equals(searchTxt)||row.Cells["QR"].Value.ToString().Equals(searchTxt))
                {
                    rowIndex = row.Index;
                    
                    grdTodayStudentsAttendance.Rows[rowIndex].Selected = true;
                    grdTodayStudentsAttendance.FirstDisplayedScrollingRowIndex = rowIndex;

                    break;
                }
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
       {
            grdTodayStudentsAttendance.ClearSelection();
            SearchOnGrdAndMakeAttend(txtSearch.Text);
        }
    }
}