using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Edge_and_Filter;
using System.Drawing;

namespace EdgeAndFilterTest
{

    [TestClass]
    public class InputOutputTest
    {
        public InputOutputTest()
        {

        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        //==============================================================
        //COPY TO SQUARE CANVAS
        //==============================================================
       
        //Test when sending a bitmap with superior width that canvas and height
        [TestMethod]
        public void TestCopyToSquareCanvasWithWidthGreaterThatCanvasAndHeight()
        {
            var inputInterface = Substitute.For<ManagerInputOutput>();           

            //Initialize sizes
            float bpmHeight = 200f;
            float bpmWidth = 1000f;
            int canvasSize = 400;

            //Determine the ratio for expected results
            float ratio = bpmWidth / canvasSize;

            //Send bitmap with height, width and canvas to tested method
            Bitmap bpmAfterMethodCanvas = inputInterface.CopyToSquareCanevas(new Bitmap((int)bpmWidth, (int)bpmHeight), canvasSize);

            //All expected sizes
            float bpmWidthExpected = canvasSize;
            float bpmHeightExpected = bpmHeight / ratio;
            //Tested sizes
            float widthResult = (float)bpmAfterMethodCanvas.Width;
            float heigthResult = (float)bpmAfterMethodCanvas.Height;
            //Compare values
            Assert.AreEqual(bpmWidthExpected, widthResult);
            Assert.AreEqual(bpmHeightExpected, heigthResult);

        }

        //Test when sending a bitmap with superior height that canvas and width
        [TestMethod]
        public void TestCopyToSquareCanvasWithHeightGreaterThatCanvasAndWidth()
        {
            var inputInterface = Substitute.For<ManagerInputOutput>();

            //Initialize sizes
            float bpmHeight = 400f;
            float bpmWidth = 200f;
            int canvasSize = 100;

            //Determine the ratio for expected results
            float ratio = bpmHeight / canvasSize;

            //Send bitmap with height, width and canvas to tested method
            Bitmap bpmAfterMethodCanvas = inputInterface.CopyToSquareCanevas(new Bitmap((int)bpmWidth, (int)bpmHeight), canvasSize);

            //All expected sizes
            float bpmWidthExpected = bpmWidth / ratio;
            float bpmHeightExpected = canvasSize;
            //Tested sizes
            float widthResult = (float)bpmAfterMethodCanvas.Width;
            float heigthResult = (float)bpmAfterMethodCanvas.Height;
            //Compare values
            Assert.AreEqual(bpmWidthExpected, widthResult);
            Assert.AreEqual(bpmHeightExpected, heigthResult);

        }

        //Test when sending a bitmap with hight and width same size as the canvas
        [TestMethod]
        public void TestCopyToSquareCanvasWithAllSameSize()
        {
            
            var inputInterface = Substitute.For<ManagerInputOutput>();

            //Initialize sizes
            float bpmHeight = 200f;
            float bpmWidth = 200f;
            int canvasSize = 200;

            //Determine the ratio for expected results
            float ratio = bpmWidth / canvasSize;

            //Send bitmap with height, width and canvas to tested method
            Bitmap bpmAfterMethodCanvas = inputInterface.CopyToSquareCanevas(new Bitmap((int)bpmWidth, (int)bpmHeight), canvasSize);

            //All expected sizes
            float bpmWidthExpected = canvasSize;
            float bpmHeightExpected = bpmHeight / ratio;
            //Tested sizes
            float widthResult = (float)bpmAfterMethodCanvas.Width;
            float heigthResult = (float)bpmAfterMethodCanvas.Height;
            //Compare values
            Assert.AreEqual(bpmWidthExpected, widthResult);
            Assert.AreEqual(bpmHeightExpected, heigthResult);

        }

        //Test when sending a bitmap with canvas smaller that height and width (both same size)
        [TestMethod]
        public void TestCopyToSquareCanvasWithSamllerCanvas()
        {
            var inputInterface = Substitute.For<ManagerInputOutput>();

            //Initialize sizes
            float bpmHeight = 200f;
            float bpmWidth = 200f;
            int canvasSize = 100;

            //Determine the ratio for expected results
            float ratio = bpmWidth / canvasSize;

            //Send bitmap with height, width and canvas to tested method
            Bitmap bpmAfterMethodCanvas = inputInterface.CopyToSquareCanevas(new Bitmap((int)bpmWidth, (int)bpmHeight), canvasSize);

            //All expected sizes
            float bpmWidthExpected = canvasSize;
            float bpmHeightExpected = bpmHeight / ratio;
            //Tested sizes
            float widthResult = (float)bpmAfterMethodCanvas.Width;
            float heigthResult = (float)bpmAfterMethodCanvas.Height;
            //Compare values
            Assert.AreEqual(bpmWidthExpected, widthResult);
            Assert.AreEqual(bpmHeightExpected, heigthResult);

        }


        //==============================================================
        //LOAD IMAGE
        //==============================================================

        //Need to Load the image "egypt.jpg inside the folder "EdgeAndFilterTest/bin/Debug/images"
        [TestMethod]
        public void TestLoadImageFromComputer()
        {
            var inputInterface = Substitute.For<ManagerInputOutput>();

            Bitmap orginalBitmap = RetrieveImage.RetrieveOriginalPicture();
            Bitmap bitmapToLoadBeforeCopyToSquare = inputInterface.LoadImage();
            Bitmap bitmapToLoadAfterCopyToSquare = inputInterface.CopyToSquareCanevas(bitmapToLoadBeforeCopyToSquare, 900);

            Assert.IsTrue(RetrieveImage.Equals(orginalBitmap, bitmapToLoadAfterCopyToSquare));

        }

        //==============================================================
        //SAVE IMAGE
        //==============================================================

        //Testing the jpg format. Need to save under the name "TestJPEG.jpg"  in the folder "EdgeAndFilterTest/bin/Debug/images"
        [TestMethod]
        public void TestSaveImageToComputerFormatJPEG()
        {
            //Substitute for ManagerInputOuput
            var outputInterface = Substitute.For<ManagerInputOutput>();

            Bitmap originalBitmapToTest = RetrieveImage.RetrieveImageFromPath("egyptJPEG.jpg");
        
            //Name the to be saved image "TestJPEG.jpg"
            outputInterface.SaveImage(originalBitmapToTest);

            Bitmap savedBitmap = RetrieveImage.RetrieveImageFromPath("TestJPEG.jpg");

            Assert.IsTrue(RetrieveImage.Equals(originalBitmapToTest, savedBitmap));

        }

        //Testing the png format. Need to save under the name "TestPNG.png"  in the folder "EdgeAndFilterTest/bin/Debug/images"
        [TestMethod]
        public void TestSaveImageToComputerFormatPNG()
        {
            //Substitute for ManagerInputOuput
            var outputInterface = Substitute.For<ManagerInputOutput>();

            Bitmap originalBitmapToTest = RetrieveImage.RetrieveImageFromPath("egyptPNG.png");

            //Name the to be saved image "TestPNG.png"
            outputInterface.SaveImage(originalBitmapToTest);

            Bitmap savedBitmap = RetrieveImage.RetrieveImageFromPath("TestPNG.png");

            Assert.IsTrue(RetrieveImage.Equals(originalBitmapToTest, savedBitmap));
        }

        //Testing the bmp format. Need to save under the name "TestBMP.bmp"  in the folder "EdgeAndFilterTest/bin/Debug/images"
        [TestMethod]
        public void TestSaveImageToComputerFormatBMP()
        {
            //Substitute for ManagerInputOutput
            var outputInterface = Substitute.For<ManagerInputOutput>();

            Bitmap originalBitmapToTest = RetrieveImage.RetrieveImageFromPath("egyptBMP.bmp");

            //Name the to be saved image "TestBPM.bmp"
            outputInterface.SaveImage(originalBitmapToTest);

            Bitmap savedBitmap = RetrieveImage.RetrieveImageFromPath("TestBMP.bmp");

            Assert.IsTrue(RetrieveImage.Equals(originalBitmapToTest, savedBitmap));
        }

    }
}
