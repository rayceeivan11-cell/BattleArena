using System;
using System.Threading;
using System.Xml.Linq;

namespace BattleArena.Warriors
{
    public class Raymond : Warrior
    {
        public int DuraDamage { get; private set; }
        public Raymond(int health, int attackPower, int arrowDamage) 
            : base("Raymond", health, attackPower, WarriorType.Marksman)
        {
            DuraDamage = arrowDamage;
            attackPower += DuraDamage; 
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Dura", HasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Duburaan kita bebe {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Need more babe!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                 Console.WriteLine($"->{target.Name}: Buhay pa ko babe {target.Name}");
        }
    }

}




