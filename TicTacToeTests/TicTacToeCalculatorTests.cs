using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeTests
{
    [TestClass]
    public class TicTacToeCalculatorTests
    {
        [DataRow("x,1|x,2|x,3|o,4|o,5|o,6|x,7|o,8|x,9","x")]
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

        [DataRow("o,1|o,2|o,3|x,4|x,5|x,6|o,7|x,8|o,9", "o")]
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
