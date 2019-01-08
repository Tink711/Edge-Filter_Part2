using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edge_and_Filter
{
    public interface InterfaceInput
    {
        //Retrieve image from computer folder
        Bitmap LoadImage();
        //Resize the picture for the pictureBox on the windows form
        Bitmap CopyToSquareCanevas(Bitmap sourceBitmap, int canvasWidhtLength);
    }
}
