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
    public class FilterTest
    {
        public FilterTest()
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


        //Testing the Rainsbow filter by applying the filter on a bitmap and comparing with one that has the expected result
        [TestMethod]
        public void RainbowFilterTestOutputPicture()
        {
            //Substitute for the managerFilter
            var filterInterface = Substitute.For<ManagerFilter>();

            Bitmap originalBitmap = RetrieveImage.RetrieveOriginalPicture();
            Bitmap bitmapForVerification = RetrieveImage.RetrieveImageFromPath("Rainbow.jpg");
            Bitmap filteredBitmap = filterInterface.RainbowFilter(new Bitmap(originalBitmap));

            Assert.IsTrue(RetrieveImage.Equals(bitmapForVerification, filteredBitmap));
        }
        //Testing the Crazy filter by applying the filter on a bitmap and comparing with one that has the expected result
        [TestMethod]
        public void CrazyFilterTestOutputPicture()
        {
            //Substitute for the ManagerFilter
            var filterInterface = Substitute.For<ManagerFilter>();

            Bitmap originalBitmap = RetrieveImage.RetrieveOriginalPicture();
            Bitmap bitmapForVerification = RetrieveImage.RetrieveImageFromPath("Crazy.jpg");
            Bitmap filteredBitmap = filterInterface.CrazyFilter(new Bitmap(originalBitmap));

            Assert.IsTrue(RetrieveImage.Equals(bitmapForVerification, filteredBitmap));
        }
        //Testing with an image with less that 4 pixels with the Rainbow filter and expecting to receive the same image that we sent
        [TestMethod]
        public void TestIfImageWidthIsSmallerThan4Pixels()
        {
            //Substitute for the ManagerFilter
            var filterInterface = Substitute.For<ManagerFilter>();

            Bitmap originalBitmap = RetrieveImage.RetrieveOriginalPicture();

            Bitmap testBitmap = new Bitmap(3, originalBitmap.Height);
            Bitmap receivedAfterTest = filterInterface.RainbowFilter(testBitmap);
            Assert.AreEqual(testBitmap, receivedAfterTest);
        }
        //Test
        [TestMethod]
        public void TestColorIfWidthNotDisibleBy4()
        {
            var filterInterface = Substitute.For<ManagerFilter>();

            Bitmap originalBitmap = RetrieveImage.RetrieveOriginalPicture();

            //Create the bitmap that will be sent to the filter
            Bitmap testBitmap = new Bitmap(99, originalBitmap.Height);
            //Create the bitmap that will be colored with the supplement color
            Bitmap unifiedTestBitmapColor = new Bitmap(99, originalBitmap.Height);

            //Color the full picture with the default supplemant color for external pixels
            for (int i = 0; i < testBitmap.Width; i++)
            {
                for (int x = 0; x < testBitmap.Height; x++)
                {
                    unifiedTestBitmapColor.SetPixel(i, x, Color.FromArgb(testBitmap.GetPixel(i, x).R / 5, testBitmap.GetPixel(i, x).G / 5, testBitmap.GetPixel(i, x).B / 5));
                }
            }
            //send the testBitmap to the filter
            Bitmap receivedAfterTest = filterInterface.RainbowFilter(testBitmap);
            //Determine the pixel to compare
            int pixelToCheck = testBitmap.Width - 1;
            //Compare pixel
            Assert.AreEqual(unifiedTestBitmapColor.GetPixel(pixelToCheck, 1), receivedAfterTest.GetPixel(pixelToCheck, 1));
        }


    }
}
