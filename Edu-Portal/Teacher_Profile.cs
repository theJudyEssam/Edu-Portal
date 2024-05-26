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
    public partial class Teacher_Profile : Form
    {
        public Teacher_Profile()
        {
            InitializeComponent();
        }

        private void Teacher_Profile_Load(object sender, EventArgs e)
        {
            Student_Name.Text = User_Session.name;
            User_Grade.Text = User_Session.grade;
            User_ID.Text = User_Session.registration_number;
            User_name.Text = User_Session.email;

        }

        private void User_ID_Click(object sender, EventArgs e)
        {

        }
    }
}
