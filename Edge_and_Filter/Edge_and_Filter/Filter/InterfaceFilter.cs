using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edge_and_Filter
{
    public interface InterfaceFilter
    {
        //Apply the Rainbow filter
        Bitmap RainbowFilter(Bitmap bmp);
        //Apply the Crazy filter
        Bitmap ApplyFilterSwap(Bitmap bmp);
        //Divide the color green by 2
        Bitmap ApplyFilterSwapDivide(Bitmap bmp, int a, int r, int g, int b);
    }
}
