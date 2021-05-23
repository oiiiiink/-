using cw.TryToGuess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class ScoreCounter_ParametersAreValid_ReturnsResult
    {
        [TestMethod]
        public void ScoreCounter_ParametersAreValid_ReturnsResult_1()
        {
            ControlsDepartment controlsDepartment = new ControlsDepartment();
            int expected = 13;
            int actual = controlsDepartment.ScoreCounter(12, true);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScoreCounter_ParametersAreValid_ReturnsResult_2()
        {
            ControlsDepartment controlsDepartment = new ControlsDepartment();
            int expected = 11;
            int actual = controlsDepartment.ScoreCounter(12, false);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScoreCounter_ParametersAreValid_ReturnsResult_3()
        {
            ControlsDepartment controlsDepartment = new ControlsDepartment();
            int expected = 15;
            int actual = controlsDepartment.ScoreCounter(16, false);
            Assert.AreEqual(expected, actual);
        }        
    }

    [TestClass]
    public class GameControllerChangeLocation_ParametersAreValid_ReturnsResult
    {
        [TestMethod]
        public void GameControllerChangeLocation_ParametersAreValid_ReturnsResult_1()
        {
            PictureBox gameController = new PictureBox() { Location = new System.Drawing.Point(90, 90) };
            Label minusPlusScore = new Label() { };
            ControlsDepartment controlsDepartment = new ControlsDepartment();
            int expected = 13;
            int actual = controlsDepartment.GameControllerChangeLocation(12, true, true, gameController, minusPlusScore);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GameControllerChangeLocation_ParametersAreValid_ReturnsResult_2()
        {
            PictureBox gameController = new PictureBox() { Location = new System.Drawing.Point(90, 90) };
            Label minusPlusScore = new Label() { };
            ControlsDepartment controlsDepartment = new ControlsDepartment();
            int expected = 11;
            int actual = controlsDepartment.GameControllerChangeLocation(12, true, false, gameController, minusPlusScore);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GameControllerChangeLocation_ParametersAreValid_ReturnsResult_3()
        {
            PictureBox gameController = new PictureBox() { Location = new System.Drawing.Point(90, 90) };
            Label minusPlusScore = new Label() { };
            ControlsDepartment controlsDepartment = new ControlsDepartment();
            int expected = 17;
            int actual = controlsDepartment.GameControllerChangeLocation(16, false, false, gameController, minusPlusScore);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GameControllerChangeLocation_ParametersAreValid_ReturnsResult_4()
        {
            PictureBox gameController = new PictureBox() { Location = new System.Drawing.Point(90, 90) };
            Label minusPlusScore = new Label() { };
            ControlsDepartment controlsDepartment = new ControlsDepartment();
            int expected = 15;
            int actual = controlsDepartment.GameControllerChangeLocation(16, false, true, gameController, minusPlusScore);
            Assert.AreEqual(expected, actual);
        }
    }
}
