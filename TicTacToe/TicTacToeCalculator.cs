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
            if (inputArray[0] == inputArray[1] && inputArray[1] == inputArray[2])
                winner = inputArray[0];


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
