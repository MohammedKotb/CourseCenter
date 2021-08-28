
namespace CourseCenterMS
{
    partial class frmAllGroup
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
            this.pnlAllGroups = new System.Windows.Forms.Panel();
            this.crdSearchResult = new Bunifu.Framework.UI.BunifuCards();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.grdAllGroups = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblGridHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.crdSearch = new Bunifu.Framework.UI.BunifuCards();
            this.btnFiter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupDetails = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlAllGroups.SuspendLayout();
            this.crdSearchResult.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllGroups)).BeginInit();
            this.crdSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAllGroups
            // 
            this.pnlAllGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAllGroups.Controls.Add(this.crdSearchResult);
            this.pnlAllGroups.Controls.Add(this.crdSearch);
            this.pnlAllGroups.Location = new System.Drawing.Point(0, 0);
            this.pnlAllGroups.Name = "pnlAllGroups";
            this.pnlAllGroups.Size = new System.Drawing.Size(1165, 808);
            this.pnlAllGroups.TabIndex = 0;
            this.pnlAllGroups.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAllStudents_Paint);
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
            this.pnlGridContainer.Controls.Add(this.grdAllGroups);
            this.pnlGridContainer.Location = new System.Drawing.Point(3, 69);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Size = new System.Drawing.Size(1111, 455);
            this.pnlGridContainer.TabIndex = 20;
            // 
            // grdAllGroups
            // 
            this.grdAllGroups.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.grdAllGroups.AllowUserToAddRows = false;
            this.grdAllGroups.AllowUserToDeleteRows = false;
            this.grdAllGroups.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.grdAllGroups.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAllGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAllGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAllGroups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdAllGroups.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdAllGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAllGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdAllGroups.ColumnHeadersHeight = 25;
            this.grdAllGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdAllGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName,
            this.GroupDays,
            this.GroupTime,
            this.GroupEndTime,
            this.StudentsNumber,
            this.ID,
            this.GroupDetails});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAllGroups.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdAllGroups.DoubleBuffered = true;
            this.grdAllGroups.EnableHeadersVisualStyles = false;
            this.grdAllGroups.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grdAllGroups.HeaderBgColor = System.Drawing.Color.LightBlue;
            this.grdAllGroups.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grdAllGroups.Location = new System.Drawing.Point(30, 3);
            this.grdAllGroups.Name = "grdAllGroups";
            this.grdAllGroups.ReadOnly = true;
            this.grdAllGroups.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdAllGroups.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sakkal Majalla", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAllGroups.RowHeadersWidth = 50;
            this.grdAllGroups.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdAllGroups.Size = new System.Drawing.Size(1056, 428);
            this.grdAllGroups.TabIndex = 21;
            this.grdAllGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllStudents_CellClick);
            // 
            // lblGridHeader
            // 
            this.lblGridHeader.AutoSize = true;
            this.lblGridHeader.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGridHeader.Location = new System.Drawing.Point(956, 24);
            this.lblGridHeader.Name = "lblGridHeader";
            this.lblGridHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGridHeader.Size = new System.Drawing.Size(160, 35);
            this.lblGridHeader.TabIndex = 18;
            this.lblGridHeader.Text = "بيــــانات المجموعات";
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
            this.btnFiter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 32);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(781, 21);
            this.textSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // GroupDays
            // 
            this.GroupDays.DataPropertyName = "GroupDays";
            this.GroupDays.FillWeight = 116.4129F;
            this.GroupDays.HeaderText = "ايـــام الحصص";
            this.GroupDays.MinimumWidth = 6;
            this.GroupDays.Name = "GroupDays";
            this.GroupDays.ReadOnly = true;
            // 
            // GroupTime
            // 
            this.GroupTime.DataPropertyName = "StartTime";
            this.GroupTime.HeaderText = "وقت بدء الحصة";
            this.GroupTime.MinimumWidth = 6;
            this.GroupTime.Name = "GroupTime";
            this.GroupTime.ReadOnly = true;
            // 
            // GroupEndTime
            // 
            this.GroupEndTime.DataPropertyName = "EndTime";
            this.GroupEndTime.HeaderText = "وقت انتهاء الحصه";
            this.GroupEndTime.Name = "GroupEndTime";
            this.GroupEndTime.ReadOnly = true;
            // 
            // StudentsNumber
            // 
            this.StudentsNumber.DataPropertyName = "StudentsCount";
            this.StudentsNumber.HeaderText = "عدد طلاب المجموعة";
            this.StudentsNumber.Name = "StudentsNumber";
            this.StudentsNumber.ReadOnly = true;
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
            // frmAllGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 817);
            this.Controls.Add(this.pnlAllGroups);
            this.Name = "frmAllGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "AllGroups";
            this.Load += new System.EventHandler(this.frmAllStudents_Load);
            this.pnlAllGroups.ResumeLayout(false);
            this.crdSearchResult.ResumeLayout(false);
            this.crdSearchResult.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllGroups)).EndInit();
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
        public System.Windows.Forms.Panel pnlAllGroups;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGridHeader;
        private System.Windows.Forms.Panel pnlGridContainer;
        public Bunifu.Framework.UI.BunifuCustomDataGrid grdAllGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewLinkColumn GroupDetails;
    }
}