// LEVEL 1    #1
//using System;
//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        int[,] a = new int[5, 7];
//        int n = 5, m = 7;
//        //Console.WriteLine("Количество столбцов");
//        //int n = int.Parse(Console.ReadLine());
//        //Console.WriteLine("Количество строк");
//        //int m = int.Parse(Console.ReadLine());
//        Console.WriteLine("Заполните матрицу");
//        for (int i=0; i<n;i++)
//        {
//            for (int j=0; j<m; j++)
//            {
//                Console.WriteLine("a["+i+","+j+"]: ");
//                a[i,j]=int.Parse(Console.ReadLine());
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0:d} ", a[i, j]);
//            Console.WriteLine();
//        }
//        int s = 0;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                s += a[i, j];
//        }
//        Console.WriteLine(s);
//    }
//}
// #2
//using System;
//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        int[,] a = new int[5, 7];
//        int n = 5, m = 7;
//        Console.WriteLine("Заполните матрицу");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.WriteLine("a[" + i + "," + j + "]: ");
//                a[i, j] = int.Parse(Console.ReadLine());
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0:d} ", a[i, j]);
//            Console.WriteLine();
//        }
//        double s = 0;
//        int p = 0;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                if (a[i, j] > 0)
//                {
//                    s += a[i, j];
//                    p++;
//                }         
//        }
//        double sr = s / p;
//        Console.WriteLine(sr);
//        Console.WriteLine(s);
//        Console.WriteLine(p);
//    }
//}

// #3
//using System;
//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        int[,] a = new int[4, 4];
//        int n = 4, m = 4;
//        Console.WriteLine("Заполните матрицу");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.WriteLine("a[" + i + "," + j + "]: ");
//                a[i, j] = int.Parse(Console.ReadLine());
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0,3:d} ", a[i, j]);
//            Console.WriteLine();
//        }
//        double s = 0;
//        for (int i = 0; i < n; i++)
//        {
//            s += a[i, i];
//        }
//        Console.WriteLine("Сумма диагональных элементов");
//        Console.WriteLine(s);
//    }
//}

// #4
//using System;
//using System.Collections.Immutable;
//using System.Reflection.Metadata;

//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        int[,] a = new int[3, 6];
//        int n = 3, m = 6;
//        Console.WriteLine("Заполните матрицу");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.WriteLine("a[" + i + "," + j + "]: ");
//                a[i, j] = int.Parse(Console.ReadLine());
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0,3:d} ", a[i, j]);
//            Console.WriteLine();
//        }
//        int amin = a[0, 0];
//        int imin = 0;
//        int jmin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j=0; j<m; j++)
//            {
//                if (amin > a[i,j])
//                {
//                    amin = a[i,j];
//                    imin = i;
//                    jmin = j;
//                }
//            }
//        }
//        Console.WriteLine("Минимальный элемент матрицы");
//        Console.WriteLine(amin);
//        Console.WriteLine("Номер строки");
//        Console.WriteLine(imin);
//        Console.WriteLine("Номер столбца");
//        Console.WriteLine(jmin);
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
//        int[,] a = new int[4, 6];
//        int n = 4, m = 6;
//        double[] b = new double [4];
//        Console.WriteLine("Заполните матрицу");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.WriteLine("a[" + i + "," + j + "]: ");
//                a[i, j] = int.Parse(Console.ReadLine());
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0,3:d} ", a[i, j]);
//            Console.WriteLine();
//        }
//        for (int i = 0; i < n; i++)
//        {
//            double sum = 0;
//            double sr = 0;
//            int p = 0;
//            for (int j = 0; j < m; j++)
//            {
//                if (a[i,j]>0)
//                {
//                    sum = sum + a[i,j];
//                    p += 1; 
//                }
//                sr = sum / p;
//            }
//            b[i]= sr;
//        }
//        Console.WriteLine("Полученный массив");
//        for (int i=0; i < 4; i++)
//        {
//            Console.Write($"{b[i]} ");
//        }
//    }
//}

// #12
//using System;
//using System.Collections.Immutable;
//using System.Reflection.Metadata;

//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        int[,] a = new int[6, 7];
//        int n = 6, m = 7;
//        Console.WriteLine("Заполните матрицу");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.WriteLine("a[" + i + "," + j + "]: ");
//                a[i, j] = int.Parse(Console.ReadLine());
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0,3:d} ", a[i, j]);
//            Console.WriteLine();
//        }
//        double amax = a[0, 0];
//        int imax = 0;
//        int jmax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (a[i, j] > amax)
//                {
//                    amax = a[i, j];
//                    imax = i;
//                    jmax = j;
//                }
//            }
//        }
//        Console.Write("Максимальный элемент ");
//        Console.WriteLine(amax);
//        Console.Write("Строка максимального элемента ");
//        Console.WriteLine(imax);
//        Console.Write("Столбец максимального элементa ");
//        Console.WriteLine(jmax);
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                if (i < imax && j < jmax)
//                {
//                    continue;
//                }
//                else if (i == imax || j == jmax)
//                {
//                    continue;
//                }
//                else if (i < imax && j > jmax)
//                {
//                    a[i, j - 1] = a[i, j];
//                }
//                else if(i > imax && j < jmax)
//                {
//                    a[i-1,j]= a[i, j];    
//                }
//                else
//                {
//                    a[i - 1, j - 1] = a[i, j];
//                }
//            }
//        }
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < m - 1; j++)
//                Console.Write("{0,3:d} ", a[i, j]);
//        }
//    }
//}

// #16
//using System;
//using System.Collections.Immutable;
//using System.Reflection.Metadata;

