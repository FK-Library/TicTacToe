using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public interface IRules
    {
        bool CanApply();
        string Apply();
    }
}
