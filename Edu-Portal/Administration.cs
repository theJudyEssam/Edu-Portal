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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Announcements ann = new Announcements();
            ann.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Administrationcs student = new Student_Administrationcs();
            student.Show();
            this.Hide();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher_Administration teacher = new Teacher_Administration();
            teacher.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
