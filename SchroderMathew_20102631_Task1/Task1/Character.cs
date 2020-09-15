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

        private int DistanceTo()
        {
            int totalDistance; 
            //
        }

    }
}
