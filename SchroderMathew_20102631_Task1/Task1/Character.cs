using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Character
    {
        static int hp;
        public int maxHp;
        public int damage;
        public int[] vision = new int[4];
        public bool range;

        public enum movement{ noMovemnet, Up, Down, Left, Right }

        public virtual void Attack() 
        {
            hp -= damage;
        }

        public bool isDead() 
        {
            bool dead = false;
            if (hp <= 0)
            {
                dead = true;
            }
            return dead;
        }

        public virtual bool CheckRange() 
        {
            bool inRange = false;
            int weapon = 0;
            int characterY = Tile.Y; // needs to be updated to character X and character Y
            int characterX = Tile.X;
            switch (weapon)
            {
                case 0: // dagger
                    if (true)
                    {
                        if (true) // (enemyPosX == charcaterX + 1 || enemyPosX == character - 1 || enemyPosY == characterY + 1 || enemyPosY == characterY - 1) 
                        {
                            inRange = true;
                        }
                    }
                    break;
            }
            return inRange;
        }

        private int DistanceTo(int enemyX, int enemyY, int heroX, int heroY)
        {
            int totalDistance; 
            if (enemyX > heroX)
	        { 
             totalDistance =+ (enemyX - heroX);
	        }else
	        {
             totalDistance =+ (heroX - enemyX);
	        }
            if (true)
	        {
             totalDistance =+ (enemyY - heroY);
	        }else
	        {
             totalDistance =+ (heroY - enemyY);
	        }
        }

        public void Move()
        {
            switch (movement)
	        {
		     case movement.noMovemnet:
               break;
             case movement.Up:
                    if (Obstacale.isBorder())
	                {
                    //re roll
	                }else
	                {
                     x =+ 1;
	                }
               break;
             case movement.Down:
                    if (Obstacale.isBorder())
	                {
                        x =-1;
	                }
               break;
             case movement.Left:
                    if (Obstacale.isBorder)
	                {
                        y=-1;
	                }
               break;
             case movement.Right:
                    if (Obstacale.isBorder)
	                {
                        y=+1;
	                }
               break;
	        }
        }

    }
}
