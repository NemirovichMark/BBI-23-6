using System;
using System.Collections.Immutable;
using System.Reflection.Metadata;
class Programm
{
    static void Main(string[] agrs)
    {
        double[,] b = new double[6, 6];
        int n = 6, m = 6;
        Console.WriteLine("Заполните матрицу");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine("b[" + i + "," + j + "]: ");
                b[i, j] = double.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
        Console.WriteLine("Введенная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write("{0,3:f} ", b[i, j]);
            Console.WriteLine();
        }
        for (int i = 1; i < m; i = i + 2)
        {
            double amax = b[i - 1, 0];
            double aamax = b[i, 0];
            int jmax = 0;
            int jjmax = 0;
            double w = 0;
            for (int j = 0; j < n; j++)
            {
                if (b[i - 1, j] > amax)
                {
                    amax = b[i - 1, j];
                    jmax = j;
                }
                if (b[i, j] > aamax)
                {
                    aamax = b[i, j];
                    jjmax = j;
                }
            }
            w = b[i-1, jmax];
            b[i-1, jmax] = b[i, jjmax];
            b[i, jjmax] = w;

        }
        Console.WriteLine();
        Console.WriteLine("Измененная матрица");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0,3:f} ", b[i, j]);
            }
            Console.WriteLine();
        }
    }
}
