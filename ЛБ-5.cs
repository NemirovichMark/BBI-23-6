// Номер по списку 19
// Номер 2
//using System;
//using System.ComponentModel.DataAnnotations;

//class Programm
//{
//    static void maxx(double[] x, ref double xmax, ref int imax)
//    {
//        xmax = x[0];
//        imax = 0;
//        for (int i = 0; i<x.Length; i++)
//        {
//            if (x[i] >= xmax)
//            {
//                xmax = x[i];
//                imax = i;
//            }
//        }
//    }
//    static void func(double[] x, ref int imax, ref double xmax)
//    {
//        int k = x.Length - (imax + 1);
//        if (k == 0)
//        {
//            return;
//        }
//        double sum = 0;
//        for (int i = imax + 1; i < x.Length; i++)
//        {
//            sum = sum + x[i];
//        }
//        double sr = sum / k;
//        for (int i = 0; i < x.Length; i++)
//        {
//            if (x[i] == xmax)
//            {
//                x[i] = sr;
//            }
//        }
//    }
//    static void Main(string[] args)
//    {
//        string p;
//        double[] b = new double[7];
//        int m = 7;
//        Console.WriteLine("Введите массив B");
//        for (int i = 0; i < m; i++)
//        {
//            p = Console.ReadLine();
//            b[i] = double.Parse(p);
//        }
//        double[] a = new double[9];
//        int n = 9;
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double amax = a[0], bmax = b[0];
//        int iamax = 0, ibmax = 0;
//        maxx(a, ref amax, ref iamax);
//        maxx(b, ref bmax, ref ibmax);
//        if (9 - (iamax + 1) > 7 - (ibmax + 1))
//        {
//            func(a, ref iamax, ref amax);
//        }
//        else
//        {
//            func(b, ref ibmax, ref bmax);
//        }
//        Console.WriteLine("Массив a");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }
//        Console.WriteLine();
//        Console.WriteLine("Массив b");
//        for (int i = 0; i < m; i++)
//        {
//            Console.Write($"{b[i]} ");
//        }
//    }
//}

// Номер 8
//using System;
//using System.ComponentModel.DataAnnotations;

//class Programm
//{
//    static void maxx(double[] x, ref double xmax, ref int imax)
//    {
//        xmax = x[0];
//        imax = 0;
//        for (int i = 0; i < x.Length; i++)
//        {
//            if (x[i] >= xmax)
//            {
//                xmax = x[i];
//                imax = i;
//            }
//        }
//    }
//    static void sort(double[] x, ref int imax)
//    {
//        for (int i = 0; i < x.Length - 1 - imax; i++)
//        {
//            for (int j = imax + 1; j < x.Length - 1 - i; j++)
//            {
//                if (x[j] > x[j + 1])
//                {
//                    (x[j], x[j + 1]) = (x[j + 1], x[j]);
//                    //double w = x[i];
//                    //x[i] = x[i + 1];
//                    //x[i + 1] = w;
//                }
//            }

//        }
//    }
//    static void Main(string[] args)
//    {
//        string p;
//        double[] a = new double[9];
//        int n = 9;
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double[] b = new double[11];
//        int m = 11;
//        Console.WriteLine("Введите массив B");
//        for (int i = 0; i < m; i++)
//        {
//            p = Console.ReadLine();
//            b[i] = double.Parse(p);
//        }
//        double amax = a[0], bmax = b[0];
//        int iamax = 0, ibmax = 0;
//        maxx(a, ref amax, ref iamax);
//        maxx(b, ref bmax, ref ibmax);
//        sort(a, ref iamax);
//        sort(b, ref ibmax);
//        Console.WriteLine("Массив a");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }
//        Console.WriteLine();
//        Console.WriteLine("Массив b");
//        for (int i = 0; i < m; i++)
//        {
//            Console.Write($"{b[i]} ");
//        }
//    }
//}

// Номер 14
//using System;
//using System.ComponentModel.DataAnnotations;

//class Programm
//{
//    static void sort(double[,] x, ref int l, ref int len)
//    {
//        for (int i = 0; i < len - 1; i++)
//        {
//            for (int j = 0; j < len - 1 - i; j++)
//            {
//                if (x[l, j] > x[l, j + 1])
//                {
//                    (x[l, j], x[l, j + 1]) = (x[l, j + 1], x[l, j]);
//                    //double w = x[i];
//                    //x[i] = x[i + 1];
//                    //x[i + 1] = w;
//                }
//            }

//        }
//    }
//    static void Main(string[] args)
//    {
//        string p;
//        int n , m;
//        Console.WriteLine("Введите количество строк");
//        n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите количество столбцов");
//        m = int.Parse(Console.ReadLine());
//        if (n*m==0)
//        {
//            Console.WriteLine(" Матрица пустая ");
//            return;
//        }
//        double[,] a = new double[n, m];
//        Console.WriteLine("Введите матрицу A");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"Введите {i + 1} строку");
//            for (int j = 0; j < m; j++)
//            {
//                a[i, j] = double.Parse(Console.ReadLine());
//            }
//        }
//        for (int i = 0; i < n; ++i)
//        {
//            sort(a, ref i, ref m);
//        }
//        Console.WriteLine("Матрица A");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"{a[i,j]} ");
//            }
//            Console.WriteLine();

//        }
//    }
//}

