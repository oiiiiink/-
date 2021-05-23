using cw.TryToGuess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TryToGuess.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScoreCounter_2andtrue_3returned()
        {
            int score = 2;
            bool answer = true;

            ControlsDepartment cd = new ControlsDepartment();
            cd.Score = 0;
            int expected = 3;

            int actual = cd.ScoreCounter(score, answer);

            Assert.AreEqual(expected, actual);
        }
    }
}
