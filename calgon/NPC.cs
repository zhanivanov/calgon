﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    class NPC : Entity
    {
        public NPC(int exp, int level, int health, int points, int posX, int posY, int sizeX, int sizeY) 
            : base(exp, level, health, points, posX, posY, sizeX, sizeY)
        {

        }
    }
}
