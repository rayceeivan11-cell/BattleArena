using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Omar : Warrior, IDefender
    {
        public int Shield { get; private set; }

        public Omar(int health, int attackPower, int speed, int shield, TeamType teamType)
            : base("Omar", health, attackPower, speed, WarriorType.Tank, teamType)
        {
            Shield = shield;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Suntok", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Harangan mo ito, {target.Name}!" );

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Hindi sapat ang depensa mo!");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shield;
            if (newActualDamage < 0) newActualDamage = 0;

            _damageTaken = damage;
            base.TakeDamage(new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical, damage.From));
        }

        public void Block()
        {
            Console.WriteLine($"Hahaha! Blocked {_damageTaken.TotalAmountDamage} damage from {_damageTaken.From.Name}!");
        }
    }
}