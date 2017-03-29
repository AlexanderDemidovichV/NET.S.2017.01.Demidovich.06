﻿using NUnit.Framework;

namespace Task2.Tests
{
    public class SorterTests
    {

        [Test]
        public void testRowMaxAscending()
        {
            int[][] array1 = new[]
            {
                new int[] {4},
                null,
                new int[] {1, 2},
                new int[] {1, 2, 3}
            };

            int[][] array2 = new[]
            {
                null,
                new int[] {1, 2},
                new int[] {1, 2, 3},
                new int[] {4}
            };

            array1.Sort(new SortRowMaxAscending());

            Assert.AreEqual(array1.Length, array2.Length);
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
        public void testRowMaxDescending()
        {
            int[][] array1 = new[]
            {
                new int[] {1},
                new int[] {1, 2, 3},
                new int[] {1, 2}
            };

            int[][] array2 = new[]
            {
                new int[] {1, 2, 3},
                new int[] {1, 2},
                new int[] {1}
            };

            array1.Sort(new SortRowMaxDescending());

            Assert.AreEqual(array1.Length, array2.Length);
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
        public void testRowMinAscending()
        {
            int[][] array1 = new[]
            {
                new int[] {1},
                new int[] {4, 2, 3},
                new int[] {5, 6}
            };

            int[][] array2 = new[]
            {
                new int[] {1},
                new int[] {4, 2, 3},
                new int[] {5, 6}
            };

            array1.Sort(new SortRowMinAscending());

            Assert.AreEqual(array1.Length, array2.Length);
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
        public void testRowMinDescending()
        {
            int[][] array1 = new[]
            {
                new int[] {1},
                new int[] {4, 2, 3},
                new int[] {5, 6}
            };

            int[][] array2 = new[]
            {
                new int[] {5, 6},
                new int[] {4, 2, 3},
                new int[] {1}
            };

            array1.Sort(new SortRowMinDescinding());

            Assert.AreEqual(array1.Length, array2.Length);
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
        public void testRowSumDescending()
        {
            int[][] array1 = new[]
            {
                new int[] {1},
                new int[] {4, 2, 3},
                new int[] {5, 6}
            };

            int[][] array2 = new[]
            {
                new int[] {5, 6},
                new int[] {4, 2, 3},
                new int[] {1}
            };

            array1.Sort(new SortRowSumDescinding());

            Assert.AreEqual(array1.Length, array2.Length);
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
        public void testRowSumAscending()
        {
            int[][] array1 = new[]
            {
                new int[] {1},
                new int[] {4, 2, 3},
                new int[] {5, 6}
            };

            int[][] array2 = new[]
            {
                new int[] {1},
                new int[] {4, 2, 3},
                new int[] {5, 6}
            };

            array1.Sort(new SortRowSumAscending());

            Assert.AreEqual(array1.Length, array2.Length);
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
    }
}
