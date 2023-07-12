using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompressProgram.Compress;

namespace CompressProgram
{
    public partial class Form1 : Form
    {
        private readonly CompressImage _compressImage;

        public Form1()
        {
            InitializeComponent();
            _compressImage = new CompressImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Png Images(*.png)|*.png";
            ofd.Filter += "|Tif Images(*.tif)|*.tif";

            ofd.Filter += "|All(*.JPG, *.PNG, *.bmp, *.tif)| *.JPG; *.PNG; *.bmp; *.tif";
            ofd.FilterIndex = 1;

            ListFiles.Items.Clear();

            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string tempFolder = System.IO.Path.GetTempPath();

                foreach (string fileName in ofd.FileNames)
                {
                    ListFiles.Items.Add($"{fileName}");
                }
            }
        }

        private async void BtnCompress_Click(object sender, EventArgs e)
        {

            if (ListFiles.Items.Count == 0)
            {
                MessageBox.Show("Debe de seleccionar al menos un archivo para reducir su tamaño");
            }

            var list = ListFiles.Items.Cast<string>().ToList();

            var pathSomeFile = list.FirstOrDefault();

            var absoluteSaveFilesPath = Path.GetDirectoryName(pathSomeFile);

            var dotIndex = 0;
            list.ForEach(async (filename)  =>
            {

                var pathSeparate = filename.Split('.').ToList();
                var fileExtension = pathSeparate.LastOrDefault();

                if (fileExtension.Length == 0) return;

                dotIndex = filename.IndexOf(fileExtension) - 1;

                var compressFilename = filename.Substring(0, dotIndex) + "_compress.jpg";

                await _compressImage.ApplyCompressedImage(Image.FromFile(filename), 10, compressFilename);
            });

            // ListFiles.Items.Clear();

            var processMessage = $"Archivos guardados en {absoluteSaveFilesPath}";
            const string title = "Proceso terminado";

            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            var result = MessageBox.Show(processMessage, title, buttons);

            if (result == DialogResult.Yes) {
                Process.Start("explorer.exe",absoluteSaveFilesPath);
            }
        }
    }
}
