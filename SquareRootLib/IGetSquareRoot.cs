using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootLib
{
    public enum SquareRootResultEnum { NoRoots, OneRoot, TwoRoots, InvalidCoef}
    public interface IGetSquareRoot
    {
        SquareRootResultEnum GetSquareRoot(double a, double b, double c, out List<double> roots);
    }
}
