﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu_Portal
{
    public partial class SignUp : Form
    {
        public string name;
        public string password;

        
        public Profile profile;

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void sign_name_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validate(string name, string email, string password, string ID)
        {
            bool name_flag = false;
            bool email_flag = false;
            bool password_flag = false;
            bool ID_flag = false;

            name_flag = name.Any(char.IsDigit)?false:true;
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);
            email_flag = regex.IsMatch(email);

            password_flag = password.Length < 8 ? false : true;
            ID_flag = (ID.Length != 9 || ID.Any(char.IsLetter)) ? false : true;


            return name_flag && email_flag && password_flag && ID_flag;

           // return true;
        }
        public void button1_Click(object sender, EventArgs e)
        {

            //the textbox values
            string name = sign_name_s.Text;
            string email = email_s.Text;
            string password = password_s.Text;
            string ID = registration_num_s.Text;
            bool is_student= Student_2.Checked;
            string grade = grade_s.Text;
            string teaching_subject = null;
            if (!is_student)
            {
                teaching_subject = Subject_ComboBox.Text;
               // MessageBox.Show(teaching_subject);
            }



           // Profile profile = new Profile(name, password, ID, email, grade,is_student);
            Authenticate auth = new Authenticate(name, password, ID, email, grade, is_student, teaching_subject);

            //add validation
            if(validate(name, email, password, ID)) { 
            if ((!Authenticate.student(ID) && is_student) || (Authenticate.student(ID) && !is_student))
            {
                MessageBox.Show("Registration Number Invalid", "Error");
                sign_name_s.Text = string.Empty;
                email_s.Text = string.Empty;
                password_s.Text = string.Empty;
                registration_num_s.Text = string.Empty;
                grade_s.Text = string.Empty;
                Student_2.Checked = false;
            }
            else
            {
                if (auth.sign_up() == "OK")
                {
                    User user;
                    if (is_student)
                    {
                        user = new Student();
                    }
                    else
                    {
                        user = new Teacher();
                    }

                    user.open_dashboard();
                    this.Hide();

                }
                else if (auth.sign_up() == "validation_error")
                {
                    MessageBox.Show("Registration Number Already exist please try another",
                       "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    sign_name_s.Text = string.Empty;
                    email_s.Text = string.Empty;
                    password_s.Text = string.Empty;
                    registration_num_s.Text = string.Empty;
                    grade_s.Text = string.Empty;
                    Student_2.Checked = false;

                }
                else
                {
                    MessageBox.Show(auth.sign_up(),
                      "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }

            }

        }
            else
            {
                MessageBox.Show("The credentials are invalid.");
            }

            //    //if the thing is a teacher, then user = teacher
            //    //else if the thing is a student then user = student
            //    // call auth.sign_up
            //    //if the process is true then open the dashboard
            //else if the process if not true....output

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void Teacher_1_CheckedChanged(object sender, EventArgs e)
        {
            Subject_Label.Visible = true;
            Subject_ComboBox.Visible = true;
        }

        private void Student_2_CheckedChanged(object sender, EventArgs e)
        {
            Subject_Label.Visible = false;
            Subject_ComboBox.Visible = false;
        }
    }
}
