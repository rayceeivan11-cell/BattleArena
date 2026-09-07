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
            var Raymond = new Marksman("Raymond", 100, 30, 3);
            var Kirk = new Tank("Kirk", 200, 15, 10);

            Raymond.DisplayStatus();
            Kirk.DisplayStatus();

            while(Raymond.IsAlive && Kirk.IsAlive)
            {
                Console.WriteLine("\n\n=================================================");
                Raymond.Attack(Kirk);
                Console.WriteLine("------------------------------------------------_");
                Thread.Sleep(2000);
                Kirk.Attack(Raymond);
                Thread.Sleep(2000); 
            }

            Console.ReadKey();
        }
    }
}
