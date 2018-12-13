using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edge_and_Filter
{
    class ManagerInputOutput : InterfaceInput, InterfaceOutput
    {
        //Retrive image from computer folder
        public Bitmap LoadImage()
        {
            throw new NotImplementedException();
        }
        //Put the image in the windows form pictureBox
        public void LoadToPreview(Bitmap imagePreview)
        {
            throw new NotImplementedException();
        }
        //Save and export the final image
        public void SaveImage(Bitmap finalPicture)
        {
            throw new NotImplementedException();
        }
    }
}
