using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Obstacale : Tile
    {
        public bool border;

        public Obstacale(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public bool isBorder(int xMap, int yMap)
        {
            bool border = false;
            // checking where the borders of the map are and then returning if a spot is a border
            if (x == 0 || x == xMax || y == 0 || y == yMax)
            {
                border = true;
            }
            return border;
        }
    }
}
