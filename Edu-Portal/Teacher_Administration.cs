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
    public partial class Teacher_Administration : Form
    {
        DataTable dt;
        public Teacher_Administration()
        {
            InitializeComponent();
        }

        private void Teacher_Administration_Load(object sender, EventArgs e)
        {
            Adminstration administration = new Adminstration();
            dt = administration.Get_Data("Teacher_Personal_Inform");
            dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;  //this fetches the current cell that i selected

            DataGridViewRow current_row = dataGridView1.Rows[index];
            //string subject = User_Session.teaching_subject;


            s_name.Text = current_row.Cells[$"Name"].Value.ToString();
            registration_num.Text = current_row.Cells[$"Registration_Number"].Value.ToString();
           grade.Text = current_row.Cells[$"Grade"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Administration a = new Administration();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
            int index = dataGridView1.CurrentCell.RowIndex;  //this fetches the current cell that i selected

            DataGridViewRow current_row = dataGridView1.Rows[index];
            string reg = current_row.Cells[$"Registration_Number"].Value.ToString();
            Adminstration a = new Adminstration();
            a.Delete_Data(reg, "Teacher_Personal_Inform");
            dt.Clear();
            dt = a.Get_Data("Teacher_Personal_Inform");
            dataGridView1.DataSource = dt;
            }
          


        }
    }
}
