using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySort.Tests
{
    class ComporatorMaxAsc : IJaggedArrayComparator
    {
        public int Compare(int[] a, int[] b)
        {
            return Max(a) > Max(b) ? 1 : (Max(a) == Max(b) ? 0 : -1);
        }

        private static int Max(int[] line)
        {
            int max = line[0];
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] > max)
                    max = line[i];
            }
            return max;
        }
    }
}

