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
            Console.ForegroundColor = this.gateColor;
            for (int row = this.X; row < this.X + 5; row++)
            {
                for (int col = this.Y; col < this.Y + 5; col++)
                {
                    // GameField.matrix[row, col] = this.GateSymbol;
                    Utilities.PrintStringOnPositon(col, row, this.GateSymbol, this.GateColor);
                }
            }
        }
    }
}
