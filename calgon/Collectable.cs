using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calgon
{
    abstract class Collectable : GameObject
    {
        public static string[] collectableSymbolsArr = { "@", "$", "B", "*" };
        private string collectableSymbol;
        private ConsoleColor color;

        public Collectable(int posX, int posY, string collectableSymbol, ConsoleColor color)
            : base(posX, posY)
        {
            this.CollectableSymbol = collectableSymbol;
            this.Color = color;
        }

        public string CollectableSymbol { get; set; }

        public ConsoleColor Color { get; set; }

        public void drawCollectable()
        {
            GameField.matrix[this.PosY, this.PosX] = this.CollectableSymbol;
            Utilities.PrintStringOnPositon(this.PosX, this.PosY, this.CollectableSymbol, this.Color);
        }

        public abstract Collectable[] GenerateCollectables(int count);

        public static bool CheckSymbolCollision(Entity entity, string direction)
        {
            int matrixPosX;
            int matrixPosY;
            try
            {
                matrixPosX = entity.CollisionCheck(entity.PosX, entity.PosY, entity.SizeX, entity.SizeY, direction)[0];
                matrixPosY = entity.CollisionCheck(entity.PosX, entity.PosY, entity.SizeX, entity.SizeY, direction)[1];
            }
            catch (Exception e)
            {
                return false;
            }
            switch (GameField.matrix[matrixPosX, matrixPosY])
            {
                case "@":
                    Player.Health += HealthCollectable.bonusHealth;
                    break;
                case "$":
                    Player.Exp += ExperienceCollectable.bonusExp;
                    break;
                case "B":
                    Player.bombs += BombCollectable.bombs;
                    break;
                case "*":
                    Player.Points += BonusCollectable.bonusPoints;
                    break;
                default:
                    return false;
            }
            GameField.matrix[matrixPosX, matrixPosY] = " ";
            Utilities.PrintStringOnPositon(matrixPosY, matrixPosX, " ");

            SideInfo.PrintInfo();

            return true;
        }
    }
}
