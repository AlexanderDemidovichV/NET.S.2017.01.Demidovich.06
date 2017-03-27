using System.Linq;

namespace Task2.Tests
{
    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public static class Comparisons
    {
        /// <summary>
        /// Compares two sz-arrays by row's max elements by ascending order.
        /// </summary>
        /// <param name="a">The first array to compare.</param>
        /// <param name="b">The second array to compare.</param>
        /// <returns>Value greater than 0 if maximum element in
        /// <paramref name="a"/> is greater than maximum element in
        /// <paramref name="b"/>. Zero if sums are equals. Less than
        /// 0 if maximum element in <paramref name="a"/> is less than
        /// maximum element in <paramref name="b"/></returns>
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

        /// <summary>
        /// Compares two sz-arrays by row's max elements by descending order.
        /// </summary>
        /// <param name="a">The first array to compare.</param>
        /// <param name="b">The second array to compare.</param>
        /// <returns>Value greater than 0 if maximum element in
        /// <paramref name="b"/> is greater than maximum element in
        /// <paramref name="a"/>. Zero if sums are equals. Less than
        /// 0 if maximum element in <paramref name="b"/> is less than
        /// maximum element in <paramref name="a"/></returns>
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

        /// <summary>
        /// Compares two sz-arrays by maximum element by descending order.
        /// </summary>
        /// <param name="a">The first array to compare.</param>
        /// <param name="b">The second array to compare.</param>
        /// <returns>Value greater than 0 if minimum element in
        /// <paramref name="b"/> is greater than minimum element in
        /// <paramref name="a"/>. Zero if sums are equals. Less than
        /// 0 if minimum element in <paramref name="b"/> is less than
        /// minimum element in <paramref name="a"/></returns>
        public static int RowMinComparatorDescinding(int[] a, int[] b)
        {
            if (ReferenceEquals(a, b))
                return 0;
            if (a == null)
                return 1;
            if (b == null)
                return -1;

            int minElementA = a.Min();
            int minElementB = b.Min();

            return minElementB.CompareTo(minElementA);
        }


        /// <summary>
        /// Compares two sz-arrays by maximum element by ascending order.
        /// </summary>
        /// <param name="a">The first array to compare.</param>
        /// <param name="b">The second array to compare.</param>
        /// <returns>Value greater than 0 if minimum element in
        /// <paramref name="a"/> is greater than minimum element in
        /// <paramref name="b"/>. Zero if sums are equals. Less than
        /// 0 if minimum element in <paramref name="a"/> is less than
        /// minimum element in <paramref name="b"/></returns>
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

        /// <summary>
        /// Compares two sz-arrays by sum of elements by ascending order.
        /// </summary>
        /// <param name="a">The first array to compare.</param>
        /// <param name="b">The second array to compare.</param>
        /// <returns>Value greater than 0 if sum of elements in
        /// <paramref name="a"/> is greater than sum of elements in
        /// <paramref name="b"/>. Zero if sums are equals. Less than
        /// 0 if sum of elements in <paramref name="a"/> is less than
        /// sum of elements in <paramref name="b"/></returns>
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

        /// <summary>
        /// Compares two sz-arrays by sum of elements by descending order.
        /// </summary>
        /// <param name="a">The first array to compare.</param>
        /// <param name="b">The second array to compare.</param>
        /// <returns>Value greater than 0 if sum of elements in
        /// <paramref name="b"/> is greater than sum of elements in
        /// <paramref name="a"/>. Zero if sums are equals. Less than
        /// 0 if sum of elements in <paramref name="b"/> is less than
        /// sum of elements in <paramref name="a"/></returns>
        public static int RowSumComparatorDescinding(int[] a, int[] b)
        {
            if (ReferenceEquals(a, b))
                return 0;
            if (a == null)
                return 1;
            if (b == null)
                return -1;

            int sumA = a.Sum();
            int sumB = b.Sum();

            return sumB.CompareTo(sumA);
        }
    }
}
