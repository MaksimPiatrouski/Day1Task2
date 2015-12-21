using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort
{
    public class ArraySort
    {
        public delegate int Comparator(int[] a, int[] b);

        public static void Sort(int[][] jaggedArray, Comparator comp)
        {
            if (jaggedArray == null || comp == null)
                throw new ArgumentNullException();
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1 - i; j++)
                {
                    if (comp.Invoke(jaggedArray[j], jaggedArray[j + 1]) > 0)
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                }
            }
        }

        public static void Sort(int[][] jaggedArray, IComparer<int[]> comparator)
        {
            if (jaggedArray == null || comparator == null)
                throw new ArgumentNullException();
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - i - 1; j++)
                {
                    if (comparator.Compare(jaggedArray[j], jaggedArray[j + 1]) == 1)
                    {
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        public static void Sort(int[][] jaggedArray, Adapter adpater)
        {
            if (jaggedArray == null || adpater == null)
                throw new ArgumentNullException();
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = 0; j < jaggedArray.Length - 1 - i; j++)
                {
                    if (adpater.Compare(jaggedArray[j], jaggedArray[j + 1]) > 0)
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                }
            }
        }

        public sealed class Adapter : IComparer<int[]>
        {
            Comparator comparator;

            public Adapter(Comparator comparator)
            {
                Comparator = comparator;
            }

            public int Compare(int[] a, int[] b)
            {
                return Comparator.Invoke(a, b);
            }

            public Comparator Comparator
            {
                private get
                {
                    return this.comparator;
                }

                set
                {
                    this.comparator = value;
                }
            }
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
    }
}