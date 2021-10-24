
namespace PhotosViewer
{
    partial class MainForm
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
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelImage = new System.Windows.Forms.Panel();
            this.PanelControls = new System.Windows.Forms.Panel();
            this.PreviousPanel = new System.Windows.Forms.Panel();
            this.NextPanel = new System.Windows.Forms.Panel();
            this.PanelOpenImages = new System.Windows.Forms.Panel();
            this.PanelZoomIn = new System.Windows.Forms.Panel();
            this.PanelZoomOut = new System.Windows.Forms.Panel();
            this.PanelMain.SuspendLayout();
            this.PanelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.AutoScroll = true;
            this.PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelMain.Controls.Add(this.PanelImage);
            this.PanelMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(891, 432);
            this.PanelMain.TabIndex = 6;
            // 
            // PanelImage
            // 
            this.PanelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelImage.Location = new System.Drawing.Point(0, 0);
            this.PanelImage.Name = "PanelImage";
            this.PanelImage.Size = new System.Drawing.Size(891, 432);
            this.PanelImage.TabIndex = 7;
            // 
            // PanelControls
            // 
            this.PanelControls.AutoScroll = true;
            this.PanelControls.BackColor = System.Drawing.Color.Transparent;
            this.PanelControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelControls.Controls.Add(this.PanelZoomOut);
            this.PanelControls.Controls.Add(this.PanelZoomIn);
            this.PanelControls.Controls.Add(this.PreviousPanel);
            this.PanelControls.Controls.Add(this.NextPanel);
            this.PanelControls.Controls.Add(this.PanelOpenImages);
            this.PanelControls.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControls.Location = new System.Drawing.Point(0, 432);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.Size = new System.Drawing.Size(891, 59);
            this.PanelControls.TabIndex = 6;
            // 
            // PreviousPanel
            // 
            this.PreviousPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PreviousPanel.BackColor = System.Drawing.Color.Transparent;
            this.PreviousPanel.BackgroundImage = global::PhotosViewer.Properties.Resources.Previous;
            this.PreviousPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreviousPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PreviousPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPanel.Location = new System.Drawing.Point(342, 13);
            this.PreviousPanel.Name = "PreviousPanel";
            this.PreviousPanel.Size = new System.Drawing.Size(53, 32);
            this.PreviousPanel.TabIndex = 2;
            this.PreviousPanel.Click += new System.EventHandler(this.PreviousPanel_Click);
            // 
            // NextPanel
            // 
            this.NextPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextPanel.BackColor = System.Drawing.Color.Transparent;
            this.NextPanel.BackgroundImage = global::PhotosViewer.Properties.Resources.Next;
            this.NextPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NextPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPanel.Location = new System.Drawing.Point(495, 13);
            this.NextPanel.Name = "NextPanel";
            this.NextPanel.Size = new System.Drawing.Size(53, 32);
            this.NextPanel.TabIndex = 1;
            this.NextPanel.Click += new System.EventHandler(this.NextPanel_Click);
            // 
            // PanelOpenImages
            // 
            this.PanelOpenImages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelOpenImages.BackColor = System.Drawing.Color.Transparent;
            this.PanelOpenImages.BackgroundImage = global::PhotosViewer.Properties.Resources.AppIcon;
            this.PanelOpenImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelOpenImages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelOpenImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelOpenImages.Location = new System.Drawing.Point(403, 4);
            this.PanelOpenImages.Name = "PanelOpenImages";
            this.PanelOpenImages.Size = new System.Drawing.Size(84, 51);
            this.PanelOpenImages.TabIndex = 0;
            this.PanelOpenImages.Click += new System.EventHandler(this.PanelOpenImages_Click);
            // 
            // PanelZoomIn
            // 
            this.PanelZoomIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelZoomIn.BackColor = System.Drawing.Color.Gray;
            this.PanelZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelZoomIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelZoomIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelZoomIn.Location = new System.Drawing.Point(554, 18);
            this.PanelZoomIn.Name = "PanelZoomIn";
            this.PanelZoomIn.Size = new System.Drawing.Size(32, 22);
            this.PanelZoomIn.TabIndex = 3;
            this.PanelZoomIn.Visible = false;
            this.PanelZoomIn.Click += new System.EventHandler(this.PanelZoomIn_Click);
            // 
            // PanelZoomOut
            // 
            this.PanelZoomOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelZoomOut.BackColor = System.Drawing.Color.Gray;
            this.PanelZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelZoomOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelZoomOut.Location = new System.Drawing.Point(592, 18);
            this.PanelZoomOut.Name = "PanelZoomOut";
            this.PanelZoomOut.Size = new System.Drawing.Size(32, 22);
            this.PanelZoomOut.TabIndex = 4;
            this.PanelZoomOut.Visible = false;
            this.PanelZoomOut.Click += new System.EventHandler(this.PanelZoomOut_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(891, 491);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelControls);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photos Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.PanelMain.ResumeLayout(false);
            this.PanelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelControls;
        private System.Windows.Forms.Panel PanelImage;
        private System.Windows.Forms.Panel PanelOpenImages;
        private System.Windows.Forms.Panel NextPanel;
        private System.Windows.Forms.Panel PreviousPanel;
        private System.Windows.Forms.Panel PanelZoomOut;
        private System.Windows.Forms.Panel PanelZoomIn;
    }
}