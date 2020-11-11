using System;
using System.Linq;

/*
 * Написать метод замены всех вхождений максимального элемента массива значением, переданным в параметре.​
 *
 * В основной программе объявить и инициализировать массив
 * (данные вводятся с клавиатуры: сначала количество элементов, далее сам массив поэлементно с новой строки);
 * Из последней введенной строки получить от пользователя число,
 * заменить им все вхождения максимального элемента в массив.
 * 
 * Исходный и изменённый массивы вывести на экран.​
 *
 * Дополнительные указания смотрите непосредственно в коде
 *
 * Пример входных данных:
 * 5
 * 4
 * 7
 * 3
 * 2
 * 4
 * 10
 *
 * Пример выходных данных:
 * 4 7 3 2 4
 * 4 10 3 2 4
 */

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask01();
        }

        public static void RunTask01()
        {
            int numOfItems = int.Parse(Console.ReadLine());
            int[] array = new int[numOfItems];
            for (int i = 0; i < numOfItems; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int newValue = int.Parse(Console.ReadLine());
            OutputArray(array);
            ReplaceMaxElem(ref array, newValue);
            OutputArray(array);
        }

        static void OutputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void ReplaceMaxElem(ref int[] arr, int val)
        {
            int max = arr.Max();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max)
                {
                    arr[i] = val;
                }
            }

        }
    }
}