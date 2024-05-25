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
    public partial class Teacher_Results_Page : Form
    {
        Teacher teacher;
        public Teacher_Results_Page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Teacher_Results_Page_Load(object sender, EventArgs e)
        {
            teacher = new Teacher();
            teacher.results();
            if(teacher.Student_Grades == null)
            {
                MessageBox.Show("The grades do not exist");
            }
            else
            {
                dataGridView1.DataSource = teacher.Student_Grades;
            }

            DataTable table = teacher.Student_Grades;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = teacher.Student_Grades;
            
            teacher.Save_Data();
        }
    }
}
