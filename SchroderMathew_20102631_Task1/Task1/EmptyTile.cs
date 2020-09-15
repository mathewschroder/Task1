using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class EmptyTile : Tile
    {
        public bool empty;
        
        public EmptyTile(bool _empty) : base(_x,y)
        {
            empty = _empty;
        }

        public bool isEmpty(int xMax, int yMax)
        {
            bool empty = false;
            if (x != 0 && x != xMax && y != 0 && y != yMax)
            {
                empty = true;
            }
            return empty;
        }
    }
}
