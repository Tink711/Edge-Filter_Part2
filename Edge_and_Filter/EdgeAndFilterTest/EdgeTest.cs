using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Edge_and_Filter;
using System.Drawing;

namespace EdgeAndFilterTest
{
    /// <summary>
    /// Description résumée pour EdgeTest
    /// </summary>
    [TestClass]
    public class EdgeTest
    {
        public EdgeTest()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
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

        //=========================================
        //Edges tests
        //=========================================
        //Testing the edge laplacian 3x3 by applying the edge detection and comparing with an image with the expected result
        [TestMethod]
        public void Laplacian3x3FilterTestOutputPicture()
        {
            //Substitute for ManagerEdge
            var edgeInterface = Substitute.For<ManagerEdge>();

            Bitmap originalBitmap = RetrieveImage.RetrieveOriginalPicture();
            Bitmap bitmapForVerification = RetrieveImage.RetrieveImageFromPath("Laplacian3x3.jpg");
            Bitmap filteredBitmap = edgeInterface.Lalpacian3x3(new Bitmap(originalBitmap));

            Assert.IsTrue(RetrieveImage.Equals(bitmapForVerification, filteredBitmap));
        }
        //Testing the edge laplacian 5x5 by applying the edge detection and comparing with an image with the expected result
        [TestMethod]
        public void Laplacian5x5FilterTestOutputPicture()
        {
            //Substitute for ManagerEdge
            var edgeInterface = Substitute.For<ManagerEdge>();

            Bitmap originalBitmap = RetrieveImage.RetrieveOriginalPicture();
            Bitmap bitmapForVerification = RetrieveImage.RetrieveImageFromPath("Laplacian5x5.jpg");
            Bitmap filteredBitmap = edgeInterface.Lalpacian5x5(new Bitmap(originalBitmap));

            Assert.IsTrue(RetrieveImage.Equals(bitmapForVerification, filteredBitmap));
        }
    }
}
