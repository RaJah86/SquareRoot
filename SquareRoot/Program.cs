using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.OutputEncoding = Encoding.GetEncoding(1251);
            Console.Write("Введите коэфициент A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите коэфициент B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите коэфициент C: ");
            c = double.Parse(Console.ReadLine());

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
