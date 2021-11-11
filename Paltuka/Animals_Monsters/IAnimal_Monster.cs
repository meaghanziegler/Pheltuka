using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheltuka.Animals_Monsters
{
    public interface IAnimal_Monster
    {
        int Health { get; }
        void Hurt(Attack attack);
        Attack Attack();
    }
}
