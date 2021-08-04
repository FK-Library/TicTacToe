using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeTests
{
    [TestClass]
    public class PrintTests
    {
        [TestMethod]
        [DataRow("x")]
        [DataRow("O")]
        [DataRow("x|x|x|x|x|x|x|x|x")]
        public void Print_Always_ShowsResults( string input)
        {
            //Arrange
            var printService = new Print();

            //Act
            printService.PrintResult("input");

            //Assert
            Assert.IsTrue(printService.IsPrinted);
        }
    }
}
