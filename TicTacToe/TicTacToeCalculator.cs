using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeCalculator : ITicTacToeCalculator
    {
        //private List<IRules> rules;
        //public TicTacToeCalculator(List<IRules> rules)
        //{
        //    this.rules = rules;
        //}
        public string Play(string inputs)
        {
            string winner = null;
            //input to array
            var inputArray = inputs.Split('|');

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

            return winner;
        }
    }
}
/*
 * Lets Assume:
 * 1|2|3
 * 4|5|6
 * 7|8|9 
 */
