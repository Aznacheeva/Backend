using System;
using Solver;

namespace ByndyuBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new double[] { 4, 0, 3, 19, 492, -10, 1 };
            Console.WriteLine(SummerTwoMinArr.ReturnSum(arr));
        }
    }
}
