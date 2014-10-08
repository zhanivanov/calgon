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
            Console.CursorVisible = false;
            GameField gameField = new GameField(10, 10);
            Player tempPlayer = new Player("$");
            for (int col = 0; col < gameField.matrix.GetLength(0); col++)
            {
                for (int row = 0; row < gameField.matrix.GetLength(1); row++)
                {   
                    Console.Write(gameField.matrix[col, row]);
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
