﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class BonusCollectable : Collectable
    {
        public static int bonusPoints = 10;

        public BonusCollectable(int posX, int posY) : base(posX, posY, "*", ConsoleColor.Green)
        {

        }

        public override Collectable[] GenerateCollectables(int count)
        {
            Random randomCoordinatesGenerator = new Random(DateTime.Now.Millisecond);
            int nextX = 0;
            int nextY = 0;

            Collectable[] collectables = new BonusCollectable[count];
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
                collectables[i] = new BonusCollectable(nextX, nextY);
            }

            return collectables;
        }
    }
}
