namespace Edu_Portal
{
    partial class Teacher_Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Registration = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.set_icon = new System.Windows.Forms.PictureBox();
            this.result_icon = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.mat = new System.Windows.Forms.PictureBox();
            this.setting = new System.Windows.Forms.Button();
            this.material = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.edu_icon = new System.Windows.Forms.PictureBox();
            this.log_icon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.set_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edu_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(528, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Dashboard";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.name.Location = new System.Drawing.Point(672, 120);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 53);
            this.name.TabIndex = 1;
            this.name.Text = "hello";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.password.Location = new System.Drawing.Point(672, 170);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(121, 53);
            this.password.TabIndex = 2;
            this.password.Text = "hello";
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.Registration.Location = new System.Drawing.Point(672, 220);
            this.Registration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(121, 53);
            this.Registration.TabIndex = 3;
            this.Registration.Text = "hello";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.Email.Location = new System.Drawing.Point(672, 280);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(121, 53);
            this.Email.TabIndex = 4;
            this.Email.Text = "hello";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.LightSteelBlue;
            this.result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.result.Cursor = System.Windows.Forms.Cursors.Default;
            this.result.ForeColor = System.Drawing.Color.Navy;
            this.result.Location = new System.Drawing.Point(23, 372);
            this.result.Margin = new System.Windows.Forms.Padding(4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(242, 56);
            this.result.TabIndex = 5;
            this.result.Text = "Results";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.log_icon);
            this.panel1.Controls.Add(this.set_icon);
            this.panel1.Controls.Add(this.result_icon);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.mat);
            this.panel1.Controls.Add(this.setting);
            this.panel1.Controls.Add(this.material);
            this.panel1.Controls.Add(this.result);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.edu_icon);
            this.panel1.Font = new System.Drawing.Font("Elephant", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 960);
            this.panel1.TabIndex = 6;
            // 
            // set_icon
            // 
            this.set_icon.Image = global::Edu_Portal.Properties.Resources.settings;
            this.set_icon.Location = new System.Drawing.Point(23, 455);
            this.set_icon.Name = "set_icon";
            this.set_icon.Size = new System.Drawing.Size(79, 56);
            this.set_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.set_icon.TabIndex = 7;
            this.set_icon.TabStop = false;
            this.set_icon.Click += new System.EventHandler(this.set_icon_Click);
            // 
            // result_icon
            // 
            this.result_icon.Image = global::Edu_Portal.Properties.Resources.results;
            this.result_icon.Location = new System.Drawing.Point(23, 372);
            this.result_icon.Name = "result_icon";
            this.result_icon.Size = new System.Drawing.Size(79, 56);
            this.result_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.result_icon.TabIndex = 7;
            this.result_icon.TabStop = false;
            this.result_icon.Click += new System.EventHandler(this.result_icon_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.logout.ForeColor = System.Drawing.Color.Navy;
            this.logout.Location = new System.Drawing.Point(23, 884);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(242, 56);
            this.logout.TabIndex = 12;
            this.logout.Text = "Log Out";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout.UseVisualStyleBackColor = false;
            // 
            // mat
            // 
            this.mat.Image = global::Edu_Portal.Properties.Resources.material;
            this.mat.Location = new System.Drawing.Point(23, 289);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(79, 56);
            this.mat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mat.TabIndex = 11;
            this.mat.TabStop = false;
            this.mat.Click += new System.EventHandler(this.mat_Click);
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.LightSteelBlue;
            this.setting.ForeColor = System.Drawing.Color.Navy;
            this.setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting.Location = new System.Drawing.Point(23, 455);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(242, 56);
            this.setting.TabIndex = 10;
            this.setting.Text = "Settings";
            this.setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setting.UseVisualStyleBackColor = false;
            // 
            // material
            // 
            this.material.BackColor = System.Drawing.Color.LightSteelBlue;
            this.material.ForeColor = System.Drawing.Color.Navy;
            this.material.Location = new System.Drawing.Point(23, 289);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(242, 56);
            this.material.TabIndex = 9;
            this.material.Text = "Materials";
            this.material.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.material.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.LightSteelBlue;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Elephant", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Navy;
            this.title.Location = new System.Drawing.Point(23, 182);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(242, 48);
            this.title.TabIndex = 8;
            this.title.Text = "Edu Portal";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edu_icon
            // 
            this.edu_icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edu_icon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.edu_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.edu_icon.Image = global::Edu_Portal.Properties.Resources.graduation_cap_3074078;
            this.edu_icon.InitialImage = global::Edu_Portal.Properties.Resources.graduation_cap_3074078;
            this.edu_icon.Location = new System.Drawing.Point(57, 20);
            this.edu_icon.Name = "edu_icon";
            this.edu_icon.Size = new System.Drawing.Size(165, 156);
            this.edu_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edu_icon.TabIndex = 7;
            this.edu_icon.TabStop = false;
            this.edu_icon.Visible = false;
            // 
            // log_icon
            // 
            this.log_icon.Image = global::Edu_Portal.Properties.Resources.log_out;
            this.log_icon.Location = new System.Drawing.Point(23, 884);
            this.log_icon.Name = "log_icon";
            this.log_icon.Size = new System.Drawing.Size(79, 56);
            this.log_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.log_icon.TabIndex = 7;
            this.log_icon.TabStop = false;
            this.log_icon.Click += new System.EventHandler(this.log_icon_Click);
            // 
            // Teacher_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1558, 984);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Teacher_Dashboard";
            this.Text = "Teacher_Dashboard";
            this.Load += new System.EventHandler(this.Teacher_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.set_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edu_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox edu_icon;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button material;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.PictureBox mat;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.PictureBox result_icon;
        private System.Windows.Forms.PictureBox set_icon;
        private System.Windows.Forms.PictureBox log_icon;
    }
}