using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheltuka.Animals_Monsters
{
    public class Bear
    {
        public static int Health { get; set; } = 25;

        public void Attack()
        {
            if (Bear.Health > 25)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("You're being attacked!\n");
                Console.Clear();
            }
        }

        public void Hurt(Attack attack)
        {
            
        }
    }
}
