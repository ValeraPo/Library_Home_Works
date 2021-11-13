using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Home_Works
{
    public class HomeWork_5
    {
        //Посчитать количества нечетных и четных элементов массива
        public static int[] CountOddAndEvenDigit(int[] arr)
        {
            int count_even = 0, count_odd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) count_even++;
                else count_odd++;
            }
            return new int[] { count_even , count_odd };
            
        }

        // Каждый третий элемент массива заменить суммой двух предыдущих элементов.
        public static int[] SumThirdNumArr(int[] arr)
        {
            for (int i = 2; i < arr.Length; i += 3)
                arr[i] = arr[i - 2] + arr[i - 1];

            return arr;
        }

        //Слить два целочисленных массива в один
        public static int[] MergeArr(int[] arr1, int[] arr2)
        {
            int[] res = Helper.GenerateIntArray(arr1.Length + arr2.Length);
            arr1.CopyTo(res, 0);
            arr2.CopyTo(res, arr1.Length);
            return res;
        }

        // Поменять местами первую и вторую половину массива
        public static int[] SwapPartArray(int[] mas)
        {
            for (int i = 0, j = (int)Math.Ceiling(mas.Length / 2.0), k = mas.Length / 2; j < mas.Length; i++, j++, k++)
            {
                Helper.Swap(ref mas[i], ref mas[j]);
                Helper.Swap(ref mas[j], ref mas[k]);
            }
            return mas;
        }

        //Циклически двинуть массив вправо на 1 элемент
        public static int[] ShiftArray(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                Helper.Swap(ref mas[i], ref mas[mas.Length - 1]);
            return mas;
        }

        // Преобразовать массив так, чтобы на четных позициях
        // стояли элементы с нечетных позиций, и наоборот.
        public static int[] SwapOddAndDigitIndex(int[] mas)
        {
            for (int i = 1; i < mas.Length; i += 2)
                Helper.Swap(ref mas[i], ref mas[i - 1]);
            return mas;
        }

        //В массиве из целочисленных элементов вычислить:
        //а) минимальный по модулю элемент массива;
        //б) сумму элементов, расположенных после первого нулевого элемента
        //Сделать одним проходом цикла!
        public static (int, int) GetMinAndSumAfterZero(int[] mas)
        {
            if (mas.Length == 0) throw new IndexOutOfRangeException("Массив не должен быть пустым");
            int min = Math.Abs(mas[0]), sum = 0;
            bool flag = false;
            for (int i = 0; i < mas.Length; i++)
            {
                //Условие для поиска наименьшьего
                if (Math.Abs(mas[i]) < min) min = Math.Abs(mas[i]);
                //Если нашли 0, дергаем флаг
                if (mas[i] == 0) flag = true;
                //Если флаг уже дергали, сумма считается
                if (flag) sum += mas[i];
            }
            return (min, sum);
        }

        // Отсортировать массив по возрастанию алгоритмом вставок (insert)
        public static int[] SortInsert(int[] mas)
        {
            for (int i = 1; i < mas.Length; i++)
            {
                for (int j = i; j > 0 && mas[j - 1] > mas[j]; j--)
                    Helper.Swap(ref mas[j], ref mas[j - 1]);
            }
            return mas;
        }

        // Отсортировать массив по возрастанию алгоритмом выборки (select).
        public static int[] SortSelect(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                int min = mas[i], pos_min = i;
                for (int j = i; j < mas.Length; j++)
                {
                    if (mas[j] < min)
                    {
                        pos_min = j;
                        min = mas[j];
                    }
                }
                mas[pos_min] = mas[i];
                mas[i] = min;
            }
            return mas;
        }

    }
}
