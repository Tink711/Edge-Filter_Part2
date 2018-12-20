using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edge_and_Filter
{
    interface InterfaceInput
    {
        //Retrive image from computer folder
        Bitmap LoadImage();
        //Put the image in the windows form pictureBox
        void LoadToPreview(PictureBox pictureBox, Bitmap imagePreview);
        //Resize the picture for the pictureBox on the windows form
        Bitmap CopyToSquareCanevas(Bitmap sourceBitmap, int canvasWidhtLength);
    }
}
