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
        { }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1251);




            double a;
            Console.Write("Введите коэфициент A: ");
            string strA = Console.ReadLine();
            bool resA = double.TryParse(strA, out a);
            if (resA != true)
            {
                Console.WriteLine("xuy");
                Console.ReadKey();
                return;
            }

            double b;
            Console.Write("Введите коэфициент B:");
            string strB = Console.ReadLine();
            bool resB = double.TryParse(strB, out b);
            if (resB != true)
            {
                Console.WriteLine("пиши цифры");
                Console.ReadKey();
                return;
            }

            double c;
            Console.Write("введите коэфицент С:");
            string strC = Console.ReadLine();
            bool resC = double.TryParse(strC, out c);
            if (resC != true)
            {
                Console.WriteLine("цифры нада");
                Console.ReadKey();
                return;
            }


            double D;
            D = b * b - 4 * a * c;
            Console.WriteLine($"Дискриминант D = {D} ");

            if (D > 0)
            {
                double x1, x2;

                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.Write($"Квадратное уравнение имеет два корня x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double x;
                x = -b / (2 * a);
                Console.Write($"Квадратное уравнение имеет один корень x = {x}");
            }
            else
            {
                Console.Write("Квадратное уравнение не имеет корней");
            }


            Console.ReadKey();

        }
    }
}
