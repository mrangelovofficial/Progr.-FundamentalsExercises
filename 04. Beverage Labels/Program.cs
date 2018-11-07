using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyI = double.Parse(Console.ReadLine());
            double sugarI = double.Parse(Console.ReadLine());

            double energy = (volume / 100) * energyI;
            double sugar = (volume / 100) * sugarI;

            Console.WriteLine("{0}ml {1}:",volume,name);
            Console.WriteLine("{0}kcal, {1}g sugars",energy,sugar);
        }
    }
}
