
namespace PictureViewer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bRotate = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.bPlay = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bPrev = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbView = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lDragInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.filesToolStripMenuItem.Text = "&Files";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.authorsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.authorsToolStripMenuItem.Text = "Authors";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.bRotate);
            this.panel1.Controls.Add(this.bPause);
            this.panel1.Controls.Add(this.bPlay);
            this.panel1.Controls.Add(this.bNext);
            this.panel1.Controls.Add(this.bPrev);
            this.panel1.Location = new System.Drawing.Point(452, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 42);
            this.panel1.TabIndex = 2;
            // 
            // bRotate
            // 
            this.bRotate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bRotate.BackgroundImage = global::PictureViewer.Properties.Resources.rotate;
            this.bRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bRotate.Location = new System.Drawing.Point(175, 3);
            this.bRotate.Name = "bRotate";
            this.bRotate.Size = new System.Drawing.Size(37, 37);
            this.bRotate.TabIndex = 4;
            this.bRotate.UseVisualStyleBackColor = true;
            this.bRotate.Click += new System.EventHandler(this.bRotate_Click);
            // 
            // bPause
            // 
            this.bPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bPause.BackgroundImage = global::PictureViewer.Properties.Resources.pause;
            this.bPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPause.Enabled = false;
            this.bPause.Location = new System.Drawing.Point(132, 3);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(37, 37);
            this.bPause.TabIndex = 3;
            this.bPause.UseVisualStyleBackColor = true;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bPlay
            // 
            this.bPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bPlay.BackgroundImage = global::PictureViewer.Properties.Resources.play;
            this.bPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPlay.Location = new System.Drawing.Point(89, 3);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(37, 37);
            this.bPlay.TabIndex = 2;
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // bNext
            // 
            this.bNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bNext.BackgroundImage = global::PictureViewer.Properties.Resources.next;
            this.bNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bNext.Location = new System.Drawing.Point(46, 2);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(37, 37);
            this.bNext.TabIndex = 1;
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bPrev
            // 
            this.bPrev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bPrev.BackgroundImage = global::PictureViewer.Properties.Resources.prev;
            this.bPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPrev.Location = new System.Drawing.Point(3, 3);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(37, 37);
            this.bPrev.TabIndex = 0;
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lDragInfo);
            this.panel2.Controls.Add(this.tvFiles);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 500);
            this.panel2.TabIndex = 3;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvFiles_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvFiles_DragEnter);
            this.panel2.DragLeave += new System.EventHandler(this.tvFiles_DragLeave);
            // 
            // tvFiles
            // 
            this.tvFiles.AllowDrop = true;
            this.tvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFiles.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tvFiles.ImageIndex = 0;
            this.tvFiles.ImageList = this.imageList1;
            this.tvFiles.Location = new System.Drawing.Point(0, 44);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.SelectedImageIndex = 0;
            this.tvFiles.Size = new System.Drawing.Size(208, 452);
            this.tvFiles.TabIndex = 0;
            this.tvFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFiles_AfterSelect);
            this.tvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvFiles_DragDrop);
            this.tvFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvFiles_DragEnter);
            this.tvFiles.DragLeave += new System.EventHandler(this.tvFiles_DragLeave);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_closed.ico");
            this.imageList1.Images.SetKeyName(1, "folder_open.ico");
            this.imageList1.Images.SetKeyName(2, "image.ico");
            // 
            // pbView
            // 
            this.pbView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbView.Location = new System.Drawing.Point(212, 24);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(707, 500);
            this.pbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbView.TabIndex = 1;
            this.pbView.TabStop = false;
            // 
            // lDragInfo
            // 
            this.lDragInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lDragInfo.Location = new System.Drawing.Point(0, 8);
            this.lDragInfo.Name = "lDragInfo";
            this.lDragInfo.Size = new System.Drawing.Size(212, 26);
            this.lDragInfo.TabIndex = 1;
            this.lDragInfo.Text = "You can drag your files";
            this.lDragInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(919, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Picture viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bPrev;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bRotate;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lDragInfo;
    }
}

