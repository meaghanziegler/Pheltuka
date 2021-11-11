using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheltuka
{
    class Character
    {
        public Character() { }
        public Character(int health, int points, int lives)
        {
            Health = health;
            Points = points;
            Lives = lives;
        }

        public static int Health { get=> 30; set { } }
        public static int Points { get => 0; set { } }
        public static int Lives { get => 3; set { } }
    }
}