//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        Console.WriteLine("Количество строк");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Количество столбцов");
//        int m = int.Parse(Console.ReadLine());
//        if (n * m == 0)
//        {
//            Console.WriteLine("В матрице нет элементов");
//            return;
//        }
//        double[,] a = new double[n, m];
//        Console.WriteLine("Заполните матрицу");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.WriteLine("a[" + i + "," + j + "]: ");
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
//        for (int i = 0; i < n; i++)
//        {
//            double amax = a[i, 0];
//            int jmax = 0;
//            for (int j = 0; j < m; j++)
//            {
//                if (a[i, j] > amax)
//                {
//                    amax = a[i, j];
//                    jmax = j;
//                }
//            }
//            for (int r = jmax+1; r < m; r++)
//            {
//                a[i, r - 1] = a[i, r];
//            }
//            a[i, m - 1] = amax;
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

// #20
//using System;
//using System.Collections.Immutable;
//using System.Reflection.Metadata;

//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        Console.WriteLine("Количество строк");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Количество столбцов");
//        int m = int.Parse(Console.ReadLine());
//        if (n * m == 0)
//        {
//            Console.WriteLine("В матрице нет элементов");
//            return;
//        }
//        double[,] f = new double[n, m];
//        Console.WriteLine("Заполните матрицу");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.WriteLine("f[" + i + "," + j + "]: ");
//                f[i, j] = double.Parse(Console.ReadLine());
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Введенная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0,3:f} ", f[i, j]);
//            Console.WriteLine();
//        }
//        for (int i = 0; i < n; i++)
//        {
//            double val1 = 1; // первый отрицательный 
//            double val2 = 1; // последний отрицательный
//            for (int j = 0; j < m; j++)
//            {
//                if (f[i, j] < 0)
//                {
//                    val1 = f[i, j];
//                }
//            }
//            for (int j = m - 1; j >= 0; j--)
//            {
//                if (f[i, j] < 0)
//                {
//                    val2 = f[i, j];
//                }
//            }
//            if (val1 >= 0)
//            {
//                Console.WriteLine($"В строке {i + 1} нет отрицательных элементов");
//                break;
//            }
//            double amax = f[i, 0];
//            int jmax = 0;
//            for (int j = 0; j < m; j++)
//            {
//                if (f[i, j] > amax)
//                {
//                    amax = f[i, j];
//                    jmax = j;
//                }
//            }
//            f[i, jmax] = (val1 + val2) / 2;
//        }
//        Console.WriteLine();
//        Console.WriteLine("Измененная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write("{0,3:f} ", f[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

// #24
//using System;
//using System.Collections.Immutable;
//using System.Diagnostics.CodeAnalysis;
//using System.Reflection.Metadata;

//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double[,] y = new double[6, 5];
//        int n = 6, m = 5;
//        Console.WriteLine("Заполните матрицу");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.WriteLine("y[" + i + "," + j + "]: ");
//                y[i, j] = double.Parse(Console.ReadLine());
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Введенная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0,3:f} ", y[i, j]);
//            Console.WriteLine();
//        }
//        for (int i = 0; i < n; i++)
//        {
//            double amax = y[i, 0];
//            int jmax = 0;
//            for (int j = 0; j < m; j++)
//            {
//                if (y[i, j] > amax)
//                {
//                    amax = y[i, j];
//                    jmax = j;
//                }
//            }
//            double sum = 0;
//            int k = 0;
//            double sr = 0;
//            for (int j = jmax+1; j < m; j++)
//            {
//                if (y[i, j] > 0)
//                {
//                    sum += y[i, j];
//                    k += 1;
//                }
//            }
//            sr = sum / k;
//            for (int j = 0; j < jmax; j++)
//            {
//                if (y[i, j] < 0)
//                {
//                    y[i, j] = sr;   
//                }
//            }
//            if (k == 0)
//            {
//                Console.WriteLine($"В строке {i + 1} нет положительных элементов элементов");
//                break;
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Измененная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write("{0,3:f} ",y[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

// #28
//using System;
//using System.Collections.Immutable;
//using System.Diagnostics.CodeAnalysis;
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
//                Console.WriteLine("a[" + i + "," + j + "]: ");
//                a[i, j] = double.Parse(Console.ReadLine());
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Введенная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//                Console.Write("{0,3:f0} ", a[i, j]);
//            Console.WriteLine();
//        }
//        double maxsum = 0;
//        int idx = -1;
//        for (int i = 0; i < n; i++)
//        {
//            double sum = 0;
//            for (int j = 0; j < m; j++)
//            {
//                if (a[i,j] > 0)
//                {
//                    sum += a[i, j];
//                }
//            }
//            if (sum > maxsum)
//            {
//                maxsum = sum;
//                idx = i;
//            }
//        }
//        for (int i = idx + 1; i<n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                a[i - 1, j] = a[i, j];
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Измененная матрица");
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write("{0,3:f0} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

// #32
//using System;
//using System.Collections.Immutable;
//using System.Reflection.Metadata;

//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double[,] a = new double[5, 7];
//        int n = 5, m = 7; 
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
//        for (int i = 0; i < n; i++)
//        {
//            double sum = 0;
//            int r = 0;
//            double sr = 0;
//            for (int j = 0; j < m; j++)
//            {
//                if (a[i,j] > 0)
//                {
//                    sum += a[i, j];
//                    r += 1;
//                }
//            }
//            if (r == 0)
//            {
//                Console.WriteLine($"В строке {i + 1} нет положительных элементов");
//                break;
//            }
//            if (r != 0)
//            {
//                sr = sum / r;
//            }
//            double amax = a[i, 0];
//            int jmax = 0;
//            for (int j = 0; j < m; j++)
//            {
//                if (a[i, j] > amax)
//                {
//                    amax = a[i, j];
//                    jmax = j;
//                }
//            }
//            a[i, jmax] = sr;
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

// LEVEL 2 #4

