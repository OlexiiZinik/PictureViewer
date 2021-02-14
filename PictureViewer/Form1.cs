using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        int k = 0, N = 0;
        List<string> names = new List<string>();
        List<string> pathes = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "PNG(*.png)|*.png|GIF(*.gif)|*.gif|JEPEG(*.jpg)|*.jpg|All Files(*.*)|*.*||";
            ofd.Title = "Select photo(s)";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                names.AddRange(ofd.SafeFileNames);
                pathes.AddRange(ofd.FileNames);
                foreach(var n in names)
                    listBox1.Items.Add(n);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            k = listBox1.SelectedIndex;
            pictureBox1.Image = Image.FromFile(pathes[k]);
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            k = listBox1.SelectedIndex;
            if (k == -1)
                 MessageBox.Show("Image not selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                N = listBox1.Items.Count;
                if (k == N - 1)
                    listBox1.SelectedIndex = 0;
                else
                    listBox1.SelectedIndex++;
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
