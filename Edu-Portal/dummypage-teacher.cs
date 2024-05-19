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
    
    public partial class Intro_Page : Form
    {

        public Intro_Page()
        {
            InitializeComponent();

        }

        private void Intro_Page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp  sign = new SignUp();
           
            label1.Text = "juj";
           

        }
    }
}
