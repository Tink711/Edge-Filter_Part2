using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edge_and_Filter;

namespace EdgeAndFilterTest
{
    public class RetrieveImage
    {
        public static Bitmap RetrieveOriginalPicture()
        {
            ManagerInputOutput manager = new ManagerInputOutput();
            return manager.CopyToSquareCanevas(RetrieveImageFromPath("egypt.jpg"), 900);
        }
        public static Bitmap RetrieveImageFromPath(string filename)
        {
            StreamReader streamReader = new StreamReader("images/"+filename);
            return (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
        }

        public static bool Equals(Bitmap bmp1, Bitmap bmp2)
        {
            if (!bmp1.Size.Equals(bmp2.Size))
            {
                return false;
            }
            for (int x = 0; x < bmp1.Width; ++x)
            {
                for (int y = 0; y < bmp1.Height; ++y)
                {
                    if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
