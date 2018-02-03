using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareRootLib;
using System.Collections.Generic;
using System.Linq;

namespace SquareRootTests
{
    [TestClass]
    public class SquareRootTest
    {
        [TestMethod]
        public void TestTwoRoots()
        {
            IGetSquareRoot sq = null;
            List<double> roots;
            var res = sq.GetSquareRoot(1d, -2d, -3d, out roots);
            Assert.AreEqual(SquareRootResultEnum.TwoRoots,res);
            Assert.IsTrue(roots.Count == 2);
            Assert.IsTrue(CloseEnough(roots.First(), -1d, Double.Epsilon));
            Assert.IsTrue(CloseEnough(roots[1], 3d, Double.Epsilon));
        }

        [TestMethod]
        public void TestOneRoot()
        {
            IGetSquareRoot sq = null;
            List<double> roots;
            var res = sq.GetSquareRoot(1d, -4d, 4d, out roots);
            Assert.AreEqual(SquareRootResultEnum.OneRoot, res);
            Assert.IsTrue(roots.Count == 1);
            Assert.IsTrue(CloseEnough(roots.First(), 2d, Double.Epsilon));
        }

        [TestMethod]
        public void TestNoRoots()
        {
            IGetSquareRoot sq = null;
            List<double> roots;
            var res = sq.GetSquareRoot(1d, 1d, 1d, out roots);
            Assert.AreEqual(SquareRootResultEnum.NoRoots, res);
            Assert.IsTrue(roots.Count == 0);
        }

        [TestMethod]
        public void TestInvalid()
        {
            IGetSquareRoot sq = null;
            List<double> roots;
            var res = sq.GetSquareRoot(0d, 0d, 0d, out roots);
            Assert.AreEqual(SquareRootResultEnum.InvalidCoef, res);
            Assert.IsTrue(roots.Count == 0);
        }


        public bool CloseEnough(double a, double b, double delta)
        {
            if (Math.Abs(a - b) < delta) return true;
            else return false;
        }
    }

}
