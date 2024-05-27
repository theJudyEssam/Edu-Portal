using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu_Portal
{
    public partial class Student_Dashboard : Form
    {
        private List<string> quotes;
        private Random random;
        public Student_Dashboard()
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

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void Student_Dashboard_Load(object sender, EventArgs e)
        {
            n.Text = User_Session.name;
            g.Text = User_Session.grade;
            r.Text = User_Session.registration_number;
            ma.Text = User_Session.email;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lstDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string grade = User_Session.grade;
            if(grade == "11")
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filePath = Path.Combine(documentsPath, "Data_11.txt");

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lstDisplay.Items.Clear();
                    foreach (string line in lines)
                    {
                        lstDisplay.Items.Add(line);
                    }
                }
                else
                {
                    MessageBox.Show("File not found!");
                }
            }

            if(grade == "12")
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filePath = Path.Combine(documentsPath, "Data_12.txt");

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    lstDisplay.Items.Clear();
                    foreach (string line in lines)
                    {
                        lstDisplay.Items.Add(line);
                    }
                }
                else
                {
                    MessageBox.Show("File not found!");
                }
            }
        }

        private void materialll_Click(object sender, EventArgs e)
        {
            Student_Materials materials = new Student_Materials();
            materials.Show();
            this.Hide();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int index = random.Next(quotes.Count);
            quoteLabel.Text = quotes[index];
        }
    }
}
