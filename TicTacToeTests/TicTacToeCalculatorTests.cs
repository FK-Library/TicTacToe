using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeTests
{
    [TestClass]
    public class TicTacToeCalculatorTests
    {
        //Horizontal---------------------------
        [TestCategory("Horizontal")]
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

        [TestCategory("Horizontal")]
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

        [TestCategory("Horizontal")]
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

        [TestCategory("Horizontal")]
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

        [TestCategory("Horizontal")]
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
        [TestCategory("Horizontal")]
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

        //vertical--------------
        [TestCategory("Vertical")]
        [DataRow("x|||x|||x||", "x")]
        [TestMethod]
        public void Play_xFirstVerticalLine_xWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [TestCategory("Vertical")]
        [DataRow("o|||o|||o||", "o")]
        [TestMethod]
        public void Play_oFirstVerticalLine_oWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [TestCategory("Vertical")]
        [DataRow("|x|||x|||x|", "x")]
        [TestMethod]
        public void Play_xSecondVerticalLine_xWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [TestCategory("Vertical")]
        [DataRow("|o|||o|||o|", "o")]
        [TestMethod]
        public void Play_oSecondtVerticalLine_oWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [TestCategory("Vertical")]
        [DataRow("||x|||x|||x", "x")]
        [TestMethod]
        public void Play_xThirdVerticalLine_xWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [TestCategory("Vertical")]
        [DataRow("||o|||o|||o", "o")]
        [TestMethod]
        public void Play_oThirdVerticalLine_oWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        //Diagonal
        [TestCategory("Diagonal")]
        [DataRow("x||||x||||x", "x")]
        [TestMethod]
        public void Play_xLeftDiagonalLine_xWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [TestCategory("Diagonal")]
        [DataRow("o||||o||||o", "o")]
        [TestMethod]
        public void Play_oLefttDiagonalLine_oWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }
        [TestCategory("Diagonal")]
        [DataRow("||x||x||x||", "x")]
        [TestMethod]
        public void Play_xRightDiagonalLine_xWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [TestCategory("Diagonal")]
        [DataRow("||o||o||o||", "o")]
        [TestMethod]
        public void Play_oRightDiagonalLine_oWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        //Null 
        [TestCategory("Null")]
        [DataRow("", "Invalid Empty Input")]
        [TestMethod]
        public void Play_Always_ReportsEmptyInput(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        //NoWin 
        [TestCategory("NoWin")]
        [DataRow("o|x|o|x|x|o|x|o|x", "NoWin")]
        [DataRow("x|o|x|o|o|x|o|x|o", "NoWin")]
        [TestMethod]
        public void Play_Always_ReportsNoWinCondition(string inputs, string expectedWiner)
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
