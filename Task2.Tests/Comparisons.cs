using System.Linq;

namespace Task2.Tests
{
    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class RowMaxComparerAscending : IComparer<int[]>
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
        public int Compare(int[] a, int[] b)
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
    }

    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class RowMaxComparerDescending : IComparer<int[]>
    {
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
        public int Compare(int[] a, int[] b)
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

    }

    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class RowMinComparerDescinding : IComparer<int[]>
    {
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
        public int Compare(int[] a, int[] b)
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
    }

    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class RowMinComparerAscending : IComparer<int[]>
    {
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
        public int Compare(int[] a, int[] b)
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


    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class RowSumComparerAscending : IComparer<int[]>
    {
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
        public int Compare(int[] a, int[] b)
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
    }

    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class RowSumComparerDescinding : IComparer<int[]>
    {
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
        public int Compare(int[] a, int[] b)
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

