using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edge_and_Filter
{
    interface InterfaceInput
    {
        //Retrive image from computer folder
        Bitmap LoadImage();
        //Put the image in the windows form pictureBox
        void LoadToPreview(Bitmap imagePreview);
    }
}
