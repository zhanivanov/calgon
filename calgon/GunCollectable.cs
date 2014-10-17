using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class GunCollectable : Collectable
    {
        public static int bonusGum = 10;

        public GunCollectable(int posX, int posY) : base(posX, posY, "#", ConsoleColor.Magenta)
        {

        }

        public override Collectable[] GenerateCollectables(int count)
        {
            Random randomXGenerator = new Random();
            Random randomYGenerator = new Random();
            int nextX = 0;
            int nextY = 0;

            Collectable[] collectables = new GunCollectable[count];
            for (int i = 0; i < count; i++)
            {
                nextX = randomXGenerator.Next(1, 150);
                nextY = randomYGenerator.Next(1, 35);
                collectables[i] = new GunCollectable(nextX, nextY);
            }

            return collectables;
        }
    }
}
