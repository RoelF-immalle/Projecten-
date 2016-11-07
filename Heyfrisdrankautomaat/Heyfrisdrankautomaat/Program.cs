using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heyfrisdrankautomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 100;
            int cost = 45;
            int change = amount - cost;
            int euro1 = change / 100;
            int c50 = (change - (euro1 * 100)) / 50;
            int c20 = (change - (euro1 * 100) - (c50 * 50)) / 20;
            int c10 = (change - (euro1 * 100) - (c50 * 50) - (c20 * 20)) / 10;
            int c05 = (change - (euro1 * 100) - (c50 * 50) - (c20 * 20) - (c10 * 10)) / 5;
            int c02 = (change - (euro1 * 100) - (c50 * 50) - (c20 * 20) - (c10 * 10) - (c05 * 5)) / 2;
            int c01 = (change - (euro1 * 100) - (c50 * 50) - (c20 * 20) - (c10 * 10) - (c05 * 5) - (c02 * 2));


            Console.WriteLine("je betaalt " + 100 + "cent en krijgt terug: ");
            Console.WriteLine("  x {1} euro", 1, euro1);
            Console.WriteLine("  x {1}  50 cent", 1, c50);
            Console.WriteLine("  x {1} 20 cent", 1, c20);
            Console.WriteLine("  x {1} 10 cent", 1, c10);
            Console.WriteLine("  x {1} 5 cent", 1, c05);
            Console.WriteLine("  x {1} 2 cent", 1, c02);
            Console.WriteLine("  x {1} 1 cent", 1, c01);
        }
    }
}
