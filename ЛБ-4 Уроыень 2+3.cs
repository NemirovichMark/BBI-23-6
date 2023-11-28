// LEVEL 2 
// #4
//using System;
//using System.Collections.Immutable;
//using System.Reflection.Metadata;

//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double[,] a = new double[7, 5];
//        int n = 7, m = 5;
//        Console.WriteLine("Заполните матрицу");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.WriteLine("f[" + i + "," + j + "]: ");
//                a[i, j] = double.Parse(Console.ReadLine());
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Введенная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0,3:f} ", a[i, j]);
//            Console.WriteLine();
//        }
//        string q;
//        double[] b = new double[5];
//        Console.WriteLine("Введите массив B");
//        for (int i = 0; i < 5; i++)
//        {
//            q = Console.ReadLine();
//            b[i] = double.Parse(q);
//        }
//        for (int j = 0; j < m; j++)
//        {
//            double amax = a[0, j];
//            int imax = 0;
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i, j] > amax)
//                {
//                    amax = a[i, j];
//                    imax = i;
//                }
//            }
//            if (b[j] > a[imax, j])
//            {
//                a[imax, j] = b[j];
//            }

//        }
//        Console.WriteLine();
//        Console.WriteLine("Измененная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write("{0,3:f} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

// #8
//using System;
//using System.Collections.Immutable;
//using System.Reflection.Metadata;

//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double[,] b = new double[6, 6];
//        int n = 6, m = 6;
//        Console.WriteLine("Заполните матрицу");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.WriteLine("b[" + i + "," + j + "]: ");
//                b[i, j] = double.Parse(Console.ReadLine());
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Введенная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0,3:f} ", b[i, j]);
//            Console.WriteLine();
//        }
//        for (int i = 1; i < m; i=i+2)
//        {
//            double amax = b[i-1, 0];
//            double aamax = b[i, 0];
//            int imax = 0;
//            int iimax = 0;
//            int jmax = 0;
//            int jjmax = 0;
//            double w = 0;
//            for (int j = 0; j < n; j++)
//            {
//                if (b[i-1, j] > amax)
//                {
//                    amax = b[i-1, j];
//                    imax = i-1;
//                    jmax = j;
//                }
//                if (b[i, j] > aamax)
//                {
//                    aamax = b[i, j];
//                    iimax = i;
//                    jjmax = j;
//                }
//            }
//            w = b[imax, jmax];
//            b[imax, jmax] = b[iimax, jjmax];
//            b[iimax, jjmax] = w;

//        }
//        Console.WriteLine();
//        Console.WriteLine("Измененная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write("{0,3:f} ", b[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

// LEVEL 3 #2
//using System;
//using System.Collections.Immutable;
//using System.Reflection.Metadata;

//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double[,] b = new double[3, 3];
//        int n = 3, m = 3;
//        Console.WriteLine("Заполните матрицу");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.WriteLine("b[" + i + "," + j + "]: ");
//                b[i, j] = double.Parse(Console.ReadLine());
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Введенная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0,3:f0} ", b[i, j]);
//            Console.WriteLine();
//        }
//        for (int i = 0; i < n; i++)
//        {
//            b[0, i] = 0;
//            b[i, 0] = 0;
//            b[n - 1, i] = 0;
//            b[i, n - 1] = 0;
//        }
//        Console.WriteLine();
//        Console.WriteLine("Измененная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0,3:f0} ", b[i, j]);
//            Console.WriteLine();
//        }
//    }
//}

// #1
using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] a = new int[7, 5];
        Random random = new Random();
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                a[i, j] = random.Next(100);
            }
        }
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int[] min1 = new int[7];
        for (int i = 0; i < 7; i++)
        {
            int amin = a[i, 0];
            for (int j = 0; j < 5; j++)
            {
                if (a[i, j] < amin)
                {
                    amin = a[i, j];
                }
            }
            Console.WriteLine($"Минимальный элемент в строке {i}: {amin}");
            min1[i] = amin;
        }
        for (int i = 0; i < 7 - 1; i++)
        {
            for (int j = i + 1; j < 7; j++)
            {
                if (min1[j] > min1[i])
                {
                    int d = min1[i];
                    min1[i] = min1[j];
                    min1[j] = d;
                    for (int k = 0; k < 5; k++)
                    {
                        d = a[i, k];
                        a[i, k] = a[j, k];
                        a[j, k] = d;
                    }
                }
            }
        }
        Console.WriteLine("Измененная матрица");
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}