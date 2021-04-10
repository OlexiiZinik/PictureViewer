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
        public int PIctureCount {
            get
            {
                int count = 0;
                foreach (TreeNode node in tvFiles.Nodes)
                {
                    count += node.Nodes.Count;
                }
                return count;
            }
        }


        public FileTreeNode SecectedImageNode
        {
            get { return (tvFiles.SelectedNode is FileTreeNode) ? (tvFiles.SelectedNode as FileTreeNode) : null; }
            set { }
        }           

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bNext.PerformClick();
        }

        private void bPrev_Click(object sender, EventArgs e)
        {
            if (tvFiles.SelectedNode == null)
                return;
            else if (tvFiles.SelectedNode.Nodes.Count > 1)
            {
                tvFiles.SelectedNode = tvFiles.SelectedNode.LastNode;
                return;
            }

            var sn = tvFiles.SelectedNode;
            if (sn.PrevNode != null)
                tvFiles.SelectedNode = sn.PrevNode;
            else
                tvFiles.SelectedNode = sn.Parent.LastNode;

        }

        private void bNext_Click(object sender, EventArgs e)
        {

            if (tvFiles.SelectedNode == null)
                return;
            else if (tvFiles.SelectedNode.Nodes.Count > 1)
            {
                tvFiles.SelectedNode = tvFiles.SelectedNode.FirstNode;
                return;
            }

            var sn = tvFiles.SelectedNode;
            if (sn.NextNode != null)
                tvFiles.SelectedNode = sn.NextNode;
            else
                tvFiles.SelectedNode = sn.Parent.FirstNode;

        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            if (PIctureCount > 0)
            {
                timer1.Start();
                bPlay.Enabled = false;
                bPause.Enabled = true;
            }
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            bPlay.Enabled = true;
            bPause.Enabled = false;
            timer1.Stop();
        }

        private void bRotate_Click(object sender, EventArgs e)
        {
            if(SecectedImageNode != null)
            {

                Image img = SecectedImageNode.Picture.Image;
                img?.RotateFlip(RotateFlipType.Rotate90FlipNone);
                SecectedImageNode.Picture.Image = pbView.Image = img;

            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvFiles.Nodes.Clear();
            bPause.PerformClick();
            pbView.Image = null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Image Files|*.bmp;*.jpg;*.gif;*.png;|All files (*.*)|*.*";
            ofd.Title = "Select photo(s)";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<Picture> pictures = new List<Picture>();
                foreach (var fn in ofd.FileNames)
                {
                    try
                    {
                        pictures.Add(Picture.FromFile(fn));
                    }
                    catch
                    {
                        MessageBox.Show("Wrong file format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                UpdateExplorer(pictures);   
            }
        }

        private void UpdateExplorer(List<Picture> pictures)
        {
            if (pictures.Count == 0)
            {
                return;
            }

            var grupedPics = pictures.GroupBy(p => p.Directory);

            foreach (var group in grupedPics)
            {
                TreeNode tn;
                if(tvFiles.Nodes.ContainsKey(group.Key))
                    tn = tvFiles.Nodes.Find(group.Key, false).First();
                else
                    tn = new TreeNode(group.Key) { Name = group.Key };

                tn.ImageIndex = 0;
                tn.SelectedImageIndex = 1;
                foreach (var p in group)
                {
                    var node = new FileTreeNode(p.Name, p) { ImageIndex = 2, SelectedImageIndex = 2, };
                    ContextMenuExt c = new ContextMenuExt(this.components, node);
                    c.Items.Add(new ToolStripMenuItem("Exclude"));
                    c.ItemClickedExt += C_ItemClickedExt;
                    node.ContextMenuStrip = c;
                    tn.Nodes.Add(node);
                }
                if (!tvFiles.Nodes.ContainsKey(group.Key))
                    tvFiles.Nodes.Add(tn);
                    
            }
        }

        

        private void tvFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvFiles.SelectedNode.Nodes.Count > 1)
                return;

            if (SecectedImageNode != null)
                pbView.Image = SecectedImageNode.Picture.Image;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void C_ItemClickedExt(object sender, EventArgs e, object item)
        {
            var node = item as TreeNode;
            
            if(node.Parent.Nodes.Count <= 1)
                tvFiles.SelectedNode = node.Parent;
            else
                tvFiles.SelectedNode = node;

            tvFiles.SelectedNode.Remove();
            pbView.Image = null;
        }

        private void tvFiles_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                lDragInfo.Text = "Drop your files";
                tvFiles.BackColor = Color.Aqua;
            }
        }

        private void tvFiles_DragLeave(object sender, EventArgs e)
        {
            lDragInfo.Text = "You can drag your files";
            tvFiles.BackColor = SystemColors.WindowFrame;
        }

        private void tvFiles_DragDrop(object sender, DragEventArgs e)
        {
            lDragInfo.Text = "You can drag your files";
            tvFiles.BackColor = SystemColors.WindowFrame;
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            List<Picture> pictures = new List<Picture>();
            foreach (var fn in files)
            {
                try
                {
                    pictures.Add(Picture.FromFile(fn));
                }
                catch
                {
                    MessageBox.Show("Wrong file format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            UpdateExplorer(pictures);
        }
    }
}
