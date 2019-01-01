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
        Bitmap CrazyFilter(Bitmap bmp);
    }
}
