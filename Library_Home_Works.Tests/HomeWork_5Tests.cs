using NUnit.Framework;


namespace Library_Home_Works.Tests
{
    public class HomeWork_5Tests
    {
        // Задание 1
        [TestCase(new int[] { -1, -11 }, new int[] { 0, 2})]
        [TestCase(new int[] { }, new int[] { 0, 0})]
        [TestCase(new int[] { 47, -14, -48, -78, 9 }, new int[] { 3, 2})]
        [TestCase(new int[] { 92, 47, -90, 74, -44, 9 }, new int[] { 4, 2})]
        [TestCase(new int[] { 97, 44, -57, 35, -18, 63, -75, -19, -28, 27 }, new int[] { 3, 7})]
        public void OutputNumberInWordTests(int[] arr, int[] expected)
        {
            int[] actual = HomeWork_5.CountOddAndEvenDigit(arr);
            Assert.AreEqual(expected, actual);
        }
        // Задание 2
        [TestCase(new int[] { -1, -11 }, new int[] { -1, -11 })]
        [TestCase(new int[] { }, new int[] {  })]
        [TestCase(new int[] { 47, -14, -48, -78, 9 }, new int[] { 47, -14, 33, -78, 9 })]
        [TestCase(new int[] { 92, 47, -90, 74, -44, 9 }, new int[] { 92, 47, 139, 74, -44, 30 })]
        [TestCase(new int[] { 97, 44, -57, 35, -18, 63, -75, -19, -28, 27 }, new int[] { 97, 44, 141, 35, -18, 17, -75, -19, -94, 27 })]
        public void SumThirdNumArrTests(int[] arr, int[] expected)
        {
            int[] actual = HomeWork_5.SumThirdNumArr(arr);
            Assert.AreEqual(expected, actual);
        }
        // Задание 3
        [TestCase(new int[] { -1, -11 }, new int[] { -98, 88, 78 }, new int[] { -1, -11, -98, 88, 78 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { 47, -14, -48, -78, 9 }, new int[] { 51, 75, 59, 79, -16 }, new int[] { 47, -14, -48, -78, 9, 51, 75, 59, 79, -16 })]
        [TestCase(new int[] { 92, 47, -90, 74, -44, 9 }, new int[] { -45, 89, 45, -46 }, new int[] { 92, 47, -90, 74, -44, 9, -45, 89, 45, -46 })]
        [TestCase(new int[] { 97, 44, -57, 35, -18, 63, -75, -19, -28, 27 }, new int[] { -20, -9 }, new int[] { 97, 44, -57, 35, -18, 63, -75, -19, -28, 27, -20, -9 })]
        public void MergeArrTests(int[] arr1, int[] arr2, int[] expected)
        {
            int[] actual = HomeWork_5.MergeArr(arr1, arr2);
            Assert.AreEqual(expected, actual);
        }
        // Задание 4
        [TestCase(new int[] { -1, -11 }, new int[] { -11, -1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 1, 2, 3 })]
        [TestCase(new int[] { 92, 47, -90, 74, -44, 9 }, new int[] { 74, -44, 9, 92, 47, -90 })]
        [TestCase(new int[] { 97, 44, -57, 35, -18, 63, -75, -19, -28 }, new int[] { 63, -75, -19, -28, 97, 44, -57, 35, -18 })]
        public void SwapPartArrayTests(int[] arr, int[] expected)
        {
            int[] actual = HomeWork_5.SwapPartArray(arr);
            Assert.AreEqual(expected, actual);
        }
        // Задание 5
        [TestCase(new int[] { -1, -11 }, new int[] { -11, -1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { 92, 47, -90, 74, -44, 9 }, new int[] { 9, 92, 47, -90, 74, -44 })]
        [TestCase(new int[] { 97, 44, -57, 35, -18, 63, -75, -19, -28, 27 }, new int[] { 27, 97, 44, -57, 35, -18, 63, -75, -19, -28 })]
        public void ShiftArrayTests(int[] arr, int[] expected)
        {
            int[] actual = HomeWork_5.ShiftArray(arr);
            Assert.AreEqual(expected, actual);
        }
        // Задание 6
        [TestCase(new int[] { -1, -11 }, new int[] { -11, -1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 1, 4, 3, 5 })]
        [TestCase(new int[] { 92, 47, -90, 74, -44, 9 }, new int[] { 47, 92, 74, -90, 9, -44 })]
        [TestCase(new int[] { 97, 44, -57, 35, -18, 63, -75, -19, -28, 27 }, new int[] {44, 97, 35, -57, 63, -18, -19, -75, 27, -28 })]
        public void SwapOddAndDigitIndexTests(int[] arr, int[] expected)
        {
            int[] actual = HomeWork_5.SwapOddAndDigitIndex(arr);
            Assert.AreEqual(expected, actual);
        }
        // Задание 7
        [TestCase(new int[] { -1, -11 }, 1, 0)]
        [TestCase(new int[] { 0 }, 0, 0)]
        [TestCase(new int[] { 1, 2, 0, 4, 5 }, 0, 9)]
        [TestCase(new int[] { 92, 47, -90, 74, -44, 0 }, 0, 0)]
        [TestCase(new int[] { 97, 44, -57, 35, 0, 63, 0, -19, -28, 27 }, 0, 43)]
        public void GetMinAndSumAfterZeroTests(int[] arr, int min, int sum)
        {
            (int, int) expected = (min, sum);
            (int, int) actual = HomeWork_5.GetMinAndSumAfterZero(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void GetMinAndSumAfterZeroNegativeTest(int[] arr)
        {
            Assert.Throws<System.IndexOutOfRangeException>(() => HomeWork_5.GetMinAndSumAfterZero(arr));
        }
        // Задание 8
        [TestCase(new int[] { -1, -11 }, new int[] { -11, -1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 4, 5, 1, 2, 3 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 92, 47, -90, 74, -44, 9 }, new int[] { -90, -44, 9, 47, 74, 92 })]
        [TestCase(new int[] { 97, 44, -57, 35, -18, 63, -75, -18, -28 }, new int[] { -75, -57, -28, -18, -18, 35, 44, 63, 97 })]
        public void SortInsertTests(int[] arr, int[] expected)
        {
            int[] actual = HomeWork_5.SortInsert(arr);
            Assert.AreEqual(expected, actual);
        }
        // Задание 9
        [TestCase(new int[] { -1, -11 }, new int[] { -11, -1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 4, 5, 1, 2, 3 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 92, 47, -90, 74, -44, 9 }, new int[] { -90, -44, 9, 47, 74, 92 })]
        [TestCase(new int[] { 97, 44, -57, 35, -18, 63, -75, -18, -28 }, new int[] { -75, -57, -28, -18, -18, 35, 44, 63, 97 })]
        public void SortInsertSelect(int[] arr, int[] expected)
        {
            int[] actual = HomeWork_5.SortInsert(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}
