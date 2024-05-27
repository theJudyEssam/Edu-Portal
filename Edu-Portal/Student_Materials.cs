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
    public partial class Student_Materials : Form
    {
        public Student_Materials()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authenticate.go_back();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Student_Materials_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Materials();
            DataTable dt = student.materials;
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;  //this fetches the current cell that i selected

            DataGridViewRow current_row = dataGridView1.Rows[index];
            //string subject = User_Session.teaching_subject;


            Teacher_Name.Text = current_row.Cells[$"Teacher_Name"].Value.ToString();
            Subject_Name.Text = current_row.Cells[$"Subject_Name"].Value.ToString();
            Material_Link.Text = current_row.Cells[$"Materials_Link"].Value.ToString();
          
        }
    }
}
