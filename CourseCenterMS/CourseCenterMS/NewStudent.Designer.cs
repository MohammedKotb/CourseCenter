
namespace CourseCenterMS
{
    partial class frmNewStudent
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
            this.pnlNewStudent = new System.Windows.Forms.Panel();
            this.crdSearchResult = new Bunifu.Framework.UI.BunifuCards();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.lblGridHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.crdSearch = new Bunifu.Framework.UI.BunifuCards();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlNewStudent.SuspendLayout();
            this.crdSearchResult.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewStudent
            // 
            this.pnlNewStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewStudent.Controls.Add(this.crdSearchResult);
            this.pnlNewStudent.Controls.Add(this.crdSearch);
            this.pnlNewStudent.Location = new System.Drawing.Point(0, 0);
            this.pnlNewStudent.Name = "pnlNewStudent";
            this.pnlNewStudent.Size = new System.Drawing.Size(1165, 808);
            this.pnlNewStudent.TabIndex = 0;
            // 
            // crdSearchResult
            // 
            this.crdSearchResult.AutoScroll = true;
            this.crdSearchResult.BackColor = System.Drawing.Color.White;
            this.crdSearchResult.BorderRadius = 5;
            this.crdSearchResult.BottomSahddow = true;
            this.crdSearchResult.color = System.Drawing.Color.Green;
            this.crdSearchResult.Controls.Add(this.bunifuSeparator1);
            this.crdSearchResult.Controls.Add(this.pnlGridContainer);
            this.crdSearchResult.Controls.Add(this.lblGridHeader);
            this.crdSearchResult.LeftSahddow = false;
            this.crdSearchResult.Location = new System.Drawing.Point(20, 25);
            this.crdSearchResult.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.crdSearchResult.Name = "crdSearchResult";
            this.crdSearchResult.RightSahddow = true;
            this.crdSearchResult.ShadowDepth = 20;
            this.crdSearchResult.Size = new System.Drawing.Size(1117, 527);
            this.crdSearchResult.TabIndex = 1;
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.Controls.Add(this.txtName);
            this.pnlGridContainer.Controls.Add(this.lblID);
            this.pnlGridContainer.Location = new System.Drawing.Point(3, 69);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Size = new System.Drawing.Size(1111, 455);
            this.pnlGridContainer.TabIndex = 20;
            // 
            // lblGridHeader
            // 
            this.lblGridHeader.AutoSize = true;
            this.lblGridHeader.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGridHeader.Location = new System.Drawing.Point(930, 23);
            this.lblGridHeader.Name = "lblGridHeader";
            this.lblGridHeader.Size = new System.Drawing.Size(168, 35);
            this.lblGridHeader.TabIndex = 18;
            this.lblGridHeader.Text = "اضافـــة طالب جديد";
            // 
            // crdSearch
            // 
            this.crdSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.crdSearch.BackColor = System.Drawing.Color.White;
            this.crdSearch.BorderRadius = 5;
            this.crdSearch.BottomSahddow = true;
            this.crdSearch.color = System.Drawing.Color.RoyalBlue;
            this.crdSearch.LeftSahddow = false;
            this.crdSearch.Location = new System.Drawing.Point(20, 581);
            this.crdSearch.Name = "crdSearch";
            this.crdSearch.RightSahddow = true;
            this.crdSearch.ShadowDepth = 20;
            this.crdSearch.Size = new System.Drawing.Size(1117, 70);
            this.crdSearch.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Black;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtName.LineIdleColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtName.LineThickness = 4;
            this.txtName.Location = new System.Drawing.Point(614, 20);
            this.txtName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 37);
            this.txtName.TabIndex = 26;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(997, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 34);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "الكود";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 53);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1114, 10);
            this.bunifuSeparator1.TabIndex = 21;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // frmNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 961);
            this.Controls.Add(this.pnlNewStudent);
            this.Name = "frmNewStudent";
            this.Text = "AllStudents";
            this.pnlNewStudent.ResumeLayout(false);
            this.crdSearchResult.ResumeLayout(false);
            this.crdSearchResult.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            this.pnlGridContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards crdSearch;
        private Bunifu.Framework.UI.BunifuCards crdSearchResult;
        public System.Windows.Forms.Panel pnlNewStudent;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGridHeader;
        private System.Windows.Forms.Panel pnlGridContainer;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}