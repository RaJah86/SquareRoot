using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootLib
{
    public class SquareRootSolver : IGetSquareRoot
    {
        public SquareRootResultEnum GetSquareRoot(double a, double b, double c, out List<double> roots)
        {


            #region
            //double D;
            //D = b * b - 4 * a * c;
            //Console.WriteLine($"Дискриминант D = {D} ");

            //if (D > 0)
            //{
            //    double x1, x2;

            //    x1 = (-b - Math.Sqrt(D)) / (2 * a);
            //    x2 = (-b + Math.Sqrt(D)) / (2 * a);
            //    Console.Write($"Квадратное уравнение имеет два корня x1 = {x1}, x2 = {x2}");
            //}
            //else if (D == 0)
            //{
            //    double x;
            //    x = -b / (2 * a);
            //    Console.Write($"Квадратное уравнение имеет один корень x = {x}");
            //}
            //else
            //{
            //    Console.Write("Квадратное уравнение не имеет корней");
            //}


            //Console.ReadKey();
            #endregion

            roots = new List<double>();

            double D;
            D = b * b - 4 * a * c;

            if (a==0)
            {
                return SquareRootResultEnum.InvalidCoef;
            }

            if (D > 0)
            {
                double x1, x2;

                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                roots.Add(x1);
                roots.Add(x2);
                return SquareRootResultEnum.TwoRoots;
            }
            else if (D == 0)
            {
                double x;
                x = -b / (2 * a);

                roots.Add(x);
                return SquareRootResultEnum.OneRoot;

            }
            else
            {
                return SquareRootResultEnum.NoRoots;
            }


        }
    }
}
