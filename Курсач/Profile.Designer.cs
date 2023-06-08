namespace Курсач
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.gradientPanel1 = new HTML5.GradientPanel();
            this.pictureBoxAccount = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogaout = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderRadius = 30;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.ForeColor = System.Drawing.Color.Black;
            this.gradientPanel1.GradientAngle = 90F;
            this.gradientPanel1.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.gradientPanel1.GradientTopColor = System.Drawing.Color.DarkBlue;
            this.gradientPanel1.Location = new System.Drawing.Point(12, 96);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(790, 302);
            this.gradientPanel1.TabIndex = 1;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // pictureBoxAccount
            // 
            this.pictureBoxAccount.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccount.Image")));
            this.pictureBoxAccount.Location = new System.Drawing.Point(345, 59);
            this.pictureBoxAccount.Name = "pictureBoxAccount";
            this.pictureBoxAccount.Size = new System.Drawing.Size(100, 80);
            this.pictureBoxAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAccount.TabIndex = 2;
            this.pictureBoxAccount.TabStop = false;
            this.pictureBoxAccount.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLogaout
            // 
            this.buttonLogaout.Location = new System.Drawing.Point(685, 1);
            this.buttonLogaout.Name = "buttonLogaout";
            this.buttonLogaout.Size = new System.Drawing.Size(117, 40);
            this.buttonLogaout.TabIndex = 3;
            this.buttonLogaout.Text = "Logaout";
            this.buttonLogaout.UseVisualStyleBackColor = true;
            this.buttonLogaout.Click += new System.EventHandler(this.buttonLogaout_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogaout);
            this.Controls.Add(this.pictureBoxAccount);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HTML5.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.PictureBox pictureBoxAccount;
        private System.Windows.Forms.Button buttonLogaout;
    }
}