using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = Convert.ToDouble(Console.ReadLine());
            double L = Circle.GetLenght(R);
            double S = Circle.GetArea(R);
            Console.WriteLine($"{L} \n{S}");
            Console.ReadKey();
        }
    }
}
