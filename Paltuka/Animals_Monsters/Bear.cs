using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheltuka.Animals_Monsters
{
    public class Bear : IAnimal_Monster
    {
        public int Health { get; set; } = 25;

        public Attack Attack()
        {
            throw new NotImplementedException();
        }

        public void Hurt(Attack attack)
        {
            
        }
    }
}
