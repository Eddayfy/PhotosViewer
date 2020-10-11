using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhotosViewer
{
    public partial class PhotosViewer : Form
    {
        private readonly List<string> ImagePathDirectory = new List<string>();
        private int PictureIndex = 0;
        private bool IsZoomOn = false;
        private float PictureScale = 1.0f;
        private int PictureWidth;
        private int PictureHeight;

        public PhotosViewer()
        {
            InitializeComponent();
        }

        public PhotosViewer(string[] Args)
        {
            InitializeComponent();

            foreach (string file in Args)
            {
                if (IsValideImageFormat(file))
                {
                    ImagePathDirectory.Add(file);
                }
            }

            if (ImagePathDirectory.Count != 0)
                InitializeTheImage(ImagePathDirectory[PictureIndex]);
        }

        private void InitializeTheImage(string path)
        {
            if (IsValideImageFormat(path))
            {
                if (path.EndsWith(".gif"))
                {
                    PictureBox.Image = Image.FromFile(path);
                    PictureBox.Visible = true;
                    ImagePanel.BackgroundImage = null;

                    PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    PictureBox.Image = null;
                    PictureBox.Visible = false;

                    Bitmap Bitmap = new Bitmap(path);

                    int Width = Bitmap.Width, Height = Bitmap.Height;

                    if (Width > ImagePanel.Width)
                        Width = ImagePanel.Width;

                    if (Height > ImagePanel.Height)
                        Height = ImagePanel.Height;

                    Bitmap = new Bitmap(Image.FromFile(path), Width, Height);

                    ImagePanel.BackgroundImage = Bitmap;

                    PictureWidth = Width;
                    PictureHeight = Height;
                }

                AdjustNextAndPreviousPanel();

                this.Text = Path.GetFileName(path) + " - Photos Viewer";
            }
        }

        private bool IsValideImageFormat(string path)
        {
            if (Path.GetExtension(path) == ".jpg" || Path.GetExtension(path) == ".jpeg" || Path.GetExtension(path) == ".png"
                || Path.GetExtension(path) == ".bmp" || Path.GetExtension(path) == ".gif" || Path.GetExtension(path) == ".ico")
                return true;
            else
                return false;
        }

        private void NextPanel_Click(object sender, EventArgs e)
        {
            if (PictureIndex < ImagePathDirectory.Count - 1)
                InitializeTheImage(ImagePathDirectory[++PictureIndex]);
        }

        private void PreviousPanel_Click(object sender, EventArgs e)
        {
            if (PictureIndex > 0)
                InitializeTheImage(ImagePathDirectory[--PictureIndex]);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog
            {
                Title = "Open your Image",
                Multiselect = false,
                Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp; *.gif; *.ico"
            };

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                ImagePathDirectory.Clear();
                ImagePathDirectory.Add(OFD.FileName);
                PictureIndex = 0;

                InitializeTheImage(ImagePathDirectory[PictureIndex]);
            }
        }

        private void PhotosViewer_DragEnter(object sender, DragEventArgs e)
        {
            string[] FilesDroped = (string[])e.Data.GetData(DataFormats.FileDrop);
            bool ValidPath = true;

            foreach (string FileDroped in FilesDroped)
            {
                if (!IsValideImageFormat(FileDroped))
                {
                    ValidPath = false;
                    break;
                }
            }

            if (ValidPath)
                e.Effect = DragDropEffects.All;
        }

        private void PhotosViewer_DragDrop(object sender, DragEventArgs e)
        {
            ImagePathDirectory.Clear();
            PictureIndex = 0;

            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                if (IsValideImageFormat(file))
                    ImagePathDirectory.Add(file);
            }

            if (ImagePathDirectory.Count != 0)
                InitializeTheImage(ImagePathDirectory[PictureIndex]);
        }

        private void GetOtherPictures(string path)
        {
            ImagePathDirectory.Clear();
            ImagePathDirectory.Add(path);
            PictureIndex = 0;

            string DirectoryPath = Path.GetDirectoryName(path);

            string[] FilesOnDirectory = Directory.GetFiles(DirectoryPath);

            foreach (string file in FilesOnDirectory)
            {
                if (IsValideImageFormat(file))
                {
                    if (file != path)
                        ImagePathDirectory.Add(file);
                }
            }

            AdjustNextAndPreviousPanel();
        }

        private void AdjustNextAndPreviousPanel()
        {
            if (!IsZoomOn)
            {
                if (ImagePathDirectory.Count > 1)
                {
                    if (PictureIndex == 0)
                    {
                        NextPanel.Visible = true;
                        PreviousPanel.Visible = false;
                    }
                    else if (PictureIndex == ImagePathDirectory.Count - 1)
                    {
                        NextPanel.Visible = false;
                        PreviousPanel.Visible = true;
                    }
                    else
                    {
                        NextPanel.Visible = true;
                        PreviousPanel.Visible = true;
                    }
                }
                else
                {
                    NextPanel.Visible = false;
                    PreviousPanel.Visible = false;
                }
            }
        }

        private void getOtherFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImagePathDirectory.Count != 0)
                GetOtherPictures(ImagePathDirectory[PictureIndex]);
        }

        private void ZoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ImagePathDirectory[PictureIndex].EndsWith(".gif"))
            {
                IsZoomOn = true;
                PictureScale += 1.0f;

                ImagePanel.Dock = DockStyle.None;
                NextPanel.Visible = false;
                PreviousPanel.Visible = false;

                if (PictureScale <= 6)
                {
                    Bitmap BitMap = new Bitmap(ImagePanel.BackgroundImage, (int)(PictureScale * PictureWidth), (int)(PictureScale * PictureHeight));
                    ImagePanel.Width = (int)(PictureScale * PictureWidth);
                    ImagePanel.Height = (int)(PictureScale * PictureHeight);
                    ImagePanel.BackgroundImage = BitMap;
                }
                else
                    PictureScale = 6.0f;
            }
        }

        private void ZoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ImagePathDirectory[PictureIndex].EndsWith(".gif"))
            {
                IsZoomOn = true;
                PictureScale -= 1.0f;

                if (PictureScale > 1)
                {
                    Bitmap Bitmap = new Bitmap(ImagePanel.BackgroundImage, (int)(PictureScale * PictureWidth), (int)(PictureScale * PictureHeight));
                    ImagePanel.Width = (int)(PictureScale * PictureWidth);
                    ImagePanel.Height = (int)(PictureScale * PictureHeight);
                    ImagePanel.BackgroundImage = Bitmap;
                }
                else
                {
                    IsZoomOn = false;
                    PictureScale = 1.0f;
                    ImagePanel.Dock = DockStyle.Fill;

                    InitializeTheImage(ImagePathDirectory[PictureIndex]);
                }
            }
        }

        private void CovertBackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImagePanel.BackColor == Color.Black)
                ImagePanel.BackColor = Color.White;
            else if (ImagePanel.BackColor == Color.White)
                ImagePanel.BackColor = Color.Black;
        }

        private void PhotosViewer_Resize(object sender, EventArgs e)
        {
            if (!IsZoomOn)
                InitializeTheImage(ImagePathDirectory[PictureIndex]);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhotosViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show(
                "You are about to close this App.\nAre you sure you want to Exit?",
                "Exit and Close this App?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (Result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void NewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CurrentEXEFilePath = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;

            Process.Start(CurrentEXEFilePath);
        }
    }
}
