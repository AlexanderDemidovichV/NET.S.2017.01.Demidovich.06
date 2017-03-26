using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Sorter
    {
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
                    if (comparison(array[j - 1], array[j]) < 0)
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
            T i = value1;
            value1 = value2;
            value2 = i;
        }
    }
}
