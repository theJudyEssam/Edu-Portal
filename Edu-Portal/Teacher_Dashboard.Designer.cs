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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(128, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Dashboard";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.name.Location = new System.Drawing.Point(328, 168);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(90, 39);
            this.name.TabIndex = 1;
            this.name.Text = "hello";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.password.Location = new System.Drawing.Point(328, 208);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(90, 39);
            this.password.TabIndex = 2;
            this.password.Text = "hello";
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.Registration.Location = new System.Drawing.Point(328, 248);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(90, 39);
            this.Registration.TabIndex = 3;
            this.Registration.Text = "hello";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.Email.Location = new System.Drawing.Point(328, 296);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(90, 39);
            this.Email.TabIndex = 4;
            this.Email.Text = "hello";
            // 
            // Teacher_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Teacher_Dashboard";
            this.Text = "Teacher_Dashboard";
            this.Load += new System.EventHandler(this.Teacher_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Label Email;
    }
}