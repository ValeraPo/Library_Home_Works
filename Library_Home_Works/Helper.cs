using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library_Home_Works
{
    static class Helper
    {
        private static Random _rnd = new Random();

        //Рисует линию-разделитель
        public static void Line(int size, char symbol = '-')
        {
            for (int i = 0; i < size; i++)
                Console.Write(symbol);
            Console.WriteLine();
        }

        //Выводит номер домашней работы и задания
        public static void Header(int nHw, int nTask)
        {
            if (nTask == 1) Line(40, '*');
            else Line(20);

            Console.WriteLine($"Домашняя работа {nHw}. Задача {nTask}.\n");
        }

        //Безопасно парсит int
        public static int InputInt(string var = "целое число", string quest = "Введите")
        {
            int res;
            do
            {
                Console.Write($"{quest} {var}: ");
            } while (!int.TryParse(Console.ReadLine(), out res));

            return res;
        }

        //Безопасно парсит double
        public static double InputDouble(string var = "число", string quest = "Введите")
        {
            double res;
            do
            {
                Console.Write($"{quest} {var}: ");
            } while (!double.TryParse(Console.ReadLine(), out res));

            return res;
        }

        //Безопасно парсит int в диапазоне
        public static int InputInt(int begin, int end,
            string var = "целое число в диапазоне [{begin} - {end}]",
            string quest = "Введите")
        {
            int res;
            do
            {
                Console.Write($"{quest} {var}: ");
            } while (!int.TryParse(Console.ReadLine(), out res)
                     || res < begin || res > end);

            return res;
        }

        //Безопасно парсит double в диапазоне
        public static double InputDouble(double begin, double end,
            string var = "число в диапазоне [{begin} - {end}]",
            string quest = "Введите")
        {
            double res;
            do
            {
                Console.Write($"{quest} {var}: ");
            } while (!double.TryParse(Console.ReadLine(), out res)
                     || res < begin || res > end);

            return res;
        }

        // Просит пользователя ввести строку и читает ее
        public static string InputString(string var = "строку", string quest = "Введите")
        {
            Console.Write($"{quest} {var}: ");
            return Console.ReadLine();
        }

        // Печатает ответ в задачах
        public static void PrintAnswer(string res, string answer = "Ответ")
        {
            Console.WriteLine($"{answer}: {res}");
        }

        public static void PrintAnswer(int res, string answer = "Ответ")
        {
            Console.WriteLine($"{answer} {res}");
        }

        public static void PrintAnswer(double res, string answer = "Ответ")
        {
            Console.WriteLine($"{answer} {res:f2}");
        }

        public static void PrintAnswer(char res, string answer = "Ответ")
        {
            Console.WriteLine($"{answer}:  {res}");
        }

        // Создает одномерный массив 
        public static int[] GenerateIntArray(int size)
        {
            int[] arr = new int[size];
            return arr;
        }

        public static int[] GenerateIntArray()
        {
            int size = InputInt(1, int.MaxValue, "размер массива");
            int[] arr = new int[size];
            return arr;
        }

        // Создает двумерный массив int[,]
        public static int[,] TwoDGenerateIntArray()
        {
            int row = InputInt(1, int.MaxValue, "кол-во рядов");
            int col = InputInt(1, int.MaxValue, "кол-во столбцов");
            // int[,] arr = new int[row, col];
            // return arr;
            return TwoDGenerateIntArray(row, col);
        }

        public static int[,] TwoDGenerateIntArray(int row, int col)
        {
            int[,] arr = new int[row, col];
            return arr;
        }

        // Создает двумерный массив double[,]
        public static double[,] TwoDGenerateDoubleArray()
        {
            int row = InputInt(1, int.MaxValue, "кол-во рядов");
            int col = InputInt(1, int.MaxValue, "кол-во столбцов");
            // double[,] arr = new double[row, col];
            // return arr;
            return TwoDGenerateDoubleArray(row, col);
        }

        public static double[,] TwoDGenerateDoubleArray(int row, int col)
        {
            double[,] arr = new double[row, col];
            return arr;
        }

        //Заполняет одномерный массив случайными числами
        public static void FillArray(int[] arr, int begin = -99, int end = 99)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = _rnd.Next(begin, end + 1);
        }

        //Заполняет двумерный массив случайными числами
        public static void FillArray(int[,] arr, int begin = -99, int end = 99)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = _rnd.Next(begin, end + 1);
        }

        public static void FillArray(double[,] arr, int length = 1000)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = _rnd.NextDouble() * length;
            
        }

        // Печатает одномерный массив
        public static void PrintArray<T>(T[] arr)
        {
            Console.WriteLine(string.Join(' ', arr));
        }
        /*public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(' ', arr));
        }

        public static void PrintArray(double[] arr)
        {
            Console.WriteLine(string.Join(' ', arr));
        }

        public static void PrintArray(char[] arr)
        {
            Console.WriteLine(string.Join(' ', arr));
        }*/

        

        // Печатает двумерный массив
        public static void PrintArray(int[,] arr, char div = '\t')
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write($"{arr[i, j]}{div}");

                Console.WriteLine();
            }
        }

        public static void PrintArray(double[,] arr, char div = '\t')
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write($"{arr[i, j]:f2}{div}");

                Console.WriteLine();
            }
        }

        public static void PrintArray(char[,] arr, char div = '\t')
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write($"{arr[i, j]}{div}");

                Console.WriteLine();
            }
        }

        // Меняем содержимое переменных местами
        public static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
        /*public static void Swap(ref double a, ref double b)
        {
            (a, b) = (b, a);
        }

        public static void Swap(ref char a, ref char b)
        {
            (a, b) = (b, a);
        }

        public static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }

        public static void Swap(ref string a, ref string b)
        {
            (a, b) = (b, a);
        }*/

        // Печатаем List
        public static void PrintList(List<int> myList)
        {
            foreach (int i in myList)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}