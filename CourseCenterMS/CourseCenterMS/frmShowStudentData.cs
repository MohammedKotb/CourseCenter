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
    public partial class frmShowStudentData : Form
    {
        CourseCenterEntities context = new CourseCenterEntities();
        public frmShowStudentData()
        {
            InitializeComponent();
        }

        private void btnSaveAndContainue_Click(object sender, EventArgs e)
        {
            try
            {
                long stdID = Int64.Parse(lblStdID.Text);
                Student student = context.Students.Find(stdID);
                if (student != null)
                {

                    student.Name = txtName.Text;
                    student.Address = txtAddress.Text;
                    student.School = txtSchool.Text;
                    student.DepartmentID = cmboDepartment.SelectedIndex >= 0 ? int.Parse(cmboDepartment.SelectedValue.ToString()) : 0;
                    student.QR = txtQR.Text;
                    student.FatherJob = txtFatherPhone.Text;
                    student.Credit = txtCredits.Text != "" ? Convert.ToDecimal(txtCredits.Text) : 0.0m;
                    student.Debit = txtDibt.Text != "" ? Convert.ToDecimal(txtDibt.Text) : 0.0m;
                    student.MotherPhone = txtMotherPhone.Text;
                    student.FatherPhone = txtFatherPhone.Text;
                    student.GroupID = cmboGroup.SelectedIndex >= 0 ? int.Parse(cmboGroup.SelectedValue.ToString()) : 0;
                    student.GroupName = cmboGroup.SelectedIndex >= 0 ? cmboGroup.GetItemText(cmboGroup.SelectedItem) : null;
                    student.Classroom = txtClassroom.Text;
                    student.Phone = txtPhone.Text;
                    student.GroupName = cmboGroup.SelectedIndex >= 0 ? cmboGroup.Text:"";
                    student.IsActive = true;
                    if (radMale.Checked)
                    {
                        student.Gender = "ذكر";
                    }
                    else
                    {
                        student.Gender = "انثى";

                    }
                    if (radCallFather.Checked)
                    {
                        student.IsFatherPrimary =true;
                    }
                    else
                    {
                        student.IsFatherPrimary = false;

                    }

                    context.SaveChanges();

                }
                Program.SuccessMessage.lblMessage.Text = "تم حفظ تعديلات الطالب بنجاح";
                Program.SuccessMessage.ShowDialog();
            
                Program.DashbordRunningForm.btnAllStudents.PerformClick();
            }
            catch 
            {
                Program.Message.lblMessage.Text = "حدث خطأ اثناء تعديل البيانات ..تأكد من صحه البيانات ";
            }
               
            }

        private void radCallFather_OnChange(object sender, EventArgs e)
        {
            if (radCallFather.Checked)
            {
                radCallMother.Checked = false;
            }
        }

        private void radCallMother_OnChange(object sender, EventArgs e)
        {
            if (radCallMother.Checked)
            {
                radCallFather.Checked = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                long stdID = Int64.Parse(lblStdID.Text);
                Student student = context.Students.Find(stdID);
                if (student != null)
                {
                    student.IsDeleted = true;
                    context.SaveChanges();
                }
               
                Program.SuccessMessage.lblMessage.Text = "تم حذف بيانات الطالب بنجاح ";
                Program.SuccessMessage.ShowDialog();
                Program.DashbordRunningForm.btnAllStudents.PerformClick();


            }
            catch
            {
               
                Program.Message.lblMessage.Text = "حدث خطا اثناء حذف بيانات الطالب ";
                Program.Message.ShowDialog();
            }
        }
    }
    }

