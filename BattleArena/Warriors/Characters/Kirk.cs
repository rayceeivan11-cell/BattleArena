using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace BattleArena.Warriors
{
    public class Kirk : Warrior
    {
        public int Shield  { get; private set; }
        public Kirk(int health, int attackPower, int shield) 
            : base("Kirk", health, attackPower, WarriorType.Tank)
        {
            Shield = shield;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Dura", HasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Lasapin mo yakap ko {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Hug me tight {Name}!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Kulang pa sa hug bebe {Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shield;
            var newDmginfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical);
            base.TakeDamage(newDmginfo);
        }

    }

}
