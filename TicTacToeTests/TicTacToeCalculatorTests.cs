using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeTests
{
    [TestClass]
    public class TicTacToeCalculatorTests
    {
        [DataRow("x|x|x|o|o|o|x|o|x","x")]
        [TestMethod]
        public void Play_xFirstLine_xWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [DataRow("o|o|o|x|x|x|o|x|o", "o")]
        [TestMethod]
        public void Play_oFirstLine_oWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [DataRow("o|o|x|x|x|x|o|o|x", "x")]
        [TestMethod]
        public void Play_xSecondHorizontalLine_xWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [DataRow("x|x|o|o|o|o|x|x|x", "o")]
        [TestMethod]
        public void Play_oSecondtHorizontalLine_oWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }


        [DataRow("|o||o||o|x|x|x", "x")]
        [TestMethod]
        public void Play_xThirdHorizontalLine_xWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [DataRow("|x||x||x|o|o|o", "o")]
        [TestMethod]
        public void Play_oThirdtHorizontalLine_oWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }
    }
}
