using System;
class Program
{
    static double[] Suma(double[,] d)
    {
        double[] m = new double[d.GetLength(1)];

        for (int j = 0; j < d.GetLength(1); j++)
        {
            double sum = 0;
            for (int i = 0; i < d.GetLength(0); i++)
            {
                if (d[i, j] > 0)
                {
                    sum += d[i, j];
                }
            }
            m[j] = sum;
        }

        return m;
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
    static void Main()
    {
        double[,] A = new double[6, 5];
        double[,] C = new double[7, 4];
        FillArray(A);
        FillArray(C);
        double[] a = new double[5];
        double[] c = new double[4];
        a = Suma(A);
        c = Suma(C);
        PrintArray1(a);
        Console.WriteLine();
        PrintArray1(c);
        double[] b = new double[9];
        b = NewArray(a, c);
        PrintArray1(b);
        Console.ReadKey();
    }
}

