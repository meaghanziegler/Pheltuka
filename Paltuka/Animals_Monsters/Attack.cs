using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pheltuka
{
    public class Attack
    {
        public int Damage;
        public static string Name { get => "Bear"; set { } }
        private readonly Random rand = new Random();

        public Attack(int minDamage, int maxDamage, string name)
        {
            Damage = rand.Next(minDamage, maxDamage + 1);
            Name = name;
        }
        public Attack Attack1(Attack Attack)
        {
            Console.WriteLine($"You've been attacked.");
            Console.Clear();
            Console.Beep(3000, 300);
            Console.WriteLine($"Your health is: {Character.Health -5}/30");
            Console.Beep(230, 200);
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine("What will you do?");
            return Attack;
        }
    }
}
