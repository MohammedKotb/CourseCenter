using CourseCenterMS.Models;
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

namespace CourseCenterMS
{
    public partial class Dashbord : Form
    {
        int ph; bool hided;
        List<Department> departments;
        List<Group> groups;
        CourseCenterEntities context;
        public Dashbord()
        {
            InitializeComponent();
            ph = pnlStudent.Height;
            hided = false;
            groups = new List<Group>();
            departments = new List<Department>();
            context = new CourseCenterEntities();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Helper.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Helper.Minimaize(this);
        }

        private void btnAllStudents_Click(object sender, EventArgs e)
        {

            frmAllStudents f = new frmAllStudents();
            ContainerPnl.Controls.Clear();
            f.grdAllStudents.DataSource = context.Students.Select(x => new { x.Name, x.GroupName, x.Classroom, x.Phone, x.ID }).ToList(); ;
            ContainerPnl.Controls.Add(f.pnlAllStudents);
        }

        private void btnMenuAddStudent_Click(object sender, EventArgs e)
        {
            groups = context.Groups.Where(x => x.IsActive == true && x.IsDeleted == false).ToList();
            departments = context.Departments.ToList();
            frmNewStudent f = new frmNewStudent();
            f.cmboDepartment.DataSource = departments;
            f.cmboDepartment.ValueMember = "ID";
            f.cmboDepartment.DisplayMember = "Name";
            f.cmboGroup.DataSource = groups;
            f.cmboGroup.ValueMember = "ID";
            f.cmboGroup.DisplayMember = "Name";
            ContainerPnl.Controls.Clear();
            f.pnlNewStudent.Width = ContainerPnl.Width;
            f.pnlNewStudent.Height = ContainerPnl.Height;

            ContainerPnl.Controls.Add(f.pnlNewStudent);

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            // Helper.ShowSubMenu(pnlStudent);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Show(pnlGroups);
            //Helper.ShowSubMenu(pnlGroups);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Helper.ShowSubMenu(pnlPresence);

        }
        public void Show(Panel subMenu)
        {
            if (hided)
            {
                subMenu.Height = subMenu.Height + 5;
                if (subMenu.Height >= ph)
                {
                    // timer1.Stop();
                    hided = false;

                }
            }
            else
            {
                subMenu.Height = subMenu.Height - 5;
                if (subMenu.Height <= 0)
                {
                    //timer1.Stop();
                    hided = true;

                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Show(pnlStudent);
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            pnlStudent.Height = 0;
            // pnlGroups.Height = 0;
            // pnlPresence.Height = 0;
        }

        private void btnMenuAddGroup_Click(object sender, EventArgs e)
        {
            frmNewGroup f = new frmNewGroup();
            ContainerPnl.Controls.Clear();
            ContainerPnl.Controls.Add(f.pnlNewGroup);
        }

        private void btnAllGroups_Click(object sender, EventArgs e)
        {
            frmAllGroup f = new frmAllGroup();

            List<Group> groups = context.Groups.Where(x => x.IsDeleted == false).Include(x => x.GroupDays).ToList();

            List<GroupToGrid> groupsToGrid = new List<GroupToGrid>();
            foreach (var item in groups)
            {
                GroupToGrid groupGrid = new GroupToGrid();
                groupGrid.ID = item.ID;
                groupGrid.Name = item.Name;
                groupGrid.StartTime = item.GroupDays.FirstOrDefault().TimeFrom.ToShortTimeString();
                groupGrid.EndTime = item.GroupDays.FirstOrDefault().TimeTo.ToShortTimeString();
                string Days = item.GroupDays.FirstOrDefault().Day;

                foreach (var day in item.GroupDays)
                {
                    if (day != item.GroupDays.FirstOrDefault())
                        Days += "  -   " + day.Day;
                }
                groupGrid.GroupDays = Days;
                groupGrid.StudentsCount = context.Students.Where(x => x.IsActive == true && x.IsDeleted == false && x.GroupID == item.ID).Count();
                groupsToGrid.Add(groupGrid);
            }
            f.grdAllGroups.DataSource = groupsToGrid;
            ContainerPnl.Controls.Clear();
            ContainerPnl.Controls.Add(f.pnlAllGroups);

        }

        private void btnStudent_Click_1(object sender, EventArgs e)
        {
            pnlGroup.Visible = false;
            pnlAttendance.Visible = false;
            Helper.ShowSubMenu(pnlStudent);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlStudent.Visible = false;
            pnlAttendance.Visible = false;
            Helper.ShowSubMenu(pnlGroup);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pnlGroup.Visible = false;
            pnlStudent.Visible = false;
            Helper.ShowSubMenu(pnlAttendance);
        }

        private void btnMenuAttendanceTable_Click(object sender, EventArgs e)
        {
            frmAllAtendance f = new frmAllAtendance();
            f.grdAllAttendanceGroup.DataSource = context.Groups.Where(x => x.IsDeleted == false && x.IsActive == true)
                .Select(x => new { x.Name, x.Classroom, x.StartDate, x.EndDate, x.IsActive, x.ID }).ToList();
            ContainerPnl.Controls.Clear();
            ContainerPnl.Controls.Add(f.pnlAllAttendance);
        }

        private void btnMenuAttendanceRecord_Click(object sender, EventArgs e)
        {
            List<GroupDay> groupDays = new List<GroupDay>();
            List<Group> TodayGroups = new List<Group>();
            DayOfWeek today = DateTime.Now.DayOfWeek;


            if (today == DayOfWeek.Saturday)
            {
                TodayGroups = context.GroupDays.Include(x => x.Group).Where(x => x.Day == "السبت").Select(x => x.Group).ToList();

            }
            else if (today == DayOfWeek.Sunday)
            {
                TodayGroups = context.GroupDays.Include(x => x.Group).Where(x => x.Day == "الاحد").Select(x => x.Group).ToList();

            }
            else if (today == DayOfWeek.Monday)
            {
                TodayGroups = context.GroupDays.Include(x => x.Group).Where(x => x.Day == "الاثنين").Select(x => x.Group).ToList();

            }
            else if (today == DayOfWeek.Tuesday)
            {
                TodayGroups = context.GroupDays.Include(x => x.Group).Where(x => x.Day == "الثلاثاء").Select(x => x.Group).ToList();

            }
            else if (today == DayOfWeek.Wednesday)
            {
                TodayGroups = context.GroupDays.Include(x => x.Group).Where(x => x.Day == "الاربعاء").Select(x => x.Group).ToList();

            }
            else if (today == DayOfWeek.Thursday)
            {
                TodayGroups = context.GroupDays.Include(x => x.Group).Where(x => x.Day == "الخميس").Select(x => x.Group).ToList();

            }
            else if (today == DayOfWeek.Friday)
            {
                TodayGroups = context.GroupDays.Include(x => x.Group).Where(x => x.Day == "الجمعه").Select(x => x.Group).ToList();

            }
            frmTodayAtendanceGroups f = new frmTodayAtendanceGroups();
            f.grdTodayAttendanceGroup.DataSource = TodayGroups.Where(x => x.IsDeleted == false && x.IsActive == true)
                .Select(x => new { x.Name, x.Classroom,x.GroupDays.FirstOrDefault().TimeFrom, x.GroupDays.FirstOrDefault().TimeTo, x.IsActive, x.ID }).ToList();
            ContainerPnl.Controls.Clear();
            ContainerPnl.Controls.Add(f.pnlTodayAttendance);
        }
    }

    public class GroupToGrid
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string GroupDays { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int StudentsCount { get; set; }

    }
}
