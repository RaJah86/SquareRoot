using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        public class SquareRootcalculater
        {

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            double a, b, c;

            Console.Write("Введите коэфициент A: ");
            string strA = Console.ReadLine();
            bool resA = double.TryParse(strA, out a);
            if (resA != true)
            {
                Console.WriteLine("не то");
                Console.ReadKey();
                return;
            }

            if (a == 0)
            {
                Console.WriteLine("Уравнение не является квадратным");
                Console.ReadKey();
                return;
            }

            Console.Write("Введите коэфициент B:");
            string strB = Console.ReadLine();
            bool resB = double.TryParse(strB, out b);
            if (resB != true)
            {
                Console.WriteLine("пиши цифры");
                Console.ReadKey();
                return;
            }
            


            Console.Write("введите коэфицент С:");
            string strC = Console.ReadLine();
            bool resC = double.TryParse(strC, out c);
            if (resC != true)
            {
                Console.WriteLine("цифры нада");
                Console.ReadKey();
                return;
            }

            double x1, x2;

           

            if (b == 0)
            {
                Console.WriteLine("Квадратное уравнение является не полным");
                if (-(c / a) > 0)
                {
                    x1 = Math.Sqrt(-c / a);
                    x2 = -Math.Sqrt(-c / a);
                }
                else
                {
                    Console.WriteLine("нет решения");
                    Console.ReadLine();
                    return;
                }
            }

             if(c == 0)
            {
                Console.WriteLine("Уравнение является не полным");
                x1 = 0;
                x2 = -(b / a);
                Console.WriteLine($"X1 = {x1}, X2 = {x2}");
                Console.ReadKey();
                return;
            }

            else
            {
                Console.WriteLine("Дискриминант не вычесляется");
            }

            double D;
            D = b * b - 4 * a * c;
            Console.WriteLine($"Дискриминант D = {D} ");

            if (D > 0)
            {

                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.Write($"Квадратное уравнение имеет два корня x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double x;
                x = -b / (2 * a);
                Console.WriteLine($"Квадратное уравнение имеет один корень x = {x}");
            }
            else
            {
                Console.WriteLine("Квадратное уравнение не имеет корней");
            }

            Console.ReadKey();
            
        }
    }
}
