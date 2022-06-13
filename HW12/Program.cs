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
            //Console.WriteLine("r=3 Length={0}", Сircle.Length(3));
            //Console.WriteLine("r=3 Square={0}", Сircle.Length(3));

            //Console.WriteLine("x=1,y=2,r=5,x1=0,y1=0 IsPointInsiceCircle={0}", Сircle.IsPointInsiceCircle(1, 0, 2, 0, 0));
            //Console.WriteLine("x=1,y=2,r=1,x1=0,y1=0 IsPointInsiceCircle={0}", Сircle.IsPointInsiceCircle(2, 0, 1, 0, 0));
            //Console.WriteLine("x=1,y=2,r=1,x1=0,y1=0 IsPointInsiceCircle={0}", Сircle.IsPointInsiceCircle(2, 0, 1, 1, 0));

            //Console.Write("press any key to exit");
            //Console.ReadLine();
            //Console.WriteLine(Circle.);

            Circle circle = new Circle.Lenght();
            Circle circle2 = new Circle.Area();
            Circle circle3 = new Circle.Coordinates();
            Console.ReadKey();
        }
       public class Circle
        {
         static void Lenght()
        {
            double L, R;
            Console.WriteLine("Для нахождения длины окружности введите радиус");
            R = Convert.ToDouble(Console.ReadLine());
            L =  2 * Math.PI*R;
            
            Console.WriteLine("Длина окружности равна {0}",L);
            
            Console.WriteLine("для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
            static void Area()
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
