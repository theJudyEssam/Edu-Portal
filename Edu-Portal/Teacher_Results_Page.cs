﻿using System;
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
        public string student_name;
        public string registration_name;
        public BindingSource source;
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

                source = new BindingSource();
                source.DataSource = teacher.Student_Grades;
                dataGridView1.DataSource = source;
              
            }

            DataTable table = teacher.Student_Grades;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            string final_grade = Final_mark.Text;
            string midterm_grade = Midterm_Mark.Text;
            string assignments_grade = Assign_Mark.Text;
            if(final_grade == null || midterm_grade == null || assignments_grade == null)
            {
                MessageBox.Show("Are you sure you want to save?");

            }

            else {


                if (Convert.ToInt32(final_grade) > 40 && Convert.ToInt32(midterm_grade) > 50 && Convert.ToInt32(assignments_grade) > 10)
                {
                    MessageBox.Show("Invalid Marks");
                }
                else
                {
                    int total = Convert.ToInt32(final_grade) + Convert.ToInt32(midterm_grade) + Convert.ToInt32(assignments_grade);
                    string total_mark = Convert.ToString(total);
                    MessageBox.Show("The registration_number is: " + registration_name);
                    teacher.Save_Data(registration_name, total_mark, final_grade, midterm_grade, assignments_grade);
                    //source.ResetBindings(false);
                    teacher.Student_Grades.Clear();
                    teacher.results();
                    dataGridView1.DataSource = teacher.Student_Grades;

                }
            }

            Final_mark.Text = "";
            Midterm_Mark.Text = "";
            Assign_Mark.Text = "";


            }

            private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          




            int index = dataGridView1.CurrentCell.RowIndex;  //this fetches the current cell that i selected
           
            DataGridViewRow current_row = dataGridView1.Rows[index];
            string subject = User_Session.teaching_subject;

            MessageBox.Show(current_row.Cells[$"{subject}_Final_Mark"].Value.ToString());

            Final_mark.Text = current_row.Cells[$"{subject}_Final_Mark"].Value.ToString();
            Midterm_Mark.Text = current_row.Cells[$"{subject}_Midterm_Mark"].Value.ToString();
            Assign_Mark.Text = current_row.Cells[$"{subject}_Assignments_Mark"].Value.ToString();
            student_name = current_row.Cells["Student_Name"].Value.ToString();
            registration_name = current_row.Cells["Registration_Number"].Value.ToString();



        }
    }
}