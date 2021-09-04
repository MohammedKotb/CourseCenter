
namespace CourseCenterMS
{
    partial class frmLoader
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
            this.piclloader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piclloader)).BeginInit();
            this.SuspendLayout();
            // 
            // piclloader
            // 
            this.piclloader.BackColor = System.Drawing.SystemColors.Control;
            this.piclloader.Image = global::CourseCenterMS.Properties.Resources.Double_Ring_1_4s_118px;
            this.piclloader.Location = new System.Drawing.Point(21, 7);
            this.piclloader.Name = "piclloader";
            this.piclloader.Size = new System.Drawing.Size(93, 90);
            this.piclloader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.piclloader.TabIndex = 0;
            this.piclloader.TabStop = false;
            // 
            // frmLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(135, 107);
            this.Controls.Add(this.piclloader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoader";
            ((System.ComponentModel.ISupportInitialize)(this.piclloader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox piclloader;
    }
}