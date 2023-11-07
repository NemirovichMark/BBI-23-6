// Номер 1
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("Введите кол-во элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
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

// Номер 2
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("Введите кол-во элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double amax = a[0];
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//            }
//        }
//        int count = 1;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i]==amax)
//            {
//                a[i] = a[i] + count;
//                count++;
//            }
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// Номер 3
using System;

class Programm
{
    static void Main(string[] args)
    {
        string p;
        Console.WriteLine("Введите кол-во элементов массива A");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] a = new double[n];
        Console.WriteLine("Введите массив A");
        for (int i = 0; i < n; i++)
        {
            p = Console.ReadLine();
            a[i] = double.Parse(p);
        }
        double amax = a[0];
        int imax = 0;
        for (int i = 0; i < n; i++)
        {
            if (a[i] > amax)
            {
                amax = a[i];
                imax = i;
            }
        }
        double r = 0;
        for (int i = 1; i < imax; i=i+2)
        {
            r = a[i];
            a[i] = a[i - 1];
            a[i - 1] = r;
        }
        Console.WriteLine("Измененный массив");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{a[i]} ");
        }

    }
}