using System;
class Program
{
    static int MaxEl(int[,] x)
    {
        int jmax = 0;
        int max = 0;
        for (int i = 0; i < x.GetLength(0); i++)
        {
            for (int j = 0; j < x.GetLength(1); j++)
            {
                if (x[i, j] > max)
                {
                    max = x[i, j];
                    jmax = j;
                }
            }
        }
        return jmax;
    }
    static void Exchange(int[,] x, int index)
    {
        for (int i = 0; i < x.GetLength(0); i++)
        {
            int p = x[i, index];
            x[i, index] = x[i, i];
            x[i, i] = p;
        }
    }
    static void Print(int[,] x)
    {
        for (int i = 0; i < x.GetLength(0); i++)
        {
            for (int j = 0; j < x.GetLength(1); j++)
            {
                Console.Write("{0,3:d} ", x[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int[,] a =
        {
            { 9, 8, 7 },
            { 6, 15, 4 },
            { 3, 2, 1 }
        };
        int[,] b =
        {
            { 19, 18, 17 },
            { 16, 5, 14 },
            { 13, 12, 11 }
        };
        int amax;
        int bmax;
        amax = MaxEl(a);
        bmax = MaxEl(b);
        Exchange(a, amax);
        Exchange(b, bmax);
        Console.WriteLine("Преобразованная матрица a");
        Print(a);
        Console.WriteLine("Преобразованная матрица b");
        Print(b);
    }
}

