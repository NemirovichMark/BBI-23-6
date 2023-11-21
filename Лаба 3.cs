//1 уровень
//1.1
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[6];
//        string s;
//        for (int i = 0; i < 6; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double sum = 0;
//        for (int i = 0; i < 6; i++)
//        {
//            sum += a[i];
//        }
//        Console.WriteLine(sum);
//        if (sum != 0)
//        {
//            for (int i = 0; i < 6; i++)
//            {
//                a[i] /= sum;
//            }
//            Console.WriteLine("Деление массива:");
//            for (int i = 0; i < 6; i++) 
//            {
//                Console.WriteLine(a[i]);
//            }
//        }
//    }
//}
//1.2
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[8];
//        string s;
//        for (int i = 0; i < 8; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double sum = 0;
//        int k = 0;
//        for (int i = 0; i < 8; i++)
//        {
//            if (a[i] > 0)
//            {
//                sum += a[i];
//                k += 1;
//            }
//        }
//        double sr = sum / k;
//        Console.WriteLine("Среднее арифметическое");
//        Console.WriteLine(sr);
//        for (int i = 0; i < 8; i++)
//        {
//            if (a[i] > 0)
//            {
//                a[i] = sr;
//            }
//        }
//        Console.Write("После замены:");
//        for (int i = 0; i < 8; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//1.3
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[4];
//        double[] b = new double[4];
//        double[] c = new double[4];
//        double[] d = new double[4];
//        string k;
//        Console.WriteLine("Массив а");
//        for (int i = 0; i < 4; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        Console.WriteLine("Массив b");
//        for (int i = 0; i < 4; i++)
//        {
//            k = Console.ReadLine();
//            b[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 4; i++)
//        {
//            c[i] = a[i] + b[i];
//        }
//        for (int i = 0; i < 4; i++)
//        {
//            d[i] = a[i] - b[i];
//        }
//        Console.WriteLine("Массив c");
//        for (int i = 0; i < 4; i++)
//        {
//            Console.WriteLine(c[i]);
//        }
//        Console.WriteLine("Массив d");
//        for (int i = 0; i < 4; i++)
//        {
//            Console.WriteLine(d[i]);
//        }
//    }
//}
//1.4
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[5];
//        string s;
//        for (int i = 0; i < 5; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double sum = 0;
//        int k = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            sum += a[i];
//            k += 1;
//        }
//        double sr = sum / k;
//        for (int i = 0; i < 5; i++)
//        {
//            a[i] = a[i] - sr;
//        }
//        Console.WriteLine(a[i]);
//    }
//}
//1.5
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[4];
//        double[] b = new double[4];
//        double[] c = new double[4];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 4; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        Console.WriteLine("Введите массив b");
//        for (int i = 0; i < 4; i++)
//        {
//            k = Console.ReadLine();
//            b[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 4; i++)
//        {
//            c[i] = a[i] + b[i];
//        }
//        Console.WriteLine("Скалярное произведение");
//        for (int i = 0; i < 4; i++)
//        {
//            Console.WriteLine(c[i]);
//        }
//    }
//}
//1.6
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[5];
//        string k;
//        double l = 0;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 5; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            l = l + a[i] * a[i];
//        }
//        Console.WriteLine(Math.Sqrt(l));
//    }
//}
//1.7
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[7];
//        string k;
//        double sum = 0;
//        int m = 0;
//        double sr;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 7; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 7; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("Среднее арифметическое");
//        Console.WriteLine(sr);
//        for(int i=0; i<7; i++)
//        {
//            if (a[i]>sr)
//            {
//                a[i] = 0;
//            }
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < 7; i++)
//        {
//            Console.WriteLine(a[i]);
//        }

//    }
//}
//1.8
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[6];
//        string k;
//        int m = 0;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 6; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 6; i++)
//        {
//            if (a[i] < 0)
//            {
//                m+=1;
//            }
//        }
//        Console.WriteLine(m);

//    }
//}
//1.9
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[8];
//        string k;
//        double sum = 0;
//        int m = 0;
//        int n = 0;
//        double sr;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 8; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 8; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("Среднее арифметическое");
//        Console.WriteLine(sr);
//        for (int i = 0; i < 8; i++)
//        {
//            if (a[i] > sr)
//            {
//                n += 1;
//            }
//        }
//        Console.WriteLine("Кол-во элементов, больших sr");
//        Console.WriteLine(n);

