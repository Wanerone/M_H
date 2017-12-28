using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class CheckCode : System.Web.UI.Page
    {
        private string RndNum()                             //随机生成验证码
        {
            int number;
            char code;
            string checkCode = String.Empty;                //表示空字符串。 此字段为只读。
            System.Random random = new Random();            //表示伪随机数生成器，一种能够产生满足某些随机性统计要求的数字序列的设备。
            for (int i = 0; i < 4; i++)
            {
                number = random.Next();                     //返回非负随机数。
                if (number % 2 == 0)
                    code = (char)('0' + (char)(number % 10));
                else
                    code = (char)('A' + (char)(number % 26));
                checkCode += code.ToString();
            }
            Session["CheckCode"] = checkCode;
            return checkCode;
        }

        private void CreateCheckCodeImage(string checkCode)//将验证码生成图片
        {

            if (checkCode == null || checkCode.Trim() == String.Empty)
                return;
            System.Drawing.Bitmap image = new System.Drawing.Bitmap((int)Math.Ceiling(checkCode.Length * 12.5), 22);

            //封装 GDI+ 位图，此位图由图形图像及其属性的像素数据组成。Bitmap 是用于处理由像素数据定义的图像的对象。
            //Ceiling(Decimal)    返回大于或等于指定的十进制数的最小整数值。
            //Ceiling(Double)    返回大于或等于指定的双精度浮点数的最小整数值。

            Graphics g = Graphics.FromImage(image);

            //Graphics.FromImage从指定的 Image 创建新的 Graphics。
            //Graphics 类 封装一个 GDI+ 绘图图面。此类不能被继承。Graphics 类提供将对象绘制到显示设备的方法。
            //使用 FromImage 方法从图像创建 Graphics 对象.

            try
            {
                Random random = new Random();
                g.Clear(Color.White);

                //Clear    清除整个绘图面并以指定背景色填充。

                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);//返回大于等于零且小于 MaxValue 的 32 位带符号整数。
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);

                    //DrawLine(Pen, Int32, Int32, Int32, Int32)    绘制一条连接由坐标对指定的两个点的线条。
                    //DrawLine(Pen, Single, Single, Single, Single)    绘制一条连接由坐标对指定的两个点的线条。
                    //Pen，它确定线条的颜色、宽度和样式。

                }
                Font font = new System.Drawing.Font("Arial", 12, (System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic));
                System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2f, true);

                //LinearGradientBrush 类使用线性渐变封装 Brush。 无法继承此类。
                //LinearGradientBrush(Rectangle, Color, Color, Single, Boolean)根据矩形、起始颜色和结束颜色以及方向角度，创建 LinearGradientBrush 类的新实例。
                //一个 Rectangle 结构，它指定线性渐变的界限。

                g.DrawString(checkCode, font, brush, 2, 2);

                //DrawString(String, Font, Brush, Single, Single)    在指定位置并且用指定的 Brush 和 Font 对象绘制指定的文本字符串。
                //Brush定义用于填充图形形状（如矩形、椭圆、饼形、多边形和封闭路径）的内部的对象。
                //Font定义特定的文本格式，包括字体、字号和字形属性。此类不能被继承。
                //所绘制文本的左上角的 x 坐标。所绘制文本的左上角的 y 坐标。

                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));

                    //Bitmap .SetPixel 方法获取此 Bitmap 中指定像素的颜色。
                    //Color .FromArgb 方法基于四个 8 位 ARGB 分量（alpha、红色、绿色和蓝色）值创建 Color 结构。

                }
                g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);

                //DrawRectangle(Pen, Single, Single, Single, Single)    绘制由坐标对、宽度和高度指定的矩形。

                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                //MemoryStream 类创建其支持存储区为内存的流。
                //MemoryStream 类创建一个流，该流使用内存作为后备存储而不是磁盘或网络连接。 
                //MemoryStream 封装作为无符号字节数组存储的数据，该数组在创建 MemoryStream 对象时进行初始化，或可创建空数组。 
                //可在内存中直接访问这些封装的数据。内存流可降低应用程序中对临时缓冲区和临时文件的需要。

                image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                //Bitmap .Save 方法将此图像以指定的格式保存到指定的流中。
                //Image .Save 方法 (Stream, ImageFormat)将此图像以指定的格式保存到指定的流中。

                Response.ClearContent();
                //HttpResponse .ClearContent 方法清除缓冲区流中的所有内容输出。
                Response.ContentType = "image/Gif";
                //HttpResponse .ContentType 属性获取或设置输出流的 HTTP MIME 类型。
                Response.BinaryWrite(ms.ToArray());
                //HttpResponse .BinaryWrite 方法将一个二进制字符串写入 HTTP 输出流。
            }
            finally
            {
                g.Dispose();//Dispose    释放由 Graphics 使用的所有资源。
                image.Dispose();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.CreateCheckCodeImage(RndNum());
        }
    }
}