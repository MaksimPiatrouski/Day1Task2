using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public class ArraySort
    {
        public static void JaggedSortBySumAsc(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - i - 1; j++)
                {
                    if (ArraySort.CountSum(jaggedArray[j]) > ArraySort.CountSum(jaggedArray[j + 1]))
                    {
                        ArraySort.Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        public static void JaggedSortBySumDesc(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - i - 1; j++)
                {
                    if (ArraySort.CountSum(jaggedArray[j]) < ArraySort.CountSum(jaggedArray[j + 1]))
                    {
                        ArraySort.Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        public static void JaggedSortByMaxAsc(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - i - 1; j++)
                {
                    if (ArraySort.FindMax(jaggedArray[j]) > ArraySort.FindMax(jaggedArray[j + 1]))
                    {
                        ArraySort.Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        public static void JaggedSortByMaxDesc(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - i - 1; j++)
                {
                    if (ArraySort.FindMax(jaggedArray[j]) < ArraySort.FindMax(jaggedArray[j + 1]))
                    {
                        ArraySort.Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        public static void JaggedSortByMinAsc(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - i - 1; j++)
                {
                    if (ArraySort.FindMin(jaggedArray[j]) > ArraySort.FindMin(jaggedArray[j + 1]))
                    {
                        ArraySort.Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        public static void JaggedSortByMinDesc(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - i - 1; j++)
                {
                    if (ArraySort.FindMin(jaggedArray[j]) < ArraySort.FindMin(jaggedArray[j + 1]))
                    {
                        ArraySort.Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }
        public static int CountSum(int[] line)
        {
            int sum = 0;
            foreach (int i in line)
            {
                sum += i;
            }
            return sum;
        }

        public static int FindMax(int[] line)
        {
            int max = line[0];
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] > max)
                    max = line[i];
            }
            return max;
        }

        public static int FindMin(int[] line)
        {
            int min = line[0];
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] < min)
                    min = line[i];
            }
            return min;
        }

        public static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
}