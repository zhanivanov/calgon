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
            // Setting the parameters of the Console
            Console.BufferHeight = 40;
            Console.BufferWidth = 150;
            Console.WindowHeight = 40;
            Console.WindowWidth = 150;
            Console.CursorVisible = false;
            GameField gameField = new GameField();

            Player tempPlayer = new Player();
            for (int col = 0; col < GameField.matrix.GetLength(0); col++)
            {
                for (int row = 0; row < GameField.matrix.GetLength(1); row++)
                {
                    Console.Write(GameField.matrix[col, row]);
                }
                Console.WriteLine();
            }
            tempPlayer.DrawPlayer();

            Gate gate = new Gate(33, 1, "R", ConsoleColor.Red);
            gate.DrawGate();
            while (true)
            {
                tempPlayer.MovePlayer();
                //tempPlayer.DrawPlayer();
            }
        }
    }
}
