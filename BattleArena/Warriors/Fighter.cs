using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Fighter : Warrior
    {
        public int SwordDamage { get; private set; }
        public Fighter(string name, int health, int attackPower, int swordDamage) 
            : base(name, health, attackPower)
        {
            SwordDamage = swordDamage;
            attackPower += SwordDamage;
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower;
            TakeDamage(totalDamage);
            Console.WriteLine($"->{Name}: Tutuhogin kita {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Aray ko po!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Buhay pa ko bebe {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t------ {target.Name} ------");
            Console.WriteLine($"\t   * Damage Taken: {totalDamage}");
            Console.WriteLine($"\t   * Health Remaining: {target.Health}");
        }
    }

}
