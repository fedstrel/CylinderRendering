using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Laba_2
{
    public class BitmapWrapper
    {
        byte[] bmp;
        System.Drawing.Imaging.BitmapData bmpData;
        public BitmapWrapper()
        {

        }
        public BitmapWrapper(Bitmap img)
        {
            Rectangle frame = new Rectangle(0, 0, img.Width, img.Height);
            bmpData = img.LockBits(frame, System.Drawing.Imaging.ImageLockMode.ReadWrite, img.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            bmp = new byte[bmpData.Stride * bmpData.Height];
            Marshal.Copy(ptr, bmp, 0, bmpData.Stride * bmpData.Height);
        }
        public Bitmap getBitmap(Bitmap img)
        {
            Marshal.Copy(bmp, 0, bmpData.Scan0, bmpData.Stride * bmpData.Height);
            img.UnlockBits(bmpData);
            return img;
        }
        public Vector3 getPixel(int x, int y)
        {
            int pos = y * bmpData.Stride + x * 4;
            return new Vector3(bmp[pos], bmp[pos + 1], bmp[pos + 2]);
        }
        public void setPixel(int x, int y, Vector3 color)
        {
            int pos = y * bmpData.Stride + x * 4;
            bmp[pos] = (byte)color.Z;
            bmp[pos + 1] = (byte)color.Y;
            bmp[pos + 2] = (byte)color.X;
            bmp[pos + 3] = 255;
        }
    }
}
