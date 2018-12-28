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
    /// Description résumée pour InputOutputTest
    /// </summary>
    [TestClass]
    public class InputOutputTest
    {
        public InputOutputTest()
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
        //Test when sending a bitmap with superior width that canvas and height
        [TestMethod]
        public void TestCopyToSquareCanvasWithWidthGreaterThatCanvasAndHeight()
        {
            var inputInterface = Substitute.For<InterfaceInput>();
            inputInterface = new ManagerInputOutput();

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
            var inputInterface = Substitute.For<InterfaceInput>();
            inputInterface = new ManagerInputOutput();

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
            
            var inputInterface = Substitute.For<InterfaceInput>();
            inputInterface = new ManagerInputOutput();

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
            var inputInterface = Substitute.For<InterfaceInput>();
            inputInterface = new ManagerInputOutput();

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
    }
}
