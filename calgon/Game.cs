using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace calgon
{
    class Game
    {
        public static void Main()
        {  
        string[,] testPlayer = new string[3,3];
        testPlayer[0, 0] = " ";
        testPlayer[0, 1] = "/";
        testPlayer[0, 2] = "/";
        testPlayer[1, 0] = "o";
        testPlayer[1, 1] = "|";
        testPlayer[1, 2] = " ";
        testPlayer[2, 0] = " ";
        testPlayer[2, 1] = "\\";
        testPlayer[2, 2] = "\\";
            Console.CursorVisible = false;
            GameField gameField = new GameField();
            Player tempPlayer = new Player(testPlayer);
            for (int col = 0; col < GameField.matrix.GetLength(0); col++)
            {
                for (int row = 0; row < GameField.matrix.GetLength(1); row++)
                {
                    Console.Write(GameField.matrix[col, row]);
                }
                Console.WriteLine();
            }
            tempPlayer.DrawPlayer();
            while (true)
            {
                tempPlayer.MovePlayer();
                //tempPlayer.DrawPlayer();
            }
        }
    }
}