// Номер 20
//using System;
//using System.ComponentModel.DataAnnotations;

//class Programm
//{
//    static void delete(double [][] x, ref int k)
//    {
//        for (int j = k; j < x[0].Length - 1; j++)
//        {
//            for (int i = 0; i < x.Length; i++)
//            {
//                x[i][j] = x[i][j + 1];
//            }
//        }
//    }
//    static int func(double[][] x)
//    {
//        int cnt = 0; // кол-во удаленных столбиков
//        for (int j = 0; j < x[0].Length - cnt; j++)
//        {
//            bool zero = false;
//            for (int i = 0; i < x.Length && !zero; i++)
//            {
//                zero = (x[i][j] == 0);
//            }
//            if (zero == true)
//            {
//                delete(x, ref j);
//                --j;
//                ++cnt;
//            }
//        }
//        return cnt;
//    }
//    static void Main(string[] args)
//    {
//        string p;
//        int n, m;
//        Console.WriteLine("Введите количество строк матрицы А");
//        n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите количество столбцов матрицы А");
//        m = int.Parse(Console.ReadLine());
//        if (n * m == 0)
//        {
//            Console.WriteLine(" Матрица пустая ");
//            return;
//        }
//        double[][] a = new double[n][];
//        Console.WriteLine("Введите матрицу A");
//        for (int i = 0; i < n; i++)
//        {
//            a[i] = new double[m];
//            Console.WriteLine($"Введите {i + 1} строку");
//            for (int j = 0; j < m; j++)
//            {
//                a[i][j] = double.Parse(Console.ReadLine());
//            }
//        }
//        int r, q;
//        Console.WriteLine("Введите количество строк матрицы В");
//        r = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите количество столбцов матрицы В");
//        q = int.Parse(Console.ReadLine());
//        if (r * q == 0)
//        {
//            Console.WriteLine(" Матрица пустая ");
//            return;
//        }
//        double[][] b = new double[r][];
//        Console.WriteLine("Введите матрицу B");
//        for (int i = 0; i < r; i++)
//        {
//            b[i] = new double[q];
//            Console.WriteLine($"Введите {i + 1} строку");
//            for (int j = 0; j < q; j++)
//            {
//                b[i][j] = double.Parse(Console.ReadLine());
//            }
//        }
//        Console.WriteLine("Введеная матрица A");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write($"{a[i][j]} ");
//            }
//            Console.WriteLine();

//        }
//        Console.WriteLine("Введеная матрица B");
//        for (int i = 0; i < r; i++)
//        {
//            for (int j = 0; j < q; j++)
//            {
//                Console.Write($"{b[i][j]} ");
//            }
//            Console.WriteLine();

//        }
//        int newSizeA = m - func(a);
//        int newSizeB = q - func(b);
//        Console.WriteLine("Матрица A");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < newSizeA; j++)
//            {
//                Console.Write($"{a[i][j]} ");
//            }
//            Console.WriteLine();

//        }
//        Console.WriteLine("Матрица B");
//        for (int i = 0; i < r; i++)
//        {
//            for (int j = 0; j < newSizeB; j++)
//            {
//                Console.Write($"{b[i][j]} ");
//            }
//            Console.WriteLine();

//        }
//    }
//}

// Номер 26
using System;
using System.ComponentModel.DataAnnotations;

class Programm
{
    static int neg(double[][] x, ref int k) // где k строка
    {
        int cnt = 0;
        for ( int j = 0; j < x[k].Length; j++ )
        {
            if (x[k][j] < 0)
            {
                ++cnt;
            }
        }
        return cnt;
    }
    static int num(double[][] x)
    {
        int max = -99999999;
        int imax = -1;
        for (int i = 0; i < x.Length; ++i)
        {
            int cnt = neg(x, ref i);
            if (max < cnt)
            {
                max = cnt;
                imax = i;
            }
        }
        return imax;
    }
    static void Main(string[] args)
    {
        string p;
        int n, m;
        Console.WriteLine("Введите количество строк матрицы А");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов матрицы А");
        m = int.Parse(Console.ReadLine());
        if (n * m == 0)
        {
            Console.WriteLine(" Матрица пустая ");
            return;
        }
        double[][] a = new double[n][];
        Console.WriteLine("Введите матрицу A");
        for (int i = 0; i < n; i++)
        {
            a[i] = new double[m];
            Console.WriteLine($"Введите {i + 1} строку");
            for (int j = 0; j < m; j++)
            {
                a[i][j] = double.Parse(Console.ReadLine());
            }
        }
        double[][] b = new double[n][];
        Console.WriteLine("Введите матрицу B");
        for (int i = 0; i < n; i++)
        {
            b[i] = new double[m];
            Console.WriteLine($"Введите {i + 1} строку");
            for (int j = 0; j < m; j++)
            {
                b[i][j] = double.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Введеная матрица A");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{a[i][j]} ");
            }
            Console.WriteLine();

        }
        Console.WriteLine("Введеная матрица B");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{b[i][j]} ");
            }
            Console.WriteLine();
        }
        (a[num(a)], b[num(b)]) = (b[num(b)], a[num(a)]);
        Console.WriteLine("Матрица A");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{a[i][j]} ");
            }
            Console.WriteLine();

        }
        Console.WriteLine("Матрица B");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{b[i][j]} ");
            }
            Console.WriteLine();

        }
    }
}




