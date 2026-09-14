using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Collections.Generic;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Nena : Warrior, IHealCaster
    {
        public int HealingAmount { get; set; }

        public Nena(int health, int attackPower, int speed, int healingAmount, TeamType teamType)
            : base("Nena", health, attackPower, speed, WarriorType.Magery, teamType)
        {
            HealingAmount = healingAmount;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Lunas", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Lalaban ako, {target.Name}!" );

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Hindi pa ako talo!");
        }

        public void HealTeamMates(List<Warrior> teamMates)
        {
            foreach (var warrior in teamMates)
            {
                if (warrior.IsAlive && warrior.TeamType == TeamType)
                {
                    Console.WriteLine($"->{Name}: Pagagalingin kita, {warrior.Name}!");
                    warrior.ReceiveHealing(HealingAmount, this);
                }
            }
        }
    }
}