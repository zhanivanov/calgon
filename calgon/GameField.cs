using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class GameField
    {
        private int sizeX;
        private int sizeY;
        public string[,] matrix;

        public GameField(int sizeX, int sizeY)
        {
            this.SizeX = sizeX;
            this.SizeY = sizeY;
            this.matrix = new string[sizeX, sizeY];

            for (int col = 0; col < sizeX; col++)
            {
                for (int row = 0; row < sizeY; row++)
                {
                    matrix[col, row] = ".";
                }
            }
        }

        public int SizeX { get; set; }
        public int SizeY { get; set; }
    }
}
