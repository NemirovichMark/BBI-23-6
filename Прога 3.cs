// 2.10
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string s;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amin = a[0];
//        int imin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > 0 && a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент массива");
//        Console.WriteLine(amin);
//        for (int i = imin; i < n-1; i++)
//        {
//            a[i] = a[i + 1];
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n-1; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}
// 2.11
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n+1];
//        string s;
//        Console.WriteLine("Введите число Р");
//        double P = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        int idx = 0;
//        for (int i = n-1; i >= 0; i--)
//        {
//            if (a[i] > 0)
//            {
//                idx = i;
//                break;
//            }
//        }
//        for (int i = n; i > idx+1; i--)
//        {
//            a[i] = a[i-1];
//        }
//        a[idx+1] = P;
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n + 1; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }
//    }
//}
//2.15
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите кол-во элементов массива B");
//        int m = Convert.ToInt32(Console.ReadLine());
//        double[] b = new double[m];
//        Console.WriteLine("Введите массив B");
//        for (int i = 0; i < m; i++)
//        {
//            s = Console.ReadLine();
//            b[i] = double.Parse(s);
//        }
//        Console.WriteLine("Введите кол-во элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n+m];
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        Console.WriteLine("Введите число k");
//        int k = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i <= n-k-1; i++)
//        {
//            a[k+m+i] = a[k+i];
//        }
//        for (int i = 0; i < m ; i++)
//        {
//            a[k + i] = b[i];
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < m + n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}
// 3.1
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        string s;
//        Console.WriteLine("Введите кол-во элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double[] b = new double[n];
//        double amax = a[0];
//        int m = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i]>amax)
//            {
//                amax = a[i];
//                m = 0;
//                b[m]= a[i];
//                m++;
//            }
//            else if (a[i]==amax)
//            {
//                b[m] = a[i];
//                m++;
//            }
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{b[i]} ");
//        }
//    }
//}