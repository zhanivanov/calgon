using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calgon
{
    class Bomb : GameObject
    {
        public static bool setBomb = false;
        public Bomb( int posY,int posX)
            : base(posX, posY)
        {

        }
        public void DrawBomb()
        {
            Console.SetCursorPosition(this.PosX , this.PosY );
            Console.Write("!");
            GameField.matrix[this.PosY , this.PosX ] = "!";
        }
      //  public static DeleteBoomb()
    }
}
