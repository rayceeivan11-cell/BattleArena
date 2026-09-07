using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior Raymond = new Warrior("Raymond", 100, 30);
            Warrior Kirk = new Warrior("Kirk", 200, 15);

            Console.WriteLine($"{Raymond.Name} has " +
                $"{Raymond.Health} health and {Raymond.AttackPower} " + $"attack power.");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"{Kirk.Name} has" +
                $" {Kirk.Health} health and {Kirk.AttackPower} attack power.");
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }
    }
}
