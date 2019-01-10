using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edge_and_Filter
{
    public class ManagerFilter : InterfaceFilter
    {
        //Apply the colors
        public Bitmap ApplyFilterSwap(Bitmap bmp)
        {
            try
            {
                Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int x = 0; x < bmp.Height; x++)
                    {
                        Color c = bmp.GetPixel(i, x);
                        Color cLayer = Color.FromArgb(c.A, c.G, c.B, c.R);
                        temp.SetPixel(i, x, cLayer);
                    }

                }
                return temp;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            
        }
        //Divide the color green by 2
        public Bitmap ApplyFilterSwapDivide(Bitmap bmp, int a, int r, int g, int b)
        {
            try
            {
                Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int x = 0; x < bmp.Height; x++)
                    {
                        Color c = bmp.GetPixel(i, x);
                        Color cLayer = Color.FromArgb(c.A / a, c.G / g, c.B / b, c.R / r);
                        temp.SetPixel(i, x, cLayer);
                    }

                }
                return temp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
           
        }
        //Apply the Crazy filter
        public Bitmap CrazyFilter(Bitmap bmp)
        {
            Bitmap changedBitmap = ApplyFilterSwapDivide(bmp, 1, 1, 2, 1);
            return ApplyFilterSwap(changedBitmap);
        }
        //Apply the Rainbow filter
        public Bitmap RainbowFilter(Bitmap bmp)
        {
            try
            {
                Bitmap temp = new Bitmap(bmp.Width, bmp.Height);
                int raz = bmp.Width / 4;

                //Check if the width is divisible by 4 and == 0
                if (raz == 0)
                {
                    return bmp;
                }


                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int x = 0; x < bmp.Height; x++)
                    {

                        if (i < (raz))
                        {
                            temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B));
                        }
                        else if (i < (raz * 2))
                        {
                            temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R, bmp.GetPixel(i, x).G / 5, bmp.GetPixel(i, x).B));
                        }
                        else if (i < (raz * 3))
                        {
                            temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B / 5));
                        }
                        else if (i < (raz * 4))
                        {
                            temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G, bmp.GetPixel(i, x).B / 5));
                        }
                        else
                        {
                            temp.SetPixel(i, x, Color.FromArgb(bmp.GetPixel(i, x).R / 5, bmp.GetPixel(i, x).G / 5, bmp.GetPixel(i, x).B / 5));
                        }
                    }

                }
                return temp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            
        }
    }
}
