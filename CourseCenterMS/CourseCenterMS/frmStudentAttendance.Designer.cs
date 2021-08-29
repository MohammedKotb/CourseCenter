
namespace CourseCenterMS
{
    partial class frmStudentAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlStudentAttendance = new System.Windows.Forms.Panel();
            this.crdSearchResult = new Bunifu.Framework.UI.BunifuCards();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.grdStudentsAttendance = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblGridHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.crdSearch = new Bunifu.Framework.UI.BunifuCards();
            this.txtClassName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClassDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupTime = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsNumber = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlStudentAttendance.SuspendLayout();
            this.crdSearchResult.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentsAttendance)).BeginInit();
            this.crdSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStudentAttendance
            // 
            this.pnlStudentAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStudentAttendance.Controls.Add(this.crdSearchResult);
            this.pnlStudentAttendance.Controls.Add(this.crdSearch);
            this.pnlStudentAttendance.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentAttendance.Name = "pnlStudentAttendance";
            this.pnlStudentAttendance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlStudentAttendance.Size = new System.Drawing.Size(1165, 808);
            this.pnlStudentAttendance.TabIndex = 0;
            this.pnlStudentAttendance.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAllStudents_Paint);
            // 
            // crdSearchResult
            // 
            this.crdSearchResult.AutoScroll = true;
            this.crdSearchResult.BackColor = System.Drawing.Color.White;
            this.crdSearchResult.BorderRadius = 5;
            this.crdSearchResult.BottomSahddow = true;
            this.crdSearchResult.color = System.Drawing.Color.RoyalBlue;
            this.crdSearchResult.Controls.Add(this.txtSearch);
            this.crdSearchResult.Controls.Add(this.pnlGridContainer);
            this.crdSearchResult.Controls.Add(this.lblGridHeader);
            this.crdSearchResult.Controls.Add(this.btnSearch);
            this.crdSearchResult.LeftSahddow = false;
            this.crdSearchResult.Location = new System.Drawing.Point(23, 123);
            this.crdSearchResult.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.crdSearchResult.Name = "crdSearchResult";
            this.crdSearchResult.RightSahddow = true;
            this.crdSearchResult.ShadowDepth = 20;
            this.crdSearchResult.Size = new System.Drawing.Size(1117, 547);
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
            this.pnlGridContainer.Controls.Add(this.grdStudentsAttendance);
            this.pnlGridContainer.Location = new System.Drawing.Point(3, 69);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Size = new System.Drawing.Size(1111, 455);
            this.pnlGridContainer.TabIndex = 20;
            // 
            // grdStudentsAttendance
            // 
            this.grdStudentsAttendance.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.grdStudentsAttendance.AllowUserToAddRows = false;
            this.grdStudentsAttendance.AllowUserToDeleteRows = false;
            this.grdStudentsAttendance.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.grdStudentsAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdStudentsAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdStudentsAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStudentsAttendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdStudentsAttendance.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdStudentsAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdStudentsAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStudentsAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdStudentsAttendance.ColumnHeadersHeight = 25;
            this.grdStudentsAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdStudentsAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName,
            this.GroupTime,
            this.GroupEndTime,
            this.StudentsNumber,
            this.Column1,
            this.ID,
            this.Details});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStudentsAttendance.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdStudentsAttendance.DoubleBuffered = true;
            this.grdStudentsAttendance.EnableHeadersVisualStyles = false;
            this.grdStudentsAttendance.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grdStudentsAttendance.HeaderBgColor = System.Drawing.Color.LightBlue;
            this.grdStudentsAttendance.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grdStudentsAttendance.Location = new System.Drawing.Point(30, 3);
            this.grdStudentsAttendance.Name = "grdStudentsAttendance";
            this.grdStudentsAttendance.ReadOnly = true;
            this.grdStudentsAttendance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdStudentsAttendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sakkal Majalla", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStudentsAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdStudentsAttendance.RowHeadersWidth = 50;
            this.grdStudentsAttendance.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdStudentsAttendance.Size = new System.Drawing.Size(1056, 428);
            this.grdStudentsAttendance.TabIndex = 21;
            this.grdStudentsAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllStudents_CellClick);
            this.grdStudentsAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudentsAttendance_CellContentClick);
            // 
            // lblGridHeader
            // 
            this.lblGridHeader.AutoSize = true;
            this.lblGridHeader.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGridHeader.Location = new System.Drawing.Point(965, 23);
            this.lblGridHeader.Name = "lblGridHeader";
            this.lblGridHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGridHeader.Size = new System.Drawing.Size(130, 35);
            this.lblGridHeader.TabIndex = 18;
            this.lblGridHeader.Text = "حضور الطلاب ";
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
            // txtClassName
            // 
            this.txtClassName.BackColor = System.Drawing.Color.LightGray;
            this.txtClassName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassName.Enabled = false;
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
            // txtClassDate
            // 
            this.txtClassDate.BackColor = System.Drawing.Color.LightGray;
            this.txtClassDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassDate.Enabled = false;
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
            // GroupName
            // 
            this.GroupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GroupName.DataPropertyName = "StudentName";
            this.GroupName.FillWeight = 116.4129F;
            this.GroupName.Frozen = true;
            this.GroupName.HeaderText = "اسم الطالب";
            this.GroupName.MinimumWidth = 6;
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupName.Width = 251;
            // 
            // GroupTime
            // 
            this.GroupTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GroupTime.DataPropertyName = "Attend";
            this.GroupTime.HeaderText = "الحضور";
            this.GroupTime.MinimumWidth = 6;
            this.GroupTime.Name = "GroupTime";
            this.GroupTime.ReadOnly = true;
            this.GroupTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GroupTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GroupTime.Width = 216;
            // 
            // GroupEndTime
            // 
            this.GroupEndTime.DataPropertyName = "AttendanceTime";
            this.GroupEndTime.HeaderText = "وقت الحضور";
            this.GroupEndTime.Name = "GroupEndTime";
            this.GroupEndTime.ReadOnly = true;
            // 
            // StudentsNumber
            // 
            this.StudentsNumber.DataPropertyName = "HomeWork";
            this.StudentsNumber.HeaderText = "الواجب";
            this.StudentsNumber.Name = "StudentsNumber";
            this.StudentsNumber.ReadOnly = true;
            this.StudentsNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Sheet";
            this.Column1.HeaderText = "الشيت";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "AttendanceID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Details
            // 
            this.Details.HeaderText = "تفاصيل";
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Details.Text = "التفاصيل";
            this.Details.UseColumnTextForLinkValue = true;
            // 
            // frmStudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 817);
            this.Controls.Add(this.pnlStudentAttendance);
            this.Name = "frmStudentAttendance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "AllStudentAttendance";
            this.Load += new System.EventHandler(this.frmAllStudents_Load);
            this.pnlStudentAttendance.ResumeLayout(false);
            this.crdSearchResult.ResumeLayout(false);
            this.crdSearchResult.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudentsAttendance)).EndInit();
            this.crdSearch.ResumeLayout(false);
            this.crdSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards crdSearch;
        private Bunifu.Framework.UI.BunifuCards crdSearchResult;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.Panel pnlStudentAttendance;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGridHeader;
        private System.Windows.Forms.Panel pnlGridContainer;
        public Bunifu.Framework.UI.BunifuCustomDataGrid grdStudentsAttendance;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtClassDate;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GroupTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupEndTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StudentsNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewLinkColumn Details;
    }
}