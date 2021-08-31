
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTodayStudentAttendance = new System.Windows.Forms.Panel();
            this.crdSearchResult = new Bunifu.Framework.UI.BunifuCards();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.grdTodayStudentsAttendance = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblGridHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.crdSearch = new Bunifu.Framework.UI.BunifuCards();
            this.txtClassDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClassName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGroupName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AttendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Homework = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sheet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblGroupID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlTodayStudentAttendance.SuspendLayout();
            this.crdSearchResult.SuspendLayout();
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
            this.crdSearchResult.Controls.Add(this.bunifuSeparator2);
            this.crdSearchResult.Controls.Add(this.btnSave);
            this.crdSearchResult.Controls.Add(this.txtSearch);
            this.crdSearchResult.Controls.Add(this.pnlGridContainer);
            this.crdSearchResult.Controls.Add(this.lblGroupID);
            this.crdSearchResult.Controls.Add(this.lblGroupName);
            this.crdSearchResult.Controls.Add(this.lblGridHeader);
            this.crdSearchResult.Controls.Add(this.btnSearch);
            this.crdSearchResult.LeftSahddow = false;
            this.crdSearchResult.Location = new System.Drawing.Point(23, 123);
            this.crdSearchResult.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.crdSearchResult.Name = "crdSearchResult";
            this.crdSearchResult.RightSahddow = true;
            this.crdSearchResult.ShadowDepth = 20;
            this.crdSearchResult.Size = new System.Drawing.Size(1117, 609);
            this.crdSearchResult.TabIndex = 1;
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
            this.txtSearch.Location = new System.Drawing.Point(90, 24);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.grdTodayStudentsAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTodayStudentsAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTodayStudentsAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTodayStudentsAttendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdTodayStudentsAttendance.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdTodayStudentsAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTodayStudentsAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTodayStudentsAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdTodayStudentsAttendance.ColumnHeadersHeight = 25;
            this.grdTodayStudentsAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdTodayStudentsAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.Attendance,
            this.AttendTime,
            this.Homework,
            this.sheet,
            this.ID,
            this.Details});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTodayStudentsAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdTodayStudentsAttendance.DoubleBuffered = false;
            this.grdTodayStudentsAttendance.EnableHeadersVisualStyles = false;
            this.grdTodayStudentsAttendance.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grdTodayStudentsAttendance.HeaderBgColor = System.Drawing.Color.LightBlue;
            this.grdTodayStudentsAttendance.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grdTodayStudentsAttendance.Location = new System.Drawing.Point(30, 3);
            this.grdTodayStudentsAttendance.Name = "grdTodayStudentsAttendance";
            this.grdTodayStudentsAttendance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdTodayStudentsAttendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sakkal Majalla", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTodayStudentsAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdTodayStudentsAttendance.RowHeadersWidth = 50;
            this.grdTodayStudentsAttendance.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdTodayStudentsAttendance.Size = new System.Drawing.Size(1056, 428);
            this.grdTodayStudentsAttendance.TabIndex = 21;
            this.grdTodayStudentsAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTodayStudentsAttendance_CellClick);
            this.grdTodayStudentsAttendance.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdTodayStudentsAttendance_CellMouseClick);
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
            // crdSearch
            // 
            this.crdSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.crdSearch.BackColor = System.Drawing.Color.White;
            this.crdSearch.BorderRadius = 5;
            this.crdSearch.BottomSahddow = true;
            this.crdSearch.color = System.Drawing.Color.Green;
            this.crdSearch.Controls.Add(this.txtClassDate);
            this.crdSearch.Controls.Add(this.bunifuCustomLabel1);
            this.crdSearch.Controls.Add(this.txtClassName);
            this.crdSearch.Controls.Add(this.bunifuCustomLabel7);
            this.crdSearch.LeftSahddow = false;
            this.crdSearch.Location = new System.Drawing.Point(23, 33);
            this.crdSearch.Name = "crdSearch";
            this.crdSearch.RightSahddow = true;
            this.crdSearch.ShadowDepth = 20;
            this.crdSearch.Size = new System.Drawing.Size(1117, 70);
            this.crdSearch.TabIndex = 0;
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
            this.txtClassDate.Location = new System.Drawing.Point(104, 19);
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
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(396, 22);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(91, 27);
            this.bunifuCustomLabel1.TabIndex = 179;
            this.bunifuCustomLabel1.Text = "تاريخ الحصة :";
            // 
            // txtClassName
            // 
            this.txtClassName.BackColor = System.Drawing.Color.LightGray;
            this.txtClassName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassName.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtClassName.ForeColor = System.Drawing.Color.Navy;
            this.txtClassName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtClassName.HintText = "";
            this.txtClassName.isPassword = false;
            this.txtClassName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtClassName.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtClassName.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtClassName.LineThickness = 5;
            this.txtClassName.Location = new System.Drawing.Point(616, 19);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtClassName.Size = new System.Drawing.Size(279, 32);
            this.txtClassName.TabIndex = 180;
            this.txtClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(908, 22);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(100, 27);
            this.bunifuCustomLabel7.TabIndex = 179;
            this.bunifuCustomLabel7.Text = "عنوان الحصة :";
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
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(4, 526);
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
            this.btnSave.Location = new System.Drawing.Point(994, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 36);
            this.btnSave.TabIndex = 181;
            this.btnSave.Text = "حفـــــظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(36, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 32);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.FillWeight = 116.4129F;
            this.StudentName.Frozen = true;
            this.StudentName.HeaderText = "اسم الطالب";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentName.Width = 251;
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
            // Details
            // 
            this.Details.HeaderText = "تفاصيل";
            this.Details.Name = "Details";
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Details.Text = "التفاصيل";
            this.Details.UseColumnTextForLinkValue = true;
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
            this.lblGroupID.Visible = false;
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
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtClassDate;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtClassName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GroupTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupEndTime;
        public Bunifu.Framework.UI.BunifuCustomLabel lblGroupName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attend;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceTime;
        private System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atten;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StudentsNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewLinkColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Homework;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sheet;
        public Bunifu.Framework.UI.BunifuCustomLabel lblGroupID;
    }
}