//using Mall.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Mall.Common;
using ThoughtWorks.QRCode.Codec;
using System.Drawing;

using System.Drawing.Imaging;
using System.IO;

namespace zamrud.BLL
{
    /// <summary>
    /// 二维码图片生成工具类
    /// </summary>
    public class QrCodeUtils
    {
        /// <summary>
        /// 生成各应用二维码图片
        /// </summary>
        /// <param name="CodeNum">二维码号</param>
        /// <param name="ImgPath">二维码图片存放相对路径，例 /Upload/1800/code/company/11100001800.png</param>
        /// <returns></returns>
        public static bool GetQRCode(string CodeNum, string ImgPath)
        {
            bool result = false;
            try
            {
                //string jumpRootUrl = GeneralConfigs.GetConfig().JumpRootUrl.EndsWith("/") ? GeneralConfigs.GetConfig().JumpRootUrl : GeneralConfigs.GetConfig().JumpRootUrl + "/";
                //string text = jumpRootUrl + CodeNum;
                //string DirPath = Utils.GetMapPath(ImgPath.Substring(0, ImgPath.IndexOf(CodeNum + ".png")));
                //string filepath = Utils.GetMapPath(ImgPath);
                //if (!Directory.Exists(DirPath))
                //{
                //    Directory.CreateDirectory(DirPath);
                //}
                //CreateQrCodeWithBottom(text, filepath);
                result = true;
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("二维码图片生成失败***********************" + DateTime.Now.ToString("HH：mm：ss"));
                sb.Append("二维码号：");
                sb.Append(CodeNum);
                sb.Append("二维码图片路径");
                sb.Append(ImgPath);
                sb.AppendLine("error 详情:");
                sb.AppendLine(ex.ToString());
                sb.AppendLine();
                //ClsSiteUtils.WriteLog(sb.ToString(), 1);
            }
            return result;
        }

        /// <summary>
        /// 创建带白色底图的二维码图片
        /// </summary>
        /// <param name="text">二维码图片内信息</param>
        /// <param name="file">二维码图片路径</param>
        public static void CreateQrCodeWithBottom(string text, string file)
        {
            CreateQrCodeImg(text, file);
            //using (Image img = Image.FromFile(Utils.GetMapPath("/upload/InvitationCode/white.jpg")))
            //{
            //    using (Graphics g = Graphics.FromImage(img))
            //    {
            //        using (Image qrcode = new Bitmap(file)) //读取二维码图
            //        {
            //            //合成
            //            g.DrawImage(qrcode, new Point(20, 20));
            //        }
            //    }
            //    img.Save(file);
            //}
        }

        /// <summary>
        /// 创建临时二维码图片（保存通讯录、vcard）
        /// </summary>
        /// <param name="text">二维码图片内信息</param>
        /// <param name="file">二维码图片路径</param>
        public static void CreateTempQrCode(string text, string file)
        {
            QRCodeEncoder qrencoder = new QRCodeEncoder();
            qrencoder.QRCodeEncodeMode = EncodeMode;
            qrencoder.QRCodeVersion = 0;
            qrencoder.QRCodeScale = CodeScale;
            qrencoder.QRCodeErrorCorrect = ErrorCorrection;
            CreateQrCodeImg(text, file, qrencoder);
        }

        /// <summary>
        /// 创建二维码图片
        /// </summary>
        /// <param name="text">二维码图片内信息</param>
        /// <param name="file">二维码图片路径</param>
        public static void CreateQrCodeImg(string text, string file)
        {
            QRCodeEncoder qrencoder = new QRCodeEncoder();
            qrencoder.QRCodeEncodeMode = EncodeMode;
            qrencoder.QRCodeVersion = CodeVersion;
            qrencoder.QRCodeScale = CodeScale;
            qrencoder.QRCodeErrorCorrect = ErrorCorrection;
            CreateQrCodeImg(text, file, qrencoder);
        }


        /// <summary>
        /// 创建二维码图片
        /// </summary>
        /// <param name="text">二维码图片内信息</param>
        /// <param name="file">二维码图片路径</param>
        /// <param name="qrencoder">QR码设置参数</param>
        public static void CreateQrCodeImg(string text, string file, QRCodeEncoder qrencoder)
        {
            using (Bitmap map = qrencoder.Encode(text, Encoding.UTF8))
            {
                map.Save(file, ImageFormat.Png);
            }
        }

        #region QR码设置方法



        /// <summary>
        /// 二维码图片纠错级别L, M, Q, H，默认为L
        /// </summary>
        internal static QRCodeEncoder.ERROR_CORRECTION ErrorCorrection
        {
            get
            {
                try
                {
                    //return (QRCodeEncoder.ERROR_CORRECTION)Enum.Parse(typeof(QRCodeEncoder.ERROR_CORRECTION),
                    //                                        GeneralConfigs.GetConfig().Errorcorrection);
                    return QRCodeEncoder.ERROR_CORRECTION.L;

                }
                catch
                {
                    return QRCodeEncoder.ERROR_CORRECTION.L;
                }
            }
        }

        /// <summary>
        /// 二维码图片编码方式，默认为BYTE  
        /// </summary>
        internal static QRCodeEncoder.ENCODE_MODE EncodeMode
        {
            get
            {
                try
                {
                    //return (QRCodeEncoder.ENCODE_MODE)Enum.Parse(typeof(QRCodeEncoder.ENCODE_MODE),
                    //                                        GeneralConfigs.GetConfig().Encodemode);
                    return QRCodeEncoder.ENCODE_MODE.BYTE;
                }
                catch
                {
                    return QRCodeEncoder.ENCODE_MODE.BYTE;
                }
            }
        }

        /// <summary>
        /// 二维码图片版本，默认为1
        /// </summary>
        internal static int CodeVersion
        {
            get
            {
                try
                {
                    //return int.Parse(GeneralConfigs.GetConfig().Codeversion);
                    return 1;
                }
                catch
                {
                    return 1;
                }
            }
        }

        /// <summary>
        /// 二维码图片大小，默认为7
        /// </summary>
        internal static int CodeScale
        {
            get
            {
                try
                {
                    //return int.Parse(GeneralConfigs.GetConfig().Codescale);
                    return 7;
                }
                catch
                {
                    return 7;
                }
            }
        }

        #endregion
    }

}
