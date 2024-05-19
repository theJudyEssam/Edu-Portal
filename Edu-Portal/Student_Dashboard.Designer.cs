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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(136, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Dasboard";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.name.Location = new System.Drawing.Point(304, 120);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(97, 37);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.email.Location = new System.Drawing.Point(304, 168);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(93, 37);
            this.email.TabIndex = 2;
            this.email.Text = "email";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.password.Location = new System.Drawing.Point(304, 216);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(155, 37);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // registration_num
            // 
            this.registration_num.AutoSize = true;
            this.registration_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.registration_num.Location = new System.Drawing.Point(312, 272);
            this.registration_num.Name = "registration_num";
            this.registration_num.Size = new System.Drawing.Size(48, 37);
            this.registration_num.TabIndex = 4;
            this.registration_num.Text = "ID";
            // 
            // Student_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}