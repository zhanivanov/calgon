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
        public string[] inputFile;
        public GameField()
        {
            this.inputFile = System.IO.File.ReadAllLines(@"../../../projectTest.txt");
            this.sizeX = inputFile.Length;
            this.sizeY = inputFile[0].Length;
            this.matrix = new string[sizeX, sizeY];

            for (int row = 0; row < sizeX - 1; row++)
            {
                for (int col = 0; col < sizeY; col++)
                {
                    matrix[row, col] = inputFile[row][col].ToString();
                }
            }
        }


    }
}
