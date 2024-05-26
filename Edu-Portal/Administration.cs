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
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Announcements ann = new Announcements();
            ann.ShowDialog();
            this.Hide();
        }
    }
}
