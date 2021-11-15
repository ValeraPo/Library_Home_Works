using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Home_Works
{
    public class HomeWork_2
    {
        //Посчитать сумму всех трех цифр трехзначного числа,
        //заданного константой (const). Вывести сумму на печать.
        public static int GetSumDigit(int num)
        {
            if (num < 100 || num > 999) 
                throw new ArgumentException("Число должно быть трехзначным");
            int num1 = num / 100;
            int num2 = num / 10 % 10;
            int num3 = num % 10;
            return num1 + num2 + num3;
        }

        // Ввести с клавиатуры координаты выстрела x1 и y1.
        // Записать в bool переменную логическое выражение,
        // которое будет истинным, когда этот выстрел попадает
        // в круглую мишень  радиусом R.
        public static bool AimHit(double x, double y, double r)
        {
            if (r <= 0) throw new ArgumentException("Радиус не может быть меньше или равен нулю");
            return (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(r, 2);
        }

        // Записать логическое условие, которые будет истинным,
        // когда его средняя цифра меньше или равна первой и
        // одновременно строго больше последней.
        public static bool CheckDigitInNumber(int num)
        {
            if (num < 100 || num > 999) throw new ArgumentException("Число дожно быть трехзначным");
            int middle = num / 10 % 10;
            return (middle <= num / 100) && (middle > num % 10);
        }

        //Ввести целое трехзначное число.
        //Поменять местами его первую и последнюю цифры.
        //Собрать новое число в новой переменной
        public static int SwapFirstAndLastDigit(int num)
        {
            if (num < 100 || num > 999) throw new ArgumentException("Число дожно быть трехзначным");
            int first = num / 100;
            int last = num % 10;
            Helper.Swap(ref first, ref last);
            int res = first * 100 + (num / 10 % 10) * 10 + last;
            return res;
        }

        // Записать логическое условие, которое проверит,
        // что в double числе нулевая дробная часть.
        public static bool CheckNullFractionalPart(double num)
        {
            
            return num == (int)num;
        }
    }
}
