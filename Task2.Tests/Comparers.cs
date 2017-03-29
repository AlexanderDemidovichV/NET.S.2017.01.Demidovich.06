using System.Linq;

namespace Task2.Tests
{
    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class SortRowMaxAscending : IComparer<int[]>
    {
        /// <summary>
        /// Compares two sz-arrays by row's max elements by ascending order.
        /// </summary>
        /// <param name="lhs">The first array to compare.</param>
        /// <param name="rhs">The second array to compare.</param>
        /// <returns>Value greater than 0 if maximum element in
        /// <paramref name="lhs"/> is greater than maximum element in
        /// <paramref name="rhs"/>. Zero if sums are equals. Less than
        /// 0 if maximum element in <paramref name="lhs"/> is less than
        /// maximum element in <paramref name="rhs"/></returns>
        public int Compare(int[] lhs, int[] rhs)
        {
            if (ReferenceEquals(lhs, rhs))
                return 0;
            if (ReferenceEquals(lhs, null))
                return -1;
            if (ReferenceEquals(rhs, null))
                return 1;

            return lhs.Max().CompareTo(rhs.Max());
        }
    }

    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class SortRowMaxDescending : IComparer<int[]>
    {
        /// <summary>
        /// Compares two sz-arrays by row's max elements by descending order.
        /// </summary>
        /// <param name="lhs">The first array to compare.</param>
        /// <param name="rhs">The second array to compare.</param>
        /// <returns>Value greater than 0 if maximum element in
        /// <paramref name="rhs"/> is greater than maximum element in
        /// <paramref name="lhs"/>. Zero if sums are equals. Less than
        /// 0 if maximum element in <paramref name="rhs"/> is less than
        /// maximum element in <paramref name="lhs"/></returns>
        public int Compare(int[] lhs, int[] rhs)
        {
            if (ReferenceEquals(lhs, rhs))
                return 0;
            if (ReferenceEquals(lhs, null))
                return 1;
            if (ReferenceEquals(rhs, null))
                return -1;

            return rhs.Max().CompareTo(lhs.Max());
        }

    }

    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class SortRowMinDescinding : IComparer<int[]>
    {
        /// <summary>
        /// Compares two sz-arrays by maximum element by descending order.
        /// </summary>
        /// <param name="lhs">The first array to compare.</param>
        /// <param name="rhs">The second array to compare.</param>
        /// <returns>Value greater than 0 if minimum element in
        /// <paramref name="rhs"/> is greater than minimum element in
        /// <paramref name="lhs"/>. Zero if sums are equals. Less than
        /// 0 if minimum element in <paramref name="rhs"/> is less than
        /// minimum element in <paramref name="lhs"/></returns>
        public int Compare(int[] lhs, int[] rhs)
        {
            if (ReferenceEquals(lhs, rhs))
                return 0;
            if (ReferenceEquals(lhs, null))
                return 1;
            if (ReferenceEquals(rhs, null))
                return -1;

            return rhs.Min().CompareTo(lhs.Min());
        }
    }

    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class SortRowMinAscending : IComparer<int[]>
    {
        /// <summary>
        /// Compares two sz-arrays by maximum element by ascending order.
        /// </summary>
        /// <param name="lhs">The first array to compare.</param>
        /// <param name="rhs">The second array to compare.</param>
        /// <returns>Value greater than 0 if minimum element in
        /// <paramref name="lhs"/> is greater than minimum element in
        /// <paramref name="rhs"/>. Zero if sums are equals. Less than
        /// 0 if minimum element in <paramref name="lhs"/> is less than
        /// minimum element in <paramref name="rhs"/></returns>
        public int Compare(int[] lhs, int[] rhs)
        {
            if (ReferenceEquals(lhs, rhs))
                return 0;
            if (ReferenceEquals(lhs, null))
                return -1;
            if (ReferenceEquals(rhs, null))
                return 1;

            return lhs.Min().CompareTo(rhs.Min());
        }
    }


    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class SortRowSumAscending : IComparer<int[]>
    {
        /// <summary>
        /// Compares two sz-arrays by sum of elements by ascending order.
        /// </summary>
        /// <param name="lhs">The first array to compare.</param>
        /// <param name="rhs">The second array to compare.</param>
        /// <returns>Value greater than 0 if sum of elements in
        /// <paramref name="lhs"/> is greater than sum of elements in
        /// <paramref name="rhs"/>. Zero if sums are equals. Less than
        /// 0 if sum of elements in <paramref name="lhs"/> is less than
        /// sum of elements in <paramref name="rhs"/></returns>
        public int Compare(int[] lhs, int[] rhs)
        {
            if (ReferenceEquals(lhs, rhs))
                return 0;
            if (ReferenceEquals(lhs, null))
                return -1;
            if (ReferenceEquals(rhs, null))
                return 1;

            return lhs.Sum().CompareTo(rhs.Sum());
        }
    }

    /// <summary>
    /// Provides methods to compare two sz-arrays by specified order
    /// </summary>
    public class SortRowSumDescinding : IComparer<int[]>
    {
        /// <summary>
        /// Compares two sz-arrays by sum of elements by descending order.
        /// </summary>
        /// <param name="lhs">The first array to compare.</param>
        /// <param name="rhs">The second array to compare.</param>
        /// <returns>Value greater than 0 if sum of elements in
        /// <paramref name="rhs"/> is greater than sum of elements in
        /// <paramref name="lhs"/>. Zero if sums are equals. Less than
        /// 0 if sum of elements in <paramref name="rhs"/> is less than
        /// sum of elements in <paramref name="lhs"/></returns>
        public int Compare(int[] lhs, int[] rhs)
        {
            if (ReferenceEquals(lhs, rhs))
                return 0;
            if (ReferenceEquals(lhs, null))
                return 1;
            if (ReferenceEquals(rhs, null))
                return -1;

            return rhs.Sum().CompareTo(lhs.Sum());
        }
    }
}

