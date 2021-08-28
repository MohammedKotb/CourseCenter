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
        CourseCenterEntities context;
        public Dashbord()
        {
            InitializeComponent();
            ph = pnlStudent.Height;
            hided = false;
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
            frmNewStudent f = new frmNewStudent();

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
                string Days=item.GroupDays.FirstOrDefault().Day;

                foreach (var day in item.GroupDays)
                {
                    if(day!= item.GroupDays.FirstOrDefault())
                    Days+= "  -   " + day.Day;
                }
                groupGrid.GroupDays = Days;
                groupGrid.StudentsCount = context.Students.Where(x => x.IsActive == true && x.IsDeleted == false && x.GroupID == item.ID).Count();
                groupsToGrid.Add(groupGrid);
            }
            f.grdAllGroups.DataSource = groupsToGrid;
            ContainerPnl.Controls.Clear();
            ContainerPnl.Controls.Add(f.pnlAllGroups);

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