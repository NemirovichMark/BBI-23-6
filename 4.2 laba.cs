using System;
class Program
{
    static void Main(string[] args)
    {
        
        #region//2 уровень 7 задача
        //double[,] a = new double[6, 6];
        //double max = -10000000000000;
        //int index = 0;
        //for (int i = 0; i < 6; i++)
        //{
        //    for (int j = 0; j < 6; j++)
        //    {
        //        Console.WriteLine("[" + i + "," + j + "]");
        //        a[i, j] = double.Parse(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < 6; i++)
        //{
        //    if (a[i, i] > max)
        //    {
        //        max = a[i, i];
        //        index = i;
        //    }
        //}
        //for (int i = 0; i < index; i++)
        //{
        //    for (int j = i + 1; j < 6; j++)
        //    {
        //        a[i, j] = 0;
        //    }
        //}
        //for (int i = 0; i < a.GetLength(0); i++)
        //{
        //    for (int j = 0; j < a.GetLength(1); j++)
        //    {
        //        Console.Write(a[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        

        #region//3 уровень 5 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[,] a = new double[n, n];
        //double max = 0;
        //double c = 0;
        //int jmax = 0;
        //int imax = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        Console.WriteLine("[" + i + "," + j + "]");
        //        a[i, j] = double.Parse(Console.ReadLine());
        //    }
        //    Console.WriteLine();
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        if (Math.Abs(a[i, j]) > max)
        //        {
        //            max = Math.Abs(a[i, j]);
        //            jmax = j;
        //            imax = i;
        //        }
        //    }
        //}
        //int k = Int32.Parse(Console.ReadLine());
        //if (k >= 1 & k <= n)
        //{
        //    k -= 1;
        //    if (imax < k)
        //    {
        //        for (int i = imax; i < k; i++)
        //        {
        //            for (int j = 0; j < a.GetLength(1); j++)
        //            {
        //                c = a[i, j];
        //                a[i, j] = a[i + 1, j];
        //                a[i + 1, j] = c;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        {
        //            for (int i = imax; i > k; i--)
        //            {
        //                for (int j = 0; j < a.GetLength(1); j++)
        //                {
        //                    c = a[i, j];
        //                    a[i, j] = a[i - 1, j];
        //                    a[i - 1, j] = c;
        //                }
        //            }
        //        }
        //    }
        //    if (jmax < k)
        //    {
        //        for (int j = jmax; j < k; j++)
        //        {
        //            for (int i = 0; i < a.GetLength(0); i++)
        //            {
        //                c = a[i, j];
        //                a[i, j] = a[i, j + 1];
        //                a[i, j + 1] = c;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int j = jmax; j > k; j--)
        //        {
        //            for (int i = 0; i < a.GetLength(0); i++)
        //            {
        //                c = a[i, j];
        //                a[i, j] = a[i, j - 1];
        //                a[i, j - 1] = c;
        //            }
        //        }
        //    }
        //}

        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        Console.Write(a[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        Console.ReadKey();
    }
}