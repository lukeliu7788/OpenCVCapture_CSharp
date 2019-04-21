using System;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using OpenCVCapture.Model;

namespace OpenCVCapture
{
    public partial class CaptureForm : Form
    {
        public CaptureForm()
        {
            InitializeComponent();
        }

        private VideoCapture _capture;
        private string _folderPath;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Application.Idle += Streaming;
            _capture = new VideoCapture();
            _folderPath = AppDomain.CurrentDomain.BaseDirectory+"CaptureResult";
            tx_SavePath.Text = "Save Path: \r\n" + _folderPath;
        }

        private void Streaming(object sender, EventArgs e)
        {
            var img = _capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Bitmap;
            ptbSource.Image = bmp;
        }

        private void ptbSource_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            var img = _capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Bitmap;
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
            string savePath = _folderPath + @"\captureImg_" + dateTime.Ticks + ".png";
            img.Save(savePath);
            CaptureImageModel captureImageModel = new CaptureImageModel
            {
                SaveTime = dateTime,
                SavePath = savePath
            };
            SqliteDataAccess.SaveCaptureImage(captureImageModel);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
