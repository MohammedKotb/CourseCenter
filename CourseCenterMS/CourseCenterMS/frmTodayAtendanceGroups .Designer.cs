
namespace CourseCenterMS
{
    partial class frmTodayAtendanceGroups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTodayAttendance = new System.Windows.Forms.Panel();
            this.crdSearchResult = new Bunifu.Framework.UI.BunifuCards();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.grdTodayAttendanceGroup = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblGridHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.crdSearch = new Bunifu.Framework.UI.BunifuCards();
            this.btnFiter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsNumber = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupDetails = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlTodayAttendance.SuspendLayout();
            this.crdSearchResult.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTodayAttendanceGroup)).BeginInit();
            this.crdSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTodayAttendance
            // 
            this.pnlTodayAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTodayAttendance.Controls.Add(this.crdSearchResult);
            this.pnlTodayAttendance.Controls.Add(this.crdSearch);
            this.pnlTodayAttendance.Location = new System.Drawing.Point(0, 0);
            this.pnlTodayAttendance.Name = "pnlTodayAttendance";
            this.pnlTodayAttendance.Size = new System.Drawing.Size(1165, 808);
            this.pnlTodayAttendance.TabIndex = 0;
            // 
            // crdSearchResult
            // 
            this.crdSearchResult.AutoScroll = true;
            this.crdSearchResult.BackColor = System.Drawing.Color.White;
            this.crdSearchResult.BorderRadius = 5;
            this.crdSearchResult.BottomSahddow = true;
            this.crdSearchResult.color = System.Drawing.Color.RoyalBlue;
            this.crdSearchResult.Controls.Add(this.pnlGridContainer);
            this.crdSearchResult.Controls.Add(this.lblGridHeader);
            this.crdSearchResult.LeftSahddow = false;
            this.crdSearchResult.Location = new System.Drawing.Point(23, 123);
            this.crdSearchResult.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.crdSearchResult.Name = "crdSearchResult";
            this.crdSearchResult.RightSahddow = true;
            this.crdSearchResult.ShadowDepth = 20;
            this.crdSearchResult.Size = new System.Drawing.Size(1117, 547);
            this.crdSearchResult.TabIndex = 1;
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.Controls.Add(this.grdTodayAttendanceGroup);
            this.pnlGridContainer.Location = new System.Drawing.Point(3, 69);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Size = new System.Drawing.Size(1111, 455);
            this.pnlGridContainer.TabIndex = 20;
            // 
            // grdTodayAttendanceGroup
            // 
            this.grdTodayAttendanceGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.grdTodayAttendanceGroup.AllowUserToAddRows = false;
            this.grdTodayAttendanceGroup.AllowUserToDeleteRows = false;
            this.grdTodayAttendanceGroup.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.grdTodayAttendanceGroup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTodayAttendanceGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTodayAttendanceGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTodayAttendanceGroup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdTodayAttendanceGroup.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdTodayAttendanceGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTodayAttendanceGroup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTodayAttendanceGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdTodayAttendanceGroup.ColumnHeadersHeight = 25;
            this.grdTodayAttendanceGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdTodayAttendanceGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName,
            this.Classroom,
            this.GroupTime,
            this.GroupEndTime,
            this.StudentsNumber,
            this.ID,
            this.GroupDetails});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTodayAttendanceGroup.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdTodayAttendanceGroup.DoubleBuffered = true;
            this.grdTodayAttendanceGroup.EnableHeadersVisualStyles = false;
            this.grdTodayAttendanceGroup.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grdTodayAttendanceGroup.HeaderBgColor = System.Drawing.Color.LightBlue;
            this.grdTodayAttendanceGroup.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grdTodayAttendanceGroup.Location = new System.Drawing.Point(30, 3);
            this.grdTodayAttendanceGroup.Name = "grdTodayAttendanceGroup";
            this.grdTodayAttendanceGroup.ReadOnly = true;
            this.grdTodayAttendanceGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdTodayAttendanceGroup.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sakkal Majalla", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTodayAttendanceGroup.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdTodayAttendanceGroup.RowHeadersWidth = 50;
            this.grdTodayAttendanceGroup.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdTodayAttendanceGroup.Size = new System.Drawing.Size(1056, 428);
            this.grdTodayAttendanceGroup.TabIndex = 21;
            this.grdTodayAttendanceGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllAttendanceGroup_CellClick);
            // 
            // lblGridHeader
            // 
            this.lblGridHeader.AutoSize = true;
            this.lblGridHeader.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGridHeader.Location = new System.Drawing.Point(935, 21);
            this.lblGridHeader.Name = "lblGridHeader";
            this.lblGridHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGridHeader.Size = new System.Drawing.Size(146, 35);
            this.lblGridHeader.TabIndex = 18;
            this.lblGridHeader.Text = "مجموعات اليـــــوم";
            // 
            // crdSearch
            // 
            this.crdSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.crdSearch.BackColor = System.Drawing.Color.White;
            this.crdSearch.BorderRadius = 5;
            this.crdSearch.BottomSahddow = true;
            this.crdSearch.color = System.Drawing.Color.Green;
            this.crdSearch.Controls.Add(this.btnFiter);
            this.crdSearch.Controls.Add(this.btnSearch);
            this.crdSearch.Controls.Add(this.textSearch);
            this.crdSearch.LeftSahddow = false;
            this.crdSearch.Location = new System.Drawing.Point(23, 33);
            this.crdSearch.Name = "crdSearch";
            this.crdSearch.RightSahddow = true;
            this.crdSearch.ShadowDepth = 20;
            this.crdSearch.Size = new System.Drawing.Size(1117, 70);
            this.crdSearch.TabIndex = 0;
            // 
            // btnFiter
            // 
            this.btnFiter.BackColor = System.Drawing.Color.Transparent;
            this.btnFiter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(176)))), ((int)(((byte)(190)))));
            this.btnFiter.FlatAppearance.BorderSize = 0;
            this.btnFiter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFiter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(230)))));
            this.btnFiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiter.Image = global::CourseCenterMS.Properties.Resources.icons8_slider_321;
            this.btnFiter.Location = new System.Drawing.Point(672, 21);
            this.btnFiter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiter.Name = "btnFiter";
            this.btnFiter.Size = new System.Drawing.Size(30, 32);
            this.btnFiter.TabIndex = 26;
            this.btnFiter.UseVisualStyleBackColor = false;
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
            this.btnSearch.Location = new System.Drawing.Point(730, 21);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 32);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(781, 21);
            this.textSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textSearch.MinimumSize = new System.Drawing.Size(290, 33);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(324, 33);
            this.textSearch.TabIndex = 24;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "Name";
            this.GroupName.FillWeight = 116.4129F;
            this.GroupName.HeaderText = "اسم المجموعة";
            this.GroupName.MinimumWidth = 6;
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Classroom
            // 
            this.Classroom.DataPropertyName = "Classroom";
            this.Classroom.HeaderText = "الصف";
            this.Classroom.Name = "Classroom";
            this.Classroom.ReadOnly = true;
            // 
            // GroupTime
            // 
            this.GroupTime.DataPropertyName = "TimeFrom";
            dataGridViewCellStyle3.Format = "hh:mm tt";
            dataGridViewCellStyle3.NullValue = null;
            this.GroupTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.GroupTime.HeaderText = "وقت بدء المجموعة";
            this.GroupTime.MinimumWidth = 6;
            this.GroupTime.Name = "GroupTime";
            this.GroupTime.ReadOnly = true;
            // 
            // GroupEndTime
            // 
            this.GroupEndTime.DataPropertyName = "TimeTo";
            dataGridViewCellStyle4.Format = "hh:mm tt";
            dataGridViewCellStyle4.NullValue = null;
            this.GroupEndTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.GroupEndTime.HeaderText = "وقت انتهاء المجموعة";
            this.GroupEndTime.Name = "GroupEndTime";
            this.GroupEndTime.ReadOnly = true;
            // 
            // StudentsNumber
            // 
            this.StudentsNumber.DataPropertyName = "IsActive";
            this.StudentsNumber.HeaderText = "نشط";
            this.StudentsNumber.Name = "StudentsNumber";
            this.StudentsNumber.ReadOnly = true;
            this.StudentsNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "GroupID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // GroupDetails
            // 
            this.GroupDetails.DataPropertyName = "Details";
            this.GroupDetails.FillWeight = 50.76142F;
            this.GroupDetails.HeaderText = "تفاصيل";
            this.GroupDetails.MinimumWidth = 6;
            this.GroupDetails.Name = "GroupDetails";
            this.GroupDetails.ReadOnly = true;
            this.GroupDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GroupDetails.Text = "التفاصيل";
            this.GroupDetails.ToolTipText = "اضغط لمزيد من المعلومات";
            this.GroupDetails.UseColumnTextForLinkValue = true;
            // 
            // frmTodayAtendanceGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 817);
            this.Controls.Add(this.pnlTodayAttendance);
            this.Name = "frmTodayAtendanceGroups";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "AllAttendance";
            this.Load += new System.EventHandler(this.frmAllStudents_Load);
            this.pnlTodayAttendance.ResumeLayout(false);
            this.crdSearchResult.ResumeLayout(false);
            this.crdSearchResult.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTodayAttendanceGroup)).EndInit();
            this.crdSearch.ResumeLayout(false);
            this.crdSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards crdSearch;
        private Bunifu.Framework.UI.BunifuCards crdSearchResult;
        private System.Windows.Forms.Button btnFiter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearch;
        public System.Windows.Forms.Panel pnlTodayAttendance;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGridHeader;
        private System.Windows.Forms.Panel pnlGridContainer;
        public Bunifu.Framework.UI.BunifuCustomDataGrid grdTodayAttendanceGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupEndTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StudentsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewLinkColumn GroupDetails;
    }
}