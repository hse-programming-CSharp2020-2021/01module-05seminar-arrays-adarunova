using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 0
 * В программе сформировать и вывести на экран целочисленный массив из N элементов
 * Значениями элементов являются степени числа 2 от нулевой до N-1 (1, 2, … 2^(N-1)).
 * Заполнение массива степенями числа 2 организовать при помощи метода.
 *
 * Пример входных данных:
 * 4
 *
 * Пример выходных данных:
 * 1 2 4 8
 */

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask02();
        }

        public static void RunTask02()
        {
            int N = int.Parse(Console.ReadLine());

            long[] arr = new long[N];

            FillArray(ref arr);

            OutputArray(arr);
        }

        static void FillArray(ref long[] arr)
        {
            arr[0] = 1;
            for(int i = 1; i < arr.Length; i++)
            {
                arr[i] = QuickMultiply(i);
            }
        }

        static long QuickMultiply(int x)
        {
            if (x > 30)
                return (long)Math.Pow(2, x);
            return 2 << (x - 1);
        }

        static void OutputArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}