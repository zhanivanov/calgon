using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace calgon
{
    class Game
    {
        public static void Main()
        {  
            int bufferHeight = 40;
            int bufferWidth = 170;
            // Setting the parameters of the Console
            Console.BufferHeight = bufferHeight;
            Console.BufferWidth = bufferWidth;
            Console.WindowHeight = bufferHeight;
            Console.WindowWidth = bufferWidth;
            Console.CursorVisible = false;
            GameField gameField = new GameField();

            Player tempPlayer = new Player();

            List<Enemy> dragons = new List<Enemy>() 
            {
                new DragonEnemy(),
                new DragonEnemy(),
                new DragonEnemy(),
                new DragonEnemy(),
                new DragonEnemy(),
                new DragonEnemy(),
                new DragonEnemy(),
                new DragonEnemy(),
                new DragonEnemy()
            };

            for (int col = 0; col < GameField.matrix.GetLength(0); col++)
            {
                for (int row = 0; row < GameField.matrix.GetLength(1); row++)
                {
                    Console.Write(GameField.matrix[col, row]);
                }
                Console.WriteLine();
            }
            tempPlayer.DrawPlayer();

            Gate gate = new Gate(33, 1, "R", ConsoleColor.Red);
            gate.DrawGate();

            Collectable[] healthCollectables = new HealthCollectable(0, 0).GenerateCollectables(5);
            Collectable[] experienceCollectables = new ExperienceCollectable(0, 0).GenerateCollectables(5);
            Collectable[] gunCollectables = new GunCollectable(0, 0).GenerateCollectables(5);
            Collectable[] bonusCollectables = new BonusCollectable(0, 0).GenerateCollectables(5);

            Collectable[][] allCollectables = { healthCollectables, experienceCollectables, gunCollectables, bonusCollectables };

            for (int i = 0; i < allCollectables.Length; i++)
            {
                for (int j = 0; j < allCollectables[i].Length; j++)
                {
                    allCollectables[i][j].drawCollectable();
                }
            }
            SideInfo.PrintInfo();

            while (true)
            {
                tempPlayer.MovePlayer();
                foreach (Enemy dragon in dragons)
                {
                    dragon.MoveEnemy();
                    tempPlayer.ChekForEnemy();
                }
            }
        }
    }
}
