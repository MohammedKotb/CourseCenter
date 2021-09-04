
namespace CourseCenterMS
{
    partial class frmTodayStudentAttendance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTodayStudentAttendance = new System.Windows.Forms.Panel();
            this.crdSearchResult = new Bunifu.Framework.UI.BunifuCards();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.grdTodayStudentsAttendance = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblGroupID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGroupName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGridHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.crdSearch = new Bunifu.Framework.UI.BunifuCards();
            this.btnUsingQR = new System.Windows.Forms.Button();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClassDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AttendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Homework = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sheet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlTodayStudentAttendance.SuspendLayout();
            this.crdSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTodayStudentsAttendance)).BeginInit();
            this.crdSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTodayStudentAttendance
            // 
            this.pnlTodayStudentAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTodayStudentAttendance.Controls.Add(this.crdSearchResult);
            this.pnlTodayStudentAttendance.Controls.Add(this.crdSearch);
            this.pnlTodayStudentAttendance.Location = new System.Drawing.Point(0, 0);
            this.pnlTodayStudentAttendance.Name = "pnlTodayStudentAttendance";
            this.pnlTodayStudentAttendance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlTodayStudentAttendance.Size = new System.Drawing.Size(1165, 808);
            this.pnlTodayStudentAttendance.TabIndex = 0;
            this.pnlTodayStudentAttendance.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAllStudents_Paint);
            // 
            // crdSearchResult
            // 
            this.crdSearchResult.AutoScroll = true;
            this.crdSearchResult.BackColor = System.Drawing.Color.White;
            this.crdSearchResult.BorderRadius = 5;
            this.crdSearchResult.BottomSahddow = true;
            this.crdSearchResult.color = System.Drawing.Color.RoyalBlue;
            this.crdSearchResult.Controls.Add(this.pictureBox1);
            this.crdSearchResult.Controls.Add(this.cmbDevice);
            this.crdSearchResult.Controls.Add(this.bunifuSeparator2);
            this.crdSearchResult.Controls.Add(this.btnSave);
            this.crdSearchResult.Controls.Add(this.pnlGridContainer);
            this.crdSearchResult.Controls.Add(this.lblGroupID);
            this.crdSearchResult.Controls.Add(this.lblGroupName);
            this.crdSearchResult.Controls.Add(this.lblGridHeader);
            this.crdSearchResult.LeftSahddow = false;
            this.crdSearchResult.Location = new System.Drawing.Point(23, 123);
            this.crdSearchResult.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.crdSearchResult.Name = "crdSearchResult";
            this.crdSearchResult.RightSahddow = true;
            this.crdSearchResult.ShadowDepth = 20;
            this.crdSearchResult.Size = new System.Drawing.Size(1117, 609);
            this.crdSearchResult.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(943, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 93);
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // cmbDevice
            // 
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(369, 21);
            this.cmbDevice.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(189, 21);
            this.cmbDevice.TabIndex = 5;
            this.cmbDevice.Visible = false;
            this.cmbDevice.SelectedIndexChanged += new System.EventHandler(this.cmbDevice_SelectedIndexChanged);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(4, 504);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1109, 20);
            this.bunifuSeparator2.TabIndex = 182;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
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
            this.btnSave.Location = new System.Drawing.Point(994, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 36);
            this.btnSave.TabIndex = 181;
            this.btnSave.Text = "حفـــــظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.Navy;
            this.txtSearch.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSearch.HintText = "";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSearch.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtSearch.LineThickness = 5;
            this.txtSearch.Location = new System.Drawing.Point(100, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtSearch.Size = new System.Drawing.Size(241, 32);
            this.txtSearch.TabIndex = 180;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.Controls.Add(this.grdTodayStudentsAttendance);
            this.pnlGridContainer.Location = new System.Drawing.Point(3, 69);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Size = new System.Drawing.Size(1111, 455);
            this.pnlGridContainer.TabIndex = 20;
            // 
            // grdTodayStudentsAttendance
            // 
            this.grdTodayStudentsAttendance.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.grdTodayStudentsAttendance.AllowUserToAddRows = false;
            this.grdTodayStudentsAttendance.AllowUserToDeleteRows = false;
            this.grdTodayStudentsAttendance.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.grdTodayStudentsAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdTodayStudentsAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTodayStudentsAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTodayStudentsAttendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdTodayStudentsAttendance.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdTodayStudentsAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTodayStudentsAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTodayStudentsAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdTodayStudentsAttendance.ColumnHeadersHeight = 25;
            this.grdTodayStudentsAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdTodayStudentsAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.Attendance,
            this.AttendTime,
            this.Homework,
            this.sheet,
            this.ID,
            this.QR,
            this.Details});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTodayStudentsAttendance.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdTodayStudentsAttendance.DoubleBuffered = false;
            this.grdTodayStudentsAttendance.EnableHeadersVisualStyles = false;
            this.grdTodayStudentsAttendance.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grdTodayStudentsAttendance.HeaderBgColor = System.Drawing.Color.LightBlue;
            this.grdTodayStudentsAttendance.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grdTodayStudentsAttendance.Location = new System.Drawing.Point(30, 3);
            this.grdTodayStudentsAttendance.Name = "grdTodayStudentsAttendance";
            this.grdTodayStudentsAttendance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdTodayStudentsAttendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sakkal Majalla", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTodayStudentsAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdTodayStudentsAttendance.RowHeadersWidth = 50;
            this.grdTodayStudentsAttendance.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdTodayStudentsAttendance.Size = new System.Drawing.Size(1056, 428);
            this.grdTodayStudentsAttendance.TabIndex = 21;
            this.grdTodayStudentsAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTodayStudentsAttendance_CellClick);
            this.grdTodayStudentsAttendance.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdTodayStudentsAttendance_CellMouseClick);
            // 
            // lblGroupID
            // 
            this.lblGroupID.AutoSize = true;
            this.lblGroupID.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGroupID.Location = new System.Drawing.Point(707, 21);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGroupID.Size = new System.Drawing.Size(30, 35);
            this.lblGroupID.TabIndex = 18;
            this.lblGroupID.Text = "...";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGroupName.Location = new System.Drawing.Point(802, 21);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGroupName.Size = new System.Drawing.Size(89, 35);
            this.lblGroupName.TabIndex = 18;
            this.lblGroupName.Text = "المجموعه";
            // 
            // lblGridHeader
            // 
            this.lblGridHeader.AutoSize = true;
            this.lblGridHeader.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGridHeader.Location = new System.Drawing.Point(887, 21);
            this.lblGridHeader.Name = "lblGridHeader";
            this.lblGridHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGridHeader.Size = new System.Drawing.Size(208, 35);
            this.lblGridHeader.TabIndex = 18;
            this.lblGridHeader.Text = "حضور طلاب المجموعه :  ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(176)))), ((int)(((byte)(190)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(230)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::CourseCenterMS.Properties.Resources.icons8_search32_32;
            this.btnSearch.Location = new System.Drawing.Point(46, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 32);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // crdSearch
            // 
            this.crdSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.crdSearch.BackColor = System.Drawing.Color.White;
            this.crdSearch.BorderRadius = 5;
            this.crdSearch.BottomSahddow = true;
            this.crdSearch.color = System.Drawing.Color.Green;
            this.crdSearch.Controls.Add(this.btnUsingQR);
            this.crdSearch.Controls.Add(this.bunifuMaterialTextbox1);
            this.crdSearch.Controls.Add(this.bunifuCustomLabel2);
            this.crdSearch.Controls.Add(this.bunifuMaterialTextbox2);
            this.crdSearch.Controls.Add(this.txtSearch);
            this.crdSearch.Controls.Add(this.bunifuCustomLabel3);
            this.crdSearch.Controls.Add(this.txtClassDate);
            this.crdSearch.Controls.Add(this.bunifuCustomLabel1);
            this.crdSearch.Controls.Add(this.btnSearch);
            this.crdSearch.LeftSahddow = false;
            this.crdSearch.Location = new System.Drawing.Point(23, 33);
            this.crdSearch.Name = "crdSearch";
            this.crdSearch.RightSahddow = true;
            this.crdSearch.ShadowDepth = 20;
            this.crdSearch.Size = new System.Drawing.Size(1117, 70);
            this.crdSearch.TabIndex = 0;
            // 
            // btnUsingQR
            // 
            this.btnUsingQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUsingQR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsingQR.FlatAppearance.BorderSize = 0;
            this.btnUsingQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsingQR.Font = new System.Drawing.Font("Sakkal Majalla", 16F, System.Drawing.FontStyle.Bold);
            this.btnUsingQR.ForeColor = System.Drawing.Color.Navy;
            this.btnUsingQR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsingQR.Location = new System.Drawing.Point(412, 19);
            this.btnUsingQR.Name = "btnUsingQR";
            this.btnUsingQR.Size = new System.Drawing.Size(109, 36);
            this.btnUsingQR.TabIndex = 187;
            this.btnUsingQR.Text = "استخدام QR";
            this.btnUsingQR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsingQR.UseVisualStyleBackColor = false;
            this.btnUsingQR.Click += new System.EventHandler(this.btnUsingQR_Click);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.LightGray;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.LightGray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.bunifuMaterialTextbox1.LineThickness = 5;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(-786, -488);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(279, 32);
            this.bunifuMaterialTextbox1.TabIndex = 185;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(-494, -485);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(91, 27);
            this.bunifuCustomLabel2.TabIndex = 183;
            this.bunifuCustomLabel2.Text = "تاريخ الحصة :";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.BackColor = System.Drawing.Color.LightGray;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.Navy;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.LightGray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.bunifuMaterialTextbox2.LineThickness = 5;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(-274, -488);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(279, 32);
            this.bunifuMaterialTextbox2.TabIndex = 186;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(18, -485);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(100, 27);
            this.bunifuCustomLabel3.TabIndex = 184;
            this.bunifuCustomLabel3.Text = "عنوان الحصة :";
            // 
            // txtClassDate
            // 
            this.txtClassDate.BackColor = System.Drawing.Color.LightGray;
            this.txtClassDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassDate.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtClassDate.ForeColor = System.Drawing.Color.Navy;
            this.txtClassDate.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtClassDate.HintText = "";
            this.txtClassDate.isPassword = false;
            this.txtClassDate.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtClassDate.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtClassDate.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtClassDate.LineThickness = 5;
            this.txtClassDate.Location = new System.Drawing.Point(679, 21);
            this.txtClassDate.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtClassDate.Name = "txtClassDate";
            this.txtClassDate.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtClassDate.Size = new System.Drawing.Size(279, 32);
            this.txtClassDate.TabIndex = 180;
            this.txtClassDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(971, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(91, 27);
            this.bunifuCustomLabel1.TabIndex = 179;
            this.bunifuCustomLabel1.Text = "تاريخ الحصة :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "إسم الطالب";
            this.StudentName.Name = "StudentName";
            // 
            // Attendance
            // 
            this.Attendance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Attendance.DataPropertyName = "Attend";
            this.Attendance.HeaderText = "الحضور";
            this.Attendance.MinimumWidth = 6;
            this.Attendance.Name = "Attendance";
            this.Attendance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Attendance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Attendance.Width = 216;
            // 
            // AttendTime
            // 
            this.AttendTime.DataPropertyName = "AttendanceTime";
            this.AttendTime.HeaderText = "وقت الحضور";
            this.AttendTime.Name = "AttendTime";
            // 
            // Homework
            // 
            this.Homework.DataPropertyName = "HomeWork";
            this.Homework.HeaderText = "الواجب";
            this.Homework.Name = "Homework";
            this.Homework.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Homework.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // sheet
            // 
            this.sheet.DataPropertyName = "Sheet";
            this.sheet.HeaderText = "الشيت";
            this.sheet.Name = "sheet";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "StudentID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // QR
            // 
            this.QR.DataPropertyName = "QR";
            this.QR.HeaderText = "QR";
            this.QR.Name = "QR";
            this.QR.Visible = false;
            // 
            // Details
            // 
            this.Details.HeaderText = "تفاصيل";
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Details.Text = "التفاصيل";
            this.Details.UseColumnTextForLinkValue = true;
            // 
            // frmTodayStudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 817);
            this.Controls.Add(this.pnlTodayStudentAttendance);
            this.Name = "frmTodayStudentAttendance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "TodayStudentAttendance";
            this.Load += new System.EventHandler(this.frmAllStudents_Load);
            this.pnlTodayStudentAttendance.ResumeLayout(false);
            this.crdSearchResult.ResumeLayout(false);
            this.crdSearchResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTodayStudentsAttendance)).EndInit();
            this.crdSearch.ResumeLayout(false);
            this.crdSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards crdSearch;
        private Bunifu.Framework.UI.BunifuCards crdSearchResult;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Panel pnlTodayStudentAttendance;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGridHeader;
        private System.Windows.Forms.Panel pnlGridContainer;
        public Bunifu.Framework.UI.BunifuCustomDataGrid grdTodayStudentsAttendance;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtClassDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GroupTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupEndTime;
        public Bunifu.Framework.UI.BunifuCustomLabel lblGroupName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attend;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceTime;
        private System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atten;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StudentsNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        public Bunifu.Framework.UI.BunifuCustomLabel lblGroupID;
        private System.Windows.Forms.Button btnUsingQR;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox cmbDevice;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Homework;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QR;
        private System.Windows.Forms.DataGridViewLinkColumn Details;
    }
}