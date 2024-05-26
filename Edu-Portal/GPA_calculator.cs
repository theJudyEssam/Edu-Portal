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
    public partial class GPA_calculator : Form
    {
        public GPA_calculator()
        {
            InitializeComponent();
        }

        private void GPA_calculator_Load(object sender, EventArgs e)
        {

        }

        private void Calc_Click(object sender, EventArgs e)
        {
            string grade1 = textBox3.Text;
            string grade2 = textBox4.Text;
            string grade3 = textBox6.Text;

            float grade_1;
            float grade_2;
            float grade_3;

            switch (grade1)
            {
                case "A":
                case "a":
                    grade_1 = 4.0f;
                    break;

                case "B":
                case "b":
                    grade_1 = 3.0f;
                    break;

                case "C":
                case "c":
                    grade_1 = 2.0f;
                    break;

                case "D":
                case "d":
                    grade_1 = 1.0f;
                    break;

                case "F":
                case "f":
                    grade_1 = 0.0f;
                    break;

                default:
                    grade_1 = 0.0f;
                    break;

            }

            switch (grade2)
            {
                case "A":
                case "a":
                    grade_2 = 4.0f;
                    break;

                case "B":
                case "b":
                    grade_2 = 3.0f;
                    break;

                case "C":
                case "c":
                    grade_2 = 2.0f;
                    break;

                case "D":
                case "d":
                    grade_2 = 1.0f;
                    break;

                case "F":
                case "f":
                    grade_2 = 0.0f;
                    break;

                default:
                    grade_2 = 0.0f;
                    break;

            }

            switch (grade3)
            {
                case "A":
                case "a":
                    grade_3 = 4.0f;
                    break;

                case "B":
                case "b":
                    grade_3 = 3.0f;
                    break;

                case "C":
                case "c":
                    grade_3 = 2.0f;
                    break;

                case "D":
                case "d":
                    grade_3 = 1.0f;
                    break;

                case "F":
                case "f":
                    grade_3 = 0.0f;
                    break;

                default:
                    grade_3 = 0.0f;
                    break;

            }

            float credit1 = (float)numericUpDown1.Value;
            float credit2 = (float)numericUpDown2.Value;
            float credit3 = (float)numericUpDown3.Value;

            float gpa = ((grade_1 * credit1) + (grade_2 * credit2) + (grade_3 * credit3)) / (credit1 + credit2 + credit3);

            rusla.Text = gpa.ToString();

        }

        private void back_Click(object sender, EventArgs e)
        {
           Authenticate.go_back();
           this.Hide();
        }
    }
}
