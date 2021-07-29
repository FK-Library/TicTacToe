using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeTests
{
    [TestClass]
    public class TicTacToeCalculatorTests
    {
        [DataRow("x,x,x,o,o,o,x,o,x","x")]
        [TestMethod]
        public void Play_xfilled1And2And3_xWins(string inputs, string expectedWiner)
        {
            //Arrange
            var ticTacToe = new TicTacToeCalculator();

            //Act
            var actual = ticTacToe.Play(inputs);

            //Assert
            Assert.AreEqual(expectedWiner, actual);
        }

        [DataRow("o,o,o,,x,x,x,o,x,o,", "o")]
        [TestMethod]
        public void Play_ofilled1And2And3_oWins(string inputs, string expectedWiner)
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
