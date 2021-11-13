    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Home_Works
{
    public class HomeWork_6
    {
        //Поменять знак на противоположный у всех элементов,
        //расположенных по краям двумерного массива NxM.
        public static int[,] AlternateSignOnEdges(int[,] arr)
        {
            int[,] mas = (int[,])arr.Clone();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == mas.GetLength(0) - 1
                        || j == mas.GetLength(1) - 1)
                        mas[i, j] *= -1;
                }
            }
            return mas;
           
        }

        //Заполнить матрицу 9x9 таблицей умножения
        public static int[,] MultTable()
        {
            int[,] mas = Helper.TwoDGenerateIntArray(9,9);
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    mas[i, j] = (i + 1) * (j + 1);
            }
            return mas;
        }

        // Заполнить квадратную матрицу NxN нулями и единицами так,
        // как расположены клетки на шахматной доске, где 0 - "черное", 1 - "белое".
        // Левое нижнее поле на шахматной доске всегда черное.
        public static int[,] ChessDesk(int size)
        {
            if (size <= 0) throw new ArgumentException("Размер матрицы больше нуля");
            int[,] mas = Helper.TwoDGenerateIntArray(size, size);
            int condition_black = (mas.GetLength(0) - 1) % 2;
            for (int i = mas.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if ((i + j) % 2 == condition_black) mas[i, j] = 0;
                    else mas[i, j] = 1;
                }
            }
            return mas;
        }

        //Образец массива произвольного размера задать вручную нулями и единицами,
        //инициализацией в момент создания. На готовом массиве проверить,
        //что нет двух занятых мест в одном ряду, расположенных рядом.
        public static bool CheckCovidRules(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                int cnt = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i,j] < 0 || mas[i, j] > 1) throw new ArgumentException("Массив должен быть из 0 и 1");
                    
                    if (mas[i, j] == 1) cnt++;
                    else cnt = 0;

                    if (cnt == 2)
                        return false;
                }
            }

            return  true;
        }

        // Доходы каждого 10 магазинов за полугодие хранятся в двумерном
        // вещественном массиве. Заполнить массив случайными вещественными
        // числами. Высчитать:
        // а) суммарный доход по каждому магазину;
        // б) средний доход по каждому месяцу;
        // в) мин.и макс.доход за весь период.
        public static (double[], double[], double, double) GetSumMiddleMinMaxIncome(double[,]  shops)
        {
            if (shops.GetLength(0) != 10 || shops.GetLength(1) != 6)
                throw new ArgumentException("Размер матриццы 10х6");

            double[] sum_income = new double[shops.GetLength(0)];
            // Суммарный доход по каждому магазину
            for (int i = 0; i < shops.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < shops.GetLength(1); j++)
                    sum += shops[i, j];
                sum_income[i] = Math.Round(sum, 2);
            }

            // Поиск максимального, минимального и ср. арифметического по месяцу
            double max_inc = shops[0, 0], min_inc = shops[0, 0];
            double[] middle_income = new double[shops.GetLength(1)];
            for (int i = 0; i < shops.GetLength(1); i++)
            {
                double sum = 0;
                for (int j = 0; j < shops.GetLength(0); j++)
                {
                    sum += shops[j, i];
                    // Поиск минимального
                    if (shops[j, i] < min_inc)
                        min_inc = shops[j, i];
                    //Поиск максимального
                    if (shops[j, i] > max_inc)
                        max_inc = shops[j, i];
                }
                middle_income[i] = Math.Round(sum / 6.0, 2);
            }
            return (sum_income, middle_income, Math.Round(min_inc, 2), Math.Round(max_inc, 2));
        }

        //Найти количество элементов массива, которые больше
        //всех своих соседей одновременно. 
        public static int SearchElemMoreNeighbours(int[,] mas)
        {
            int cnt = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    int sum = 0;
                    if (i - 1 >= 0) sum += mas[i - 1, j];
                    if (i + 1 < mas.GetLength(0)) sum += mas[i + 1, j];
                    if (j - 1 >= 0) sum += mas[i, j - 1];
                    if (j + 1 < mas.GetLength(1)) sum += mas[i, j + 1];

                    if (mas[i, j] > sum) cnt++;
                }
            }
            return cnt;
        }

        // Заполнить массив из символов (char) указанным образом
        public static char[,] SandWatch(int size)
        {
            if (size <= 0) throw new ArgumentException("Размер массива больше нуля");
            char[,] mas = new char[size, size];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if ((i <= j && i <= mas.GetLength(0) - 1 - j)
                      || (i >= j && i >= mas.GetLength(0) - 1 - j)) mas[i, j] = '1';
                    else mas[i, j] = '0';
                }
            }
            return mas;
        }

        // Реализовать перемножение матриц целых чисел.
        public static int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
                throw new ArgumentException("Матриццы несовместимы");
            // Создаем массив - результат умножения
            int[,] matrix_res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < matrix_res.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_res.GetLength(1); j++)
                {
                    matrix_res[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                        matrix_res[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
            return matrix_res;
        }
    }
}
