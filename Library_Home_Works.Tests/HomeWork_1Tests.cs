using NUnit.Framework;

namespace Library_Home_Works.Tests
{
    public class HomeWork_1_Tests
    {
        // Задание 1
        [TestCase(2, -1.7, "привет, 2!\n2 + -1.7 = 0.3\nпока, -1.7...")]
        [TestCase(1, 3.5, "привет, 1!\n1 + 3.5 = 4.5\nпока, 3.5...")]
        [TestCase(-4, 2.5, "привет, -4!\n-4 + 2.5 = -1.5\nпока, 2.5...")]
        [TestCase(3, 2.3, "привет, 3!\n3 + 2.3 = 5.3\nпока, 2.3...")]
        [TestCase(0, 0, "привет, 0!\n0 + 0 = 0\nпока, 0...")]
        public void GetHelloByeStringTests(int a, double b, string expected)
        {
            string actual = HomeWork_1.GetHelloByeString(a, b);
            Assert.AreEqual(expected, actual);
        }
        // Задание 2
        [TestCase(0, 1.5, 3.375)] 
        [TestCase(1.5, 0, -5)]
        [TestCase(-2.5, -3.5, -137.5625)]
        [TestCase(4.5, 5.6, 914.4996363636364)]
        [TestCase(3.6, -4.7, -60.960012048192773)]
        public void GetSolveTests(double a, double b, double expected)
        {
            double actual = HomeWork_1.GetSolve(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        public void GetSolveNegativeTest(double a, double b)
        {
            Assert.Throws<System.DivideByZeroException>(() => HomeWork_1.GetSolve(a, b));
        }
        // Задание 3
        [TestCase("Привет ", "Пока ", "Пока Привет ")]
        [TestCase("Hello ", "World ", "World Hello ")]
        [TestCase("^-^ ", "(*-*) ", "(*-*) ^-^ ")]
        [TestCase("123 ", "321 ", "321 123 ")]
        [TestCase("", "", "")]
        public void SwapStringTests(string a, string b, string expected)
        {
            HomeWork_1.SwapString(ref a, ref b);
            string actual = a + b;
            Assert.AreEqual(expected, actual);
        }
        //Задание 4
        [TestCase(1.5, 1.5, 0, -1)]
        [TestCase(-1.5, -4.5, -4.5, 0)]
        [TestCase(100.9, -3.5, 5.6, 0.090188305252725462)]
        [TestCase(-4078.7, 5.6, 8.7, -0.00076004609311790521)]
        [TestCase(3.6, -4.7, -1000.6, -276.63888888888886)]
        public void GetSolve2Tests(double a, double b, double c, double expected)
        {
            double actual = HomeWork_1.GetSolve2(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 1, 1)]
        public void GetSolve2NegativeTest(double a, double b, double c)
        {
            Assert.Throws<System.DivideByZeroException>(() => HomeWork_1.GetSolve2(a, b, c));
        }
    }
}