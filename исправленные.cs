//3.2
//int n = int.Parse(Console.ReadLine());
//int[,] a = new int[n, n];
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        a[i, j] = int.Parse(Console.ReadLine());
//        if (i == n - 1  j == 0  j == n - 1 || i == 0)
//        {
//    a[i, j] = 0;
//}
//    }
//}

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write(a[i, j] + "\t");
//    }
//    Console.WriteLine();
//}
//2.7
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int n = 6;
//        int[,] a = new int[n, n];
//        Console.WriteLine("Введите элементы матрицы");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write("{0,3:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        int max = a[0, 0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//            if (a[i, i] > max)
//            {
//                max = a[i, i];
//                imax = i;
//            }

//        for (int i = 0; i < imax; i++)
//        {
//            for (int j = i + 1; j < n; j++)
//            {
//                a[i, j] = 0;
//            }
//        }
//        Console.WriteLine("Преобразованная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write("{0,3} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

        

