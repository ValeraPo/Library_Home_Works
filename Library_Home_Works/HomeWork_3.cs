using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Home_Works
{
    public class HomeWork_3
    {
        // Пользователь вводит два числа (A и B).
        //Если A > B, подсчитать A+B,
        // если A == B, подсчитать A*B,
        // если A<B, подсчитать A-B.
        public static double SystemEquations(double a, double b)
        {
            // return a > b ? a + b :
            // b > a ? a - b : a * b;
            double res;
            if (a > b) res = a + b;
            else if (a == b) res = a * b;
            else res = a - b;

            return Math.Round(res, 8);
        }

        // Определить какой четверти координатной плоскости
        // принадлежит точка с координатами (X,Y).
        public static int CheckZonePoint(double x, double y)
        {
            int res = x > 0 && y > 0 ? 1 :
                x > 0 && y < 0 ? 2 :
                x < 0 && y < 0 ? 3 :
                x < 0 && y > 0 ? 4 : 0;

            return res;
        }

        // Пользователь вводит три числа (A, B и С).
        // Выведите их в консоль в порядке возрастания. 
        public static string OutputInAscendingOrder(double a, double b, double c)
        {
            double min_num = a <= b && a <= c ? a : b <= c && b <= a ? b : c;
            double max_num = a >= b && a >= c ? a : b >= c && b >= a ? b : c;
            double middle_num = Math.Round(a + b + c - max_num - min_num, 8);
            return $"{min_num} {middle_num} {max_num}";
        }

        // Пользователь вводит три числа. Выведите в
        // консоль решение квадратного уравнения AX^2+BX+C=0.
        public static double[] QuadraticEquation(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d < 0) return new double[0];
            if (d == 0)
                return new double[] { -b / (2 * a) };
            
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return new double[] { x1, x2 };
        }

        //Пользователь вводит двузначное число.
        //Выведите в консоль прописную запись этого числа. 
        public static string OutputNumberInWord(int num)
        {
            if (num < 10 || num > 99) 
                throw new ArgumentException("Число должно быть двузначным");
            string res = "";
            if (num > 19)
            {
                switch (num / 10)
                {
                    case 2: res = "двадцать "; break;
                    case 3: res = "тридцать "; break;
                    case 4: res = "сорок "; break;
                    case 5: res = "пятьдесят "; break;
                    case 6: res = "шестьдесят "; break;
                    case 7: res = "семдесят "; break;
                    case 8: res = "восемдесят "; break;
                    case 9: res = "девяносто "; break;
                    default: break;
                }

                switch (num % 10)
                {
                    case 1: res += "один "; break;
                    case 2: res += "два "; break;
                    case 3: res += "три "; break;
                    case 4: res += "четыре "; break;
                    case 5: res += "пять "; break;
                    case 6: res += "шесть "; break;
                    case 7: res += "семь "; break;
                    case 8: res += "восемь "; break;
                    case 9: res += "девять "; break;
                    default: res += " "; break;
                }
            }
            else
            {
                switch (num)
                {
                    case 10: res = "десять "; break;
                    case 11: res = "одиннадцать "; break;
                    case 12: res = "двенадцать "; break;
                    case 13: res = "тринадцать "; break;
                    case 14: res = "четырнадцать "; break;
                    case 15: res = "пятнадцать "; break;
                    case 16: res = "шестнадцать "; break;
                    case 17: res = "семнадцать "; break;
                    case 18: res = "восемнадцать "; break;
                    default: res = "девятнадцать "; break;
                }
            }
            return res;
        }

        //Даны вещественные положительные числа a, b, c.
        //Выяснить, существует ли треугольник со сторонами a, b, c.
        public static bool CheckExistenceTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны должны быть больше 0");
            return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && c + b > a;
        }
    }
}
