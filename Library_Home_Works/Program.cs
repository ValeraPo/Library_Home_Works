using System;

namespace Library_Home_Works
{
    class Program
    {
        static void Main(string[] args)
        {
            //Helper.Header(1, 1);
            //Console.WriteLine("Вывести\nпривет, <a>!\n<a> + <b> = <a+b>\nпока, <b>...\n");
            //Console.WriteLine(HomeWork_1.GetHelloByeString(5, 6.5));

            //Helper.Header(1, 2);
            //Console.WriteLine("Выведите в консоль решение (5*a + b^4) / (b - a)\n");
            //double a12 = Helper.InputDouble("a");
            //double b12 = Helper.InputDouble("b");
            //Helper.PrintAnswer(HomeWork_1.GetSolve(a12, b12));

            //Helper.Header(1, 3);
            //Console.WriteLine("Поменяйте содержимое переменных s1 и s2 местами\n");
            //string s1 = Helper.InputString("строку s1");
            //string s2 = Helper.InputString("строку s2");
            //HomeWork_1.SwapString(ref s1, ref s2);
            //Helper.PrintAnswer(s1, "s1");
            //Helper.PrintAnswer(s1, "s2");

            //Helper.Header(1, 4);
            //Console.WriteLine("Вывести решение линейного уравнения a*X+b=c.\n");
            //double a14 = Helper.InputDouble("a");
            //double b14 = Helper.InputDouble("b");
            //double c14 = Helper.InputDouble("c");
            //Helper.PrintAnswer(HomeWork_1.GetSolve2(a14, b14, c14), "X =");

            //Helper.Header(2, 1);
            //Console.WriteLine("Посчитать сумму всех трех цифр трехзначного числа," +
            //    "\nзаданного константой (const).\n");
            //const int num = 735;
            //Helper.PrintAnswer(HomeWork_2.GetSumDigit(num), "Сумма цифр 735");

            //Helper.Header(2, 2);
            //Console.WriteLine("Проверить, что выстрел попал в круглую мишень\n");
            //double x22 = Helper.InputDouble("x1");
            //double y22 = Helper.InputDouble("y1");
            //double r22 = Helper.InputDouble("радиус мишени");
            //if (HomeWork_2.AimHit(x22, y22, r22)) Console.WriteLine("Попал");
            //else Console.WriteLine("Не попал");

            //Helper.Header(2, 3);
            //Console.WriteLine("Проверить, что средняя цифра трехзначного числа меньше\n" +
            //    "или равна первой и одновременно строго больше последней.\n");
            //int num23 = Helper.InputInt(100, 999, "трехзначное число");
            //if (HomeWork_2.CheckDigitInNumber(num23)) Console.WriteLine("ДА");
            //else Console.WriteLine("НЕТ");

            //Helper.Header(2, 4);
            //Console.WriteLine("Поменять местами его первую и последнюю " +
            //    "цифры трехзначного числа\n");
            //int num24 = Helper.InputInt(100, 999, "трехзначное число");
            //Console.WriteLine(HomeWork_2.SwapFirstAndLastDigit(num24));

            //Helper.Header(2, 5);
            //Console.WriteLine("Проверить, что в double числе нулевая дробная часть.\n");
            //double d_num25 = Helper.InputDouble();
            //if (HomeWork_2.CheckNullFractionalPart(d_num25)) Console.WriteLine("ДА");
            //else Console.WriteLine("НЕТ");

            //Helper.Header(3, 1);
            //Console.WriteLine("Если A > B, подсчитать A+B, " +
            //    "\nесли A == B, подсчитать A * B," +
            //    "\nесли A < B, подсчитать A - B.\n");
            //double a31 = Helper.InputDouble("A");
            //double b31 = Helper.InputDouble("B");
            //Helper.PrintAnswer(HomeWork_3.SystemEquations(a31, b31));

            //Helper.Header(3, 2);
            //Console.WriteLine("Определить какой четверти координатной плоскости" +
            //    "\nпринадлежит точка с координатами (X,Y).\n");
            //double x32 = Helper.InputDouble("X");
            //double y32 = Helper.InputDouble("Y");
            //Helper.PrintAnswer(HomeWork_3.CheckZonePoint(x32, y32), "Точка принадлежит");

            //Helper.Header(3, 3);
            //Console.WriteLine("Выведите в консоль числа в порядке возрастания\n");
            //double a33 = Helper.InputDouble("A");
            //double b33 = Helper.InputDouble("B");
            //double c33 = Helper.InputDouble("C");
            //Helper.PrintAnswer(HomeWork_3.OutputInAscendingOrder(a33, b33, c33));

            //Helper.Header(3, 4);
            //Console.WriteLine("Найти корни квадратного уравнения AX^2+BX+C=0\n");
            //double a34 = Helper.InputDouble("A");
            //double b34 = Helper.InputDouble("B");
            //double c34 = Helper.InputDouble("C");
            //double[] solutions = HomeWork_3.QuadraticEquation(a34, b34, c34);
            //if (solutions.Length == 0) Console.WriteLine("Уравнение не имеет корней");
            //else if (solutions.Length == 1) Helper.PrintAnswer(solutions[0], "Уравнение имеет один корень x =");
            //else
            //{
            //    Helper.PrintAnswer(solutions[0], "Уравнение имеет два корня \nx1 =");
            //    Helper.PrintAnswer(solutions[1], "x2 =");
            //}

            //Helper.Header(3, 5);
            //Console.WriteLine("Выведите в консоль прописную запись числа.\n");
            //int num35 = Helper.InputInt(0, 99, "двузначное число");
            //Console.WriteLine(HomeWork_3.OutputNumberInWord(num35));

            //Helper.Header(3, 6);
            //Console.WriteLine("Выяснить, существует ли треугольник со сторонами a, b, c.\n");
            //double a36 = Helper.InputDouble("A");
            //double b36 = Helper.InputDouble("B");
            //double c36 = Helper.InputDouble("C");
            //if (HomeWork_3.CheckExistanceTriangle(a36, b36, c36))
            //    Console.WriteLine("Треугольник с такими сторонами существует");
            //else
            //    Console.WriteLine("Треугольник с такими сторонами не существует");

            //Helper.Header(4, 1);
            //Console.WriteLine("Вывести все числа от 1 до 1000, которые делятся на A\n");
            //double div41 = Helper.InputDouble("A");
            //Helper.PrintArray(HomeWork_4.GetDividents(div41));

            //Helper.Header(4, 2);
            //Console.WriteLine("Найдите количество положительных целых чисел, " +
            //    "\nквадрат которых меньше A.\n");
            //double num42 = Helper.InputDouble("A");
            //Helper.PrintAnswer(HomeWork_4.GetSqrs(num42));

            //Helper.Header(4, 3);
            //Console.WriteLine("Вывести наибольший делитель (кроме самого A) числа A.\n");
            //int num43 = Helper.InputInt("A");
            //Helper.PrintAnswer(HomeWork_4.GetMaxDiv(num43));

            //Helper.Header(4, 4);
            //Console.WriteLine("Вывести сумму всех чисел из диапазона от A до B, " +
            //    "\nкоторые делятся без остатка на 7\n");
            //int a44 = Helper.InputInt("A");
            //int b44 = Helper.InputInt("B");
            //Helper.PrintAnswer(HomeWork_4.GetSumDividentsOn7(a44, b44));

            //Helper.Header(4, 5);
            //Console.WriteLine("Найти наибольший общий делитель A и B " +
            //    "\nиспользуя алгоритм Евклида.\n");
            //int a45 = Helper.InputInt("A");
            //int b45 = Helper.InputInt("B");
            //Helper.PrintAnswer(HomeWork_4.MaxCommonDiv(a45, b45));

            //Helper.Header(4, 6);
            //Console.WriteLine("Найти кубический корень числа, используя метод" +
            //    "\nполовинного деления\n");
            //int cube;
            //do
            //{
            //    Console.Write("Введите число, которое является кубом целого числа: ");
            //} while (!(int.TryParse(Console.ReadLine(), out cube)) ||
            //            (Math.Pow(cube, 1.0 / 3.0) % 1 != 0));
            //Helper.PrintAnswer(HomeWork_4.GetCoub(cube));

            //Helper.Header(4, 7);
            //Console.WriteLine("Найти кол-во нечетных цифр числа\n");
            //int num47 = Helper.InputInt();
            //Helper.PrintAnswer(HomeWork_4.CountOddDigit(num47));

            //Helper.Header(4, 8);
            //Console.WriteLine("Найти зеркальное отображение числа\n");
            //int num48 = Helper.InputInt();
            //Helper.PrintAnswer(HomeWork_4.MirrorNum(num48));

            //Helper.Header(4, 9);
            //Console.WriteLine("Выведите числа в диапазоне от 1 до N," +
            //    "\nсумма четных цифр которых больше суммы нечетных.\n");
            //int num49 = Helper.InputInt();
            //Helper.PrintArray(HomeWork_4.NumSumOdd(num49));

            //Helper.Header(4, 10);
            //Console.WriteLine("Сообщите, есть ли в написании двух чисел одинаковые цифры\n");
            //int a410 = Helper.InputInt("A");
            //int b410 = Helper.InputInt("B");
            //Helper.PrintAnswer(HomeWork_4.CheckSameDigits(a410, b410));

            //Helper.Header(5, 1);
            //Console.WriteLine("Посчитать количества нечетных и четных элементов массива\n");
            //int[] mas51 = Helper.GenerateIntArray();
            //Helper.FillArray(mas51);
            //Helper.PrintArray(mas51);
            //int[] answer51 = HomeWork_5.CountOddAndEvenDigit(mas51);
            //Helper.PrintAnswer(answer51[0], "Количество четных: ");
            //Helper.PrintAnswer(answer51[1], "Количество нечетных: ");


            //Helper.Header(5, 2);
            //Console.WriteLine("Каждый третий элемент массива заменить " +
            //    "суммой двух предыдущих элементов.\n");
            //int[] mas52 = Helper.GenerateIntArray();
            //Helper.FillArray(mas52);
            //Helper.PrintArray(mas52);
            //Console.WriteLine("Результат работы: ");
            //Helper.PrintArray(HomeWork_5.SumThirdNumArr(mas52));

            //Helper.Header(5, 3);
            //Console.WriteLine("Слить два целочисленных массива в один\n");
            //int[] mas_1 = Helper.GenerateIntArray();
            //Helper.FillArray(mas_1);
            //int[] mas_2 = Helper.GenerateIntArray();
            //Helper.FillArray(mas_2);
            //Console.WriteLine("Исходные массивы: ");
            //Helper.PrintArray(mas_1);
            //Helper.PrintArray(mas_2);
            //Console.WriteLine("Результат работы: ");
            //Helper.PrintArray(HomeWork_5.MergeArr(mas_1, mas_2));

            //Helper.Header(5, 4);
            //Console.WriteLine("Поменять местами первую и вторую половину массива\n");
            //int[] mas54 = Helper.GenerateIntArray();
            //Helper.FillArray(mas54);

            //Console.WriteLine("Исходный массив: ");
            //Helper.PrintArray(mas54);
            //Console.WriteLine("Результат работы: ");
            //Helper.PrintArray(HomeWork_5.SwapPartArray(mas54));

            //Helper.Header(5, 5);
            //Console.WriteLine("Циклически двинуть массив вправо на 1 элемент\n");
            //int[] mas55 = Helper.GenerateIntArray();
            //Helper.FillArray(mas55);
            //Console.WriteLine("Исходный массив: ");
            //Helper.PrintArray(mas55);
            //Console.WriteLine("Результат работы: ");
            //Helper.PrintArray(HomeWork_5.ShiftArray(mas55));

            //Helper.Header(5, 6);
            //Console.WriteLine("Преобразовать массив так, чтобы на четных позициях" +
            //    "\nстояли элементы с нечетных позиций, и наоборот.\n");
            //int[] mas56 = Helper.GenerateIntArray();
            //Helper.FillArray(mas56);
            //Console.WriteLine("Исходный массив: ");
            //Helper.PrintArray(mas56);
            //Console.WriteLine("Результат работы: ");
            //Helper.PrintArray(HomeWork_5.SwapOddAndDigitIndex(mas56));

            //Helper.Header(5, 7);
            //Console.WriteLine("В массиве из целочисленных элементов вычислить:" +
            //    "\nа) минимальный по модулю элемент массива;" +
            //    "\nб) сумму элементов, расположенных после первого нулевого элемента" +
            //    "\nСделать одним проходом цикла!\n");
            //int[] mas57 = Helper.GenerateIntArray();
            //Helper.FillArray(mas57);
            //Console.WriteLine("Исходный массив: ");
            //Helper.PrintArray(mas57);
            //(int min, int sum) = HomeWork_5.GetMinAndSumAfterZero(mas57);
            //Console.WriteLine($"Наименьшее по модулю: {min}");
            //Console.WriteLine($"Сумма чисел после 0: {sum}");

            //Helper.Header(5, 8);
            //Console.WriteLine("Отсортировать массив алгоритмом вставок (insert)\n");
            //int[] mas58 = Helper.GenerateIntArray();
            //Helper.FillArray(mas58);
            //Console.WriteLine("Исходный массив: ");
            //Helper.PrintArray(mas58);
            //Console.WriteLine("Результат работы: ");
            //Helper.PrintArray(HomeWork_5.SortInsert(mas58));

            //Helper.Header(5, 9);
            //Console.WriteLine("Отсортировать массив алгоритмом выборки (select)\n");
            //int[] mas59 = Helper.GenerateIntArray();
            //Helper.FillArray(mas59);

            //Console.WriteLine("Исходный массив: ");
            //Helper.PrintArray(mas59);
            //Console.WriteLine("Результат работы: ");
            //Helper.PrintArray(HomeWork_5.SortSelect(mas59));

            //Helper.Header(6, 1);
            //Console.WriteLine("Поменять знак на противоположный у всех элементов, " +
            //    "\nрасположенных по краям двумерного массива NxM.\n");
            //int[,] mas61 = Helper.TwoDGenerateIntArray();
            //Helper.FillArray(mas61);
            //Console.WriteLine("Исходный массив");
            //Helper.PrintArray(mas61);
            //Console.WriteLine("\nРезультат работы");
            //Helper.PrintArray(HomeWork_6.AlternateSignOnEdges(mas61));

            //Helper.Header(6, 2);
            //Console.WriteLine("Заполнить матрицу 9x9 таблицей умножения\n");
            //Helper.PrintArray(HomeWork_6.MultTable()); 

            //Helper.Header(6, 3);
            //Console.WriteLine("Заполнить квадратную матрицу NxN нулями и единицами так," +
            //    "\nкак расположены клетки на шахматной доске, где 0 - черное, " +
            //    "\n1 - белое Левое нижнее поле на шахматной доске всегда черное.\n");
            //int size63 = Helper.InputInt(0, int.MaxValue, "размер матрицы");
            //Helper.PrintArray(HomeWork_6.ChessDesk(size63), ' ');

            //Helper.Header(6, 4);
            //Console.WriteLine("Образец массива произвольного размера задать вручную нулями " +
            //    "\nи единицами, инициализацией в момент создания. На готовом " +
            //    "\nмассиве проверить,что нет двух занятых мест в одном ряду, " +
            //    "\n расположенных рядом.\n");
            //int[,] mas64 = new int[4, 8] { {1, 0, 1, 0, 0, 0, 0, 1 },
            //                                 {0, 0, 1, 0, 1, 0, 0, 0 },
            //                                 {1, 1, 1, 0, 1, 0, 0, 0 },
            //                                 {0, 0, 1, 0, 0, 0, 0, 1 }};
            //if (HomeWork_6.CheckCovidRules(mas64)) Console.WriteLine("Антиковидные меры не выполнены! ");
            //else Console.WriteLine("Антиковидные меры выполняются");

            //Helper.Header(6, 5);
            //Console.WriteLine("Доходы каждого 10 магазинов за полугодие хранятся в двумерном" +
            //    "\nвещественном массиве. Заполнить массив случайными вещественными" +
            //    "\nчислами. Высчитать: \nа) суммарный доход по каждому магазину;" +
            //    "\nб) средний доход по каждому месяцу;\nв) мин.и макс.доход за весь период.\n");
            //double[,] shops = Helper.TwoDGenerateDoubleArray(10, 6);
            //Helper.FillArray(shops);
            //Helper.PrintArray(shops);
            //Console.WriteLine();
            //(double[], double[], double, double) res = HomeWork_6.GetSumMiddleMinMaxIncome(shops);
            //for (int i = 0; i < res.Item1.Length; i++)
            //    Console.WriteLine($"Суммарный доход по {i + 1} магазину: {Math.Round(res.Item1[i], 2)}");
            //Console.WriteLine();
            //for (int i = 0; i < res.Item2.Length; i++)
            //    Console.WriteLine($"Средний доход по {i + 1} месяцу: {Math.Round(res.Item2[i], 2)}");
            //Console.WriteLine();
            //Console.WriteLine($"Минимальный доход за месяц: {Math.Round(res.Item3, 2)}");
            //Console.WriteLine($"Максимальный доход за месяц: {Math.Round(res.Item4, 2)}");


            //Helper.Header(6, 6);
            //Console.WriteLine("Найти количество элементов массива, которые больше " +
            //    "суммы соседей.\n");
            //int[,] mas66 = Helper.TwoDGenerateIntArray();
            //Helper.FillArray(mas66);
            //Helper.PrintArray(mas66);
            //Console.WriteLine($" Kоличество элементов массива, " +
            //     $"которые больше всех своих соседей одновременно: {HomeWork_6.SearchElemMoreNeighbours(mas66)}");

            //Helper.Header(6, 7);
            //Console.WriteLine("Заполнить массив из символов (char) указанным образом\n");
            //int size67 = Helper.InputInt("Размер массива");
            //Helper.PrintArray(HomeWork_6.SandWatch(size67), ' ');

            //Helper.Header(6, 8);
            //Console.WriteLine("Реализовать перемножение матриц целых чисел.\n");
            //int[,] matrix1 = Helper.TwoDGenerateIntArray();
            //Helper.FillArray(matrix1);
            //Console.WriteLine($"Кол-во столбцов первой матрицы == кол-ву " +
            //    $"строк второй == {matrix1.GetLength(1)}");
            //int сol = Helper.InputInt(1, int.MaxValue, "кол-во столбов второй матрицы");
            //int[,] matrix2 = Helper.TwoDGenerateIntArray(matrix1.GetLength(1), сol);
            //Helper.FillArray(matrix2);
            //Console.WriteLine("Исходныe массивы");
            //Helper.PrintArray(matrix1);
            //Console.WriteLine();
            //Helper.PrintArray(matrix2);
            //Console.WriteLine("\nПроизведение матриц");
            //Helper.PrintArray(HomeWork_6.MatrixMult(matrix1, matrix2));






            while (true)
            {
                int size67 = Helper.InputInt("Размер массива");
                char[,] res = HomeWork_6.SandWatch(size67);
                for (int i = 0; i < res.GetLength(0); i++)
                {
                    Console.Write("{ ");
                    for (int j = 0; j < res.GetLength(1); j++)
                        Console.Write($"'{res[i, j]}', ");
                    Console.WriteLine("},");
                }
                
            }

                //}



                //while (true)
                //{
                //    int size = int.Parse(Console.ReadLine());
                //    int[,] mas = Helper.TwoDGenerateIntArray(size, size);
                //    int condition_black = (mas.GetLength(0) - 1) % 2;
                //    for (int i = mas.GetLength(0) - 1; i >= 0; i--)
                //    {
                //        for (int j = 0; j < mas.GetLength(1); j++)
                //        {
                //            if ((i + j) % 2 == condition_black) mas[i, j] = 0;
                //            else mas[i, j] = 1;
                //        }
                //    }
                //    for (int i = 0; i < mas.GetLength(0); i++)
                //    {
                //        Console.Write("{ ");
                //        for (int j = 0; j < mas.GetLength(1); j++)
                //            Console.Write($"{mas[i, j]}, ");
                //        Console.WriteLine("}, ");
                //    }


            
            
            Console.ReadKey();
        }
    }
}
