using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solver;

namespace Solver.Tests
{
    [TestClass]
    public class SolverTest
    {
        [TestMethod]
        public void OrdinaryArray()
        {
            var ordinaryArr = new double[] { 4, 0, 3, 19, 492, -10, 1 };

            var result = SummerTwoMinArr.ReturnSum(ordinaryArr);

            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void EmptyArray()
        {
            var emptyArr = new double[] { };

            Assert.ThrowsException<Exception>(() => SummerTwoMinArr.ReturnSum(emptyArr));
        }

        [TestMethod]
        public void ArrayWithNaN()
        {
            var arrWithNaN = new double[] { 0, 10, 11, -100, double.NaN };

            Assert.ThrowsException<Exception>(() => SummerTwoMinArr.ReturnSum(arrWithNaN));
        }

        [TestMethod]
        public void NaNArray()
        {
            var nanArr = new double[] { double.NaN, double.NaN, double.NaN, double.NaN };

            Assert.ThrowsException<Exception>(() => SummerTwoMinArr.ReturnSum(nanArr));
        }

        [TestMethod]
        public void BigArray()
        {
            var bigArr = new double[100000000];
            for (int i = 0; i < bigArr.Length; i++)
                bigArr[i] = i;

            var result = SummerTwoMinArr.ReturnSum(bigArr);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IdenticalElements()
        {
            var arr = new double[] { 5, 5, 5, 5, 5 };

            var result = SummerTwoMinArr.ReturnSum(arr);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void ArrMaxValue()
        {
            var arrMax = new double[] { int.MaxValue, int.MaxValue, int.MaxValue };

            var result = SummerTwoMinArr.ReturnSum(arrMax);
            
            Assert.AreEqual(4294967294, result);
        }

        [TestMethod]
        public void ArrMinValue()
        {
            var arrMin = new double[] { int.MinValue, int.MinValue, int.MinValue };

            var result = SummerTwoMinArr.ReturnSum(arrMin);

            Assert.AreEqual(-4294967296, result);
        }

        [TestMethod]
        public void ArrIsNull()
        {
            double[] arr = null;

            Assert.ThrowsException<Exception>(() => SummerTwoMinArr.ReturnSum(arr));
        }

        [TestMethod]
        public void OneElem()
        {
            var arr = new double[] { 42 };

            Assert.ThrowsException<Exception>(() => SummerTwoMinArr.ReturnSum(arr));
        }

        [TestMethod]
        public void ArrWithNegativeInfinity()
        {
            var arr = new double[] { 0, double.NegativeInfinity, 0 };

            var result = SummerTwoMinArr.ReturnSum(arr);

            Assert.AreEqual(double.NegativeInfinity, result);
        }

        [TestMethod]
        public void ArrWithSeveralNegativeInfinity()
        {
            var arr = new double[] { 0, double.NegativeInfinity, double.NegativeInfinity, 0 };

            var result = SummerTwoMinArr.ReturnSum(arr);

            Assert.AreEqual(double.NegativeInfinity * 2, result);
        }
    }
}
