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
            int round = 1;
            Warrior Raymond = new Warrior("Raymond", 100, 30, "Dinuraan");
            Warrior Kirk = new Warrior("Kirk", 200, 15, "Dinaganan");

            Raymond.DisplayStatus();
            Kirk.DisplayStatus();

            while(Raymond.IsAlive && Kirk.IsAlive)
            {
                Console.WriteLine($"-------- Round {round} --------");
                Raymond.Attack(Kirk);
                Kirk.Attack(Raymond);
                Console.WriteLine("------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}
