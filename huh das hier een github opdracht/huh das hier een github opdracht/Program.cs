using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huh_das_hier_een_github_opdracht
{
    class Program
    {
        static void Groet()
        {
            Console.WriteLine("hey");
        }
        static void Groet(string Naam)
        {
            Console.WriteLine("Hey {0}!", Naam);
        }


        static void Main(string[] args)
        {
            Groet();
            Groet("Kindje");
            Groet("bompa,wat gaan we doen in de kelder?");
        }

    }
}
