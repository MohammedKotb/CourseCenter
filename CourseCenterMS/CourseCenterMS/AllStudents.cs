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
    public partial class frmAllStudents : Form
    {
       CourseCenterEntities context;
        public frmAllStudents()
        {
            InitializeComponent();
            context = new CourseCenterEntities();
        }

        private void frmAllStudents_Load(object sender, EventArgs e)
        {
           
            
        }

        private void grdAllStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (grdAllStudents.Columns[e.ColumnIndex].HeaderText=="تفاصيل")
            {
                   
                    

                    long stdID = Convert.ToInt64(grdAllStudents.Rows[e.RowIndex].Cells["ID"].Value);
                    Student student = context.Students.Where(x => x.ID == stdID).Include(x=>x.Group).Include(x=>x.Department).FirstOrDefault();
                    frmShowStudentData fStdData = new frmShowStudentData();
                   
                    fStdData.txtName.Text = student.Name;
                    fStdData.txtAddress.Text = student.Address;
                    fStdData.txtPhone.Text = student.Phone;
                    fStdData.txtSchool.Text = student.School;
                    fStdData.txtQR.Text = student.QR;
                    fStdData.txtFatherJob.Text = student.FatherJob;
                    fStdData.txtFatherPhone.Text = student.FatherPhone;
                    fStdData.txtMotherPhone.Text = student.MotherPhone;
                    fStdData.txtClassroom.Text = student.Classroom;
                    fStdData.txtDibt.Text = student.Debit.ToString();
                    fStdData.txtCredits.Text = student.Credit.ToString();
                    fStdData.cmboDepartment.DataSource = context.Departments.ToList();
                    fStdData.cmboGroup.DataSource = context.Groups.ToList();

                    fStdData.cmboDepartment.ValueMember = "ID";
                    fStdData.cmboDepartment.DisplayMember = "Name";
                    fStdData.cmboGroup.ValueMember = "ID";
                    fStdData.cmboGroup.DisplayMember = "Name";
                    //new[] { student.Department.Name };
                    fStdData.cmboDepartment.SelectedValue =student.DepartmentID;
                    fStdData.cmboGroup.SelectedValue = student.GroupID;
                   
                    //fStdData.cmboGroup.selectedIndex = 0;
                    //fStdData.pctureImage.Image = student.ImgURL;
                    if (student.Gender=="ذكر")
                    {
                        fStdData.radMale.Checked = true;
                    }
                   else if(student.Gender == "انثى")
                    {
                        fStdData.radFemail.Checked = true;
                    }
                    if (student.IsFatherPrimary)
                    {
                        fStdData.radCallFather.Checked = true;
                        fStdData.radCallMother.Checked = false;
                    }
                    else
                    {
                        fStdData.radCallMother.Checked = true;

                        fStdData.radCallFather.Checked = false;
                        

                    }
                    fStdData.lblStdID.Text = stdID.ToString();


                    Program.DashbordRunningForm.ContainerPnl.Controls.Clear();
                    Program.DashbordRunningForm.ContainerPnl.Controls.Add(fStdData.pnlStudentData);
                }
            }
        }

        private void pnlAllStudents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grdAllStudents.ClearSelection();
            SearchOnGrd(txtSearch.Text);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            grdAllStudents.ClearSelection();
            SearchOnGrd(txtSearch.Text);
        }
        //function for Grid Searching
        public void SearchOnGrd(string searchTxt)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in grdAllStudents.Rows)
            {
                if (row.Cells["StudentName"].Value.ToString().Contains(searchTxt) || row.Cells["QR"].Value.ToString().Equals(searchTxt))
                {
                    rowIndex = row.Index;

                    grdAllStudents.Rows[rowIndex].Selected = true;
                    grdAllStudents.FirstDisplayedScrollingRowIndex = rowIndex;

                    break;
                }
            }
        }

       
    }
}
