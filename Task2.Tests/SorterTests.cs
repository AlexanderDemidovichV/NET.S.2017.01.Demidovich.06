using NUnit.Framework;

namespace Task2.Tests
{
    public class SorterTests
    {

        [Test]
        public void testFailToPassNullParameters()
        {
            int[][] array1 = new[]
            {
                new int[] {1},
                null,
                new int[] {1, 2},
                new int[] {1, 2, 3}
            };

            int[][] array2 = new[]
            {
                new int[] {1, 2, 3},
                new int[] {1, 2},
                new int[] {1},
                null
            };

            array1.Sort(Comparisons.RowMaxComparatorAscending);

            Assert.AreEqual(array1.Length, array2.Length,
                "Expected and actual matrixes have a different number of rows");
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == null && array2[i] == null)
                    continue;
                if (array1[i] == null)
                    Assert.Fail($"Expected null, but found {array2[i]}");
                Assert.AreEqual(array1[i].Length, array2[i].Length,
                    "Length of actual matrix is differ from expected");
                for (int j = 0; j < array2[i].Length; j++)
                    Assert.AreEqual(array1[i][j], array2[i][j],
                        "Element in actual matrix is differ from expected");
            }
        }

        [Test]
        public void testRowMinComparatorAscending()
        {
            int[][] array1 = new[]
            {
                new int[] {1},
                new int[] {1, 2},
                new int[] {1, 2, 3}
            };

            int[][] array2 = new[]
            {
                new int[] {1},
                new int[] {1, 2},
                new int[] {1, 2, 3}
            };

            array1.Sort(Comparisons.RowMaxComparatorAscending);

            Assert.AreEqual(array1.Length, array2.Length);
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == null && array2[i] == null)
                    continue;

                if (array1[i] == null)
                    Assert.Fail($"Expected null, but found {array2[i]}");

                //Assert.AreEqual(array1[i].Length, array2[i].Length,
                //    "Length of actual matrix is differ from expected");

                for (int j = 0; j < array2[i].Length; j++)
                    Assert.AreEqual(array1[i][j], array2[i][j],
                        "Element in actual matrix is differ from expected");
            }
        }
    }
}
