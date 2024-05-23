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

            s_total_mark.Text =  science.total_mark;
            s_midterm_mark.Text = science.midterm_mark;
            s_final_mark.Text = science.final_mark;


        }
    }
}
