using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace ImageDownsizer
{
    public partial class ImageDownsizer : Form
    {
        public ImageDownsizer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "File extensions|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    Image originalImage = Image.FromFile(imagePath);
                    picBoxOriginal.Image = originalImage;
                }
            }
        }

        private Image DownscaleImage(Image originalImage, double scaleFactor)
        {
            int newWidth = (int)(originalImage.Width * scaleFactor / 100);
            int newHeight = (int)(originalImage.Height * scaleFactor / 100);

            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double scaleFactor;
            if (double.TryParse(txtForDownscale.Text, out scaleFactor))
            {
                if (scaleFactor > 0 && scaleFactor <= 100)
                {
                    Image originalImage = picBoxOriginal.Image;
                    if (originalImage != null)
                    {
                        Stopwatch watch = new Stopwatch();
                        watch.Restart();

                        Image downscaledImage = DownscaleImage(originalImage, scaleFactor);
                        picBoxDownscaled.Image = downscaledImage;

                        watch.Stop();
                        string message = watch.ElapsedMilliseconds.ToString();
                        MessageBox.Show("Изминалото време е: " + message + " ms.");

                    }
                    else
                    {
                        MessageBox.Show("Please select an image.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter downscaling factor between 1 and 100.");
                }
            }
            else
            {
                MessageBox.Show("Invalid downscaling factor. Please enter a number between 1 and 100.");
            }
        }
    }
}