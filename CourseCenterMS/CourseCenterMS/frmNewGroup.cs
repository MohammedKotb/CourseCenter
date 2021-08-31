using CourseCenterMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCenterMS
{
    public partial class frmNewGroup : Form
    {
        CourseCenterEntities context;
        public frmNewGroup()
        {
            InitializeComponent();
            context = new CourseCenterEntities();

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pnlGridContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveNewGroupe();
        }
        private void btnSaveAndContainue_Click(object sender, EventArgs e)
        {
            SaveNewGroupe();
        }

        public void SaveNewGroupe()
        {
            Group group = new Group();
            try
            {
                int count = 0;
                group.Name = txtGroupName.Text != "" ? txtGroupName.Text : throw new Exception("يجب ادخال اسم المجموعه لاتمام التسجيل");
                group.Classroom = txtClassroom.Text != "" ? txtClassroom.Text : throw new Exception("يجب ادخال الصف الدراسى لاتمام التسجيل");
                group.StartDate = dtpkrStartYear.Value != null ? dtpkrStartYear.Value.Date : throw new Exception("يجب ادخال تاريخ بدء المجموعه لاتمام التسجيل");
                group.EndDate = dtPkrEndDate.Value != null ? dtPkrEndDate.Value.Date : throw new Exception("يجب ادخال تاريخ انتهاء المجموعه لاتمام التسجيل");
                group.CreationDate = DateTime.Now;
                context.Groups.Add(group);
                context.SaveChanges();
                if (chkIsActive.Checked)
                {
                    group.IsActive = true;
                }
                else
                    group.IsActive = false;

                context.Groups.Add(group);
                if (chkSaturay.Checked)
                {
                    SaveGroupDayAndTime(group.ID, "السبت");
                    count++;
                }
                if (chkSunday.Checked)
                {
                    SaveGroupDayAndTime(group.ID, "الاحد");
                    count++;

                }
                if (chkMonday.Checked)
                {
                    SaveGroupDayAndTime(group.ID, "الاثنين");
                    count++;

                }
                if (chkTuesday.Checked)
                {
                    SaveGroupDayAndTime(group.ID, "الثلاثاء");
                    count++;

                }
                if (chkWednesday.Checked)
                {
                    SaveGroupDayAndTime(group.ID, "الاربعاء");
                    count++;

                }
                if (chkThursday.Checked)
                {
                    SaveGroupDayAndTime(group.ID, "الخميس");
                    count++;

                }
                if (chkFriday.Checked)
                {
                    SaveGroupDayAndTime(group.ID, "الجمعه");
                    count++;

                }
                if (count > 0)
                {
                    MessageBox.Show("تم اضافة المجموعه بنجاح");

                }
                else
                {
                    MessageBox.Show("لم يتم حفظ المجموعه بنجاح يجب تحدبد يوم ووقت المجموعة");
                    context.Groups.Remove(group);
                    context.SaveChanges();

                }


            }
            catch (Exception ex)
            {
              
              

                Program.Message.lblMessage.Text = ex.Message;
                Program.Message.ShowDialog();

            }
        }

        public void SaveGroupDayAndTime(long groupID, string day)
        {
            GroupDay groupDay = new GroupDay();
            groupDay.Day = day;
            groupDay.GroupID = groupID;
            int hourFrom = int.Parse(cmboTimeFrom.GetItemText(cmboTimeFrom.SelectedItem));
            int hourTo = int.Parse(cmboTimeTo.GetItemText(cmboTimeTo.SelectedItem));
            if (RadPmFrom.Checked)
            {
                hourFrom += 12;
            }
            DateTime dFrom = new DateTime(2000, 1, 1, hourFrom, 0, 0);
            groupDay.TimeFrom = dFrom;

            if (RadPmTo.Checked)
            {
                hourTo += 12;
            }
            DateTime dTo = new DateTime(2000, 1, 1, hourTo, 0, 0);
            groupDay.TimeTo = dTo;
            context.GroupDays.Add(groupDay);
            context.SaveChanges();
        }

       
    }
}

