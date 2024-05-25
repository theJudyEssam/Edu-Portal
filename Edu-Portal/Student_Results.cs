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
    public partial class Student_Results : Form
    {
        public Student_Results()
        {
            InitializeComponent();
        }

        private void Student_Results_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            student.results();
            Subject science = student.subjects[0];

            if(science.total_mark == null )
            {
                MessageBox.Show("ERROR THIS IS NULL");
            }

            Subject math = student.subjects[1];
            Subject english = student.subjects[2];


            //the names of the labels
            s_total_mark.Text = science.total_mark;
            s_midterm_mark.Text = science.midterm_mark;
            s_final_mark.Text = science.final_mark;
            s_assignments_mark.Text = science.assignment_mark;

            m_total_mark.Text = math.total_mark;
            m_final_mark.Text = math.final_mark;
            m_midterm_mark.Text = math.midterm_mark;
            m_assignments_mark.Text = math.assignment_mark;

            e_total_mark.Text = english.total_mark;
            e_final_mark.Text = english.final_mark;
            e_midterm_mark.Text = english.midterm_mark;
            e_assignments_mark.Text = english.assignment_mark;

        }
    }
}
