using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace HoiPolloi.Drawing
{
    public static class ImageExtensions
    {
        public static byte[] ToByteArray(this Image image, ImageFormat imageFormat)
        {
            if(image == null) throw new ArgumentNullException("image");

            using (var byteStream = new MemoryStream())
            {
                image.Save(byteStream, imageFormat);
                return byteStream.ToArray();
            }
        }
    }
}
