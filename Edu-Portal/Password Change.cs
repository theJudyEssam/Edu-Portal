using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu_Portal
{
    public partial class Password_Change : Form
    {
        public Password_Change()
        {
            InitializeComponent();
        }

        private void Password_Change_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Your old password is: " + User_Session.password);
            string n_password = new_password.Text;
            string o_password = old_password.Text;
           
            Settings setting = new Settings();
            if (setting.change_password(n_password, o_password))
            {
                MessageBox.Show("Password Successfully Changed!");
               // MessageBox.Show("Your new Password is: " + User_Session.password);
            }
            new_password.Text = "";
            n.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Authenticate.go_back();
        }
    }
}
