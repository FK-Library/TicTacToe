using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    public class Print : IPrint
    {
        public bool IsPrinted = false;
        public void PrintResult(string output)
        {
            if (output.Contains('|'))
            {
                var outputs = output.Split('|');

                for (int i = 0; i < 9; i++)
                {
                    Trace.Listeners.Add(new System.Diagnostics.DefaultTraceListener());
                    Console.Write(outputs[i]);
                    if (i / 3 == 0)
                        Console.WriteLine();
                }
                IsPrinted = true;
            }
            else
            {
                Console.WriteLine(output);
                IsPrinted = true;
            }
            _ = Console.ReadLine();
        }
    }
}
