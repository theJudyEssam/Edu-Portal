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
    public partial class Email_Change : Form
    {
        public Email_Change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n_email = new_password.Text;
            Settings settings = new Settings();
            settings.change_email(n_email);
            MessageBox.Show("Your new email is: "+ User_Session.email);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authenticate.go_back();
        }
    }
}
