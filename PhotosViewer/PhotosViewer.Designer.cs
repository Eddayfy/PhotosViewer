namespace PhotosViewer
{
    partial class PhotosViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotosViewer));
            this.AppMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.GetOtherFileOnTheSameCurrentFileDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.AppTimer = new System.Windows.Forms.Timer(this.components);
            this.PreviousPanel = new System.Windows.Forms.Panel();
            this.NextPanel = new System.Windows.Forms.Panel();
            this.AppMenuStrip.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AppMenuStrip
            // 
            this.AppMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ToolsToolStripMenuItem});
            this.AppMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.AppMenuStrip.Name = "AppMenuStrip";
            this.AppMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.AppMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.AppMenuStrip.TabIndex = 0;
            this.AppMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewWindowToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // NewWindowToolStripMenuItem
            // 
            this.NewWindowToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem";
            this.NewWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewWindowToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.NewWindowToolStripMenuItem.Text = "&New Window";
            this.NewWindowToolStripMenuItem.Click += new System.EventHandler(this.NewWindowToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Right)));
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.NextPanel_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Left)));
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.PreviousPanel_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomInToolStripMenuItem,
            this.ZoomOutToolStripMenuItem,
            this.toolStripSeparator7,
            this.GetOtherFileOnTheSameCurrentFileDirectoryToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ToolsToolStripMenuItem.Text = "&Tools";
            // 
            // ZoomInToolStripMenuItem
            // 
            this.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem";
            this.ZoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.ZoomInToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ZoomInToolStripMenuItem.Text = "Zoom In";
            this.ZoomInToolStripMenuItem.Click += new System.EventHandler(this.ZoomInToolStripMenuItem_Click);
            // 
            // ZoomOutToolStripMenuItem
            // 
            this.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem";
            this.ZoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.ZoomOutToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ZoomOutToolStripMenuItem.Text = "Zoom Out";
            this.ZoomOutToolStripMenuItem.Click += new System.EventHandler(this.ZoomOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(180, 6);
            // 
            // GetOtherFileOnTheSameCurrentFileDirectoryToolStripMenuItem
            // 
            this.GetOtherFileOnTheSameCurrentFileDirectoryToolStripMenuItem.Name = "GetOtherFileOnTheSameCurrentFileDirectoryToolStripMenuItem";
            this.GetOtherFileOnTheSameCurrentFileDirectoryToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.GetOtherFileOnTheSameCurrentFileDirectoryToolStripMenuItem.Text = "Get Other Files";
            this.GetOtherFileOnTheSameCurrentFileDirectoryToolStripMenuItem.Click += new System.EventHandler(this.getOtherFilesToolStripMenuItem_Click);
            // 
            // ImagePanel
            // 
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.BackColor = System.Drawing.Color.Black;
            this.ImagePanel.Controls.Add(this.ImagePictureBox);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePanel.Location = new System.Drawing.Point(40, 24);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(720, 426);
            this.ImagePanel.TabIndex = 1;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(0, 0);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(719, 426);
            this.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePictureBox.TabIndex = 0;
            this.ImagePictureBox.TabStop = false;
            // 
            // AppTimer
            // 
            this.AppTimer.Enabled = true;
            this.AppTimer.Tick += new System.EventHandler(this.AppTimer_Tick);
            // 
            // PreviousPanel
            // 
            this.PreviousPanel.BackColor = System.Drawing.Color.Transparent;
            this.PreviousPanel.BackgroundImage = global::PhotosViewer.Properties.Resources.Previous;
            this.PreviousPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreviousPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PreviousPanel.Location = new System.Drawing.Point(0, 24);
            this.PreviousPanel.Name = "PreviousPanel";
            this.PreviousPanel.Size = new System.Drawing.Size(40, 426);
            this.PreviousPanel.TabIndex = 1;
            this.PreviousPanel.Visible = false;
            this.PreviousPanel.Click += new System.EventHandler(this.PreviousPanel_Click);
            // 
            // NextPanel
            // 
            this.NextPanel.BackColor = System.Drawing.Color.Transparent;
            this.NextPanel.BackgroundImage = global::PhotosViewer.Properties.Resources.Next;
            this.NextPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextPanel.Location = new System.Drawing.Point(760, 24);
            this.NextPanel.Name = "NextPanel";
            this.NextPanel.Size = new System.Drawing.Size(40, 426);
            this.NextPanel.TabIndex = 1;
            this.NextPanel.Visible = false;
            this.NextPanel.Click += new System.EventHandler(this.NextPanel_Click);
            // 
            // PhotosViewer
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.PreviousPanel);
            this.Controls.Add(this.NextPanel);
            this.Controls.Add(this.AppMenuStrip);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.AppMenuStrip;
            this.Name = "PhotosViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photos Viewer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.PhotosViewer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.PhotosViewer_DragEnter);
            this.AppMenuStrip.ResumeLayout(false);
            this.AppMenuStrip.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AppMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Panel NextPanel;
        private System.Windows.Forms.Panel PreviousPanel;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.Timer AppTimer;
        private System.Windows.Forms.ToolStripMenuItem GetOtherFileOnTheSameCurrentFileDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
    }
}

