
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
            this.pnlAllStudents = new System.Windows.Forms.Panel();
            this.crdSearchResult = new Bunifu.Framework.UI.BunifuCards();
            this.crdSearch = new Bunifu.Framework.UI.BunifuCards();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.lblGridHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.btnFiter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.GridData = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.stdudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGrad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetails = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlAllStudents.SuspendLayout();
            this.crdSearchResult.SuspendLayout();
            this.crdSearch.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).BeginInit();
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
            this.crdSearch.Location = new System.Drawing.Point(23, 26);
            this.crdSearch.Name = "crdSearch";
            this.crdSearch.RightSahddow = true;
            this.crdSearch.ShadowDepth = 20;
            this.crdSearch.Size = new System.Drawing.Size(1117, 70);
            this.crdSearch.TabIndex = 0;
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
            // pnlGridContainer
            // 
            this.pnlGridContainer.Controls.Add(this.GridData);
            this.pnlGridContainer.Location = new System.Drawing.Point(3, 69);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Size = new System.Drawing.Size(1111, 455);
            this.pnlGridContainer.TabIndex = 20;
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
            // GridData
            // 
            this.GridData.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sakkal Majalla", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridData.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridData.ColumnHeadersHeight = 25;
            this.GridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdudentName,
            this.studentGroup,
            this.studentGrad,
            this.studentPhone,
            this.studentDetails});
            this.GridData.DoubleBuffered = true;
            this.GridData.EnableHeadersVisualStyles = false;
            this.GridData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.GridData.HeaderBgColor = System.Drawing.Color.LightBlue;
            this.GridData.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GridData.Location = new System.Drawing.Point(24, 3);
            this.GridData.Name = "GridData";
            this.GridData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridData.RowHeadersWidth = 50;
            this.GridData.Size = new System.Drawing.Size(1056, 428);
            this.GridData.TabIndex = 21;
            // 
            // stdudentName
            // 
            this.stdudentName.FillWeight = 116.4129F;
            this.stdudentName.HeaderText = "اسم الطالب";
            this.stdudentName.Name = "stdudentName";
            // 
            // studentGroup
            // 
            this.studentGroup.FillWeight = 116.4129F;
            this.studentGroup.HeaderText = "المجموعه";
            this.studentGroup.Name = "studentGroup";
            // 
            // studentGrad
            // 
            this.studentGrad.FillWeight = 116.4129F;
            this.studentGrad.HeaderText = "الصــــف ";
            this.studentGrad.Name = "studentGrad";
            // 
            // studentPhone
            // 
            this.studentPhone.HeaderText = "رقم التليفون";
            this.studentPhone.Name = "studentPhone";
            // 
            // studentDetails
            // 
            this.studentDetails.FillWeight = 50.76142F;
            this.studentDetails.HeaderText = "تفاصيل";
            this.studentDetails.Name = "studentDetails";
            this.studentDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.studentDetails.Text = "";
            this.studentDetails.ToolTipText = "اضغط لمزيد من المعلومات";
            // 
            // frmAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 961);
            this.Controls.Add(this.pnlAllStudents);
            this.Name = "frmAllStudents";
            this.Text = "AllStudents";
            this.pnlAllStudents.ResumeLayout(false);
            this.crdSearchResult.ResumeLayout(false);
            this.crdSearchResult.PerformLayout();
            this.crdSearch.ResumeLayout(false);
            this.crdSearch.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards crdSearch;
        private Bunifu.Framework.UI.BunifuCards crdSearchResult;
        private System.Windows.Forms.Button btnFiter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearch;
        public System.Windows.Forms.Panel pnlAllStudents;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGridHeader;
        private System.Windows.Forms.Panel pnlGridContainer;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGrad;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPhone;
        private System.Windows.Forms.DataGridViewLinkColumn studentDetails;
    }
}