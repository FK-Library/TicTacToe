using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToeTests
{
    [TestClass]
    public class PrintTests
    {
        [TestMethod]
        public void Print_Always_ShowsResults()
        {
            //Arrange
            var printService = new Print();

            //Act
            printService.PrintResult("x");

            //Assert
            Assert.IsTrue(printService.IsPrinted);
        }
    }
}
