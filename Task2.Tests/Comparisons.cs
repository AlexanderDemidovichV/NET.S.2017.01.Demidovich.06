using System.Linq;

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

        public static int RowMaxComparatorDescending(int[] a, int[] b)
        {
            if (ReferenceEquals(a, b))
                return 0;
            if (a == null)
                return 1;
            if (b == null)
                return -1;

            int maxElementA = a.Max();
            int maxElementB = b.Max();

            return maxElementB.CompareTo(maxElementA);
        }

        public static int RowMinComparatorDescinding(int[] a, int[] b)
        {
            if (ReferenceEquals(a, b))
                return 0;
            if (a == null)
                return -1;
            if (b == null)
                return 1;

            int minElementA = a.Min();
            int minElementB = b.Min();

            return minElementB.CompareTo(minElementA);
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

        public static int RowSumComparatorAscending(int[] a, int[] b)
        {
            if (ReferenceEquals(a, b))
                return 0;
            if (a == null)
                return -1;
            if (b == null)
                return 1;

            int sumA = a.Sum();
            int sumB = b.Sum();

            return sumA.CompareTo(sumB);
        }

        public static int RowSumComparatorDescinding(int[] a, int[] b)
        {
            if (ReferenceEquals(a, b))
                return 0;
            if (a == null)
                return -1;
            if (b == null)
                return 1;

            int sumA = a.Sum();
            int sumB = b.Sum();

            return sumB.CompareTo(sumA);
        }
    }
}
