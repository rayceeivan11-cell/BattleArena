using System;
using System.Threading;

namespace BattleArena.Warriors
{
    public class Marksman : Warrior
    {
        public int ArrowDamage { get; private set; }
        public Marksman(string name, int health, int attackPower, int arrowDamage) 
            : base(name, health, attackPower)
        {
            ArrowDamage = arrowDamage;
            attackPower += ArrowDamage; 
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower;
            TakeDamage(totalDamage);
            Console.WriteLine($"->{Name}: Duburaan kita bebe {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Need more babe!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                 Console.WriteLine($"->{target.Name}: Buhay pa ko babe {target.Name}");
           
            Thread.Sleep(1000);
            Console.WriteLine($"\t------ {target.Name} ------");
            Console.WriteLine($"\t   * Damage Taken: {totalDamage}");
            Console.WriteLine($"\t   * Health Remaining: {target.Health}");
        }
    }

}
