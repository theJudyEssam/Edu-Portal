using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu_Portal
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            User user;
            //these are the user inputs
            string registration = registration_login.Text;
            string password = password_login.Text;

            Authenticate auth = new Authenticate(registration, password);
            if (Authenticate.student(registration))
            {
                user = new Student();
            }
            else
            {
                user = new Teacher();
            }


            if (auth.log_in())
            {
                user.open_dashboard();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error bruh");
            }
        }
    }
}
