using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 0.
 * В программе сформировать и вывести на экран целочисленный массив из N элементов,
 * элементами которого являются нечетные числа от 1.
 * Заполнение массива нечётными числами организовать при помощи метода.​
 *
 * Пример входных данных:
 * 7
 *
 * Пример выходных данных:
 * 1 3 5 7 9 11 13
 */

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask03();
        }

        public static void RunTask03()
        {
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];

            FillArray(ref arr);

            OutputArray(arr);
        }

        static void FillArray(ref int[] arr)
        {
            arr[0] = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + 2;
            }
        }

        static void OutputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}