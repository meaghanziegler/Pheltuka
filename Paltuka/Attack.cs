using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheltuka
{
    public class Attack
    {
        public int Damage;
        public string Name { get; set; }
        private readonly Random rand = new Random();

        public Attack(int minDamage, int maxDamage, string name)
        {
            Damage = rand.Next(minDamage, maxDamage + 1);
            Name = name;
        }

    }
}
