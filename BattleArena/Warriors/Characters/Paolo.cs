using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Paolo : Warrior
    {
        public int KickDamage { get; private set; }

        public Paolo(int health, int attackPower, int speed, int kickDamage, TeamType teamType)
            : base("Paolo", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            KickDamage = kickDamage;
            attackPower += KickDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Sipa", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Sisipain kita {target.Name}!" );

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Masakit!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Lalaban pa ako!");
        }
    }
}