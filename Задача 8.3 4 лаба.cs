
using System;

class Program
{
    static void Main(string[] args)
    {
        string s;
        int n = 4;
        int m = 3;
        int[,] a = new int[n, m];
        Console.WriteLine("Введите элементы матрицы");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                s = Console.ReadLine();
                a[i, j] = int.Parse(s);
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0,3:d} ", a[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        int k;
        int[] pos = new int[n];
        for (int i = 0; i < n; i++)
        {
            k = 0;
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] > 0)
                {
                    k++;
                }
            }
            pos[i] = k;
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (pos[j] < pos[j + 1])
                {
                    int t = pos[j];
                    pos[j] = pos[j + 1];
                    pos[j + 1] = t;

                    for (int l = 0; l < m; l++)
                    {
                        int tt = a[j, l];
                        a[j, l] = a[j + 1, l];
                        a[j + 1, l] = tt;
                    }
                }
            }
        }

        Console.WriteLine("Преобразованная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0,3:d} ", a[i, j]);
            }
            Console.WriteLine();
        }
    }
}