//    }
//}
//1.10
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[10];
//        string k;
//        int m = 0;
//        Console.WriteLine("Введите P");
//        double P = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Введите Q такое, что P<Q");
//        double Q = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 10; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 10; i++)
//        {
//            if (P > a[i] && a[i]<Q)
//            {
//                m += 1;
//            }
//        }
//        Console.WriteLine("Кол-во элементов, удовлетворяющих условию");
//        Console.WriteLine(m);

//    }
//}
//1.11
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[10];
//        double[] b = new double[10];
//        string k;
//        int m = 0;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 10; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 10; i++)
//        {
//            if (a[i]>=0)
//            {
//                b[m] = a[i];
//                m += 1;
//            }
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine(b[i]);
//        }

//    }
//}
//1.12
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[8];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 8; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amin = a[0];
//        int imin = 0;
//        for (int i=1; i<8; i++)
//        {
//            if (a[i]<amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Значение последнего отрицательного элемента");
//        Console.WriteLine(amin);
//        Console.WriteLine("Индекс последнего отрицательного элемента");
//        Console.WriteLine(imin);
//    }
//}
//1.13
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[10];
//        double[] b = new double[5];
//        double[] c = new double[5];
//        string k;
//        int m = 0;
//        int n = 0;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 10; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 10; i=i+2)
//        {
//            b[m] = a[i] ;
//            m++;
//        }
//        for (int i = 1; i < 10; i = i + 2)
//        {
//            c[n] = a[i];
//            n++;
//        }
//        Console.WriteLine("Массив по четным индексам");
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine(b[i]);
//        }
//        Console.WriteLine("Массив по нечетным индексам");
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine(c[i]);
//        }
//    }
//}
//1.14
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[11];
//        string k;
//        double sum = 0;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 11; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 11; i++)
//        {
//            if (a[i]>0)
//            {
//                sum = sum + a[i] * a[i];
//            }
//            else
//            {
//                break;
//            }
//        }
//        Console.WriteLine(sum);
//    }
//}
//1.15
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] x = new double[10];
//        double[] y = new double[10];
//        string k;
//        Console.WriteLine("Введите массив x");
//        for (int i = 0; i < 10; i++)
//        {
//            k = Console.ReadLine();
//            x[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 10; i++)
//        {
//            y[i] = 0.5 * Math.Log(x[i]);
//        }
//        Console.WriteLine(" ");
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine($"{x[i]} {y[i]}");
//        }
//    }
//}
//
//2 уровень
//2.1
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        double[] a = new double[n];
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amin = a[0];
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < amin)
//            {
//                amin = a[i];
//            }
//        }
//        Console.WriteLine("Минимальный элемент");
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] == amin)
//            {
//                a[i] = a[i] * 2;
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//2.2
//using System;
//class Program
//{
//  static void Main(string[] args)
//  {
//      string s;
//      Console.WriteLine("Введите n");
//      int n = Convert.ToInt32(Console.ReadLine());
//      double[] a = new double[n];
//      Console.WriteLine("Введите массив a");
//      for (int i = 0; i < n; i++)
//      {
//          s = Console.ReadLine();
//          a[i] = double.Parse(s);
//      }
//      double amax = a[0];
//      int imax = 0;
//      for (int i = 0; i < n; i++)
//      {
//          if (a[i] > amax)
//          {
//              amax = a[i];
//              imax = i;
//          }
//      }
//      Console.WriteLine("Максимальный элемент массива и его индекс");
//      Console.WriteLine($"{amax}, {imax}");
//      double sum = 0;
//      for (int i = 0; i < n; i++)
//      {
//          if (i < imax)
//          {
//              sum = sum + a[i];
//          }
//          else
//          {
//             break;
//          }
//      }
//      Console.WriteLine("Сумма элементов");
//      Console.WriteLine(sum);
//  }
//}
//2.3
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        double[] a = new double[n];
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amin = a[0];
//        int imin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент и его индекс");
//        Console.WriteLine($"{amin}, {imin}");
//        for (int i = 0; i < n; i++)
//        {
//            if (i < imin)
//            {
//                a[i] = a[i] * 2;
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < n; i++)
//        {

//            Console.Write(a[i]);
//        }
//    }
//}
//2.4
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double sum = 0;
//        int k = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + a[i];
//            k += 1;
//        }
//        double sr = sum / k;
//        Console.WriteLine("Среднее арифметическое");
//        Console.WriteLine(sr);
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }

