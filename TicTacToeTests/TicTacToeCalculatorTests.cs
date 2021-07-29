using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TicTacToeTests
{
    [TestClass]
    public class TicTacToeCalculatorTests
    {
        [DataRow("x,x,x,o,o,o,x,o,x","x")]
        [TestMethod]
        public void TestMethod1(string inputs, string expectedWiner)
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
