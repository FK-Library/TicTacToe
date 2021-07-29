using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeCalculator : ITicTacToeCalculator
    {
        private List<IRules> rules;
        public TicTacToeCalculator(List<IRules> rules)
        {
            this.rules = rules;
        }
        public string Play()
        {
            throw new NotImplementedException();
        }
    }
}