//        }
//        Console.WriteLine("Максимальный элемент массива и его индекс");
//        Console.WriteLine($"{amax}, {imax}");
//        for (int i = 0; i < n; i++)
//        {
//            if (i > imax)
//            {
//                a[i] = sr;
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//2.5
//using System;
//using System.Security.Claims;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        double[] a = new double[n];
//        double[] b = new double[n];
//        int m = 0;
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент и его индекс");
//        Console.WriteLine($"{amax}, {imax}");
//        double amin = a[0];
//        int imin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент и его индекс");
//        Console.WriteLine($"{amin}, {imin}");
//        for (int i = 0; i < n; i++)
//        {
//            if (i > imin && i < imax)
//            {
//                if (a[i] < 0)
//                {
//                    b[m] = a[i];
//                    m++;
//                }
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < m; i++)
//        {
//            Console.WriteLine(b[i]);
//        }
//    }
//}
//2.7
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        double[] a = new double[n];
//        for (int i = 9; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент и его индекс");
//        Console.WriteLine($"{amax}, {imax}")
//        for (int i = 0; i < n; i++)
//        {
//            a[imax + 1] = a[imax + 1] * 2;
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//2.8
//using System;
//class program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите n");
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент и его индекс");
//        Console.WriteLine($"{amax}, {imax}");
//        double amin = a[0];
//        int imin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < amin && i > imax)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент после максимального и его индекс");
//        Console.WriteLine($"{amin}, {imin}");
//        int p;
//        for (int i = 0; i < n; i++)
//        {
//            p = amax;
//            amax = amin;
//            amin = p;
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//2.9
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        double[] a = new double[n];
//        double[] b = new double[n];
//        int m = 0;
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент и его индекс");
//        Console.WriteLine($"{amax}, {imax}");
//        double amin = a[0];
//        double imin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент и его индекс");
//        Console.WriteLine($"{amin}, {imin}");
//        for (int i = 0; i < n; i++)
//        {
//            if (imin > i && imax > i)
//            {
//                b[m] = a[i];
//                m++;
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < m; i++)
//        {
//            Console.WriteLine(b[m]);
//        }
//        double sum = 0;
//        int k = 0;
//        for (int i = 0; i < m; i++)
//        {
//            sum = sum + b[m];
//            k += 1;
//        }
//        double sr = sum / k;
//        Console.WriteLine(sr);
//    }
//}
//2.10
//using System;
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите массив: ");
//            double[] a = new double[5];
//            double[] b = new double[4];
//            string s;
//            for (int i = 0; i < 5; i++)
//            {
//                s = Console.ReadLine();
//                a[i] = double.Parse(s);
//            }
//            double amin = a[0];
//            int imin = 0;
//            for (int i = 0; i < 5; i++)
//            {
//                if (a[i] < amin & (a[i] > 0))
//                {
//                    amin = a[i];
//                    imin = i;
//                }
//            }
//            for (int i = 0; i < imin ; i++)
//            {
//                b[i] = a[i];
//            }
//            for (int i = imin + 1;i < 5 ; i++)
//            {
//                b[i - 1] = a[i];
//            }
//            for (int i = 0; i < b.Length; i++)
//            {
//                Console.WriteLine("{0:f}", b[i]);
//            }
//        }
//    }
//}
//2.12
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("Введите маасив a");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент и его индекс");
//        Console.WriteLine($"{amax}, {imax}");
//        double sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (i > imax)
//            {
//                sum += a[i];
//            }
//        }
//        Console.WriteLine("Сумма элементов после максимального");
//        Console.WriteLine(sum);
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < 0)
//            {
//                break;
//                a[i] = sum;
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//2.13
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        double[] a = new double[n];
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax && i % 2 == 0)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент и его индекс");
//        Console.WriteLine($"{amax}, {imax}");
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] == amax)
//            {
//                a[i] = imax;
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//2.14
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        double[] a = new double[n];
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amax = a[0];
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > a[0])
//            {
//                amax = a[i];
//            }
//        }
//        Console.WriteLine("Максимальный элемент");
//        Console.WriteLine(amax);
//        double p;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < 0)
//            {
//                break;
//                p = a[i]; a[i] = amax; amax = p;
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//2.15
//using System;
//class programm
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите m");
//        int m = Convert.ToInt32(Console.ReadLine());
//        double[] b = new double[m];
//        Console.WriteLine("Введите массив b");
//        for (int i = 0; i < m; i++)
//        {
//            s = Console.ReadLine();
//            b[i] = double.Parse(s);
//        }
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n + m];
//        Console.WriteLine("Введите массив b");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        Console.WriteLine("Введите k");
//        int k = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i <= n - k - 1; i++)
//        {
//            a[k + m + i] = a[k + i];
//        }
//        for (int i = 0; i < m; i++)
//        {
//            a[k + i] = b[i];
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < m + n; i++)
//        {
//            Console.Write($"{a[i]}");
//        }
//    }
//}
//2.16
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите n");
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double[] b = new double[n];
//        int m = 0;
//        double sum = 0;
//        int k = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum += a[i];
//            k += 1;
//        }
//        double sr = sum / k;
//        Console.WriteLine("Среднее значение");
//        Console.WriteLine(sr);
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < sr)
//            {
//                b[m] = a[i];
//                m++;
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < m; i++)
//        {
//            Console.WriteLine(b[m]);
//        }
//    }
//}
//2.17
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        double[] a = new double[n];
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент и его индекс");
//        Console.WriteLine($"{amax}, {imax}");
//        double amin = a[0];
//        int imin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент и его индекс");
//        Console.WriteLine($"{amin}, {imin}");
//        double sum = 0;
//        int k = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (imax < imin)
//            {
//                if (a[i] > 0)
//                {
//                    sum = sum + a[i];
//                    k = k + 1;
//                }
//            }
//            else
//            {
//                if (a[i] < 0)
//                {
//                    sum = sum + a[i];
//                    k = k + 1;
//                }
//            }
//        }
//        double sr = sum / k;
//        Console.WriteLine(sum);
//    }
//}
//2.18
//using System;
//using System.Diagnostics.Eventing.Reader;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите n");
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double chetamax = a[0];
//        int chetimax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > chetamax && i % 2 == 0)
//            {
//                chetamax = a[i];
//                chetimax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент с чётным индексом и его индекс");
//        Console.WriteLine($"{chetamax}, {chetimax}");
//        double nechetamax = a[0];
//        int nechetimax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > nechetamax && i % 2 != 0)
//            {
//                nechetamax = a[i];
//                nechetimax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент с нечётным индексом и его индекс");
//        Console.WriteLine($"{nechetamax}, {nechetimax}");
//        for (int i = 0; i < n; i++)
//        {
//            if (chetamax > nechetamax)
//            {
//                for (int i = 0; i < (n / 2); i++)
//                {
//                    a[i] = 0;
//                }
//            }
//            else
//            {
//                for (int i = (n - 1); i >= (n/2); i--) ;
//                {
//                    a[i] = 0;
//                }
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//2.19
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите n");
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amax = a[0];
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//            }
//        }
//        Console.WriteLine("Максимальное значение");
//        Console.WriteLine(amax);
//        double sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum += a[i];
//        }
//        Console.WriteLine("Сумма элементов массива");
//        Console.WriteLine(sum);
//        for (int i = 0; i < n; i++)
//        {
//            if (amax > sum)
//            {
//                amax = 0;
//            }
//            else
//            {
//                amax = amax * 2;
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}
//2.20
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите n");
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double otr = a[0];
//        int iotr = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < 0)
//            {
//                otr = a[i];
//                iotr = i;
//                break;
//            }
//        }
//        Console.WriteLine("Первый отрицательный элемент и его индекс");
//        Console.WriteLine($"{otr}, {iotr}");
//        double amin = a[0];
//        int imin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент и его индекс");
//        Console.WriteLine($"{amin}, {imin}");
//        double sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (iotr < imin)
//            {
//                if (i % 2 == 0)
//                {
//                    sum += a[i];
//                }
//            }
//            else
//            {
//                if (i % 2 != 0)
//                {
//                    sum = sum + a[i];
//                }
//            }
//        }
//        Console.WriteLine(sum);
//    }
//}
//3 уровень
//3.1
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        double[] a = new double[n];
//        double[] b = new double[n];
//        int m = 0;
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент и его индекс");
//        Console.WriteLine($"{amax}, {imax}");
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] == amax)
//            {
//                b[m] = i;
//                m++;
//            }
//        }
//        Console.WriteLine("Индексы максимальных элементов массива");
//        for (int i = 0; i < m; i++)
//        {
//            Console.WriteLine(b[m]);
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
//        Console.WriteLine("Введите n");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        double[] a = new double[n];
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amax = a[0];
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//            }
//        }
//        Console.WriteLine("Максимальный элемент");
//        Console.WriteLine(amax);
//        int m = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] == amax)
//            {
//                m++;
//                a[i] = a[i] + m;
//            }
//        }
//        Console.WriteLine("Изменённый массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}








