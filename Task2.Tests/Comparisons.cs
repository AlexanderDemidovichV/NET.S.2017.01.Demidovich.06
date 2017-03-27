using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Tests
{
    public static class Comparisons
    {
        public static int RowMaxComparatorAscending(int[] a, int[] b)
        {
            if (ReferenceEquals(a, b))
                return 0;
            if (a == null)
                return -1;
            if (b == null)
                return 1;

            int maxElementA = a.Max();
            int maxElementB = b.Max();

            return maxElementA.CompareTo(maxElementB);
        }

        public static int RowMinComparatorAscending(int[] a, int[] b)
        {
            if (ReferenceEquals(a, b))
                return 0;
            if (a == null)
                return -1;
            if (b == null)
                return 1;

            int minElementA = a.Min();
            int minElementB = b.Min();

            return minElementA.CompareTo(minElementB);
        }
    }
}
