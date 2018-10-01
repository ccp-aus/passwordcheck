namespace PasswordCheck
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.CheckPassword = new System.Windows.Forms.Button();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.CheckEmail = new System.Windows.Forms.Button();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioShowPassword = new System.Windows.Forms.RadioButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckPassword
            // 
            this.CheckPassword.Location = new System.Drawing.Point(14, 140);
            this.CheckPassword.Name = "CheckPassword";
            this.CheckPassword.Size = new System.Drawing.Size(370, 43);
            this.CheckPassword.TabIndex = 6;
            this.CheckPassword.Text = "Check Password";
            this.CheckPassword.UseVisualStyleBackColor = true;
            this.CheckPassword.Click += new System.EventHandler(this.CheckPassword_click);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DescriptionBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionBox.Location = new System.Drawing.Point(14, 19);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.Size = new System.Drawing.Size(370, 89);
            this.DescriptionBox.TabIndex = 4;
            this.DescriptionBox.TabStop = false;
            this.DescriptionBox.Text = resources.GetString("DescriptionBox.Text");
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(14, 114);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '●';
            this.PasswordBox.Size = new System.Drawing.Size(344, 20);
            this.PasswordBox.TabIndex = 5;
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyDown);
            // 
            // CheckEmail
            // 
            this.CheckEmail.Location = new System.Drawing.Point(12, 140);
            this.CheckEmail.Name = "CheckEmail";
            this.CheckEmail.Size = new System.Drawing.Size(370, 43);
            this.CheckEmail.TabIndex = 9;
            this.CheckEmail.Text = "Check Email";
            this.CheckEmail.UseVisualStyleBackColor = true;
            this.CheckEmail.Click += new System.EventHandler(this.CheckEmail_Click);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(12, 114);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(370, 20);
            this.EmailBox.TabIndex = 8;
            this.EmailBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailBox_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(370, 89);
            this.textBox1.TabIndex = 7;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioShowPassword);
            this.groupBox1.Controls.Add(this.DescriptionBox);
            this.groupBox1.Controls.Add(this.PasswordBox);
            this.groupBox1.Controls.Add(this.CheckPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 189);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password Check";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.EmailBox);
            this.groupBox2.Controls.Add(this.CheckEmail);
            this.groupBox2.Location = new System.Drawing.Point(414, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 189);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email Check";
            // 
            // radioShowPassword
            // 
            this.radioShowPassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioShowPassword.AutoCheck = false;
            this.radioShowPassword.BackgroundImage = global::CCP.PasswordCheck.Properties.Resources.icons8_show_password_50;
            this.radioShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioShowPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioShowPassword.FlatAppearance.BorderSize = 0;
            this.radioShowPassword.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioShowPassword.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioShowPassword.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioShowPassword.Location = new System.Drawing.Point(364, 114);
            this.radioShowPassword.Name = "radioShowPassword";
            this.radioShowPassword.Size = new System.Drawing.Size(20, 20);
            this.radioShowPassword.TabIndex = 7;
            this.radioShowPassword.UseVisualStyleBackColor = false;
            this.radioShowPassword.CheckedChanged += new System.EventHandler(this.radioShowPassword_CheckedChanged);
            this.radioShowPassword.Click += new System.EventHandler(this.radioShowPassword_Click);
            this.radioShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioShowPassword_MouseDown);
            this.radioShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radioShowPassword_MouseUp);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Right;
            this.Logo.Image = global::CCP.PasswordCheck.Properties.Resources.ccplogo;
            this.Logo.Location = new System.Drawing.Point(815, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(140, 208);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(955, 208);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCP Password Checker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button CheckPassword;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button CheckEmail;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioShowPassword;
    }
}

