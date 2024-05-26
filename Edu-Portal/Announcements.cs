using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu_Portal
{
    public partial class Announcements : Form
    {
        public Announcements()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, "Data_11.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true)) // true to append
            {
                writer.WriteLine(input);
            }

            MessageBox.Show("Data saved!");
            txtInput.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, "Data_12.txt");

            using (StreamWriter writer = new StreamWriter(filePath, true)) // true to append
            {
                writer.WriteLine(input);
            }

            MessageBox.Show("Data saved!");
            txtInput.Clear();
        }

        private void Announcements_Load(object sender, EventArgs e)
        {

        }
    }
}
