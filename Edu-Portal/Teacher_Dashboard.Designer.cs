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
            this.Email = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpa = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.material = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.quote = new System.Windows.Forms.TextBox();
            this.welcome = new System.Windows.Forms.TextBox();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.na = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.TextBox();
            this.em = new System.Windows.Forms.TextBox();
            this.reg = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.study = new System.Windows.Forms.PictureBox();
            this.calc = new System.Windows.Forms.PictureBox();
            this.log_icon = new System.Windows.Forms.PictureBox();
            this.set_icon = new System.Windows.Forms.PictureBox();
            this.result_icon = new System.Windows.Forms.PictureBox();
            this.mat = new System.Windows.Forms.PictureBox();
            this.edu_icon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.study)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edu_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Dashboard";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Elephant", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Blue;
            this.name.Location = new System.Drawing.Point(203, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(116, 42);
            this.name.TabIndex = 1;
            this.name.Text = "hello !";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Elephant", 10.125F);
            this.Email.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Email.Location = new System.Drawing.Point(104, 136);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(63, 27);
            this.Email.TabIndex = 4;
            this.Email.Text = "hello";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.LightSteelBlue;
            this.result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.result.Cursor = System.Windows.Forms.Cursors.Default;
            this.result.ForeColor = System.Drawing.Color.Navy;
            this.result.Location = new System.Drawing.Point(17, 298);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(182, 45);
            this.result.TabIndex = 5;
            this.result.Text = "Results";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.calc);
            this.panel1.Controls.Add(this.gpa);
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
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 773);
            this.panel1.TabIndex = 6;
            // 
            // gpa
            // 
            this.gpa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gpa.Font = new System.Drawing.Font("Elephant", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpa.ForeColor = System.Drawing.Color.Navy;
            this.gpa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gpa.Location = new System.Drawing.Point(17, 362);
            this.gpa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpa.Name = "gpa";
            this.gpa.Size = new System.Drawing.Size(182, 45);
            this.gpa.TabIndex = 9;
            this.gpa.Text = "GPA Calc.";
            this.gpa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gpa.UseVisualStyleBackColor = false;
            this.gpa.Click += new System.EventHandler(this.gpa_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.LightSteelBlue;
            this.logout.ForeColor = System.Drawing.Color.Navy;
            this.logout.Location = new System.Drawing.Point(17, 690);
            this.logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(182, 45);
            this.logout.TabIndex = 12;
            this.logout.Text = "Log Out";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.LightSteelBlue;
            this.setting.ForeColor = System.Drawing.Color.Navy;
            this.setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting.Location = new System.Drawing.Point(17, 428);
            this.setting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(182, 45);
            this.setting.TabIndex = 10;
            this.setting.Text = "Profile";
            this.setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setting.UseVisualStyleBackColor = false;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // material
            // 
            this.material.BackColor = System.Drawing.Color.LightSteelBlue;
            this.material.ForeColor = System.Drawing.Color.Navy;
            this.material.Location = new System.Drawing.Point(17, 231);
            this.material.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(182, 45);
            this.material.TabIndex = 9;
            this.material.Text = "Materials";
            this.material.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.material.UseVisualStyleBackColor = false;
            this.material.Click += new System.EventHandler(this.material_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.LightSteelBlue;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Elephant", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Navy;
            this.title.Location = new System.Drawing.Point(17, 146);
            this.title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(182, 36);
            this.title.TabIndex = 8;
            this.title.Text = "Edu Portal";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(234, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 50);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Controls.Add(this.quote);
            this.panel3.Controls.Add(this.study);
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.welcome);
            this.panel3.Location = new System.Drawing.Point(260, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 159);
            this.panel3.TabIndex = 8;
            // 
            // quote
            // 
            this.quote.BackColor = System.Drawing.Color.CadetBlue;
            this.quote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quote.Font = new System.Drawing.Font("Elephant", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quote.ForeColor = System.Drawing.Color.Lavender;
            this.quote.Location = new System.Drawing.Point(40, 88);
            this.quote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quote.Name = "quote";
            this.quote.Size = new System.Drawing.Size(213, 27);
            this.quote.TabIndex = 3;
            this.quote.Text = "STAY UPDATED !";
            this.quote.TextChanged += new System.EventHandler(this.quote_TextChanged);
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.CadetBlue;
            this.welcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcome.Font = new System.Drawing.Font("Elephant", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Blue;
            this.welcome.Location = new System.Drawing.Point(34, 34);
            this.welcome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(308, 42);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome, ";
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.CadetBlue;
            this.calendar.Font = new System.Drawing.Font("Elephant", 7.874999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.ForeColor = System.Drawing.Color.Black;
            this.calendar.Location = new System.Drawing.Point(836, 80);
            this.calendar.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 9;
            this.calendar.TitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Controls.Add(this.na);
            this.panel4.Controls.Add(this.id);
            this.panel4.Controls.Add(this.Email);
            this.panel4.Controls.Add(this.label);
            this.panel4.Controls.Add(this.em);
            this.panel4.Controls.Add(this.reg);
            this.panel4.Location = new System.Drawing.Point(260, 278);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 194);
            this.panel4.TabIndex = 10;
            // 
            // na
            // 
            this.na.AutoSize = true;
            this.na.Font = new System.Drawing.Font("Elephant", 10.125F);
            this.na.ForeColor = System.Drawing.Color.MidnightBlue;
            this.na.Location = new System.Drawing.Point(96, 40);
            this.na.Name = "na";
            this.na.Size = new System.Drawing.Size(63, 27);
            this.na.TabIndex = 6;
            this.na.Text = "hello";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Elephant", 10.125F);
            this.id.ForeColor = System.Drawing.Color.MidnightBlue;
            this.id.Location = new System.Drawing.Point(168, 88);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(63, 27);
            this.id.TabIndex = 5;
            this.id.Text = "hello";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.CadetBlue;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label.Font = new System.Drawing.Font("Elephant", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Blue;
            this.label.Location = new System.Drawing.Point(19, 41);
            this.label.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(524, 27);
            this.label.TabIndex = 2;
            this.label.Text = "Name :";
            // 
            // em
            // 
            this.em.BackColor = System.Drawing.Color.CadetBlue;
            this.em.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.em.Font = new System.Drawing.Font("Elephant", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.em.ForeColor = System.Drawing.Color.Blue;
            this.em.Location = new System.Drawing.Point(19, 136);
            this.em.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(524, 27);
            this.em.TabIndex = 1;
            this.em.Text = "Email :";
            // 
            // reg
            // 
            this.reg.BackColor = System.Drawing.Color.CadetBlue;
            this.reg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reg.Font = new System.Drawing.Font("Elephant", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.ForeColor = System.Drawing.Color.Blue;
            this.reg.Location = new System.Drawing.Point(19, 90);
            this.reg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(524, 27);
            this.reg.TabIndex = 0;
            this.reg.Text = "Registration :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(260, 509);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(566, 227);
            this.panel5.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(26, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Announcements :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Azure;
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Location = new System.Drawing.Point(836, 368);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(303, 368);
            this.panel6.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Elephant", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(16, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Quote of the Day";
            // 
            // study
            // 
            this.study.Image = global::Edu_Portal.Properties.Resources.educational_tool;
            this.study.Location = new System.Drawing.Point(382, 11);
            this.study.Margin = new System.Windows.Forms.Padding(2);
            this.study.Name = "study";
            this.study.Size = new System.Drawing.Size(160, 134);
            this.study.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.study.TabIndex = 2;
            this.study.TabStop = false;
            // 
            // calc
            // 
            this.calc.Image = global::Edu_Portal.Properties.Resources.clipboard;
            this.calc.Location = new System.Drawing.Point(17, 362);
            this.calc.Margin = new System.Windows.Forms.Padding(2);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(59, 45);
            this.calc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.calc.TabIndex = 9;
            this.calc.TabStop = false;
            // 
            // log_icon
            // 
            this.log_icon.Image = global::Edu_Portal.Properties.Resources.log_out;
            this.log_icon.Location = new System.Drawing.Point(17, 690);
            this.log_icon.Margin = new System.Windows.Forms.Padding(2);
            this.log_icon.Name = "log_icon";
            this.log_icon.Size = new System.Drawing.Size(59, 45);
            this.log_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.log_icon.TabIndex = 7;
            this.log_icon.TabStop = false;
            this.log_icon.Click += new System.EventHandler(this.log_icon_Click);
            // 
            // set_icon
            // 
            this.set_icon.Image = global::Edu_Portal.Properties.Resources.settings;
            this.set_icon.Location = new System.Drawing.Point(17, 428);
            this.set_icon.Margin = new System.Windows.Forms.Padding(2);
            this.set_icon.Name = "set_icon";
            this.set_icon.Size = new System.Drawing.Size(59, 45);
            this.set_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.set_icon.TabIndex = 7;
            this.set_icon.TabStop = false;
            this.set_icon.Click += new System.EventHandler(this.set_icon_Click);
            // 
            // result_icon
            // 
            this.result_icon.Image = global::Edu_Portal.Properties.Resources.results;
            this.result_icon.Location = new System.Drawing.Point(17, 298);
            this.result_icon.Margin = new System.Windows.Forms.Padding(2);
            this.result_icon.Name = "result_icon";
            this.result_icon.Size = new System.Drawing.Size(59, 45);
            this.result_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.result_icon.TabIndex = 7;
            this.result_icon.TabStop = false;
            this.result_icon.Click += new System.EventHandler(this.result_icon_Click);
            // 
            // mat
            // 
            this.mat.Image = global::Edu_Portal.Properties.Resources.material;
            this.mat.Location = new System.Drawing.Point(17, 231);
            this.mat.Margin = new System.Windows.Forms.Padding(2);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(59, 45);
            this.mat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mat.TabIndex = 11;
            this.mat.TabStop = false;
            this.mat.Click += new System.EventHandler(this.mat_Click);
            // 
            // edu_icon
            // 
            this.edu_icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edu_icon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.edu_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.edu_icon.Image = global::Edu_Portal.Properties.Resources.graduation_cap_3074078;
            this.edu_icon.InitialImage = global::Edu_Portal.Properties.Resources.graduation_cap_3074078;
            this.edu_icon.Location = new System.Drawing.Point(47, 32);
            this.edu_icon.Margin = new System.Windows.Forms.Padding(2);
            this.edu_icon.Name = "edu_icon";
            this.edu_icon.Size = new System.Drawing.Size(124, 125);
            this.edu_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edu_icon.TabIndex = 7;
            this.edu_icon.TabStop = false;
            this.edu_icon.Visible = false;
            // 
            // Teacher_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1168, 772);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Teacher_Dashboard";
            this.Text = "Teacher_Dashboard";
            this.Load += new System.EventHandler(this.Teacher_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.study)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.result_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edu_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox welcome;
        private System.Windows.Forms.PictureBox study;
        private System.Windows.Forms.TextBox quote;
        private System.Windows.Forms.Button gpa;
        private System.Windows.Forms.PictureBox calc;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox reg;
        private System.Windows.Forms.TextBox label;
        private System.Windows.Forms.TextBox em;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label na;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label2;
    }
}