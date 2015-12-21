using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort.Tests
{
    class ComporatorMaxDesc : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            return MaxAbs(a) < MaxAbs(b) ? 1 : (MaxAbs(a) == MaxAbs(b) ? 0 : -1);
        }

        private static int MaxAbs(int[] line)
        {
            int max = line[0];
            for (int i = 0; i < line.Length; i++)
            {
                if (Math.Abs(line[i]) > Math.Abs(max))
                    max = line[i];
            }
            return Math.Abs(max);
        }
    }
}
