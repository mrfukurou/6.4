using System;

namespace ConsoleApp14
{
    class Program
    {
        static int[][] Input()
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    Random rand = new Random();
                    a[i][j] = rand.Next(-100, 200);

                }
            }
            return a;
        }

        static void Print1(int[] a)
        {
            for (int i = 0; i < a.Length; ++i)
                Console.Write("{0,5} ", a[i]);
            Console.WriteLine();
        }

        static void Print2(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                for (int j = 0; j < a[i].Length; ++j)
                    Console.Write("{0,5} ", a[i][j]);
        }

        static int Mas(int[] a)
        {
            int mas = a[0];
            for (int i = 1; i < a.Length; ++i)
                mas += a[i];
            return mas;
        }

        static void Main()
        {
            try
            {
                int[][] myArray = Input();
                Console.WriteLine("Исходный массив:");
                Print2(myArray);
                int[] rez = new int[myArray.Length];
                for (int i = 0; i < myArray.Length; ++i)
                    rez[i] = Mas(myArray[i]);
                Console.WriteLine("Новый массив:");
                Print1(rez);
                int max = rez[0];
                for (int i = 0; i < myArray.Length; ++i)
                {
                    if (rez[i] > max) max = rez[i];
                }
                Console.WriteLine("Максимальное число в массиве: " + max);
            }
            catch { Console.WriteLine("Некорректный ввод!"); }

        }
    }
}
