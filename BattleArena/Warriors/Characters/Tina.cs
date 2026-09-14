using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Tina : Warrior
    {
        public int ArrowDamage { get; private set; }

        public Tina(int health, int attackPower, int speed, int arrowDamage, TeamType teamType)
            : base("Tina", health, attackPower, speed, WarriorType.Marksman, teamType)
        {
            ArrowDamage = arrowDamage;
            attackPower += ArrowDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Pana", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Pana para sa iyo, {target.Name}!" );

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Aray ko po!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Buhay pa ko {target.Name}");
        }
    }
}