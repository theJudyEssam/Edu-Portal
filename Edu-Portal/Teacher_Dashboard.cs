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
    public partial class Teacher_Dashboard : Form
    {
        public Teacher_Dashboard()
        {
            InitializeComponent();
        }

        private void Teacher_Dashboard_Load(object sender, EventArgs e)
        {
            name.Text = User_Session.name;
            Registration.Text = User_Session.registration_number;
            Email.Text = User_Session.email;
            password.Text = User_Session.password;
        }

        private void name_Click(object sender, EventArgs e)
        {
           
        }
    }
}
