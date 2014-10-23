using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class ExperienceCollectable : Collectable
    {
        public static int bonusExp = 50;

        public ExperienceCollectable(int posX, int posY) : base(posX, posY, "$", ConsoleColor.Yellow)
        {

        }

        public override Collectable[] GenerateCollectables(int count)
        {
            Random randomCoordinatesGenerator = new Random(DateTime.Now.Millisecond);
            int nextX = 0;
            int nextY = 0;

            Collectable[] collectables = new ExperienceCollectable[count];
            for (int i = 0; i < count; i++)
            {
                nextX = randomCoordinatesGenerator.Next(1, 140);
                nextY = randomCoordinatesGenerator.Next(1, 35);
                if (GameField.matrix[nextY, nextX].Equals("█"))
                {
                    bool isEqual;
                    do
                    {
                        nextX = randomCoordinatesGenerator.Next(1, 140);
                        nextY = randomCoordinatesGenerator.Next(1, 35);
                        isEqual = GameField.matrix[nextY, nextX].Equals("█");
                    } while (isEqual);
                }
                collectables[i] = new ExperienceCollectable(nextX, nextY);
            }

            return collectables;
        }
    }
}
