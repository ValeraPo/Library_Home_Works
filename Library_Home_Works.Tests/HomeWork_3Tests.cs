using NUnit.Framework;

namespace Library_Home_Works.Tests
{
    public class HomeWork_3Tests
    {
        // Задание 1
        [TestCase(2.5, 1.5, 4)]
        [TestCase(10, 0, 10)]
        [TestCase(0, 0, 0)]
        [TestCase(3.4, 3.4, 11.56)]
        [TestCase(-6.7, 3.4, -10.1)]
        public void GetSolveTests(double a, double b, double expected)
        {
            double actual = HomeWork_3.SystemEquations(a, b);
            Assert.AreEqual(expected, actual);
        }
        // Задание 2
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(1, -3, 2)]
        [TestCase(-3.5, -5.7, 3)]
        [TestCase(-1, 4.6, 4)]
        public void CheckZonePointTests(double x, double y, int expected)
        {
            double actual = HomeWork_3.CheckZonePoint(x, y);
            Assert.AreEqual(expected, actual);
        }
        // Задание 3
        [TestCase(0, 0, 0, "0 0 0")]
        [TestCase(1, 2.4, 4.5, "1 2.4 4.5")]
        [TestCase(1, -3, 2, "-3 1 2")]
        [TestCase(-3.5, -5.7, 3, "-5.7 -3.5 3")]
        [TestCase(-1, 4.6, 4, "-1 4 4.6")]
        public void OutputInAscendingOrderTests(double a, double b, double c, string expected)
        {
            string actual = HomeWork_3.OutputInAscendingOrder(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        // Задание 4
        [TestCase(-1, 7, 8, new double[] { -1, 8 })]
        [TestCase(4, 4, 1, new double[] { -0.5})]
        [TestCase(2, 1, 1, new double[] { })]
        [TestCase(-1, 2, 8, new double[] { -2, 4})]
        [TestCase(1, 3, 2, new double[] { -1, -2})]
        public void QuadraticEquationTests(double a, double b, double c, double[] expected)
        {
            double[] actual = HomeWork_3.QuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        // Задание 5
        [TestCase(10, "десять ")]
        [TestCase(66, "шестьдесят шесть ")]
        [TestCase(70, "семдесят  ")]
        [TestCase(25, "двадцать пять ")]
        [TestCase(11, "одиннадцать ")]
        public void OutputNumberInWordTests(int num, string expected)
        {
            string actual = HomeWork_3.OutputNumberInWord(num);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-10)]
        [TestCase(9)]
        [TestCase(100)]
        public void OutputNumberInWordNegativeTest(int num)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_3.OutputNumberInWord(num));
        }
        // Задание 6
        [TestCase(2, 2, 2, true)]
        [TestCase(2, 3, 4, true)]
        [TestCase(1, 2, 3, false)]
        [TestCase(4, 4, 8, false)]
        [TestCase(100, 567, 8, false)]
        public void CheckExistenceTriangleTests(double a, double b, double c, bool expected)
        {
            bool actual = HomeWork_3.CheckExistenceTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-10, 2, 3)]
        [TestCase(3, 4, 0)]
        [TestCase(3, -3, 1)]
        public void CheckExistenceTriangleNegativeTest(double a, double b, double c)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_3.CheckExistenceTriangle(a, b, c));
        }
    }
}
