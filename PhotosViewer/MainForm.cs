using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PhotosViewer
{
    public partial class MainForm : Form
    {
        private readonly List<string> Images = new List<string>();
        private Bitmap bitmap;
        private int ImageIndex;
        private bool IsZoomOn;
        private int ZoomScale;

        public MainForm(string[] Args)
        {
            InitializeComponent();

            foreach (string Arg in Args)
                if (IsFileAnImage(Arg))
                    Images.Add(Arg);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try { this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location); }
            catch { }

            ImageIndex = 0;
            IsZoomOn = false;

            if (ImageIndex < Images.Count)
                SetTheImage(Images[ImageIndex]);
            else
                SetTheNavigateControls();
        }

        private bool IsFileAnImage(string file)
        {
            switch (Path.GetExtension(file).ToLower())
            {
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                case ".png":
                    return true;
                case ".bmp":
                    return true;
                case ".gif":
                    return true;
                case ".ico":
                    return true;
                default:
                    return false;
            }
        }

        private void SetTheImage(string file)
        {
            if (IsFileAnImage(file))
            {
                this.Text = Path.GetFileName(file) + " - Photos Viewer";

                if (!file.EndsWith(".gif"))
                {
                    bitmap = new Bitmap(file);

                    ZoomScale = 100;
                    SetZoom(ZoomScale);

                    PanelImage.BackgroundImage = bitmap;
                }

                SetTheNavigateControls();
            }
        }

        private void SetTheNavigateControls()
        {
            if (!IsZoomOn)
            {
                if (Images.Count > 1)
                {
                    if (ImageIndex == 0)
                    {
                        NextPanel.Enabled = true;
                        PreviousPanel.Enabled = false;
                    }
                    else if (ImageIndex == Images.Count - 1)
                    {
                        NextPanel.Enabled = false;
                        PreviousPanel.Enabled = true;
                    }
                    else
                    {
                        NextPanel.Enabled = true;
                        PreviousPanel.Enabled = true;
                    }
                }
                else
                {
                    NextPanel.Enabled = false;
                    PreviousPanel.Enabled = false;
                }
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            List<string> ImagesDroped = new List<string>();
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
                if (IsFileAnImage(file))
                    ImagesDroped.Add(file);

            if (ImagesDroped.Count > 0)
            {
                Images.Clear();
                foreach (string image in ImagesDroped)
                    Images.Add(image);

                ImageIndex = 0;
                if (ImageIndex < Images.Count)
                    SetTheImage(Images[ImageIndex]);
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (!IsZoomOn)
            {
                if (ImageIndex < Images.Count)
                    SetTheImage(Images[ImageIndex]);
            }
            else
                SetZoom(ZoomScale);
        }

        private void PreviousPanel_Click(object sender, EventArgs e)
        {
            if (ImageIndex > 0)
                SetTheImage(Images[--ImageIndex]);
        }

        private void NextPanel_Click(object sender, EventArgs e)
        {
            if (ImageIndex < Images.Count - 1)
                SetTheImage(Images[++ImageIndex]);
        }

        private void PanelOpenImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog
            {
                Title = "Open your Image",
                Multiselect = true,
                Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp; *.gif; *.ico"
            };

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                Images.Clear();
                foreach (string file in OFD.FileNames)
                    Images.Add(file);

                ImageIndex = 0;
                IsZoomOn = false;

                if (ImageIndex < Images.Count)
                    SetTheImage(Images[ImageIndex]);
                else
                    SetTheNavigateControls();
            }
        }

        private void PanelZoomIn_Click(object sender, EventArgs e)
        {
            if (!Images[ImageIndex].EndsWith(".gif"))
            {
                ZoomScale += 10;
                SetZoom(ZoomScale);
            }
        }

        private void PanelZoomOut_Click(object sender, EventArgs e)
        {
            if (!Images[ImageIndex].EndsWith(".gif"))
            {
                ZoomScale -= 10;
                SetZoom(ZoomScale);
            }
        }

        void SetZoom(int ZoomScale)
        {
            if (ZoomScale.Equals(100))
            {
                IsZoomOn = false;
                PanelImage.Dock = DockStyle.Fill;
            }
            else
            {
                IsZoomOn = true;
                PanelImage.Dock = DockStyle.None;

                PanelImage.Width = (ZoomScale * bitmap.Width) / 100;
                PanelImage.Height = (ZoomScale * bitmap.Height) / 100;
            }
        }

    }
}
