using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Miko : Warrior
    {
        public int ShotDamage { get; private set; }

        public Miko(int health, int attackPower, int speed, int shotDamage, TeamType teamType)
            : base("Miko", health, attackPower, speed, WarriorType.Marksman, teamType)
        {
            ShotDamage = shotDamage;
            attackPower += ShotDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Tira", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Tatamaan kita {target.Name}!" );

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Aray ko po!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Buhay pa ko {target.Name}");
        }
    }
}