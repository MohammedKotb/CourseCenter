
namespace CourseCenterMS
{
    partial class frmNewGroup
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
            this.pnlNewGroup = new System.Windows.Forms.Panel();
            this.crdSearchResult = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlGridContainer = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkIsActive = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtClassroom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGroupName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RadPmFrom = new System.Windows.Forms.RadioButton();
            this.RadAmFrom = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadPmTo = new System.Windows.Forms.RadioButton();
            this.RadAmTo = new System.Windows.Forms.RadioButton();
            this.cmboTimeFrom = new System.Windows.Forms.ComboBox();
            this.cmboTimeTo = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkWednesday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkThursday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkSunday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkTuesday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox5 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkSaturay = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkMonday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtPkrEndDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpkrStartYear = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkFriday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnSave = new System.Windows.Forms.Button();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGridHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlNewGroup.SuspendLayout();
            this.crdSearchResult.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewGroup
            // 
            this.pnlNewGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNewGroup.AutoScroll = true;
            this.pnlNewGroup.AutoSize = true;
            this.pnlNewGroup.Controls.Add(this.crdSearchResult);
            this.pnlNewGroup.Location = new System.Drawing.Point(0, 0);
            this.pnlNewGroup.Name = "pnlNewGroup";
            this.pnlNewGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlNewGroup.Size = new System.Drawing.Size(1174, 800);
            this.pnlNewGroup.TabIndex = 0;
            // 
            // crdSearchResult
            // 
            this.crdSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crdSearchResult.AutoScroll = true;
            this.crdSearchResult.AutoScrollMinSize = new System.Drawing.Size(0, 500);
            this.crdSearchResult.AutoSize = true;
            this.crdSearchResult.BackColor = System.Drawing.Color.White;
            this.crdSearchResult.BorderRadius = 5;
            this.crdSearchResult.BottomSahddow = true;
            this.crdSearchResult.color = System.Drawing.Color.Green;
            this.crdSearchResult.Controls.Add(this.bunifuSeparator1);
            this.crdSearchResult.Controls.Add(this.pnlGridContainer);
            this.crdSearchResult.Controls.Add(this.lblGridHeader);
            this.crdSearchResult.LeftSahddow = false;
            this.crdSearchResult.Location = new System.Drawing.Point(24, 34);
            this.crdSearchResult.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.crdSearchResult.Name = "crdSearchResult";
            this.crdSearchResult.RightSahddow = true;
            this.crdSearchResult.ShadowDepth = 20;
            this.crdSearchResult.Size = new System.Drawing.Size(1118, 548);
            this.crdSearchResult.TabIndex = 1;
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
            this.pnlGridContainer.Controls.Add(this.btnRemove);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel12);
            this.pnlGridContainer.Controls.Add(this.chkIsActive);
            this.pnlGridContainer.Controls.Add(this.txtClassroom);
            this.pnlGridContainer.Controls.Add(this.txtGroupName);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel7);
            this.pnlGridContainer.Controls.Add(this.groupBox2);
            this.pnlGridContainer.Controls.Add(this.groupBox1);
            this.pnlGridContainer.Controls.Add(this.cmboTimeFrom);
            this.pnlGridContainer.Controls.Add(this.cmboTimeTo);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel10);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel8);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel9);
            this.pnlGridContainer.Controls.Add(this.chkWednesday);
            this.pnlGridContainer.Controls.Add(this.chkThursday);
            this.pnlGridContainer.Controls.Add(this.chkSunday);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel16);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel17);
            this.pnlGridContainer.Controls.Add(this.chkTuesday);
            this.pnlGridContainer.Controls.Add(this.bunifuCheckbox5);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel3);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel6);
            this.pnlGridContainer.Controls.Add(this.chkSaturay);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel13);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel1);
            this.pnlGridContainer.Controls.Add(this.chkMonday);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel2);
            this.pnlGridContainer.Controls.Add(this.dtPkrEndDate);
            this.pnlGridContainer.Controls.Add(this.dtpkrStartYear);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel4);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel5);
            this.pnlGridContainer.Controls.Add(this.chkFriday);
            this.pnlGridContainer.Controls.Add(this.lblID);
            this.pnlGridContainer.Controls.Add(this.btnCancel);
            this.pnlGridContainer.Controls.Add(this.bunifuSeparator2);
            this.pnlGridContainer.Controls.Add(this.btnSave);
            this.pnlGridContainer.Controls.Add(this.bunifuCustomLabel11);
            this.pnlGridContainer.Location = new System.Drawing.Point(29, 84);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.Size = new System.Drawing.Size(1074, 448);
            this.pnlGridContainer.TabIndex = 20;
            this.pnlGridContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGridContainer_Paint);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Sakkal Majalla", 16F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.Yellow;
            this.btnRemove.Image = global::CourseCenterMS.Properties.Resources.icons8_remove_32;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.Location = new System.Drawing.Point(825, 399);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 36);
            this.btnRemove.TabIndex = 181;
            this.btnRemove.Text = "حـــــــــذف";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(62, 303);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(106, 25);
            this.bunifuCustomLabel12.TabIndex = 179;
            this.bunifuCustomLabel12.Text = "مجموعـــه نشطــــه";
            // 
            // chkIsActive
            // 
            this.chkIsActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkIsActive.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkIsActive.ForeColor = System.Drawing.Color.White;
            this.chkIsActive.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.chkIsActive.Location = new System.Drawing.Point(187, 308);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(20, 20);
            this.chkIsActive.TabIndex = 180;
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
            this.txtClassroom.Location = new System.Drawing.Point(39, 42);
            this.txtClassroom.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtClassroom.Name = "txtClassroom";
            this.txtClassroom.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtClassroom.Size = new System.Drawing.Size(341, 32);
            this.txtClassroom.TabIndex = 178;
            this.txtClassroom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.Color.LightGray;
            this.txtGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupName.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtGroupName.ForeColor = System.Drawing.Color.Navy;
            this.txtGroupName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtGroupName.HintText = "";
            this.txtGroupName.isPassword = false;
            this.txtGroupName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtGroupName.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtGroupName.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txtGroupName.LineThickness = 5;
            this.txtGroupName.Location = new System.Drawing.Point(558, 42);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.txtGroupName.Size = new System.Drawing.Size(341, 32);
            this.txtGroupName.TabIndex = 177;
            this.txtGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(402, 49);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(57, 25);
            this.bunifuCustomLabel7.TabIndex = 175;
            this.bunifuCustomLabel7.Text = "الصف :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RadPmFrom);
            this.groupBox2.Controls.Add(this.RadAmFrom);
            this.groupBox2.Location = new System.Drawing.Point(62, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(145, 43);
            this.groupBox2.TabIndex = 174;
            this.groupBox2.TabStop = false;
            // 
            // RadPmFrom
            // 
            this.RadPmFrom.AutoSize = true;
            this.RadPmFrom.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.RadPmFrom.Location = new System.Drawing.Point(8, 9);
            this.RadPmFrom.Margin = new System.Windows.Forms.Padding(2);
            this.RadPmFrom.Name = "RadPmFrom";
            this.RadPmFrom.Size = new System.Drawing.Size(64, 29);
            this.RadPmFrom.TabIndex = 0;
            this.RadPmFrom.Text = "مساءا";
            this.RadPmFrom.UseVisualStyleBackColor = true;
            // 
            // RadAmFrom
            // 
            this.RadAmFrom.AutoSize = true;
            this.RadAmFrom.Checked = true;
            this.RadAmFrom.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.RadAmFrom.ForeColor = System.Drawing.Color.Black;
            this.RadAmFrom.Location = new System.Drawing.Point(76, 9);
            this.RadAmFrom.Margin = new System.Windows.Forms.Padding(2);
            this.RadAmFrom.Name = "RadAmFrom";
            this.RadAmFrom.Size = new System.Drawing.Size(69, 29);
            this.RadAmFrom.TabIndex = 0;
            this.RadAmFrom.TabStop = true;
            this.RadAmFrom.Text = "صباحا";
            this.RadAmFrom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadPmTo);
            this.groupBox1.Controls.Add(this.RadAmTo);
            this.groupBox1.Location = new System.Drawing.Point(62, 238);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(145, 43);
            this.groupBox1.TabIndex = 174;
            this.groupBox1.TabStop = false;
            // 
            // RadPmTo
            // 
            this.RadPmTo.AutoSize = true;
            this.RadPmTo.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.RadPmTo.Location = new System.Drawing.Point(8, 9);
            this.RadPmTo.Margin = new System.Windows.Forms.Padding(2);
            this.RadPmTo.Name = "RadPmTo";
            this.RadPmTo.Size = new System.Drawing.Size(64, 29);
            this.RadPmTo.TabIndex = 0;
            this.RadPmTo.Text = "مساءا";
            this.RadPmTo.UseVisualStyleBackColor = true;
            // 
            // RadAmTo
            // 
            this.RadAmTo.AutoSize = true;
            this.RadAmTo.Checked = true;
            this.RadAmTo.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.RadAmTo.ForeColor = System.Drawing.Color.Black;
            this.RadAmTo.Location = new System.Drawing.Point(76, 9);
            this.RadAmTo.Margin = new System.Windows.Forms.Padding(2);
            this.RadAmTo.Name = "RadAmTo";
            this.RadAmTo.Size = new System.Drawing.Size(69, 29);
            this.RadAmTo.TabIndex = 0;
            this.RadAmTo.TabStop = true;
            this.RadAmTo.Text = "صباحا";
            this.RadAmTo.UseVisualStyleBackColor = true;
            // 
            // cmboTimeFrom
            // 
            this.cmboTimeFrom.BackColor = System.Drawing.Color.LightGray;
            this.cmboTimeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboTimeFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmboTimeFrom.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.cmboTimeFrom.FormattingEnabled = true;
            this.cmboTimeFrom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmboTimeFrom.Location = new System.Drawing.Point(293, 188);
            this.cmboTimeFrom.Margin = new System.Windows.Forms.Padding(2);
            this.cmboTimeFrom.Name = "cmboTimeFrom";
            this.cmboTimeFrom.Size = new System.Drawing.Size(87, 30);
            this.cmboTimeFrom.TabIndex = 173;
            // 
            // cmboTimeTo
            // 
            this.cmboTimeTo.BackColor = System.Drawing.Color.LightGray;
            this.cmboTimeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboTimeTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmboTimeTo.Font = new System.Drawing.Font("Sakkal Majalla", 12F, System.Drawing.FontStyle.Bold);
            this.cmboTimeTo.FormattingEnabled = true;
            this.cmboTimeTo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmboTimeTo.Location = new System.Drawing.Point(293, 247);
            this.cmboTimeTo.Margin = new System.Windows.Forms.Padding(2);
            this.cmboTimeTo.Name = "cmboTimeTo";
            this.cmboTimeTo.Size = new System.Drawing.Size(87, 30);
            this.cmboTimeTo.TabIndex = 173;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(402, 193);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(82, 25);
            this.bunifuCustomLabel10.TabIndex = 150;
            this.bunifuCustomLabel10.Text = "من الساعه :";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(707, 240);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(51, 25);
            this.bunifuCustomLabel8.TabIndex = 148;
            this.bunifuCustomLabel8.Text = "الثلاثاء";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(825, 240);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(48, 25);
            this.bunifuCustomLabel9.TabIndex = 149;
            this.bunifuCustomLabel9.Text = "الاثنين";
            // 
            // chkWednesday
            // 
            this.chkWednesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkWednesday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkWednesday.Checked = false;
            this.chkWednesday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkWednesday.ForeColor = System.Drawing.Color.White;
            this.chkWednesday.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.chkWednesday.Location = new System.Drawing.Point(879, 293);
            this.chkWednesday.Margin = new System.Windows.Forms.Padding(4);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(20, 20);
            this.chkWednesday.TabIndex = 171;
            // 
            // chkThursday
            // 
            this.chkThursday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkThursday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkThursday.Checked = false;
            this.chkThursday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkThursday.ForeColor = System.Drawing.Color.White;
            this.chkThursday.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.chkThursday.Location = new System.Drawing.Point(770, 293);
            this.chkThursday.Margin = new System.Windows.Forms.Padding(4);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(20, 20);
            this.chkThursday.TabIndex = 171;
            // 
            // chkSunday
            // 
            this.chkSunday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkSunday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkSunday.Checked = false;
            this.chkSunday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkSunday.ForeColor = System.Drawing.Color.White;
            this.chkSunday.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.chkSunday.Location = new System.Drawing.Point(770, 191);
            this.chkSunday.Margin = new System.Windows.Forms.Padding(4);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(20, 20);
            this.chkSunday.TabIndex = 169;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(700, 288);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(58, 25);
            this.bunifuCustomLabel16.TabIndex = 159;
            this.bunifuCustomLabel16.Text = "الخميس";
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.AutoSize = true;
            this.bunifuCustomLabel17.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel17.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(825, 340);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(54, 25);
            this.bunifuCustomLabel17.TabIndex = 158;
            this.bunifuCustomLabel17.Text = "الجمعة";
            // 
            // chkTuesday
            // 
            this.chkTuesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkTuesday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkTuesday.Checked = false;
            this.chkTuesday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkTuesday.ForeColor = System.Drawing.Color.White;
            this.chkTuesday.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.chkTuesday.Location = new System.Drawing.Point(770, 242);
            this.chkTuesday.Margin = new System.Windows.Forms.Padding(4);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(20, 20);
            this.chkTuesday.TabIndex = 166;
            // 
            // bunifuCheckbox5
            // 
            this.bunifuCheckbox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox5.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox5.Checked = false;
            this.bunifuCheckbox5.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox5.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox5.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bunifuCheckbox5.Location = new System.Drawing.Point(738, 293);
            this.bunifuCheckbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCheckbox5.Name = "bunifuCheckbox5";
            this.bunifuCheckbox5.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox5.TabIndex = 172;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(825, 189);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(51, 25);
            this.bunifuCustomLabel3.TabIndex = 156;
            this.bunifuCustomLabel3.Text = "السبت";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(718, 189);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(40, 25);
            this.bunifuCustomLabel6.TabIndex = 155;
            this.bunifuCustomLabel6.Text = "الاحد";
            // 
            // chkSaturay
            // 
            this.chkSaturay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkSaturay.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkSaturay.Checked = false;
            this.chkSaturay.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkSaturay.ForeColor = System.Drawing.Color.White;
            this.chkSaturay.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.chkSaturay.Location = new System.Drawing.Point(879, 191);
            this.chkSaturay.Margin = new System.Windows.Forms.Padding(4);
            this.chkSaturay.Name = "chkSaturay";
            this.chkSaturay.Size = new System.Drawing.Size(20, 20);
            this.chkSaturay.TabIndex = 167;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(825, 288);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(51, 25);
            this.bunifuCustomLabel13.TabIndex = 157;
            this.bunifuCustomLabel13.Text = "الاربعاء";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(402, 252);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(79, 25);
            this.bunifuCustomLabel1.TabIndex = 154;
            this.bunifuCustomLabel1.Text = "الى الساعه :";
            // 
            // chkMonday
            // 
            this.chkMonday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkMonday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkMonday.Checked = false;
            this.chkMonday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkMonday.ForeColor = System.Drawing.Color.White;
            this.chkMonday.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.chkMonday.Location = new System.Drawing.Point(879, 242);
            this.chkMonday.Margin = new System.Windows.Forms.Padding(4);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(20, 20);
            this.chkMonday.TabIndex = 170;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(923, 186);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(57, 25);
            this.bunifuCustomLabel2.TabIndex = 153;
            this.bunifuCustomLabel2.Text = "الايـــــــــام :";
            // 
            // dtPkrEndDate
            // 
            this.dtPkrEndDate.BackColor = System.Drawing.Color.LightGray;
            this.dtPkrEndDate.BorderRadius = 0;
            this.dtPkrEndDate.Font = new System.Drawing.Font("Sakkal Majalla", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.World, ((byte)(1)), true);
            this.dtPkrEndDate.ForeColor = System.Drawing.Color.Navy;
            this.dtPkrEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPkrEndDate.FormatCustom = "";
            this.dtPkrEndDate.Location = new System.Drawing.Point(37, 110);
            this.dtPkrEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtPkrEndDate.Name = "dtPkrEndDate";
            this.dtPkrEndDate.Size = new System.Drawing.Size(343, 37);
            this.dtPkrEndDate.TabIndex = 162;
            this.dtPkrEndDate.Value = new System.DateTime(2021, 8, 27, 22, 33, 49, 203);
            // 
            // dtpkrStartYear
            // 
            this.dtpkrStartYear.BackColor = System.Drawing.Color.LightGray;
            this.dtpkrStartYear.BorderRadius = 0;
            this.dtpkrStartYear.Font = new System.Drawing.Font("Sakkal Majalla", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.World, ((byte)(1)), true);
            this.dtpkrStartYear.ForeColor = System.Drawing.Color.Navy;
            this.dtpkrStartYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkrStartYear.FormatCustom = "";
            this.dtpkrStartYear.Location = new System.Drawing.Point(556, 110);
            this.dtpkrStartYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkrStartYear.Name = "dtpkrStartYear";
            this.dtpkrStartYear.Size = new System.Drawing.Size(343, 37);
            this.dtpkrStartYear.TabIndex = 162;
            this.dtpkrStartYear.Value = new System.DateTime(2021, 8, 27, 22, 33, 49, 203);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(923, 116);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(137, 25);
            this.bunifuCustomLabel4.TabIndex = 152;
            this.bunifuCustomLabel4.Text = "بداية السنه الدراسيه :";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(402, 116);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(135, 25);
            this.bunifuCustomLabel5.TabIndex = 151;
            this.bunifuCustomLabel5.Text = "نهايه السنه الدراسيه :";
            // 
            // chkFriday
            // 
            this.chkFriday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkFriday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkFriday.Checked = false;
            this.chkFriday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkFriday.ForeColor = System.Drawing.Color.White;
            this.chkFriday.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.chkFriday.Location = new System.Drawing.Point(879, 343);
            this.chkFriday.Margin = new System.Windows.Forms.Padding(4);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(20, 20);
            this.chkFriday.TabIndex = 168;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(923, 49);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblID.Size = new System.Drawing.Size(96, 25);
            this.lblID.TabIndex = 160;
            this.lblID.Text = "اسم الجموعة :";
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
            this.btnCancel.Location = new System.Drawing.Point(47, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 36);
            this.btnCancel.TabIndex = 91;
            this.btnCancel.Text = "الغــــــاء";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 372);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1074, 20);
            this.bunifuSeparator2.TabIndex = 90;
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
            this.btnSave.Location = new System.Drawing.Point(946, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 36);
            this.btnSave.TabIndex = 91;
            this.btnSave.Text = "حفـــــظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(206, 570);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(165, 31);
            this.bunifuCustomLabel11.TabIndex = 37;
            this.bunifuCustomLabel11.Text = " صورة شخصية";
            // 
            // lblGridHeader
            // 
            this.lblGridHeader.AutoSize = true;
            this.lblGridHeader.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGridHeader.Location = new System.Drawing.Point(898, 22);
            this.lblGridHeader.Name = "lblGridHeader";
            this.lblGridHeader.Size = new System.Drawing.Size(201, 35);
            this.lblGridHeader.TabIndex = 18;
            this.lblGridHeader.Text = "اضافـــة مجموعة جديده";
            // 
            // frmNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 741);
            this.Controls.Add(this.pnlNewGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNewGroup";
            this.Text = "frmNewGroup1";
            this.pnlNewGroup.ResumeLayout(false);
            this.pnlNewGroup.PerformLayout();
            this.crdSearchResult.ResumeLayout(false);
            this.crdSearchResult.PerformLayout();
            this.pnlGridContainer.ResumeLayout(false);
            this.pnlGridContainer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlNewGroup;
        private Bunifu.Framework.UI.BunifuCards crdSearchResult;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel pnlGridContainer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCheckbox chkThursday;
        private Bunifu.Framework.UI.BunifuCheckbox chkSunday;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private Bunifu.Framework.UI.BunifuCheckbox chkTuesday;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCheckbox chkSaturay;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox chkMonday;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker dtpkrStartYear;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCheckbox chkFriday;
        private Bunifu.Framework.UI.BunifuCustomLabel lblID;
        private System.Windows.Forms.Button btnCancel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGridHeader;
        private Bunifu.Framework.UI.BunifuCheckbox chkWednesday;
        private System.Windows.Forms.ComboBox cmboTimeTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RadPmFrom;
        private System.Windows.Forms.RadioButton RadAmFrom;
        private System.Windows.Forms.RadioButton RadPmTo;
        private System.Windows.Forms.RadioButton RadAmTo;
        private System.Windows.Forms.ComboBox cmboTimeFrom;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtClassroom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGroupName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCheckbox chkIsActive;
        private Bunifu.Framework.UI.BunifuDatepicker dtPkrEndDate;
        public System.Windows.Forms.Button btnRemove;
    }
}