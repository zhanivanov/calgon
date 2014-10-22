using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calgon
{
    class Bomb : GameObject
    {
        public Bomb( int posY,int posX)
            : base(posX, posY)
        {

        }
        public void DrawBomb()
        {
            Console.SetCursorPosition(this.PosX + 3, this.PosY + 2);
            Console.Write("!");
            GameField.matrix[this.PosY + 2, this.PosX + 3] = "!";
        }
    }
}
