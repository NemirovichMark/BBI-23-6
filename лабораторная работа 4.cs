//3.1
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] a = new int[4, 4];
//        string s;
//        Console.WriteLine("Введите элементы матрицы");
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 4; j++)
//            {
//                Console.WriteLine("{0,3:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        int sum1 = 0;
//        for (int i = 0; i < 4; i++)
//        {
//            sum1 += a[i, i];
//        }
//        Console.WriteLine("Сумма элeментов главной диагонали");
//        Console.WriteLine(sum1);
//        int sum2 = 0;
//        for (int i = 0; i < 4; i++)
//        {
//            sum2 += a[i, 4 - i - 1];
//        }
//        Console.WriteLine("Сумма элементов побочной диагонали");
//        Console.WriteLine(sum2);
//        int sum = sum1 + sum2;
//        Console.WriteLine("Сумма диагональных элементов");
//        Console.WriteLine(sum);
//    }
//}
//8.1
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[,] a = new int[4, 6];
//        string s;
//        Console.WriteLine("Введите элементы матрицы");
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < 4; i++)
//        {
//            for (int j = 0; j < 6; j++)
//            {
//                Console.WriteLine("{0,3:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        double[] b = new double[4];
//        for (int i = 0; i < 4; i++)
//        {
//            double sum = 0;
//            double k = 0;
//            for (int j = 0; j < 6; j++)
//            {
//                if (a[i, j] > 0)
//                {
//                    sum += a[i, j];
//                    k += 1;
//                }
//            }
//            b[i] = sum / k;
//        }
//        Console.WriteLine("Полученный массив");
//        for (int i = 0; i < 4; i++)
//        {
//            Console.WriteLine(b[i]);
//        }
//    }
//}
//12.1
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int[,] a = new int[6, 7];
//        Console.WriteLine("Введите элементы матрицы");
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.WriteLine("{0:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        int amax = a[0, 0];
//        int imax = 0;
//        int jmax = 0;
//        for (int i = 0; i < 6; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                if (a[i, j] > amax)
//                {
//                    amax = a[i, j];
//                    imax = i;
//                    jmax = j;
//                }
//            }
//        }
//        Console.WriteLine("Максимальный элемент и его индексы");
//        Console.WriteLine($"{amax}, {imax}, {jmax}");
//        Console.WriteLine("Преобразованная матрица");
//        int[,] b = new int[5, 6];
//        int i1 = 0;
//        int j1 = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            if (i >= imax)
//            {
//                i1 = i + 1;
//            }
//            else
//            {
//                i1 = i;
//            }
//            for (int j = 0; j < 6; j++)
//            {
//                if (j >= jmax)
//                {
//                    j1 = j + 1;
//                }
//                else
//                {
//                    j1 = j;
//                }
//                b[i, j] = a[i1, j1];
//                Console.WriteLine("{0:d} ", b[i, j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }
//}
//15.1
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int[,] a = new int[5, 7];
//        Console.WriteLine("Введите элементы матрицы");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write("{0:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        for (int i = 0; i < 5; i++)
//        {
//            int amax = a[i, 0];
//            int jmax = 0;
//            for (int j = 0; j < 7; j++)
//            {
//                if (a[i, j] > amax)
//                {
//                    amax = a[i, j];
//                    jmax = j;
//                }
//            }
//            a[i, jmax] = a[i, jmax] * i;
//        }
//        Console.WriteLine("Преобразованная матрица");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write("{0:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//19.1
//using System;
//using System.Runtime.CompilerServices;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите m");
//        int m = Convert.ToInt32(Console.ReadLine());
//        double[,] a = new double[n, m];
//        Console.WriteLine("Введите элементы матрицы");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = double.Parse(s);
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write("{0:f} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
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
//            for(int j = 0; j < jmax; j++)
//            {    
//                if (a[i, j] < 0)
//                {
//                    a[i, j] = a[i, j] / amax;

//                }
//            }
//        }
//        Console.WriteLine();
//        Console.WriteLine("Преобразованная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                Console.Write("{0, 3:f} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//23.1
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int[,] a = new int[3, 4];
//        int n = 3, m = 4;
//        Console.WriteLine("Введите элементы матрицы");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m - 1; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m - 1; j++)
//            {
//                Console.Write("{0,3:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        for (int i = 0; i < n; i++)
//        {
//            int amax = a[i, 0];
//            int jmax = 0;
//            for (int j = 0; j < m - 1; j++)
//            {
//                if (a[i, j] > amax)
//                {
//                    amax = a[i, j];
//                    jmax = j;
//                }
//            }
//            for (int j = m - 1; j > jmax; j--)
//            {
//                if (j > jmax)
//                {
//                    a[i, j] = a[i, j - 1];
//                }

//            }
//            a[i, jmax + 1] = amax;
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
//27.1
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int[,] a = new int[5, 7];
//        Console.WriteLine("Введите элементы матрицы");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write("{0:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        //Console.WriteLine();
//        int[] b = new int[5];
//        for (int i = 0; i < 5; i++)
//        {
//            int amax = a[i, 0];
//            int imax = 0;
//            int jmax = 0;
//            for (int j = 0; j < 7; j++)
//            {
//                if (a[i, j] > amax)
//                {
//                    amax = a[i, j];
//                    imax = i;
//                    jmax = j;
//                }
//            }
//            for (int j = 0; j < 7; j++)
//            {
//                if (a[i, j] == amax)
//                {
//                    b[i] = a[i, j];
//                }
//            }
//        }
//        int c = 0;
//        for (int i = 0; i < 5 / 2; i++)
//        {
//            c = b[i];
//            b[i] = b[5 - 1 - i];
//            b[5 - 1 - i] = c;
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            a[i, 3] = b[i];
//        }
//        Console.WriteLine("Преобразованная матрица");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                Console.Write("{0:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//31.1
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int[,] a = new int[5, 8];
//        Console.WriteLine("Введите элеменеты матрицы");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 7; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 1; j < 7; j++)
//            {
//                Console.Write("{0:d}  ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        int[] b = new int[5];
//        int amin = a[4, 0];
//        int jmin = 0;
//        for (int j = 1; j < 7; j++)
//        {
//            if (a[4, j] < amin)
//            {
//                amin = a[4, j];
//                jmin = j;
//            }
//        }
//        int[,] r = new int[5, 9];
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < jmin; j++)
//            {
//                r[i, j] = a[i, j];
//            }
//            r[i, jmin + 1] = b[i];
//            for (int j = jmin + 2; j < 9; j++)
//            {
//                r[i, j] = a[i, j - 1];
//            }
//        }
//        Console.WriteLine("Искомая матрица");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                Console.Write("{0,3:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//3.2
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int n = 10, m = 5;
//        int[,] a = new int[n, m];
//        Console.WriteLine("Введите элементы матрицы");
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
//        Console.WriteLine();
//        for (int j = 0; j < m; j++)
//        {
//            int amax = a[0, j];
//            int imax = 0;
//            for (int i = 0; i < n; i++)
//            {
//                if (a[i, j] > amax)
//                {
//                    amax = a[i, j];
//                    imax = i;
//                }
//            }
//            int sum = 0;
//            for (int i = 0; i < n; i++)
//            {
//                if (imax < (n / 2))
//                {
//                    if (i > imax)
//                    {
//                        sum = sum + a[i, j];
//                    }
//                    a[0, j] = sum;
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
//7.2
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int n = 6;
//        int[,] a = new int[n, n];
//        Console.WriteLine("Введите элементы матрицы");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write("{0,3:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        int amax = a[0, 0];
//        int imax = 0;
//        int jmax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i, i] > amax)
//            {
//                amax = a[i, i];
//                imax = i;
//                jmax = i;
//            }
//        }
//        for (int i = 0; i < imax; i++)
//        {
//            for (int j = jmax + 1; j < n; j++)
//            {
//                a[i, j] = 0;
//            }
//        }
//        Console.WriteLine("Преобразованная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write("{0,3:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//1.3
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int[,] a = new int[7, 5];
//        Console.WriteLine("Введите элементы матрицы");
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                s = Console.ReadLine();
//                a[i,j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write("{0,3:d} ", a[i,j]);
//            }
//            Console.WriteLine();
//        }
//        int[] min1 = new int[7];
//        for (int i=0; i < 7; i++) 
//        {
//            int amin = a[i,0];
//            for (int j = 0;j < 5; j++)
//            {
//                if (a[i,j] < amin)
//                {
//                    amin= a[i,j];
//                }
//            }
//            Console.WriteLine($"Минимальный элемент в столбце {i}: {amin}");
//            min1[i] = amin;
//        }
//        for (int i = 0; i < 7 - 1; i++)
//        {
//            for (int j = i + 1; j < 7; j++)
//            {
//                if (min1[j] > min1[i])
//                {
//                    int d = min1[i];
//                    min1[i] = min1[j];
//                    min1[j] = d;
//                    for (int k = 0; k < 5; k++)
//                    {
//                        d = a[i, k];
//                        a[i, k] = a[j, k];
//                        a[j, k] = d;
//                    }
//                }
//            }           
//        }
//        Console.WriteLine("Матрица A после обработки:");
//        for (int i = 0; i < 7; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write("{0,3:d} ", a[i,j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}
//3.2
//using System;
//using System.Runtime.InteropServices;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите значение n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        int[,] a = new int[n, n];
//        Console.WriteLine("Введите элементы матрицы");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                s = Console.ReadLine();
//                a[i, j] = int.Parse(s);
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write("{0,3:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                if (i == 0 || i == n - 1)
//                {
//                    a[i, j] = 0;
//                }
//            }
//        }
//        for (int j = 0; j < n; j++)
//        {
//            for (int i = 0; i < n; i++)
//            {
//                if (j == 0 || j == n - 1)
//                {
//                    a[i, j] = 0;
//                }
//            }
//        }
//        Console.WriteLine("Преобразованная матрица");
//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++)
//            {
//                Console.Write("{0,3:d} ", a[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}




































