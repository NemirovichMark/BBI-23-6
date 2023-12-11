using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

class Program
{
    static int FindMax(double[,] a)
    { double max = -0.0000000001;
        int index = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            if (a[i, i] > max)
            {
                max = a[i, i];
                index = i;
            }
        }
        return index;
    }
    static double[,] FindMax2(double[,] a)
    {

        for (int i = 0; i < a.GetLength(0); i++)
        {
            double max = -0.000000000000000000001;
            int index = 0;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] > max)
                {
                    max = a[i, j];
                    index = j;
                }
            }
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[i, j] == max)
                {
                    if (i % 2 == 0)
                    {
                        a[i, index] = 0;
                    }
                    if (i % 2 != 0)
                    {
                        a[i, index] *= index + 1;
                    }
                }
            }


        }

        return a;
    }
    static double[] GetMinElements(double[,] a)
    {
        double[] b = new double[a.GetLength(0)];

        for (int i = 0; i < a.GetLength(0); i++)
        {
            double min = a[i, i]; // Минимальный элемент на диагонали

            for (int j = i + 1; j < a.GetLength(0); j++)
            {
                if (a[i, j] < min)
                {
                    min = a[i, j];
                }
            }

            b[i] = min;
        }

        return b;
    }
    static double Average(double[,] d)
    {
        double sum = 0;
        int count = 0;
        double min = 10000000000000;
        double max = -10000000000000;

        foreach (double element in d)
        {
            if (element < min)
            {
                min = element;
            }

            if (element > max)
            {
                max = element;
            }

            sum += element;
            count++;
        }
        if (count <= 2)
        {
            return 0;
        }
        else
        {
            return (sum - min - max) / (count - 2);
        }
    }
    static double [] Suma(double[,] d)
    {
        double[] m = new double[d.GetLength(1)];

        for (int k = 0; k < d.GetLength(1); k++)
        {
            double sum = 0;
            for (int j = 0; j < d.GetLength(1); j++)
            {

                for (int i = 0; i < d.GetLength(0); i++)
                {
                    if (d[i, j] > 0)
                    {
                        sum += d[i, j];
                    }
                }
            }
            m[k] = sum;
        }
        return m;
    }
    static double[] NewArray(double[] d, double[] a)
        {
            double[] K = new double[9];

            for (int i = 0; i < 5; i++)
            {
                K[i] = d[i];
            }

            for (int i = 0; i < 4; i++)
            {
                K[i + 5] = a[i];
            }

            return K;
        }
    static bool Increasing(double[] a)
    {
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] <= a[i - 1])
            {
                return false;
            }
        }

        return true;
    }
    static bool Decreasing(double[] a)
    {
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] >= a[i - 1])
            {
                return false;
            }
        }

        return true;
    }
    static double [,] Delete(double[,] a,int index)
    {
        double[,] b = new double[a.GetLength(0) - 1, a.GetLength(1)];
        
        for (int i = 0; i < index; i++)
        {
            for (int j=0; j< a.GetLength(1);j++)
            {
                b[i,j]= a[i,j];
            }
        }
        for (int i = index; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                b[i, j] = a[i+1, j];
            }
        }

        return b;
    }
    static void FillArray(double[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.WriteLine("[" + i + "," + j + "]");
                a[i, j] = double.Parse(Console.ReadLine());
            }
        }
           }
    static void PrintArray1(double[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }
    static void PrintArray(double[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        #region// 1 уровень 3 задача
        //double[,] B = new double[5, 5];
        //double[,] C = new double[6, 6];

        //FillArray(B);
        //FillArray(C);
        //int b=FindMax(B);
        //int c=FindMax(C);
        //B = Delete(B, b);
        //C = Delete(C, c);
        //PrintArray(B);
        //PrintArray(C);
        #endregion

        #region// 1 уровень 9 задача
        //double[,] A = new double[6, 5];
        //double[,] C = new double[7, 4];
        //FillArray(A);
        //FillArray(C);
        //double[] a = new double[5];
        //double[] c = new double[4];
        //a = Suma(A);
        //c = Suma(C);
        //PrintArray1(a);
        //Console.WriteLine();
        //PrintArray1(c);
        // double[]b= new double[9];
        //b = NewArray(a, c);
        //PrintArray1(b);
        #endregion

        #region// 1 уровень 15 задача
        //int n = Int32.Parse(Console.ReadLine());
        //int m = Int32.Parse(Console.ReadLine());
        //if (n <= 0 | m <= 0)
        //{
        //    Console.WriteLine("Введите другие значения");

        //}
        //double[,] a = new double[n, m];
        //int q = Int32.Parse(Console.ReadLine());
        //int w = Int32.Parse(Console.ReadLine());
        //if (q <= 0 | w <= 0)
        //{
        //    Console.WriteLine("Введите другие значения");

        //}
        //double[,] b = new double[q, w];
        //int e = Int32.Parse(Console.ReadLine());
        //int r = Int32.Parse(Console.ReadLine());
        //if (e <= 0 | r <= 0)
        //{
        //    Console.WriteLine("Введите другие значения");

        //}
        //double[,] c = new double[e, r];
        //FillArray(a);
        //FillArray(b);
        //FillArray(c);
        //double[] sr = new double[3];
        //sr[0] = Average(a);
        //sr[1] = Average(b);
        //sr[2] = Average(c);
        //PrintArray1(sr);
        //if (Increasing(sr))
        //{
        //    Console.WriteLine("Средние значения образуют возрастающую последовательность");
        //}
        //else if (Decreasing(sr))
        //{
        //    Console.WriteLine("Средние значения образуют убывающую последовательность");
        //}
        //else
        //{
        //    Console.WriteLine("Средние значения не образуют определенную последовательность");
        //}



        #endregion

        #region// 1 уровень 21 задача
        //int n = Int32.Parse(Console.ReadLine());
        //int m = Int32.Parse(Console.ReadLine());
        //double[,] a = new double[n, m];
        //int f = Int32.Parse(Console.ReadLine());
        //int k = Int32.Parse(Console.ReadLine());
        //double[,] b = new double[f, k];
        //FillArray(a);
        //FillArray(b);
        //double[] A = GetMinElements(a);
        //double[] B = GetMinElements(b);
        //PrintArray1(A);
        //PrintArray1(B);
        #endregion

        #region// 1 уровень 27 задача
        int n = Int32.Parse(Console.ReadLine());
        int m = Int32.Parse(Console.ReadLine());
        double[,] a = new double[n, m];
        int f = Int32.Parse(Console.ReadLine());
        int k = Int32.Parse(Console.ReadLine());
        double[,] b = new double[f, k];
        FillArray(a);
        FillArray(b);
        a = FindMax2(a);
        b = FindMax2(b);
        PrintArray(a);
        PrintArray(b);
        #endregion
        Console.ReadKey();
    }
}
