using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Lando : Warrior
    {
        public int SlashDamage { get; private set; }

        public Lando(int health, int attackPower, int speed, int slashDamage, TeamType teamType)
            : base("Lando", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            SlashDamage = slashDamage;
            attackPower += SlashDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Sugod", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Susugurin kita {target.Name}!" );

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Aray ko po!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Buhay pa ko {target.Name}");
        }
    }
}