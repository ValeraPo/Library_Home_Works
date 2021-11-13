using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Home_Works
{
    public class HomeWork_1
    {
        // Выведите на консоль значение двух инициализированных переменных
        // a(int) и b(double) (любые значения) и текст в следующем виде:
        //привет, <a>!
        //<a> + <b> = <a+b>
        //пока, <b>...
        public static string GetHelloByeString(int a, double b)
        {
            return $"привет, {a}!\n{a} + {b} = {Math.Round(a + b, 8)}\nпока, {b}...";
        }

        // Пользователь вводит два числа (a и b).
        // Выведите в консоль решение (5*a + b^4) / (b - a)
        public static double GetSolve(double a, double b)
        {
            if (b == a) throw new DivideByZeroException("Деление на ноль!");
            return (5 * a + Math.Pow(b, 4)) / (b - a);
        }

        //Пользователь вводит два строковых значения(s1 и s2).
        //Поменяйте содержимое переменных s1 и s2 местами.
        public static void SwapString(ref string s1, ref string s2)
        {
            Helper.Swap(ref s1, ref s2);
        }

        //Пользователь вводит три не равных нулю числа.
        //Выведите в консоль решение (значение X) линейного
        //уравнения стандартного вида a*X+b=c.
        public static double GetSolve2(double a, double b, double c)
        {
            if (a == 0) throw new DivideByZeroException("Деление на ноль!");
            return (c - b) / a;
        }

    }
}
