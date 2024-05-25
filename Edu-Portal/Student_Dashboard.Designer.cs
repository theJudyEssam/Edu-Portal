namespace Edu_Portal
{
    partial class Student_Dashboard
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
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.registration_num = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grade = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Student_Profile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Dasboard";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name.Location = new System.Drawing.Point(32, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 25);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.email.Location = new System.Drawing.Point(32, 136);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(58, 25);
            this.email.TabIndex = 2;
            this.email.Text = "email";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.password.Location = new System.Drawing.Point(32, 184);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(96, 25);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // registration_num
            // 
            this.registration_num.AutoSize = true;
            this.registration_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registration_num.Location = new System.Drawing.Point(40, 240);
            this.registration_num.Name = "registration_num";
            this.registration_num.Size = new System.Drawing.Size(31, 25);
            this.registration_num.TabIndex = 4;
            this.registration_num.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Location = new System.Drawing.Point(40, 304);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(54, 20);
            this.grade.TabIndex = 6;
            this.grade.Text = "Grade";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Student_Profile
            // 
            this.Student_Profile.Location = new System.Drawing.Point(248, 88);
            this.Student_Profile.Name = "Student_Profile";
            this.Student_Profile.Size = new System.Drawing.Size(152, 32);
            this.Student_Profile.TabIndex = 8;
            this.Student_Profile.Text = "Student Profile";
            this.Student_Profile.UseVisualStyleBackColor = true;
            this.Student_Profile.Click += new System.EventHandler(this.Student_Profile_Click);
            // 
            // Student_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.Student_Profile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registration_num);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Student_Dashboard";
            this.Text = "Student_Dashboard";
            this.Load += new System.EventHandler(this.Student_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label registration_num;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Student_Profile;
    }
}