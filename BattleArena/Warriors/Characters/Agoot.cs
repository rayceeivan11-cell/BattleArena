using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Warriors.Characters
{
    public class Agoot : Warrior
    {
        public Agoot( int health, int attackPower) 
            : base("Agoot", health, attackPower, WarriorType.Magery)
        {

        }

        public override void Attack(Warrior target)
        {
            throw new NotImplementedException();
        }
    }
}
