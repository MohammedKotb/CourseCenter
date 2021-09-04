
namespace CourseCenterMS
{
    partial class frmAllStudents
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
            this.pnlAllStudents = new System.Windows.Forms.Panel();
            this.crdSearchResult = new Bunifu.Framework.UI.BunifuCards();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.grdAllStudents = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.lblGridHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.crdSearch = new Bunifu.Framework.UI.BunifuCards();
            this.btnFiter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGrad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetails = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlAllStudents.SuspendLayout();
            this.crdSearchResult.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAllStudents)).BeginInit();
            this.crdSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAllStudents
            // 
            this.pnlAllStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAllStudents.Controls.Add(this.crdSearchResult);
            this.pnlAllStudents.Controls.Add(this.crdSearch);
            this.pnlAllStudents.Location = new System.Drawing.Point(0, 0);
            this.pnlAllStudents.Name = "pnlAllStudents";
            this.pnlAllStudents.Size = new System.Drawing.Size(1165, 808);
            this.pnlAllStudents.TabIndex = 0;
            this.pnlAllStudents.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAllStudents_Paint);
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
            this.pnlGridContainer.Controls.Add(this.grdAllStudents);
            this.pnlGridContainer.Location = new System.Drawing.Point(3, 69);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Size = new System.Drawing.Size(1111, 455);
            this.pnlGridContainer.TabIndex = 20;
            // 
            // grdAllStudents
            // 
            this.grdAllStudents.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.grdAllStudents.AllowUserToAddRows = false;
            this.grdAllStudents.AllowUserToDeleteRows = false;
            this.grdAllStudents.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.grdAllStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdAllStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAllStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAllStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdAllStudents.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdAllStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAllStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdAllStudents.ColumnHeadersHeight = 25;
            this.grdAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdAllStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.studentGroup,
            this.studentGrad,
            this.studentPhone,
            this.ID,
            this.QR,
            this.studentDetails});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAllStudents.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdAllStudents.DoubleBuffered = true;
            this.grdAllStudents.EnableHeadersVisualStyles = false;
            this.grdAllStudents.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grdAllStudents.HeaderBgColor = System.Drawing.Color.LightBlue;
            this.grdAllStudents.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.grdAllStudents.Location = new System.Drawing.Point(24, 3);
            this.grdAllStudents.MultiSelect = false;
            this.grdAllStudents.Name = "grdAllStudents";
            this.grdAllStudents.ReadOnly = true;
            this.grdAllStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdAllStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sakkal Majalla", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAllStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdAllStudents.RowHeadersWidth = 50;
            this.grdAllStudents.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdAllStudents.Size = new System.Drawing.Size(1056, 428);
            this.grdAllStudents.TabIndex = 21;
            this.grdAllStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAllStudents_CellClick);
            // 
            // lblGridHeader
            // 
            this.lblGridHeader.AutoSize = true;
            this.lblGridHeader.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGridHeader.Location = new System.Drawing.Point(956, 24);
            this.lblGridHeader.Name = "lblGridHeader";
            this.lblGridHeader.Size = new System.Drawing.Size(136, 35);
            this.lblGridHeader.TabIndex = 18;
            this.lblGridHeader.Text = "بيــــانات الطــــــلاب";
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
            this.crdSearch.Controls.Add(this.txtSearch);
            this.crdSearch.LeftSahddow = false;
            this.crdSearch.Location = new System.Drawing.Point(23, 26);
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(781, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MinimumSize = new System.Drawing.Size(290, 33);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 33);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Name";
            this.StudentName.FillWeight = 116.4129F;
            this.StudentName.HeaderText = "اسم الطالب";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // studentGroup
            // 
            this.studentGroup.DataPropertyName = "GroupName";
            this.studentGroup.FillWeight = 116.4129F;
            this.studentGroup.HeaderText = "المجموعه";
            this.studentGroup.Name = "studentGroup";
            this.studentGroup.ReadOnly = true;
            // 
            // studentGrad
            // 
            this.studentGrad.DataPropertyName = "Classroom";
            this.studentGrad.FillWeight = 116.4129F;
            this.studentGrad.HeaderText = "الصــــف ";
            this.studentGrad.Name = "studentGrad";
            this.studentGrad.ReadOnly = true;
            // 
            // studentPhone
            // 
            this.studentPhone.DataPropertyName = "Phone";
            this.studentPhone.HeaderText = "رقم التليفون";
            this.studentPhone.Name = "studentPhone";
            this.studentPhone.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // QR
            // 
            this.QR.DataPropertyName = "QR";
            this.QR.HeaderText = "QR";
            this.QR.Name = "QR";
            this.QR.ReadOnly = true;
            this.QR.Visible = false;
            // 
            // studentDetails
            // 
            this.studentDetails.DataPropertyName = "Details";
            this.studentDetails.FillWeight = 50.76142F;
            this.studentDetails.HeaderText = "تفاصيل";
            this.studentDetails.Name = "studentDetails";
            this.studentDetails.ReadOnly = true;
            this.studentDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.studentDetails.Text = "التفاصيل";
            this.studentDetails.ToolTipText = "اضغط لمزيد من المعلومات";
            this.studentDetails.UseColumnTextForLinkValue = true;
            // 
            // frmAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 961);
            this.Controls.Add(this.pnlAllStudents);
            this.Name = "frmAllStudents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "AllStudents";
            this.Load += new System.EventHandler(this.frmAllStudents_Load);
            this.pnlAllStudents.ResumeLayout(false);
            this.crdSearchResult.ResumeLayout(false);
            this.crdSearchResult.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAllStudents)).EndInit();
            this.crdSearch.ResumeLayout(false);
            this.crdSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards crdSearch;
        private Bunifu.Framework.UI.BunifuCards crdSearchResult;
        private System.Windows.Forms.Button btnFiter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Panel pnlAllStudents;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGridHeader;
        private System.Windows.Forms.Panel pnlGridContainer;
        public Bunifu.Framework.UI.BunifuCustomDataGrid grdAllStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGrad;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QR;
        private System.Windows.Forms.DataGridViewLinkColumn studentDetails;
    }
}