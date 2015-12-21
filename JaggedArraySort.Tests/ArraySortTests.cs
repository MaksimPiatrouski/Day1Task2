using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using JaggedArraySort;

namespace JaggedArraySort.Tests
{
    [TestFixture]
    public class ArraySortTest
    {
        #region SortBySum
        public IEnumerable<TestCaseData> TestDataSum
        {
            get
            {
                yield return new TestCaseData(
                    new int[][]
                    {
                        new int[] {6, 8, 10},
                        new int[] {-5,-3},
                        new int[] {1, 2, 3, 4} },

                    new int[][]
                    {
                        new int[] {-5, -3},
                        new int[] {1, 2, 3, 4},
                        new int[] {6, 8, 10} }
                       );


                yield return new TestCaseData(
                    new int[][]
                     {
                        new int[] {0},
                        new int[] {-10, 0, 10, 100},
                        new int[] {-5, -10, -15} },

                    new int[][]
                     {
                        new int[] {-5, -10, -15},
                        new int[] {0},
                        new int[] {-10, 0, 10, 100} });
            }
        }

        #region interface
        [Test, TestCaseSource(typeof(ArraySortTest), "TestDataSum")]
        public static void SortMethod_Test_Interface_BySumAsc(int[][] jaggedArray, int[][] expected)
        {
            IComparer<int[]> comparator = new ComporatorSumAsc();
            ArraySort.Sort(jaggedArray, comparator);
            CollectionAssert.AreEqual(jaggedArray, expected);
        }

        [Test, TestCaseSource(typeof(ArraySortTest), "TestDataSum")]
        public static void SortJMethod_Test_Interface_BySumDesc(int[][] jaggedArray, int[][] expected)
        {
            IComparer<int[]> comparator = new ComporatorSumDesc();
            ArraySort.Sort(jaggedArray, comparator);
            CollectionAssert.AreEqual(jaggedArray, expected.Reverse());
        }
        #endregion

        #region delegate
        [Test, TestCaseSource(typeof(ArraySortTest), "TestDataSum")]
        public static void SortMethod_Test_Delegate_BySumAsc(int[][] jaggedArray, int[][] expected)
        {
            ComporatorSumAsc c = new ComporatorSumAsc();
            ArraySort.Comparator comp = c.Compare;
            ArraySort.Sort(jaggedArray, comp);
            CollectionAssert.AreEqual(jaggedArray, expected);
        }

        [Test, TestCaseSource(typeof(ArraySortTest), "TestDataSum")]
        public static void SortJMethod_Test_Delegate_BySumDesc(int[][] jaggedArray, int[][] expected)
        {
            ComporatorSumDesc c = new ComporatorSumDesc();
            ArraySort.Comparator comp = c.Compare;
            ArraySort.Sort(jaggedArray, comp);
            CollectionAssert.AreEqual(jaggedArray, expected.Reverse());
        }
        #endregion
        #endregion

        #region SortByMax
        public IEnumerable<TestCaseData> TestDataMax
        {
            get
            {
                yield return new TestCaseData(
                    new int[][]
                    {
                        new int[] {1, 2, 3, 4},
                        new int[] {6, 8, 10},
                        new int[] {-5, -3}},

                    new int[][]
                    {
                        new int[] {1, 2, 3, 4},
                        new int[] {-5, -3},
                        new int[] {6, 8, 10} }
                       );


                yield return new TestCaseData(
                    new int[][]
                     {
                        new int[] {0},
                        new int[] {-10, 0, 10, 100},
                        new int[] {-5, -10, -15} },
                    new int[][]
                     {
                        new int[] { 0 },
                        new int[] {-5, -10, -15},
                        new int[] { -10, 0, 10, 100 }}
                      );
            }
        }

        #region interface
        [Test, TestCaseSource(typeof(ArraySortTest), "TestDataMax")]
        public static void SortMethod_Test_Interface_ByMaxAsc(int[][] jaggedArray, int[][] expected)
        {
            IComparer<int[]> comparator = new ComporatorMaxAsc();
            ArraySort.Sort(jaggedArray, comparator);
            CollectionAssert.AreEqual(jaggedArray, expected);
        }

        [Test, TestCaseSource(typeof(ArraySortTest), "TestDataMax")]
        public static void SortJMethod_Test_Interface_ByMaxDesc(int[][] jaggedArray, int[][] expected)
        {
            IComparer<int[]> comparator = new ComporatorMaxDesc();
            ArraySort.Sort(jaggedArray, comparator);
            CollectionAssert.AreEqual(jaggedArray, expected.Reverse());
        }
        #endregion

        #region delegate
        [Test, TestCaseSource(typeof(ArraySortTest), "TestDataMax")]
        public static void SortMethod_Test_Delegate_ByMaxAsc(int[][] jaggedArray, int[][] expected)
        {
            ComporatorMaxAsc c = new ComporatorMaxAsc();
            ArraySort.Comparator comp = c.Compare;
            ArraySort.Sort(jaggedArray, comp);
            CollectionAssert.AreEqual(jaggedArray, expected);
        }

        [Test, TestCaseSource(typeof(ArraySortTest), "TestDataMax")]
        public static void SortJMethod_Test_Delegate_ByMaxDesc(int[][] jaggedArray, int[][] expected)
        {
            ComporatorMaxDesc c = new ComporatorMaxDesc();
            ArraySort.Comparator comp = c.Compare;
            ArraySort.Sort(jaggedArray, comp);
            CollectionAssert.AreEqual(jaggedArray, expected.Reverse());
        }
        #endregion
        #endregion
    }
}