
namespace CourseCenterMS
{
    partial class frmShowStudentData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowStudentData));
            this.pnlStudentData = new System.Windows.Forms.Panel();
            this.crdSearchResult = new Bunifu.Framework.UI.BunifuCards();
            this.lblStdID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.radCallMother = new Bunifu.Framework.UI.BunifuCheckbox();
            this.radCallFather = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnSaveAndContainue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cmboDepartment = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtCredits = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFatherJob = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtQR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSchool = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmboGroup = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDibt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMotherPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFatherPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtClassroom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.radFemail = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddPicture = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pctureImage = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGridHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlStudentData.SuspendLayout();
            this.crdSearchResult.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStudentData
            // 
            this.pnlStudentData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStudentData.AutoScroll = true;
            this.pnlStudentData.AutoSize = true;
            this.pnlStudentData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudentData.Controls.Add(this.crdSearchResult);
            this.pnlStudentData.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentData.Name = "pnlStudentData";
            this.pnlStudentData.Size = new System.Drawing.Size(1165, 800);
            this.pnlStudentData.TabIndex = 1;
            // 
            // crdSearchResult
            // 
            this.crdSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.crdSearchResult.AutoScroll = true;
            this.crdSearchResult.AutoScrollMinSize = new System.Drawing.Size(0, 600);
            this.crdSearchResult.AutoSize = true;
            this.crdSearchResult.BackColor = System.Drawing.Color.White;
            this.crdSearchResult.BorderRadius = 5;
            this.crdSearchResult.BottomSahddow = true;
            this.crdSearchResult.color = System.Drawing.Color.Green;
            this.crdSearchResult.Controls.Add(this.lblStdID);
            this.crdSearchResult.Controls.Add(this.bunifuSeparator1);
            this.crdSearchResult.Controls.Add(this.pnlGridContainer);
            this.crdSearchResult.Controls.Add(this.lblGridHeader);
            this.crdSearchResult.LeftSahddow = false;
            this.crdSearchResult.Location = new System.Drawing.Point(12, 24);
            this.crdSearchResult.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.crdSearchResult.Name = "crdSearchResult";
            this.crdSearchResult.RightSahddow = true;
            this.crdSearchResult.ShadowDepth = 20;
            this.crdSearchResult.Size = new System.Drawing.Size(1143, 615);
            this.crdSearchResult.TabIndex = 1;
            // 
            // lblStdID
            // 
            this.lblStdID.AutoSize = true;
            this.lblStdID.BackColor = System.Drawing.Color.Transparent;
            this.lblStdID.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdID.ForeColor = System.Drawing.Color.Black;
            this.lblStdID.Location = new System.Drawing.Point(839, 28);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(74, 25);
            this.lblStdID.TabIndex = 93;
            this.lblStdID.Text = "StudentID";
            this.lblStdID.Visible = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 61);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1114, 10);
            this.bunifuSeparator1.TabIndex = 21;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.Controls.Add(this.radCallMother);
            this.pnlGridContainer.Controls.Add(this.radCallFather);
            this.pnlGridContainer.Controls.Add(this.btnSaveAndContainue);
            this.pnlGridContainer.Controls.Add(this.btnCancel);
            this.pnlGridContainer.Controls.Add(this.btnSave);
            this.pnlGridContainer.Controls.Add(this.bunifuSeparator2);
            this.pnlGridContainer.Controls.Add(this.cmboDepartment);
            this.pnlGridContainer.Controls.Add(this.txtCredits);
            this.pnlGridContainer.Controls.Add(this.txtFatherJob);
            this.pnlGridContainer.Controls.Add(this.txtQR);
            this.pnlGridContainer.Controls.Add(this.txtSchool);
            this.pnlGridContainer.Controls.Add(this.txtAddress);
            this.pnlGridContainer.Controls.Add(this.txtName);
            this.pnlGridContainer.Controls.Add(this.cmboGroup);
            this.pnlGridContainer.Controls.Add(this.txtPhone);
            this.pnlGridContainer.Controls.Add(this.txtDibt);
            this.pnlGridContainer.Controls.Add(this.txtMotherPhone);
            this.pnlGridContainer.Controls.Add(this.txtFatherPhone);
            this.pnlGridContainer.Controls.Add(this.txtClassroom);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel7);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel17);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel16);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel14);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel13);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel6);
            this.pnlGridContainer.Controls.Add(this.radFemail);
            this.pnlGridContainer.Controls.Add(this.radMale);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel15);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel12);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel10);
            this.pnlGridContainer.Controls.Add(this.btnAddPicture);
            this.pnlGridContainer.Controls.Add(this.pctureImage);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel4);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel11);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel9);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel8);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel5);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel3);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel2);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel1);
            this.pnlGridContainer.Controls.Add(this.lblID);
            this.pnlGridContainer.Location = new System.Drawing.Point(3, 84);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Size = new System.Drawing.Size(1100, 523);
            this.pnlGridContainer.TabIndex = 20;
            // 
            // radCallMother
            // 
            this.radCallMother.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCallMother.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.radCallMother.Checked = true;
            this.radCallMother.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCallMother.ForeColor = System.Drawing.Color.White;
            this.radCallMother.Location = new System.Drawing.Point(182, 300);
            this.radCallMother.Margin = new System.Windows.Forms.Padding(4);
            this.radCallMother.Name = "radCallMother";
            this.radCallMother.Size = new System.Drawing.Size(20, 20);
            this.radCallMother.TabIndex = 92;
            // 
            // radCallFather
            // 
            this.radCallFather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCallFather.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.radCallFather.Checked = true;
            this.radCallFather.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radCallFather.ForeColor = System.Drawing.Color.White;
            this.radCallFather.Location = new System.Drawing.Point(180, 248);
            this.radCallFather.Margin = new System.Windows.Forms.Padding(4);
            this.radCallFather.Name = "radCallFather";
            this.radCallFather.Size = new System.Drawing.Size(20, 20);
            this.radCallFather.TabIndex = 92;
            // 
            // btnSaveAndContainue
            // 
            this.btnSaveAndContainue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.btnSaveAndContainue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveAndContainue.FlatAppearance.BorderSize = 0;
            this.btnSaveAndContainue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndContainue.Font = new System.Drawing.Font("Sakkal Majalla", 16F, System.Drawing.FontStyle.Bold);
            this.btnSaveAndContainue.ForeColor = System.Drawing.Color.Navy;
            this.btnSaveAndContainue.Image = global::CourseCenterMS.Properties.Resources.icons8_save_32;
            this.btnSaveAndContainue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAndContainue.Location = new System.Drawing.Point(809, 474);
            this.btnSaveAndContainue.Name = "btnSaveAndContainue";
            this.btnSaveAndContainue.Size = new System.Drawing.Size(154, 36);
            this.btnSaveAndContainue.TabIndex = 91;
            this.btnSaveAndContainue.Text = "حفـــــظ واستمرار";
            this.btnSaveAndContainue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAndContainue.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Sakkal Majalla", 16F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Image = global::CourseCenterMS.Properties.Resources.icons8_cancel_32;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(76, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 36);
            this.btnCancel.TabIndex = 91;
            this.btnCancel.Text = "الغــــــاء";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Sakkal Majalla", 16F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Navy;
            this.btnSave.Image = global::CourseCenterMS.Properties.Resources.icons8_save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(983, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 36);
            this.btnSave.TabIndex = 91;
            this.btnSave.Text = "حفـــــظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, 450);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1105, 20);
            this.bunifuSeparator2.TabIndex = 90;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // cmboDepartment
            // 
            this.cmboDepartment.BackColor = System.Drawing.Color.Transparent;
            this.cmboDepartment.BorderRadius = 3;
            this.cmboDepartment.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboDepartment.ForeColor = System.Drawing.Color.Navy;
            this.cmboDepartment.Items = new string[] {
        "علمى علوم ",
        "علمى رياضة",
        "أدبى"};
            this.cmboDepartment.Location = new System.Drawing.Point(685, 186);
            this.cmboDepartment.Margin = new System.Windows.Forms.Padding(8, 15, 8, 15);
            this.cmboDepartment.Name = "cmboDepartment";
            this.cmboDepartment.NomalColor = System.Drawing.Color.LightGray;
            this.cmboDepartment.onHoverColor = System.Drawing.Color.Silver;
            this.cmboDepartment.selectedIndex = -1;
            this.cmboDepartment.Size = new System.Drawing.Size(292, 32);
            this.cmboDepartment.TabIndex = 6;
            // 
            // txtCredits
            // 
            this.txtCredits.BackColor = System.Drawing.Color.LightGray;
            this.txtCredits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCredits.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCredits.ForeColor = System.Drawing.Color.Navy;
            this.txtCredits.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCredits.HintText = "";
            this.txtCredits.isPassword = false;
            this.txtCredits.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCredits.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtCredits.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtCredits.LineThickness = 5;
            this.txtCredits.Location = new System.Drawing.Point(685, 351);
            this.txtCredits.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtCredits.Size = new System.Drawing.Size(292, 39);
            this.txtCredits.TabIndex = 10;
            this.txtCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFatherJob
            // 
            this.txtFatherJob.BackColor = System.Drawing.Color.LightGray;
            this.txtFatherJob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFatherJob.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtFatherJob.ForeColor = System.Drawing.Color.Navy;
            this.txtFatherJob.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtFatherJob.HintText = "";
            this.txtFatherJob.isPassword = false;
            this.txtFatherJob.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtFatherJob.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtFatherJob.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtFatherJob.LineThickness = 5;
            this.txtFatherJob.Location = new System.Drawing.Point(685, 296);
            this.txtFatherJob.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtFatherJob.Name = "txtFatherJob";
            this.txtFatherJob.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtFatherJob.Size = new System.Drawing.Size(292, 39);
            this.txtFatherJob.TabIndex = 8;
            this.txtFatherJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQR
            // 
            this.txtQR.BackColor = System.Drawing.Color.LightGray;
            this.txtQR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQR.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtQR.ForeColor = System.Drawing.Color.Navy;
            this.txtQR.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtQR.HintText = "";
            this.txtQR.isPassword = false;
            this.txtQR.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtQR.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtQR.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtQR.LineThickness = 5;
            this.txtQR.Location = new System.Drawing.Point(685, 241);
            this.txtQR.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtQR.Name = "txtQR";
            this.txtQR.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtQR.Size = new System.Drawing.Size(292, 39);
            this.txtQR.TabIndex = 6;
            this.txtQR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSchool
            // 
            this.txtSchool.BackColor = System.Drawing.Color.LightGray;
            this.txtSchool.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSchool.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSchool.ForeColor = System.Drawing.Color.Navy;
            this.txtSchool.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSchool.HintText = "";
            this.txtSchool.isPassword = false;
            this.txtSchool.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSchool.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtSchool.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtSchool.LineThickness = 5;
            this.txtSchool.Location = new System.Drawing.Point(685, 131);
            this.txtSchool.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtSchool.Size = new System.Drawing.Size(292, 39);
            this.txtSchool.TabIndex = 85;
            this.txtSchool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.LightGray;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtAddress.ForeColor = System.Drawing.Color.Navy;
            this.txtAddress.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtAddress.HintText = "";
            this.txtAddress.isPassword = false;
            this.txtAddress.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAddress.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtAddress.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtAddress.LineThickness = 5;
            this.txtAddress.Location = new System.Drawing.Point(685, 76);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtAddress.Size = new System.Drawing.Size(292, 39);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightGray;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.Navy;
            this.txtName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtName.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtName.LineThickness = 5;
            this.txtName.Location = new System.Drawing.Point(685, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtName.Size = new System.Drawing.Size(292, 39);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmboGroup
            // 
            this.cmboGroup.BackColor = System.Drawing.Color.Transparent;
            this.cmboGroup.BorderRadius = 3;
            this.cmboGroup.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboGroup.ForeColor = System.Drawing.Color.Navy;
            this.cmboGroup.Items = new string[0];
            this.cmboGroup.Location = new System.Drawing.Point(225, 186);
            this.cmboGroup.Margin = new System.Windows.Forms.Padding(8, 15, 8, 15);
            this.cmboGroup.Name = "cmboGroup";
            this.cmboGroup.NomalColor = System.Drawing.Color.LightGray;
            this.cmboGroup.onHoverColor = System.Drawing.Color.Silver;
            this.cmboGroup.selectedIndex = -1;
            this.cmboGroup.Size = new System.Drawing.Size(292, 32);
            this.cmboGroup.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.LightGray;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtPhone.ForeColor = System.Drawing.Color.Navy;
            this.txtPhone.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPhone.HintText = "";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtPhone.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtPhone.LineThickness = 5;
            this.txtPhone.Location = new System.Drawing.Point(225, 21);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtPhone.Size = new System.Drawing.Size(292, 39);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDibt
            // 
            this.txtDibt.BackColor = System.Drawing.Color.LightGray;
            this.txtDibt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDibt.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDibt.ForeColor = System.Drawing.Color.Navy;
            this.txtDibt.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDibt.HintText = "";
            this.txtDibt.isPassword = false;
            this.txtDibt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDibt.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtDibt.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtDibt.LineThickness = 5;
            this.txtDibt.Location = new System.Drawing.Point(225, 351);
            this.txtDibt.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtDibt.Name = "txtDibt";
            this.txtDibt.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtDibt.Size = new System.Drawing.Size(292, 39);
            this.txtDibt.TabIndex = 11;
            this.txtDibt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMotherPhone
            // 
            this.txtMotherPhone.BackColor = System.Drawing.Color.LightGray;
            this.txtMotherPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotherPhone.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtMotherPhone.ForeColor = System.Drawing.Color.Navy;
            this.txtMotherPhone.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMotherPhone.HintText = "";
            this.txtMotherPhone.isPassword = false;
            this.txtMotherPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMotherPhone.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtMotherPhone.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtMotherPhone.LineThickness = 5;
            this.txtMotherPhone.Location = new System.Drawing.Point(225, 293);
            this.txtMotherPhone.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtMotherPhone.Name = "txtMotherPhone";
            this.txtMotherPhone.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtMotherPhone.Size = new System.Drawing.Size(292, 39);
            this.txtMotherPhone.TabIndex = 9;
            this.txtMotherPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFatherPhone
            // 
            this.txtFatherPhone.BackColor = System.Drawing.Color.LightGray;
            this.txtFatherPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFatherPhone.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtFatherPhone.ForeColor = System.Drawing.Color.Navy;
            this.txtFatherPhone.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtFatherPhone.HintText = "";
            this.txtFatherPhone.isPassword = false;
            this.txtFatherPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtFatherPhone.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtFatherPhone.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtFatherPhone.LineThickness = 5;
            this.txtFatherPhone.Location = new System.Drawing.Point(225, 241);
            this.txtFatherPhone.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtFatherPhone.Name = "txtFatherPhone";
            this.txtFatherPhone.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtFatherPhone.Size = new System.Drawing.Size(292, 39);
            this.txtFatherPhone.TabIndex = 7;
            this.txtFatherPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClassroom
            // 
            this.txtClassroom.BackColor = System.Drawing.Color.LightGray;
            this.txtClassroom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassroom.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtClassroom.ForeColor = System.Drawing.Color.Navy;
            this.txtClassroom.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtClassroom.HintText = "";
            this.txtClassroom.isPassword = false;
            this.txtClassroom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtClassroom.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtClassroom.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtClassroom.LineThickness = 5;
            this.txtClassroom.Location = new System.Drawing.Point(225, 131);
            this.txtClassroom.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtClassroom.Name = "txtClassroom";
            this.txtClassroom.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtClassroom.Size = new System.Drawing.Size(292, 39);
            this.txtClassroom.TabIndex = 89;
            this.txtClassroom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(1000, 190);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(69, 25);
            this.bunifuCustomLabel7.TabIndex = 78;
            this.bunifuCustomLabel7.Text = " القســــــــــم :";
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel17.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(546, 355);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(78, 25);
            this.bunifuCustomLabel17.TabIndex = 76;
            this.bunifuCustomLabel17.Text = "مستحقات :";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(1000, 355);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(75, 25);
            this.bunifuCustomLabel16.TabIndex = 74;
            this.bunifuCustomLabel16.Text = "مدفوعات :";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(95, 295);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(62, 25);
            this.bunifuCustomLabel14.TabIndex = 73;
            this.bunifuCustomLabel14.Text = "للتواصل";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(95, 248);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(62, 25);
            this.bunifuCustomLabel13.TabIndex = 73;
            this.bunifuCustomLabel13.Text = "للتواصل";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(546, 80);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(61, 25);
            this.bunifuCustomLabel6.TabIndex = 73;
            this.bunifuCustomLabel6.Text = "النـــــــــــــوع :";
            // 
            // radFemail
            // 
            this.radFemail.AutoSize = true;
            this.radFemail.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemail.Location = new System.Drawing.Point(345, 74);
            this.radFemail.Name = "radFemail";
            this.radFemail.Size = new System.Drawing.Size(65, 36);
            this.radFemail.TabIndex = 5;
            this.radFemail.TabStop = true;
            this.radFemail.Text = "انثــــى";
            this.radFemail.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(451, 74);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(66, 36);
            this.radMale.TabIndex = 4;
            this.radMale.TabStop = true;
            this.radMale.Text = "ذكـــــر";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(1000, 248);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(77, 25);
            this.bunifuCustomLabel15.TabIndex = 68;
            this.bunifuCustomLabel15.Text = " (QR) كود :";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(54, 35);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(99, 25);
            this.bunifuCustomLabel12.TabIndex = 67;
            this.bunifuCustomLabel12.Text = "صوره شخصية ";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(546, 135);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(57, 25);
            this.bunifuCustomLabel10.TabIndex = 65;
            this.bunifuCustomLabel10.Text = "الصف :";
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.ActiveBorderThickness = 1;
            this.btnAddPicture.ActiveCornerRadius = 20;
            this.btnAddPicture.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddPicture.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddPicture.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddPicture.BackColor = System.Drawing.Color.White;
            this.btnAddPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPicture.BackgroundImage")));
            this.btnAddPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddPicture.ButtonText = "إضافة صورة";
            this.btnAddPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPicture.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddPicture.IdleBorderThickness = 1;
            this.btnAddPicture.IdleCornerRadius = 20;
            this.btnAddPicture.IdleFillColor = System.Drawing.Color.White;
            this.btnAddPicture.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddPicture.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddPicture.Location = new System.Drawing.Point(54, 120);
            this.btnAddPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(98, 43);
            this.btnAddPicture.TabIndex = 59;
            this.btnAddPicture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPicture.Visible = false;
            // 
            // pctureImage
            // 
            this.pctureImage.BackColor = System.Drawing.Color.White;
            this.pctureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctureImage.Location = new System.Drawing.Point(30, 79);
            this.pctureImage.Name = "pctureImage";
            this.pctureImage.Size = new System.Drawing.Size(143, 125);
            this.pctureImage.TabIndex = 54;
            this.pctureImage.TabStop = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(546, 25);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(81, 25);
            this.bunifuCustomLabel4.TabIndex = 51;
            this.bunifuCustomLabel4.Text = "رقم الهاتف :";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(206, 570);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(112, 34);
            this.bunifuCustomLabel11.TabIndex = 37;
            this.bunifuCustomLabel11.Text = " صورة شخصية";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(1000, 80);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(63, 25);
            this.bunifuCustomLabel9.TabIndex = 35;
            this.bunifuCustomLabel9.Text = "العنوان :";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(546, 190);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(72, 25);
            this.bunifuCustomLabel8.TabIndex = 34;
            this.bunifuCustomLabel8.Text = "المجموعة :";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(1000, 300);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(83, 25);
            this.bunifuCustomLabel5.TabIndex = 31;
            this.bunifuCustomLabel5.Text = "وظيفة الأب :";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(546, 241);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(78, 25);
            this.bunifuCustomLabel3.TabIndex = 29;
            this.bunifuCustomLabel3.Text = "هاتف الأب :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(546, 300);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(74, 25);
            this.bunifuCustomLabel2.TabIndex = 28;
            this.bunifuCustomLabel2.Text = "هاتف الام :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1000, 135);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(67, 25);
            this.bunifuCustomLabel1.TabIndex = 27;
            this.bunifuCustomLabel1.Text = " المدرســـة :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(1000, 25);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblID.Size = new System.Drawing.Size(58, 25);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "الاســــــــم :";
            // 
            // lblGridHeader
            // 
            this.lblGridHeader.AutoSize = true;
            this.lblGridHeader.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGridHeader.Location = new System.Drawing.Point(966, 22);
            this.lblGridHeader.Name = "lblGridHeader";
            this.lblGridHeader.Size = new System.Drawing.Size(143, 35);
            this.lblGridHeader.TabIndex = 18;
            this.lblGridHeader.Text = "بيــــــــانات الطالــــــــب";
            // 
            // frmShowStudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 749);
            this.Controls.Add(this.pnlStudentData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmShowStudentData";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmShowStudentData";
            this.pnlStudentData.ResumeLayout(false);
            this.pnlStudentData.PerformLayout();
            this.crdSearchResult.ResumeLayout(false);
            this.crdSearchResult.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            this.pnlGridContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctureImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlStudentData;
        public Bunifu.Framework.UI.BunifuCards crdSearchResult;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel pnlGridContainer;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGridHeader;
        public Bunifu.Framework.UI.BunifuCheckbox radCallMother;
        public Bunifu.Framework.UI.BunifuCheckbox radCallFather;
        public System.Windows.Forms.Button btnSaveAndContainue;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        public Bunifu.Framework.UI.BunifuDropdown cmboDepartment;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtCredits;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtFatherJob;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtQR;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSchool;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtAddress;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        public Bunifu.Framework.UI.BunifuDropdown cmboGroup;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDibt;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtMotherPhone;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtFatherPhone;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtClassroom;
        public System.Windows.Forms.RadioButton radFemail;
        public System.Windows.Forms.RadioButton radMale;
        public Bunifu.Framework.UI.BunifuThinButton2 btnAddPicture;
        public System.Windows.Forms.PictureBox pctureImage;
        public Bunifu.Framework.UI.BunifuCustomLabel lblStdID;
    }
}