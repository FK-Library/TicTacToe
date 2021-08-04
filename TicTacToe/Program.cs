using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var printResult = new Print();
            var ticTacToe = new TicTacToeCalculator(printResult);

            string input = "x|x|x|o|o|o|x|o|x";
             
            var result = ticTacToe.Play(input);            
            ticTacToe.PrintResult(input);
            Console.WriteLine("---------------");
            
            Console.WriteLine("Winner : ");
            ticTacToe.PrintResult(result);

            Console.ReadLine();
        }
    }
}
