using System;
class Program
{
    static void Main(string[] args)
    {
        #region //2 уровень 15 задача
        //int n = Int32.Parse(Console.ReadLine());
        //int m = Int32.Parse(Console.ReadLine());
        //double[] A = new double[n];
        //double[] B = new double[m];
        //double[] C = new double[m + n];

        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    A[i] = Double.Parse(Console.ReadLine());
        //}
        //Console.WriteLine();
        //for (int i = 0; i < m; i++)
        //{
        //    B[i] = Double.Parse(Console.ReadLine());
        //}
        //int k = Int32.Parse(Console.ReadLine());
        //if (k > n)
        //{
        //    Console.WriteLine("Некорректное k");
        //}
        //else
        //{
        //    for (int i = 0; i < k; i++)
        //    {
        //        C[i] = A[i];
        //    }
        //    for (int i = k; i < k + m; i++)
        //    {
        //        C[i] = B[i - k];
        //    }
        //    for (int i = k + m; i < m + n; i++)
        //    {
        //        C[i] = A[i - m];
        //    }
        //    for (int i = 0; i < m + n; i++)
        //    {
        //        Console.WriteLine(C[i]);
        //    }
        //}

        #endregion

        #region //2уровень 17 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int indexmin = 0;
        //int indexmax = 0;
        //int count1 = 0, count2 = 0;
        //double min = 1000000000000;
        //double max = -100000000;
        //double s1 = 0, sr1 = 0, s2 = 0, sr2 = 0;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] < min)
        //    {
        //        min = a[i];
        //        indexmin = i;
        //    }
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        indexmax = i;
        //    }
        //}
        //Console.WriteLine();
        //Console.WriteLine(a[indexmax]);
        //Console.WriteLine(a[indexmin]);
        //if (indexmax < indexmin)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (a[i] > 0)
        //        {
        //            s1 += a[i];
        //            count1++;
        //        }
        //        if (count1 > 0)
        //        {
        //            sr1 = s1 / count1;
        //        }
        //        else { Console.WriteLine("Таких чисел нет"); break; }
        //    }
        //    Console.WriteLine(sr1);
        //}
        //else
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (a[i] < 0)
        //        {
        //            s2 += a[i];
        //            count2++;
        //        }
        //        if (count2 > 0)
        //        {
        //            sr2 = s2 / count1;
        //        }
        //        else { Console.WriteLine("Таких чисел нет"); break; }
        //    }
        //    sr2 = s2 / count2;
        //    Console.WriteLine(sr2);
        //}
        #endregion

        #region//3 уровень 6 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] A = new double[n];
        //int dlina = 1;
        //int maxdlina = 0;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    A[i] = Double.Parse(Console.ReadLine());
        //}
        //for (int i = 0; i < n - 1; i++)
        //{
        //    if (A[i] > A[i + 1])
        //    {
        //        dlina++;

        //        if (dlina > maxdlina)
        //        {
        //            maxdlina = dlina;
        //        }
        //    }
        //    else
        //    {
        //        dlina = 1;
        //    }
        //}
        //Console.WriteLine("Максимальная длина последовательности: " + maxdlina);
        #endregion

        Console.ReadKey();
    }
}
