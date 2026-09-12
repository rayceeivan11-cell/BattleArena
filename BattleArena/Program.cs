using BattleArena.Enums;
using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Raymond = new Raymond(100, 30, 3, TeamType.A);
            var Kirk = new Kirk( 200, 15, 10, TeamType.B);

            Raymond.DisplayStatus();
            Kirk.DisplayStatus();

            while(Raymond.IsAlive && Kirk.IsAlive)
            {
                Console.WriteLine("\n\n=================================================");
                Raymond.Attack(Kirk);
                Kirk.DisplayStatus();
                Console.WriteLine("-------------------------------------------------");
                Thread.Sleep(2000);
                Kirk.Attack(Raymond);
                Raymond.DisplayStatus();
                Thread.Sleep(2000); 
            }

            Console.ReadKey();
        }
    }
}
