using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Muhat : Warrior
    {
        public int PunchDamage { get; private set; }
        public Muhat(int health, int attackPower, int speed, int punchDamage, TeamType teamType) 
            : base("Muhat", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            PunchDamage = punchDamage;
            attackPower += PunchDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Sapak", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Sasapakin kita {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Aray ko po!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Buhay pa ko bebe {target.Name}");
        }
    }

}
