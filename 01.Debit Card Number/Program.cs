using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "";
            for (int i = 0; i < 4; i++)
            {
                int n = int.Parse(Console.ReadLine());
                data = data + $"{n:D4} ";
            }
            Console.WriteLine(data);
        }
    }
}
