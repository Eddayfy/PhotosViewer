
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ButtonZoomIn = new System.Windows.Forms.Button();
            this.ButtonZoomOut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelMain.SuspendLayout();
            this.PanelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.AutoScroll = true;
            this.PanelMain.BackColor = System.Drawing.Color.Black;
            this.PanelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelMain.Controls.Add(this.PanelImage);
            this.PanelMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(891, 432);
            this.PanelMain.TabIndex = 6;
            this.PanelMain.Click += new System.EventHandler(this.PanelMain_Click);
            // 
            // PanelImage
            // 
            this.PanelImage.BackColor = System.Drawing.Color.Transparent;
            this.PanelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelImage.Location = new System.Drawing.Point(0, 0);
            this.PanelImage.Name = "PanelImage";
            this.PanelImage.Size = new System.Drawing.Size(891, 432);
            this.PanelImage.TabIndex = 7;
            this.PanelImage.Click += new System.EventHandler(this.PanelMain_Click);
            // 
            // PanelControls
            // 
            this.PanelControls.AutoScroll = true;
            this.PanelControls.BackColor = System.Drawing.Color.Black;
            this.PanelControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelControls.Controls.Add(this.button2);
            this.PanelControls.Controls.Add(this.ButtonZoomOut);
            this.PanelControls.Controls.Add(this.button1);
            this.PanelControls.Controls.Add(this.ButtonZoomIn);
            this.PanelControls.Controls.Add(this.numericUpDown1);
            this.PanelControls.Controls.Add(this.trackBar1);
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
            this.PreviousPanel.Location = new System.Drawing.Point(340, 11);
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
            this.NextPanel.Location = new System.Drawing.Point(493, 11);
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
            this.PanelOpenImages.Location = new System.Drawing.Point(401, 2);
            this.PanelOpenImages.Name = "PanelOpenImages";
            this.PanelOpenImages.Size = new System.Drawing.Size(84, 51);
            this.PanelOpenImages.TabIndex = 0;
            this.PanelOpenImages.Click += new System.EventHandler(this.PanelOpenImages_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(731, 4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(153, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(10, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ButtonZoomIn
            // 
            this.ButtonZoomIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonZoomIn.Location = new System.Drawing.Point(553, 16);
            this.ButtonZoomIn.Name = "ButtonZoomIn";
            this.ButtonZoomIn.Size = new System.Drawing.Size(32, 22);
            this.ButtonZoomIn.TabIndex = 8;
            this.ButtonZoomIn.Text = "+";
            this.ButtonZoomIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonZoomIn.UseVisualStyleBackColor = true;
            this.ButtonZoomIn.Click += new System.EventHandler(this.PanelZoomIn_Click);
            // 
            // ButtonZoomOut
            // 
            this.ButtonZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonZoomOut.Location = new System.Drawing.Point(591, 16);
            this.ButtonZoomOut.Name = "ButtonZoomOut";
            this.ButtonZoomOut.Size = new System.Drawing.Size(32, 22);
            this.ButtonZoomOut.TabIndex = 8;
            this.ButtonZoomOut.Text = "-";
            this.ButtonZoomOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonZoomOut.UseVisualStyleBackColor = true;
            this.ButtonZoomOut.Click += new System.EventHandler(this.PanelZoomOut_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(262, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "L";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.PanelZoomIn_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(300, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 22);
            this.button2.TabIndex = 8;
            this.button2.Text = "R";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.PanelZoomOut_Click);
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
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photos Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.PanelMain.ResumeLayout(false);
            this.PanelControls.ResumeLayout(false);
            this.PanelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelControls;
        private System.Windows.Forms.Panel PanelImage;
        private System.Windows.Forms.Panel PanelOpenImages;
        private System.Windows.Forms.Panel NextPanel;
        private System.Windows.Forms.Panel PreviousPanel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button ButtonZoomIn;
        private System.Windows.Forms.Button ButtonZoomOut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}