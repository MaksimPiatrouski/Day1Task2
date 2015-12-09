using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public class ArraySort
    {
        public static void Sort(int[][] jaggedArray, Func<int[], int> myFunc, int order)
        {
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - i - 1; j++)
                {
                    if ((myFunc(jaggedArray[j]) < myFunc(jaggedArray[j + 1]) && order == 0))
                    {
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }

                    else if ((myFunc(jaggedArray[j]) > myFunc(jaggedArray[j + 1]) && order == 1))
                    {
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        public static int Sum(int[] line)
        {
            int sum = 0;
            foreach (int i in line)
            {
                sum += i;
            }
            return sum;
        }

        public static int Max(int[] line)
        {
            int max = line[0];
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] > max)
                    max = line[i];
            }
            return max;
        }

        public static int Min(int[] line)
        {
            int min = line[0];
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] < min)
                    min = line[i];
            }
            return min;
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
}