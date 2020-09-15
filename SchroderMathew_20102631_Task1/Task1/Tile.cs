using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Schema;

namespace Task1
{
    class Tile
    {
        public int x;
        public int y;
        public enum tileType { Hero, Enemy, Gold, Weapon }

        public Tile(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        
    }

   

    
}

