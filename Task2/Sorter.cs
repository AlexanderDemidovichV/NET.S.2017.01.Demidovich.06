using System;

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
        /// <param name="array">The jagged, zero-based Array to sort.</param>
        /// <param name="comparison">The comparison to use when comparing elements.</param>
        /// <exception cref="System.ArgumentNullException">
        /// array is null
        /// or
        /// comparison is null
        /// </exception>
        public static void Sort(this int[][] array, Comparison<int[]> comparison)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (comparison == null)
                throw new ArgumentNullException(nameof(comparison));

            for (int i = 0; i < array.Length; i++)
            {
                bool isSwap = false;
                for (int j = 1; j < array.Length - i; j++)
                    if (comparison(array[j - 1], array[j]) > 0)
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        isSwap = true;
                    }
                if (isSwap == false)
                    break;
            }
        }   

        private static void Swap<T>(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
}
