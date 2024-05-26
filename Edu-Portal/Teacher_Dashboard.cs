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
    public partial class Teacher_Dashboard : Form
    {
        public Teacher_Dashboard()
        {
            InitializeComponent();
        }

        private void Teacher_Dashboard_Load(object sender, EventArgs e)
        {
            na.Text = User_Session.name;
            id.Text = User_Session.registration_number;
            Email.Text = User_Session.email;
        }

        private void name_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher_Results_Page results = new Teacher_Results_Page();
            results.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void set_icon_Click(object sender, EventArgs e)
        {

        }

        private void result_icon_Click(object sender, EventArgs e)
        {

        }

        private void mat_Click(object sender, EventArgs e)
        {

        }

        private void log_icon_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            calendar.BackColor = Color.CadetBlue;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            Teacher_Profile profile = new Teacher_Profile();
            profile.Show();
        }

        private void gpa_Click(object sender, EventArgs e)
        {
            GPA_calculator gPA = new GPA_calculator();
            gPA.Show();
        }
    }
}
