using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edge_and_Filter
{
    interface InterfaceEdge
    {
        //Apply the filters(calculation of the colors)
        Bitmap ConvultionFilter(Bitmap SourceBitmap, double[,] filterMatrix, double factor=1, int bias=0, bool grayscale=false);
        //Retrive the matrix of Lalpacian3x3 and run the method ConvultionFilter to apply this filter
        Bitmap Lalpacian3x3(Bitmap sourceBitmap, bool grayscale = true);
        //Retrive the matrix of Lalpacian5x5 and run the method ConvultionFilter to apply this filter
        Bitmap Lalpacian5x5(Bitmap sourceBitmap, bool grayscale = true);
    }
}
