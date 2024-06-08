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
    public partial class Teacher_Materials : Form
    {
        public Teacher_Materials()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string link = materials_link.Text;
            Teacher teacher  = new Teacher();
            teacher.Materials(link);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authenticate.go_back();
            this.Hide();
        }

        private void Teacher_Materials_Load(object sender, EventArgs e)
        {

        }
    }
}
