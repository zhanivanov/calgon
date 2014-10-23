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
        public static string[,] matrix;
        private string[] inputFile;
        public GameField()
        {
            this.inputFile = System.IO.File.ReadAllLines(@"../../TextFiles/GameField.txt");
            this.SizeX = inputFile.Length;
            this.sizeY = inputFile[0].Length;
            matrix = new string[SizeX, SizeY];

            for (int row = 0; row < SizeX; row++)
            {
                for (int col = 0; col < SizeY; col++)
                {
                    matrix[row, col] = inputFile[row][col].ToString();
                }
            }
        }
        public int SizeX { get { return this.sizeX; } set { this.sizeX = value; } }
        public int SizeY { get { return this.sizeY; } set { this.sizeY = value; } }
     

    }
}
