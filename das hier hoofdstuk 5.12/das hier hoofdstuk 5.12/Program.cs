using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace das_hier_hoofdstuk_5._12
{public
     class Program
    {
        public static void Main()
        {
            double straal = 1.2;
            double diameter = straal * 2;
            Console.WriteLine("als de straal {0} is dan is het oppervlak van de cilinder {1}", straal, volume(straal,diameter));
        }
        private static double volume(double straal,double diameter)
        {
            return Math.Round(2 * Math.PI * straal * (straal + diameter), 2);
           
        }
    }
}