using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edge_and_Filter
{
    public partial class Form1 : Form
    {
        //Instanciation of all interfaces and managers
        InterfaceInput input = new ManagerInputOutput();
        InterfaceOutput output = new ManagerInputOutput();

        Bitmap originalBitmap = null;
        Bitmap previewBitmap = null;


        public Form1()
        {
            //initialize the form
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //get picture and copyToSquareCanvas
            originalBitmap = input.LoadImage();
            previewBitmap = input.CopyToSquareCanevas(originalBitmap, PreviewPictureBox.Width);
            PreviewPictureBox.Image = previewBitmap;

        }

        private void RainbowButton_Click(object sender, EventArgs e)
        {
            //calls manager for rainbow filter
        }

        private void CrazyButton_Click(object sender, EventArgs e)
        {
            //calls manager for Crazy filter
        }

        private void Laplacian3x3Button_Click(object sender, EventArgs e)
        {
            //calls manager for Laplacian 3x3 edge        }
        }

        private void Laplacian5x5Button_Click(object sender, EventArgs e)
        {
            //calls manager for Laplacian 5x5 edge 
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //save picture
        }
    }
}
