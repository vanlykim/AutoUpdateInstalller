using SkiaSharp;
using System.Drawing;

namespace AutoUpdateInstalller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string inputPath = "D:\\tmp\\8\\_backup\\1.JPG";
            //string outputPath = "D:\\tmp\\8\\_backup\\1.JPG";
            //ImageResizer(inputPath, outputPath);
        }

        public void ImageResizer(string inputPath, string OutputPath)
        {
            int DesiredWidth = 1080, DesiredHeight = 1080;
            const int quality = 70;
            using (var input = File.OpenRead(inputPath))
            using (var inputStream = new SKManagedStream(input))
            using (var original = SKBitmap.Decode(inputStream))
            {
                using (var resized = original.Resize(new SKImageInfo(DesiredWidth, DesiredHeight), SKBitmapResizeMethod.Lanczos3))
                {
                    if (resized == null) return;
                    using (var image = SKImage.FromBitmap(resized))
                    using (var output = File.OpenWrite(OutputPath))
                    {
                        image.Encode(SKEncodedImageFormat.Jpeg, quality).SaveTo(output);
                    }
                }
            }
        }
    }
}
