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



        [TestMethod]
        public void RainbowFilterTestOutputPicture()
        {
            var filterInterface = Substitute.For<InterfaceFilter>();
            filterInterface = new ManagerFilter();

            Bitmap originalBitmap = RetrieveImage.RetrieveOriginalPicture();
            Bitmap bitmapForVerification = RetrieveImage.RetrieveImageFromPath("Rainbow.jpg");
            Bitmap filteredBitmap = filterInterface.RainbowFilter(new Bitmap(originalBitmap));

            Assert.IsTrue(RetrieveImage.Equals(bitmapForVerification, filteredBitmap));
        }

        [TestMethod]
        public void CrazyFilterTestOutputPicture()
        {
            var filterInterface = Substitute.For<InterfaceFilter>();
            filterInterface = new ManagerFilter();

            Bitmap originalBitmap = RetrieveImage.RetrieveOriginalPicture();
            Bitmap bitmapForVerification = RetrieveImage.RetrieveImageFromPath("Crazy.jpg");
            Bitmap filteredBitmap = filterInterface.CrazyFilter(new Bitmap(originalBitmap));

            Assert.IsTrue(RetrieveImage.Equals(bitmapForVerification, filteredBitmap));
        }
    }
}
