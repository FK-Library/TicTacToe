using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TicTacToe
{
    public class TicTacToeCalculator : ITicTacToeCalculator
    {
        private IPrint Print;
        public TicTacToeCalculator(IPrint Print)
        {
            this.Print = Print;
        }
       // to do -List of delimiters can be added here
        public string Play(string inputs)
        {
            var noWin = "NoWin";
            

            if (!this.Validate(inputs))
                return "Invalid Input";

            inputs = inputs.Replace("-", "");

                //validate
                var inputArray = inputs.Split('|'); // to do- add other delimiters rather than only '|'

                //apply rules
                //horizontal
                if (inputArray[0] == inputArray[1]
                    && inputArray[1] == inputArray[2]
                    && !String.IsNullOrEmpty(inputArray[0]))
                    return inputArray[0];

                if (inputArray[3] == inputArray[4]
                    && inputArray[4] == inputArray[5]
                    && !String.IsNullOrEmpty(inputArray[3]))
                    return inputArray[3];

                if (inputArray[6] == inputArray[7]
                    && inputArray[7] == inputArray[8]
                    && !String.IsNullOrEmpty(inputArray[6]))
                    return inputArray[6];

                //vertical
                if (inputArray[0] == inputArray[3]
                    && inputArray[3] == inputArray[6]
                    && !String.IsNullOrEmpty(inputArray[0]))
                    return inputArray[0];

                if (inputArray[1] == inputArray[4]
                    && inputArray[4] == inputArray[7]
                    && !String.IsNullOrEmpty(inputArray[1]))
                    return inputArray[1];

                if (inputArray[2] == inputArray[5]
                    && inputArray[5] == inputArray[8]
                    && !String.IsNullOrEmpty(inputArray[2]))
                    return inputArray[2];

                //Diagonal
                if (inputArray[0] == inputArray[4]
                    && inputArray[4] == inputArray[8]
                    && !String.IsNullOrEmpty(inputArray[0]))
                    return inputArray[0];

                if (inputArray[2] == inputArray[4]
                    && inputArray[4] == inputArray[6]
                    && !String.IsNullOrEmpty(inputArray[2]))
                    return inputArray[2];

            return noWin;
        }

        public void PrintResult(string input)
        {
            this.Print.PrintResult(input);
        }

        private bool Validate(string input)
        {
            //string pattern = @"[[xXoO\-\|] ]*";
            //Regex rg = new Regex(pattern);
            //var matched = rg.Matches(input);
            //if (matched.Count != 9)
            //    return false;


            if (string.IsNullOrEmpty(input))
                return false;

            input = input.Replace("x", "");
            input = input.Replace("X", "");
            input = input.Replace("o", "");
            input = input.Replace("O", "");
            input = input.Replace("|", "");
            input = input.Replace("-", "");

            if (input.Count() > 0)
                return false;

            return true;
        }
    }
}
/*
 * Lets Assume:
 * 0|1|2
 * 3|4|5
 * 6|7|8
 */
