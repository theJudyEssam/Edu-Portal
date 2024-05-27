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
        private List<string> quotes;
        private Random random;
        public Teacher_Dashboard()
        {
            InitializeComponent();

            
            quotes = new List<string>
            {
                "The only limit to our realization of tomorrow is our doubts of today.",
                "The purpose of our lives is to be happy.",
                "Life is what happens when you're busy making other plans.",
                "Get busy living or get busy dying.",
                "You have within you right now, everything you need to deal with whatever the world can throw at you."
            };

            
            random = new Random();
    }

        private void Teacher_Dashboard_Load(object sender, EventArgs e)
        {
            na.Text = User_Session.name;
            id.Text = User_Session.registration_number;
            mail.Text = User_Session.email;
        }

        private void name_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher_Results_Page results = new Teacher_Results_Page();
            results.Show();
            this.Hide();
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
            this.Hide();
        }

        private void gpa_Click(object sender, EventArgs e)
        {
            GPA_calculator gPA = new GPA_calculator();
            gPA.Show();
            this.Hide();
        }

        private void quote_TextChanged(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
            this.Hide();
        }

        private void material_Click(object sender, EventArgs e)
        {
            Teacher_Materials material = new Teacher_Materials();
            material.Show();
            this.Hide();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int index = random.Next(quotes.Count);
            quoteLabel.Text = quotes[index];
        }
    }
}
