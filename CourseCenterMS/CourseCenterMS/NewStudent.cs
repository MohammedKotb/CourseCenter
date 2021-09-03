 using System;
﻿using CourseCenterMS.Models;
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
    public partial class frmNewStudent : Form
    {
        CourseCenterEntities context;
        public frmNewStudent()
        {
            InitializeComponent();
            context = new CourseCenterEntities();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
          //  btnAddPicture.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
           // btnAddPicture.Visible = false;

        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("h");
        }

        private void frmNewStudent_Load(object sender, EventArgs e)
        {



        }

        private void pnlGridContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = SaveStudent();
            if (result)
            {
                Program.SuccessMessage.lblMessage.Text ="تم حفظ بيانات الطالب بنجاح";
                Program.SuccessMessage.ShowDialog();
                Program.DashbordRunningForm.btnAllStudents.PerformClick();

            }

            else
            {
                Program.Message.lblMessage.Text = "حدث خطا اثناء تسجيل بيانات الطالب ";
                Program.Message.ShowDialog();
            }
         

        }

        private void chkCallFather_OnChange(object sender, EventArgs e)
        {
            if (chkCallFather.Checked)
            {
                chkCallMother.Checked = false;
            }
            else
            {
                chkCallMother.Checked = true;

            }
        }

        private void chkCallMother_OnChange(object sender, EventArgs e)
        {
            if (chkCallMother.Checked)
            {
                chkCallFather.Checked = false;
            }
            else
            {
                chkCallFather.Checked = true;

            }
        }
        private bool SaveStudent()
        {
            try
            {
                Student student = new Student();
                student.Name = txtName.Text!=""?txtName.Text:throw new Exception();
                student.Address = txtAddress.Text!=""? txtAddress.Text:throw new Exception();
                student.School = txtSchool.Text!=""? txtSchool.Text : throw new Exception();
                student.DepartmentID = cmboDepartment.SelectedIndex >= 0 ? int.Parse(cmboDepartment.SelectedValue.ToString()) :throw new Exception();
                student.QR = txtQR.Text!=""? txtQR.Text : throw new Exception();
                student.FatherJob = txtFatherPhone.Text;
                student.Credit = txtCredit.Text != "" ? Convert.ToDecimal(txtCredit.Text) :0.0m;
                student.Debit = txtDibt.Text != "" ? Convert.ToDecimal(txtDibt.Text) :0.0m;
                student.MotherPhone = txtMatherPhone.Text;
                student.FatherPhone = txtFatherPhone.Text;
                student.GroupID = cmboGroup.SelectedIndex >= 0 ? int.Parse(cmboGroup.SelectedValue.ToString()) :throw new Exception();
                student.GroupName = cmboGroup.SelectedIndex >=0?cmboGroup.GetItemText( cmboGroup.SelectedItem) : null;
                student.Classroom = txtClassroom.Text;
                student.Phone = txtPhone.Text;
                student.IsActive = true;
                if (radMale.Checked)
                {
                    student.Gender = "ذكر";
                }
                else
                {
                    student.Gender = "انثى";

                }
                if (chkCallFather.Checked)
                {
                    student.IsFatherPrimary = true;
                }
                else
                {
                    student.IsFatherPrimary = true;
                }
                context.Students.Add(student);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        private void btnSaveAndContainue_Click(object sender, EventArgs e)
        {
            bool result = SaveStudent();
            if (result)
            {
                Program.SuccessMessage.lblMessage.Text = "تم حفظ بيانات الطالب بنجاح";
                Program.SuccessMessage.ShowDialog();
                txtAddress.Text = txtClassroom.Text = txtCredit.Text = txtDibt.Text = txtFatherPhone.Text
          = txtMatherPhone.Text = txtName.Text = txtPhone.Text = txtQR.Text = txtSchool.Text = txtAddress.Text = txtFatherJob.Text = "";
                cmboDepartment.SelectedIndex = cmboGroup.SelectedIndex = 0;
            }

            else
            {
                Program.Message.lblMessage.Text = "حدث خطا اثناء تسجيل بيانات الطالب ";
                Program.Message.ShowDialog();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAddress.Text = txtClassroom.Text = txtCredit.Text = txtDibt.Text = txtFatherPhone.Text
           = txtMatherPhone.Text = txtName.Text = txtPhone.Text = txtQR.Text = txtSchool.Text = txtAddress.Text=txtFatherJob.Text = "";
            cmboDepartment.SelectedIndex=cmboGroup.SelectedIndex = 0;
     

        }

        
        // Function to rest All values for form Controls


    }
}