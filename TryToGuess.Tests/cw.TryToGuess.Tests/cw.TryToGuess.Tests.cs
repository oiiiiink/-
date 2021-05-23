using Microsoft.VisualStudio.TestTools.UnitTesting;
using cw.TryToGuess;
using System.Windows.Forms;

namespace cw.TryToGuess.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScoreCounter_1andtrue_2return()
        {
            int score = 1;
            bool answer = true;
            PictureBox gameController = new PictureBox();
            Label minusPlusScore = new Label();
            gameController.Location = new System.Drawing.Point(110, gameController.Location.Y);
            int expected = 2;

            ControlDepartment cD = new ControlDepartment();
        }
    }
}
