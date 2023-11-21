//2.10
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите массив: ");
//        double[] a = new double[5];
//        double[] b = new double[4];
//        string s;
//        int f = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            s = Console.ReadLine();
//            a[i] = double.Parse(s);
//        }
//        double amin = 10000000;
//        int imin = 0;
//        for (int i = 0; i < 5; i++)
//        {
//            if (a[i] < amin & (a[i] > 0))
//            {
//                amin = a[i];
//                imin = i;
//                f = 1;
//            }
//        }
//        for (int i = 0; i < imin; i++)
//        {
//            b[i] = a[i];
//        }
//        for (int i = imin + 1; i < 5; i++)
//        {
//            b[i - 1] = a[i];
//        }
//        if (f == 0)
//        {
//            Console.WriteLine("Нет положительных элементов");
//        }
//        else
//        {
//            for (int i = 0; i < b.Length; i++)
//            {
//                Console.WriteLine("{0:f}", b[i]);
//            }
//        }
//    }
//}
//2.11
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] a = new int[n];
//        Console.WriteLine("Введите число P: ");
//        int p = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите элементы массива:");
//        int lastIndex = -1;
//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//            if (a[i] > 0)
//            {
//                lastIndex = i;
//            }
//        }
//        if (lastIndex >= 0)
//        {
//            int[] b = new int[n + 1];
//            for (int i = 0; i <= lastIndex; i++)
//            {
//                b[i] = a[i];
//            }
//            b[lastIndex + 1] = p;
//            for (int i = lastIndex + 2; i < n + 1; i++)
//            {
//                b[i] = a[i - 1];
//            }
//            a = b;
//            n++;

//            Console.WriteLine("Массив после вставки:");
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write("{0} ", a[i]);
//            }
//        }
//        else
//        {
//            Console.WriteLine("В массиве нет положительных элементов.");
//        }
//    }
//}
//2.15
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите n: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] a = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();
//            a[i] = int.Parse(s);
//        }
//        Console.WriteLine("Введите m: ");
//        int m = int.Parse(Console.ReadLine());
//        Console.WriteLine("Введите массив: ");
//        int[] b = new int[m];
//        for (int i = 0; i < m; i++)
//        {
//            string s1 = Console.ReadLine();
//            b[i] = int.Parse(s1);
//        }
//        int[] c = new int[n + m];
//        Console.WriteLine("Введите k: ");
//        int k = int.Parse(Console.ReadLine());
//        if (k >= a.Length)
//        {
//            Console.WriteLine("Не существует такого элемента в массиве а");
//        }
//        else
//        {
//            for (int i = 0; i <= k; i++)
//            {
//                c[i] = a[i];
//            }
//            for (int i = 0; i < m; i++)
//            {
//                c[k + i + 1] = b[i];
//            }
//            for (int i = k + m + 1; i < m + n; i++)
//            {
//                c[i] = a[i - m];
//            }
//            Console.WriteLine("Получившийся массив: ");
//            for (int i = 0; i < m + n; i++)
//            {
//                Console.WriteLine(c[i]);
//            }

//        }
//    }
//}

