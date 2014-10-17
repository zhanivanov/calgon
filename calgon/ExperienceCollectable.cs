using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class ExperienceCollectable : Collectable
    {
        public static int bonusExp = 10;

        public ExperienceCollectable(int posX, int posY) : base(posX, posY, "$", ConsoleColor.Yellow)
        {

        }

        public override Collectable[] GenerateCollectables(int count)
        {
            Random randomXGenerator = new Random();
            Random randomYGenerator = new Random();
            int nextX = 0;
            int nextY = 0;

            Collectable[] collectables = new ExperienceCollectable[count];
            for (int i = 0; i < count; i++)
            {
                nextX = randomXGenerator.Next(1, 150);
                nextY = randomYGenerator.Next(1, 35);
                collectables[i] = new ExperienceCollectable(nextX, nextY);
            }

            return collectables;
        }
    }
}
