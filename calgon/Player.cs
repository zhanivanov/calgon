using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class Player : Entity
    {
        private string playerSymbol;
        private GameObject currPos = new GameObject(0, 0);

        public Player(string playerSymbol)
            : base(0, 0, 0, 0, 0, 1, 1)
        {
            this.playerSymbol = playerSymbol;
        }

        public void MovePlayer()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    this.PosX -= 1;
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    this.PosX += 1;
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    this.PosY -= 1;
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    this.PosY += 1;
                }
                DrawPlayer();
                ClearTrace();
            }
        }

        public void DrawPlayer()
        {
            Console.SetCursorPosition(this.PosX, this.PosY);
            Console.Write(this.playerSymbol);
        }

        private void ClearTrace()
        {
            Console.SetCursorPosition(currPos.PosX, currPos.PosY);
            Console.Write(".");
            this.currPos.PosX = this.PosX;
            this.currPos.PosY = this.PosY;
        }
    }
}
