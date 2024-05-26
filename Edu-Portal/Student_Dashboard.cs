using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu_Portal
{
    public partial class Student_Dashboard : Form
    {
        public Student_Dashboard()
        {
            InitializeComponent();
        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void Student_Dashboard_Load(object sender, EventArgs e)
        {
            //name.Text = "Name: " + User_Session.name;
            //email.Text ="Email: " +  User_Session.email;
            //password.Text = "Password: " + User_Session.password;
            //registration_num.Text = "Registration Number: "+ User_Session.registration_number;
            //grade.Text = "Grade: "+User_Session.grade;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Results student = new Student_Results();
            student.Show();
            this.Hide();
        }

        private void Student_Profile_Click(object sender, EventArgs e)
        {
            Student_Profile student_profile = new Student_Profile();
            student_profile.Show();
            this.Hide();
        }

        private void res_Click(object sender, EventArgs e)
        {
            Student_Results results = new Student_Results();
            results.Show();
            this.Hide();
        }

        private void gpaaa_Click(object sender, EventArgs e)
        {
            GPA_calculator gpa = new GPA_calculator();
            gpa.Show();
            this.Hide();
        }

        private void settingss_Click(object sender, EventArgs e)
        {
            Student_Profile student = new Student_Profile();
            student.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
            this.Hide();
        }
    }
}
