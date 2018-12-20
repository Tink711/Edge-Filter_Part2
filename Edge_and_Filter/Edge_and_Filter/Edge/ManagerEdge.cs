using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edge_and_Filter
{
    class ManagerEdge : InterfaceEdge
    {
        //Apply the filters(calculation of the colors)
        public Bitmap ConvultionFilter(Bitmap SourceBitmap, double[,] filterMatrix, double factor = 1, int bias = 0, bool grayscale = false)
        {
            throw new NotImplementedException();
        }
        //Retrive the matrix of Lalpacian3x3 and run the method ConvultionFilter to apply this filter
        public Bitmap Lalpacian3x3(Bitmap sourceBitmap, bool grayscale = true)
        {
            throw new NotImplementedException();
        }
        //Retrive the matrix of Lalpacian5x5 and run the method ConvultionFilter to apply this filter
        public Bitmap Lalpacian5x5(Bitmap sourceBitmap, bool grayscale = true)
        {
            throw new NotImplementedException();
        }
    }
}
