using LTImageTools.ImageTools;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LTImageTools
{
    public partial class MainMenu : Form
    {
        ImageOperations imageOperations;

        public MainMenu()
        {
            InitializeComponent();
            imageOperations = new ImageOperations();
            CheckWorkingFoldersConfiguration();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImages();
        }

        private void LoadImages()
        {
            try
            {
                ImageFolderDialog.SelectedPath = Properties.Settings.Default.WorkingFolder;
                DialogResult dr = ImageFolderDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    imageOperations.DirectoryPath = ImageFolderDialog.SelectedPath;
                    imageOperations.LoadImages();
                    GridViewImages.DataSource = imageOperations.BindableFileContainer;
                    previewDecodedImage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void previewDecodedImage()
        {
            var index = Convert.ToInt32(GridViewImages.CurrentRow.Cells["Index"].Value);
            var FileContainer = imageOperations.ImageFilesContainer.Where(Q => Q.Index == index).First();
            var memStream = new MemoryStream(FileContainer.DecodedImage);
            pictureBoxDecodedView.Image = Image.FromStream(memStream);
        }

        private void GridViewImages_SelectionChanged(object sender, EventArgs e)
        {
            previewDecodedImage();
        }

        private void CheckWorkingFoldersConfiguration()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.WorkingFolder))
            {
                MessageBox.Show("Game folder path not set, pick Lost Technology folder", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult dr = ImageFolderDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Properties.Settings.Default.WorkingFolder = ImageFolderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.DecodedFolder))
            {
                MessageBox.Show("Decoded ouput folder not set, please set the decoded image output folder", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult dr = ImageFolderDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Properties.Settings.Default.DecodedFolder = ImageFolderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.EncodedFolder))
            {
                MessageBox.Show("Encoded ouput folder not set, please set the encoded image output folder", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult dr = ImageFolderDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Properties.Settings.Default.EncodedFolder = ImageFolderDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void GridViewImages_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (GridViewImages.Columns[e.ColumnIndex].HeaderText != "saveFile")
                e.Cancel = true;
        }

        private void decodeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageFileIO DecodeToDisk = new ImageFileIO();
                DecodeToDisk.Decode(imageOperations.ImageFilesContainer, Properties.Settings.Default.DecodedFolder);
                MessageBox.Show("Decoding all Images Complete");
            }
            catch
            {
                MessageBox.Show("An error ocurred writting to disk");
            }
        }

        private void encodeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageFileIO EncodeToDisk = new ImageFileIO();
                EncodeToDisk.Encode(imageOperations.ImageFilesContainer, Properties.Settings.Default.EncodedFolder);
                MessageBox.Show("Encoding all Images Complete");
            }
            catch
            {
                MessageBox.Show("An error ocurred writting to disk");
            }
        }

        private void encodeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewImages.EndEdit();
                var indexes = imageOperations.BindableFileContainer.Where(Q => Q.saveFile == true).Select(R => R.Index).ToList();
                var container = imageOperations.ImageFilesContainer.Where(Q => indexes.Contains(Q.Index)).ToList();
                ImageFileIO EncodeToDisk = new ImageFileIO();
                EncodeToDisk.Encode(container, Properties.Settings.Default.EncodedFolder);
                MessageBox.Show("Encoding all Images Complete");
            }
            catch
            {
                MessageBox.Show("An error ocurred writting to disk");
            }
        }

        private void decodeSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
                try
                {
                    GridViewImages.EndEdit();
                    var indexes = imageOperations.BindableFileContainer.Where(Q => Q.saveFile == true).Select(R => R.Index).ToList();
                    var container = imageOperations.ImageFilesContainer.Where(Q => indexes.Contains(Q.Index)).ToList();
                    ImageFileIO DecodeToDisk = new ImageFileIO();
                    DecodeToDisk.Decode(container, Properties.Settings.Default.EncodedFolder);
                    MessageBox.Show("Decoding all Images Complete");
                }
                catch
                {
                    MessageBox.Show("An error ocurred writting to disk");
                }
            }
    }
}