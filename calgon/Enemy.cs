﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace calgon
{
    abstract class Enemy : NPC
    {
        public static int direction = 0;
        private string enemySymbol;
        private GameObject currPos = new GameObject(70, 17);

        public Enemy(int exp, int level, int health, int points, int posX, int posY, int sizeX, int sizeY, string enemySymbol)
            : base(exp, level, health, points, posX, posY, sizeX, sizeY)
        {
            this.EnemySymbol = enemySymbol;
            this.Direction = direction;
        }

        public string EnemySymbol { get; set; }

        public int Direction { get; set; }

        public void DrawEnemy(ConsoleColor enemyColor)
        {
            GameField.matrix[this.PosY, this.PosX] = this.EnemySymbol;
            Utilities.PrintStringOnPositon(this.PosX, this.PosY, this.EnemySymbol, ConsoleColor.White);
        }

        public void MoveEnemy()
        {
            DateTime currTime = DateTime.Now.AddSeconds(0.007);
            Random directionGenerator = new Random();
            checkWallCollision(this.Direction, directionGenerator);
            while (DateTime.Now < currTime)
            {
                
            }
        }

        private bool checkWallCollision(int direction, Random directionGenerator)
        {
            if (direction == 1 && !GameField.matrix[this.PosY, this.PosX + 1].Equals("█") && !GameField.matrix[this.PosY, this.PosX + 1].Equals("R"))
            {
                internalMove(direction);
                return false;
            }
            else if (direction == 2 && !GameField.matrix[this.PosY, this.PosX - 1].Equals("█") && !GameField.matrix[this.PosY, this.PosX - 1].Equals("R"))
            {
                internalMove(direction);
                return false;
            }
            else if (direction == 3 && !GameField.matrix[this.PosY + 1, this.PosX].Equals("█") && !GameField.matrix[this.PosY + 1, this.PosX].Equals("R"))
            {
                internalMove(direction);
                return false;
            }
            else if (direction == 4 && !GameField.matrix[this.PosY - 1, this.PosX].Equals("█") && !GameField.matrix[this.PosY - 1, this.PosX].Equals("R"))
            {
                internalMove(direction);
                return false;
            }
            else
            {
                this.Direction = directionGenerator.Next(1, 5);
                return true;
            }
        }

        private void internalMove(int direction)
        {
            switch (direction)
            {
                case 1:
                    this.PosX += 1;
                    break;
                case 2:
                    this.PosX -= 1;
                    break;
                case 3:
                    this.PosY += 1;
                    break;
                case 4:
                    this.PosY -= 1;
                    break;
                default:
                    break;
            }
            this.DrawEnemy(ConsoleColor.White);
            this.ClearTrace();
        }

        private void ClearTrace()
        {
            Console.SetCursorPosition(currPos.PosX, currPos.PosY);
            Console.Write(" ");
            GameField.matrix[currPos.PosY, currPos.PosX] = " ";
            this.currPos.PosX = this.PosX;
            this.currPos.PosY = this.PosY;
        }
    }
}
