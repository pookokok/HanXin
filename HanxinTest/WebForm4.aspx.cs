using Aspose.BarCode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HanxinTest
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int w =Convert.ToInt32(TextBox2.Text);
            int h = Convert.ToInt32(TextBox3.Text);
            string str = TextBox1.Value;
            lbl.InnerText = str.Length.ToString();
            //var aa = new ServiceReference1.FirmForTMTResponse();

            //create codetext
            QrExtCodetextBuilder lTextBuilder = new QrExtCodetextBuilder();
            lTextBuilder.AddFNC1FirstPosition();
            //lTextBuilder.AddPlainCodetext("000%89%%0");
            lTextBuilder.AddPlainCodetext(str);
            lTextBuilder.AddFNC1GroupSeparator();
            //lTextBuilder.AddPlainCodetext("12345<FNC1>");

            //generate codetext
            string lCodetext = lTextBuilder.GetExtendedCodetext();
            
            //generate
            BarCodeBuilder builder = new BarCodeBuilder();
            // set its Symbology
            builder.SymbologyType = Symbology.QR;
            // set encoding mode
            builder.QREncodeMode = QREncodeMode.ExtendedCodetext;
            // set error correction level
            builder.QRErrorLevel = QRErrorLevel.LevelL;
            // set code text
            builder.CodeText = lCodetext;
            // set display text
            //builder.Display2DText = "";

            builder.CodeLocation = Aspose.BarCode.CodeLocation.None;

            //builder.AutoSize = false;
            //builder.ImageHeight = 400;
            //builder.ImageWidth = 400;
            
            // get barcode image Bitmap
            Bitmap lBmp = builder.GenerateBarCodeImage();

            //Bitmap lBmp = builder.GetCustomSizeBarCodeImage(new Size(100, 100), true);
            //Bitmap lBmp = builder.GetOnlyBarCodeImage(1);
            Graphics g1 = Graphics.FromImage(lBmp);
            g1.FillRectangle(Brushes.White, new Rectangle(0, 0, lBmp.Width, 12));

            //Bitmap newlbmp = KiResizeImage(lBmp, w, h);
            // save QR code
            //newlbmp.Save(@"d:\test_qr.png", ImageFormat.Png);
            lBmp.Save(@"d:\test_qr.png", ImageFormat.Png);

        }


        public Bitmap GetThumbnail(Bitmap b, int destHeight, int destWidth)
        {
            System.Drawing.Image imgSource = b;
            System.Drawing.Imaging.ImageFormat thisFormat = imgSource.RawFormat;
            int sW = 0, sH = 0;
            // 按比例缩放           
            int sWidth = imgSource.Width;
            int sHeight = imgSource.Height;
            if (sHeight > destHeight || sWidth > destWidth)
            {
                if ((sWidth * destHeight) > (sHeight * destWidth))
                {
                    sW = destWidth;
                    sH = (destWidth * sHeight) / sWidth;
                }
                else
                {
                    sH = destHeight;
                    sW = (sWidth * destHeight) / sHeight;
                }
            }
            else
            {
                sW = sWidth;
                sH = sHeight;
            }
            Bitmap outBmp = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage(outBmp);
            g.Clear(Color.Transparent);
            // 设置画布的描绘质量         
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(imgSource, new Rectangle((destWidth - sW) / 2, (destHeight - sH) / 2, sW, sH), 0, 0, imgSource.Width, imgSource.Height, GraphicsUnit.Pixel);
            g.Dispose();
            // 以下代码为保存图片时，设置压缩质量     
            EncoderParameters encoderParams = new EncoderParameters();
            long[] quality = new long[1];
            quality[0] = 100;
            EncoderParameter encoderParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            encoderParams.Param[0] = encoderParam;
            imgSource.Dispose();
            return outBmp;
        }

        public static Bitmap KiResizeImage(Bitmap bmp, int newW, int newH, int Mode=0)
        {
            try
            {
                Bitmap b = new Bitmap(newW, newH);
                Graphics g = Graphics.FromImage(b);
                // 插值算法的质量
                //g.InterpolationMode = InterpolationMode.HighQualityBilinear;

                //设置高质量插值法   
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                //设置高质量,低速度呈现平滑程度   
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
                //消除锯齿 
                //g.SmoothingMode = SmoothingMode.HighSpeed; 

                g.DrawImage(bmp, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();
                return b;
            }
            catch
            {
                return null;
            }
        }

    }
}