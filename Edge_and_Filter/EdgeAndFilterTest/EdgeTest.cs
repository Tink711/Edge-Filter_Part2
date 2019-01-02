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

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active, ainsi que ses fonctionnalités.
        ///</summary>
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

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Laplacian3x3FilterTestOutputPicture()
        {
            var edgeInterface = Substitute.For<InterfaceEdge>();
            edgeInterface = new ManagerEdge();

            Bitmap originalBitmap = RetrieveImage.RetrieveOriginalPicture();
            Bitmap bitmapForVerification = RetrieveImage.RetrieveImageFromPath("Laplacian3x3.jpg");
            Bitmap filteredBitmap = edgeInterface.Lalpacian3x3(new Bitmap(originalBitmap));

            Assert.IsTrue(RetrieveImage.Equals(bitmapForVerification, filteredBitmap));
        }

        [TestMethod]
        public void Laplacian5x5FilterTestOutputPicture()
        {
            var edgeInterface = Substitute.For<InterfaceEdge>();
            edgeInterface = new ManagerEdge();

            Bitmap originalBitmap = RetrieveImage.RetrieveOriginalPicture();
            Bitmap bitmapForVerification = RetrieveImage.RetrieveImageFromPath("Laplacian5x5.jpg");
            Bitmap filteredBitmap = edgeInterface.Lalpacian5x5(new Bitmap(originalBitmap));

            Assert.IsTrue(RetrieveImage.Equals(bitmapForVerification, filteredBitmap));
        }
    }
}
