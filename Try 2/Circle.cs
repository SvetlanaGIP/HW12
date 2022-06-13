using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_2
{
    static class Circle
    {
        public static GetLenght(double R, double L)
        {
            L = 2 * Math.PI * R;
            return L;
        }

        static public GetArea(double R, double S)
        {
            S = Math.PI * Math.Pow(R, 2);
            return S;
        }
        static public GetCoordinates(double R, double hypotenuse, double x1, double x2, double y1, double y2, )
        {
            double x = x2 - x1;
            double y = y2 - y1;

            hypotenuse = Math.Sqrt(x * x + y * y);
            if (hypotenuse == R)
            {
                Console.WriteLine("Указанная точка лежит на окружности");
            }
            else
            {
                Console.WriteLine("Указанная точка НЕ лежит на окружности");
            }

        }

    }
}
