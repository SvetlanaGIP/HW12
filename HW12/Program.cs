using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:

            //метод, определяющий длину окружности по заданному радиусу;
            //метод, определяющий площадь круга по заданному радиусу;
            //метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
        }
       public class Circle
        {
         static void Lenght()
        {
            double L, R;
            Console.WriteLine("Для нахождения длины окружности введите радиус");
            R = Convert.ToDouble(Console.ReadLine());
            L =  2 * Math.PI*R;
            
            Console.WriteLine(L);
            
            Console.WriteLine("для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
            static void Square()
            {
                double R, S;
                Console.WriteLine("Для нахождения площади окружности введите радиус");
                R = Convert.ToDouble(Console.ReadLine());
                S = Math.PI * Math.Pow(R, 2);
                Console.WriteLine(S);
                Console.WriteLine("для завершения нажмите любую клавишу на клавиатуре");
                Console.ReadKey();
            }

            //x^2 + y^2 = R^2
            static void Coordinates()
            {
                double R, x1, y1, x2, y2;
                Console.WriteLine("Для определения, находятся ли точки на окружности введите радиус");
                R = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите координаты центра окружности");
                x1 = Convert.ToDouble(Console.ReadLine());
                y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("введите координаты которых необходимо провеить на принадлежность к окружности ");
                x2 = Convert.ToDouble(Console.ReadLine());
                y2 = Convert.ToDouble(Console.ReadLine());
                // если дельты х и у равны радиусу, пишем принадлежат
                //если нет, пшем что точки не принадлежат
                double hypotenuse;

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
                
                Console.WriteLine("для завершения нажмите любую клавишу на клавиатуре");
                Console.ReadKey();
            }
        }
        

    }
}
