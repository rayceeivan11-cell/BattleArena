using System;
using System.Threading;

namespace BattleArena.Warriors
{
    public class Tank : Warrior
    {
        public int Shield  { get; private set; }
        public Tank(string name, int health, int attackPower, int shield) 
            : base(name, health, attackPower)
        {
            Shield = shield;
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower - Shield;
            TakeDamage(totalDamage);
            Console.WriteLine($"->{Name}: Lasapin mo yakap ko {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Hug me tight {Name}!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Kulang pa sa hug bebe {Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t------ {target.Name} ------");
            Console.WriteLine($"\t   * Damage Taken: {totalDamage}");
            Console.WriteLine($"\t   * Health Remaining: {target.Health}");
        }
    }

}
