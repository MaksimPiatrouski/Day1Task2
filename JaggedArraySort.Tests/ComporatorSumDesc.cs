using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort.Tests
{
    class ComporatorSumDesc : IJaggedArrayComparator
    {
        public int Compare(int[] a, int[] b)
        {
            return Sum(a) < Sum(b) ? 1 : (Sum(a) == Sum(b) ? 0 : -1);
        }

        private static int Sum(int[] line)
        {
            int sum = 0;
            foreach (int i in line)
            {
                sum += i;
            }
            return sum;
        }
    }
}
