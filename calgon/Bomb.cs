using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calgon
{
    class Bomb : GameObject
    {
        private static Bomb curBomb = new Bomb(0, 0);
        public static bool setBomb = false;
        public Bomb(int posY, int posX)
            : base(posX, posY)
        {

        }
        public static void NewBomb(int posX, int posY)
        {
            Bomb.curBomb = new Bomb(posX, posY);
            Console.SetCursorPosition(Bomb.curBomb.PosX, Bomb.curBomb.PosY);
            Console.Write("!");
            GameField.matrix[Bomb.curBomb.PosY, Bomb.curBomb.PosX] = "!";
            Bomb.setBomb = true;
            Player.bombs--;
        }
        public static void DeleteBoomb()
        {
            GameField.matrix[Bomb.curBomb.PosY, Bomb.curBomb.PosX] = " ";
            Bomb.setBomb = false;
        }
    }
}
