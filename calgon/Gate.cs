using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class Gate :GameObject
    {
      
        private string gateSymbol;
        private ConsoleColor gateColor;

        public Gate(int posX, int posY, string gateSymbol, ConsoleColor color)
            : base(posX, posY)
        {
            this.GateSymbol = gateSymbol;
            this.GateColor = color;
        }


        public string GateSymbol { get { return this.gateSymbol; } set { this.gateSymbol = value; } }
        public ConsoleColor GateColor { get { return this.gateColor; } set { this.gateColor = value; } }

        public void DrawGate()
        {
            Console.ForegroundColor = this.gateColor;
            for (int row = this.PosX; row < this.PosX + 5; row++)
            {
                for (int col = this.PosY; col < this.PosY + 5; col++)
                {
                    GameField.matrix[row, col] = this.GateSymbol;
                    Utilities.PrintStringOnPositon(col, row, this.GateSymbol, this.GateColor);
                }
            }
        }
    }
}
