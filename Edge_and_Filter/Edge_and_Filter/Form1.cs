﻿using System;
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
        InterfaceFilter filter = new ManagerFilter();
        InterfaceEdge edge = new ManagerEdge();

        Bitmap originalBitmap = null;
        Bitmap middleBitmap = null;
        Bitmap resultBitmap = null;

        Boolean filterIsApplied = false;
        Boolean edgeIsApplied = false;


        public Form1()
        {
            //initialize the form
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Used for the unit tests
        public int GetWidthPictureBox()
        {
            return PreviewPictureBox.Width;
        }
        //Load image button
        private void LoadButton_Click(object sender, EventArgs e)
        {
            //get picture and copyToSquareCanvas
            originalBitmap = input.LoadImage();
            middleBitmap = originalBitmap;
            PutImageBackToOriginal();
        } 
        //Apply the Rainbow filter
        private void RainbowButton_Click(object sender, EventArgs e)
        {
            if (edgeIsApplied)
            {
                DisplayCannotDoFilterAfterEdge();
            }
            else
            {
                //calls manager for rainbow filter
                PutImageBackToOriginal();
                middleBitmap = filter.RainbowFilter(new Bitmap(middleBitmap));
                PreviewPictureBox.Image = middleBitmap;
                filterIsApplied = true;
            }
        }
        //Apply the Crazy filter
        private void CrazyButton_Click(object sender, EventArgs e)
        {
            if (edgeIsApplied)
            {
                DisplayCannotDoFilterAfterEdge();
            }
            else
            {
                //calls manager for Crazy filter
                PutImageBackToOriginal();
                middleBitmap = filter.CrazyFilter(new Bitmap(middleBitmap));
                PreviewPictureBox.Image = middleBitmap;
                filterIsApplied = true;
            }
        }
        //Edges only if filters applied before
        //Apply laplacian 3x3 edge detection
        private void Laplacian3x3Button_Click(object sender, EventArgs e)
        {
            if (!filterIsApplied)
            {
                DisplayCannotDoEdgeBeforeFiltering();
            }
            else
            {
                //calls manager for Laplacian 3x3 edge        
                putImageBackToAfterFilter();
                resultBitmap = edge.Lalpacian3x3(new Bitmap(resultBitmap));
                PreviewPictureBox.Image = resultBitmap;
                edgeIsApplied = true;
            }
        }
        //Apply laplacian 5x5 edge detection
        private void Laplacian5x5Button_Click(object sender, EventArgs e)
        {
            if (!filterIsApplied)
            {
                DisplayCannotDoEdgeBeforeFiltering();
            }
            else
            {
                //calls manager for Laplacian 5x5 edge 
                putImageBackToAfterFilter();
                resultBitmap = edge.Lalpacian5x5(new Bitmap(resultBitmap));
                PreviewPictureBox.Image = resultBitmap;
                edgeIsApplied = true;
            }
        }
        //Save button only if filter and edge applied
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!edgeIsApplied)
            {
                MessageBox.Show("Please add a filter and an edge!");
            }
            else
            {
                //save picture
                MessageBox.Show("If you cancel, your image will be reset anyways!");
                output.SaveImage(resultBitmap);
                ResetImageToOriginal();
            }
           
        }
        //Displays a dialog to notify the user that he needs to use a filter before doing edge detection
        private void DisplayCannotDoEdgeBeforeFiltering()
        {
            MessageBox.Show("Before you can apply the edge detection you need to add a filter!");
        }

        //Displays a dialog to notify the user that he needs to use a filter before doing edge detection
        private void DisplayCannotDoFilterAfterEdge()
        {
            MessageBox.Show("You cannot apply a filter after an Edge Detection!");
        }

        //put the image to the orignal picture
        private void PutImageBackToOriginal()
        {
            middleBitmap = input.CopyToSquareCanevas(originalBitmap, PreviewPictureBox.Width);
            PreviewPictureBox.Image = middleBitmap;
        }
        //put the image to the after filter state
        private void putImageBackToAfterFilter()
        {
            resultBitmap = input.CopyToSquareCanevas(middleBitmap, PreviewPictureBox.Width);
            PreviewPictureBox.Image = resultBitmap;
        }
        //reset the image with the original image
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetImageToOriginal(); 
        }
        //Clears all filters and edges to put back to the original image
        private void ResetImageToOriginal()
        {
            middleBitmap = originalBitmap;
            resultBitmap = originalBitmap;
            PutImageBackToOriginal();
            //PreviewPictureBox.Image = originalBitmap;
            filterIsApplied = false;
            edgeIsApplied = false;
        }

    }
}
