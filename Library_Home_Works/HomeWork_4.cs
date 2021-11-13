using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Home_Works
{
    public class HomeWork_4
    {
        //Пользователь вводит одно число (A).
        //Вывести все числа от 1 до 1000, которые делятся на A.
        public static double[] GetDividents(double div)
        {
            if (div == 0) throw new DivideByZeroException("Деление на 0");
            if (div < 0) throw new ArgumentException("Число должно быть положительным");
            if (div > 1000) throw new ArgumentException("Число должно быть меньше 1000");
            double[] res = new double[1000 / (int)div];
            int j = 0;
            for (double i = div; i <= 1000; i += div, j++)
                res[j] = i;
            return res;
        }

        //Пользователь вводит одно число (A).
        //Найдите количество положительных целых чисел, квадрат которых меньше A.
        public static int GetSqrs(double num)
        {
            if (num < 0) throw new ArgumentException("Число должно быть положительным");
            return (int)Math.Pow(num, 1.0 / 2.0);
        }

        // Пользователь вводит одно число (A).
        // Вывести наибольший делитель (кроме самого A) числа A.
        public static int GetMaxDiv(int num)
        {
            if (num == 0) throw new ArgumentException("Число не может быть равно 0");
            for (int i = (Math.Abs(num)) / 2; ; i--)
                if (num % i == 0) return i;
        }

        //Пользователь вводит два числа (A и B).
        //Вывести сумму всех чисел из диапазона от A до B,
        //которые делятся без остатка на 7. 
        public static int GetSumDividentsOn7(int a, int b)
        {
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            while (min <= max)
            {
                if (min % 7 == 0) break;
                min++;
            }
            int sum;
            for (sum = 0; min <= max; min += 7) sum += min;
            return sum;
        }

        //Пользователь вводит два числа.
        //Найти их наибольший общий делитель используя алгоритм Евклида.
        public static int MaxCommonDiv(int a, int b)
        {
            if (a == 0 || b == 0) throw new DivideByZeroException("Деление на ноль");
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            while (min != 0)
            {
                int temp = min;
                min = max % min;
                max = temp;
            }
            return max;
        }

        // Пользователь вводит целое положительное число,
        // которое является кубом целого числа N.
        // Найдите число N методом половинного деления.
        public static int GetCoub(int cube)
        {
            if (cube == 1) return 1;
            int max = cube;
            int min = 0;
            int x;
            while (true)
            {
                x = (max + min) / 2;
                int tmp = (int)Math.Pow(x, 3);
                if (tmp == cube) return x;
                if (max - min == 1) return min;

                if (tmp > cube) max = x;
                else min = x;
            }
        }

        // Пользователь вводит одно число произвольной длины.
        // Найти количество нечетных цифр этого числа.
        public static int CountOddDigit(int num)
        {
            int count = 0;
            while (num > 0)
            {
                int tmp = num % 10;
                if (tmp % 2 != 0) count++;
                num /= 10;
            }
            return count;
        }

        // Найти число, которое является зеркальным отображением
        // последовательности цифр заданного числа.
        public static int MirrorNum(int num)
        {
            if (num < 0) throw new ArgumentException("Число должно быть положительным");
            int res;
            for (res = 0; num != 0; num /= 10)
                res = (res * 10) + (num % 10);

            return res;
        }

        // Выведите числа в диапазоне от 1 до N,
        // сумма четных цифр которых больше суммы нечетных.
        public static int[] NumSumOdd(int num)
        {
            if (num < 0) throw new ArgumentException("Число должно быть положительным");
            int[] arr = new int[num];
            int index = 0;
            for (int i = 0; i <= num; i++)
            {
                int tmp = i, sum_even = 0, sum_odd = 0;
                while (tmp != 0)
                {
                    int last_num = tmp % 10;
                    if (last_num % 2 == 1) sum_odd += last_num;
                    else sum_even += last_num;
                    tmp /= 10;
                }
                if (sum_even > sum_odd)
                {
                    arr[index] = i;
                    index++;
                }
            }
            int[] result = new int[index];
            Array.Copy(arr, 0, result, 0, index);
            return result; 
        }

        // Сообщите, есть ли в написании двух чисел одинаковые цифры.
        public static string CheckSameDigits(int a, int b)
        {
            do
            {
                int tmp_a = a % 10;
                int new_b = b;
                do
                {
                    int tmp_b = new_b % 10;
                    if (tmp_a == tmp_b) return "ДА";
                    new_b /= 10;
                } while (new_b != 0);
                a /= 10;
            } while (a != 0);
            return "НЕТ";
        }
    }
}
