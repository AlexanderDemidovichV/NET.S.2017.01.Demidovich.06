using System;
using System.Collections.Generic;

namespace Task2
{
    /// <summary>
    /// Provides static sort methods.
    /// </summary>
    public static class Sorter
    {
        /// <summary>
        /// Sorts the elements in an jagged array using the specified Comparison.
        /// </summary>
        /// <param name="array">The jagged, zero-based array to sort.</param>
        /// <param name="comparer">The comparer to use when comparing elements.</param>
        /// <exception cref="System.ArgumentNullException">
        /// array is null
        /// or
        /// comparer is null
        /// </exception>
        public static void Sort(this int[][] array, IComparer<int[]> comparer)
        {
            if (ReferenceEquals(array, null))
                throw new ArgumentNullException(nameof(array));

            if (ReferenceEquals(comparer, null))
                throw new ArgumentNullException(nameof(comparer));

            for (int i = 0; i < array.Length; i++)
            {
                bool isSwap = false;
                for (int j = 1; j < array.Length - i; j++)
                    if (comparer.Compare(array[j - 1], array[j]) > 0)
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        isSwap = true;
                    }
                if (isSwap == false)
                    break;
            }
        }

        /// <summary>
        /// Sorts the elements in an jagged array using the specified Comparison.
        /// </summary>
        /// <param name="array">The jagged, zero-based array to sort.</param>
        /// <param name="comparison">The comparison to use when comparing elements.</param>
        /// <exception cref="System.ArgumentNullException">
        /// array is null
        /// or
        /// comparer is null
        /// </exception>
        public static void Sort(this int[][] array, Comparison<int[]> comparison)
        {
            if (ReferenceEquals(comparison, null))
                throw new ArgumentNullException($"{nameof(comparison)} is null.");

            Sort(array, new ComparisonAdaptor<int[]>(comparison));
        }

        private static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
