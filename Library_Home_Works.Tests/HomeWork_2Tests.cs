using NUnit.Framework;

namespace Library_Home_Works.Tests
{
    public class HomeWork_2_Tests
    {
        //Задание 1
        [TestCase(735, 15)]
        [TestCase(123, 6)]
        [TestCase(456, 15)]
        [TestCase(100, 1)]
        [TestCase(999, 27)]
        public void GetSumDigitTests(int a, int expexted)
        {
            int actual = HomeWork_2.GetSumDigit(a);
            Assert.AreEqual(expexted, actual);
        }
        [TestCase(99)]
        [TestCase(1000)]
        public void GetSumDigitNegativeTest(int a)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_2.GetSumDigit(a));
        }
        //Задание 2
        [TestCase(0, 0, 1, true)]
        [TestCase(2, -2, 1, false)]
        [TestCase(0, 1, 1, true)]
        [TestCase(-1, 0, 1, true)]
        [TestCase(-100, 100, 50, false)]
        public void AimHitTests(double x, double y, double r, bool expexted)
        {
            bool actual = HomeWork_2.AimHit(x, y, r);
            Assert.AreEqual(expexted, actual);
        }
        [TestCase(1, 1, 0)]
        [TestCase(1, 1, -300)]
        public void AimHitNegativeTest(double x, double y, double r)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_2.AimHit(x, y, r));
        }
        //Задание 3
        [TestCase(742, true)]
        [TestCase(773, true)]
        [TestCase(755, false)]
        [TestCase(354, false)]
        [TestCase(335, false)]
        public void CheckDigitInNumberTests(int num, bool expexted)
        {
            bool actual = HomeWork_2.CheckDigitInNumber(num);
            Assert.AreEqual(expexted, actual);
        }
        [TestCase(-999)]
        [TestCase(1002)]
        public void CheckDigitInNumberNegativeTest(int num)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_2.CheckDigitInNumber(num));
        }
        //Задание 4
        [TestCase(365, 563)]
        [TestCase(947, 749)]
        [TestCase(111, 111)]
        [TestCase(567, 765)]
        [TestCase(766, 667)]
        public void SwapFirstAndLastDigitTests(int num, int expexted)
        {
            int actual = HomeWork_2.SwapFirstAndLastDigit(num);
            Assert.AreEqual(expexted, actual);
        }
        [TestCase(-999)]
        [TestCase(1002)]
        public void SwapFirstAndLastDigitNegativeTest(int num)
        {
            Assert.Throws<System.ArgumentException>(() => HomeWork_2.SwapFirstAndLastDigit(num));
        }
        //Задание 5
        [TestCase(156.0, true)]
        [TestCase(156.2, false)]
        [TestCase(0.78, false)]
        [TestCase(0.0009, false)]
        [TestCase(-1.0, true)]
        public void CheckNullFractionalPartTests(double num, bool expexted)
        {
            bool actual = HomeWork_2.CheckNullFractionalPart(num);
            Assert.AreEqual(expexted, actual);
        }
        
    }
}
