// Первый уровень
// Номер 1
//using System;
//class Programm
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
//            Console.WriteLine("Массив после деления: ");
//            for (int i = 0; i < 6; i++)
//            {
//                Console.WriteLine(a[i]);
//            }
//        }
//    }
//}

// Номер 2
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[8];
//        string s;
//        double sum = 0;
//        int m = 0;
//        double sr;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 8; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        for (int i = 0; i < 8; i++)
//        {
//            if (a[i]>0)
//            {
//                sum += a[i];
//                m += 1;
//            }
//        }
//        sr = sum / m;
//        Console.WriteLine("Среднее арифметическое положительных элементов");
//        Console.WriteLine(sr);
//        for(int i=0; i < 8; i++)
//        {
//            if (a[i]>0)
//            {
//                a[i] = sr;
//            }
//        }
//        Console.WriteLine("Массив после изменения");
//        for (int i = 0; i < 8; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}

// Номер 3
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[4];
//        double[] b = new double[4];
//        double[] c = new double[4];
//        double[] d = new double[4];
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
//        for (int i = 0; i < 4; i++)
//        {
//            d[i] = a[i] - b[i];
//        }
//        Console.WriteLine("Массив с");
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

// Номер 4
//using System;
//class Programm
//{
//    static void Main(string[] args)
//    {
//        double[] a = new double[5];
//        string k;
//        double sum = 0;
//        int m = 0;
//        double sr;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < 5; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        for (int i = 0; i < 5; i++)
//        {
//            sum += a[i];
//            m += 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("Среднее значение");
//        Console.WriteLine(sr);
//        for (int i = 0; i < 5; i++)
//        {
//            a[i] = a[i] - sr;
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < 5; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}

// Номер 5
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

// Номер 6
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

// Номер 7
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

// Номер 8
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

// Номер 9
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

// Номер 10
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

// Номер 11
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

// Номер 12
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

// Номер 13
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

// Номер 14
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

// Номер 15
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

