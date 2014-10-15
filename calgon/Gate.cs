using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class Gate
    {
        private int x;
        private int y;
        private string[,] gateMatrix = new string[5, 5];
        private string gateSymbol;
        private ConsoleColor gateColor;

        public Gate(int x, int y, string gateSymbol, ConsoleColor color)
        {
            this.X = x;
            this.Y = y;
            this.GateSymbol = gateSymbol;
            this.GateColor = color;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string GateSymbol { get; set; }
        public ConsoleColor GateColor { get; set; }

        public void DrawGate()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.ForegroundColor = this.gateColor;
            for (int row = 0; row < this.gateMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.gateMatrix.GetLength(1); col++)
                {
                    Utilities.PrintStringOnPositon(col + this.X, row + this.Y, this.GateSymbol, this.GateColor);
                }
                Console.WriteLine();
            }
        }
    }
}
