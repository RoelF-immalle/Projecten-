using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaal = 2549;
            var h = totaal / 3600;
            var m = (totaal - h * 3600) / 60;
            var s = (totaal - (h * 3600) - (m * 60));
            Console.WriteLine("{0} uren, {1} minuten , {2} seconden", h, m, s);

        }
    }
}
