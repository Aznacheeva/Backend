using System;
using System.Collections.Generic;

namespace Solver
{
    public class SummerTwoMinArr
    {
        public static double ReturnSum(double[] arr)
        {
            if (arr is null) throw new Exception("Массив пустой");
            if (arr.Length < 2) throw new Exception("В массиве меньше двух элементов");

            double result = 0;
            var list = new List<double>(arr);

            result += GetMin(arr);
            list.Remove(GetMin(arr));
            result += GetMin(list.ToArray());

            return result;
        }

        private static double GetMin(double[] arr)
        {
            double min = int.MaxValue;
            foreach (var e in arr)
            {
                if (double.IsNaN(e))
                    throw new Exception("Массив содержит как минимум одно нечисло");
                if (e < min)
                    min = e;
            }
            return min;
        }
    }
}
