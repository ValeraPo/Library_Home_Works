using NUnit.Framework;

namespace Library_Home_Works.Tests
{
    public class HomeWork_4Tests
    {
        // Задание 1
        [TestCase(50, new double[] { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000 })]
        [TestCase(100, new double[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000})]
        [TestCase(500, new double[] { 500, 1000 })]
        [TestCase(300, new double[] { 300, 600, 900})]
        [TestCase(1000, new double[] {1000 })]
        public void GetDividentsTests(double a, double[] expected)
        {
            double[] actual = HomeWork_4.GetDividents(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-100)]
        [TestCase(1000.9)]
        public void GetDividentsNegativeTest(double a)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_4.GetDividents(a));
        }
        [TestCase(0)]
        public void GetDividentsNegativeTest2(double a)
        {
            Assert.Throws<System.DivideByZeroException>(() => HomeWork_4.GetDividents(a));
        }
        // Задание 2
        [TestCase(25.4, 5)]
        [TestCase(1.4, 1)]
        [TestCase(999.7, 31)]
        [TestCase(14.5, 3)]
        [TestCase(0, 0)]
        public void GetSqrsTests(double num, int expected)
        {
            int actual = HomeWork_4.GetSqrs(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-100)]
        public void GetSqrsNegativeTest(double num)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_4.GetSqrs(num));
        }
        // Задание 3
        [TestCase(25, 5)]
        [TestCase(14, 7)]
        [TestCase(101, 1)]
        [TestCase(100, 50)]
        [TestCase(-145, 29)]
        public void GetMaxDivTests(int num, int expected)
        {
            int actual = HomeWork_4.GetMaxDiv(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void GetMaxDivNegativeTest(int num)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_4.GetMaxDiv(num));
        }
        // Задание 4
        [TestCase(0, 0, 0)]
        [TestCase(1, 8, 7)]
        [TestCase(23, 14, 35)]
        [TestCase(-100, 100, 0)]
        [TestCase(0, -100, -735)]
        public void GetSumDividentsOn7Tests(int a, int b, int expected)
        {
            int actual = HomeWork_4.GetSumDividentsOn7(a, b);
            Assert.AreEqual(expected, actual);
        }
        // Задание 5
        [TestCase(2, 4, 2)]
        [TestCase(24, 24, 24)]
        [TestCase(9, 7, 1)]
        [TestCase(145, 678, 1)]
        [TestCase(322328, 122120, 344)]
        public void MaxCommonDivTests(int a, int b, int expected)
        {
            int actual = HomeWork_4.MaxCommonDiv(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1)]
        [TestCase(1, 0)]
        public void MaxCommonDivTest(int a, int b)
        {
            Assert.Throws<System.DivideByZeroException>(() => HomeWork_4.MaxCommonDiv(a, b));
        }
        // Задание 6
        [TestCase(64, 4)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(1000, 10)]
        [TestCase(65, 4)]
        public void GetCoubTests(int a, int expected)
        {
            int actual = HomeWork_4.GetCoub(a);
            Assert.AreEqual(expected, actual);
        }
        // Задание 7
        [TestCase(0, 0)]
        [TestCase(12345, 3)]
        [TestCase(111111111, 9)]
        [TestCase(10000001, 2)]
        [TestCase(66422462, 0)]
        public void CountOddDigitTests(int num, int expected)
        {
            int actual = HomeWork_4.CountOddDigit(num);
            Assert.AreEqual(expected, actual);
        }
        // Задание 8
        [TestCase(0, 0)]
        [TestCase(12345, 54321)]
        [TestCase(7789, 9877)]
        [TestCase(10000011, 11000001)]
        [TestCase(66422462, 26422466)]
        public void MirrorNumTests(int num, int expected)
        {
            int actual = HomeWork_4.MirrorNum(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-100)]
        public void MirrorNumNegativeTest(int num)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_4.MirrorNum(num));
        }
        // Задание 9
        [TestCase(0, new int[0])]
        [TestCase(1, new int[0])]
        [TestCase(4, new int[] { 2, 4})]
        [TestCase(20, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20})]
        [TestCase(2, new int[] { 2})]
        public void NumSumOddTests(int num, int[] expected)
        {
            int[] actual = HomeWork_4.NumSumOdd(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-1)]
        public void NumSumOddNegativeTest(int num)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_4.NumSumOdd(num));
        }
        // Задание 10
        [TestCase(0, 0, "ДА")]
        [TestCase(12345, 32, "ДА")]
        [TestCase(7789, 1111, "НЕТ")]
        [TestCase(12345678, 0, "НЕТ")]
        [TestCase(66422462, 26422466, "ДА")]
        public void CheckSameDigitsTests(int a, int b, string expected)
        {
            string actual = HomeWork_4.CheckSameDigits(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
