

//8.3
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int n = 4, m = 3;
//        Console.WriteLine("Введите элементы матрицы");
//        int[,] a = new int[n, m];
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write("{0,3:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        int ps = 0;
//        int k1 = 0;
//        int count = 0;
//        int pos = 0;
//        int pos1 = 0;
//        for (int i = 0; i < n; i++)
//        {
//            int k = 0;
//            for (int j = 0; j < m; j++)
//            {
//                if (a[i, j] > 0)
//                {
//                    k++;
//                }
//            }
//            ps = i;
//            for (k = i + 1; k < n; k++)
//            {
//                k1 = 0;
//                for (int l = 0; l < m; l++)
//                {
//                    k1++;
//                }
//                if (k1 >= k)
//                {
//                    count = k1;
//                    pos = k;
//                }
//            }
//            if (count > k)
//            {
//                for (int q = 0; q < m; q++)
//                {
//                    int p = a[pos, q];
//                    a[pos, q] = a[pos1, q];
//                    a[pos1, q] = p;
//                }
//            }
//        }
//        Console.WriteLine("Преобразованная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write("{0,3:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

        
















