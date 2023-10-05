////Третий уровень первый номер//
//using System;
//class Program
//{
//    public static void Main()
//    {
//        double sum = 0;
//        double a = 0.1;
//        double b = 1;
//        double h = 0.1;
//        int i = 0;
//        for (double x = a; x <= b; x += h, i++)
//        {
//            double cur;
//            long fact = 1;
//            double y = Math.Cos(x);
//            for (int g = 2; g <= 2 * i; g++)
//            {
//                fact = fact * g;
//            }
//            if (i % 2 == 0)
//            {
//                cur = Math.Pow(x, 2 * i) / fact;
//            }
//            else
//            {
//                cur = -1 * Math.Pow(x, 2 * i) / fact;
//            }
//            if (Math.Abs(cur) < 0.0001)
//            {
//                break;
//            }
//            sum += cur;
//            Console.WriteLine($"i = {i}, x = {x}, current element = {cur}, cos(x) = {y} \n\n");
//        }
//        Console.WriteLine($"sum = {sum}");
//    }
//}

// Второй уровень номер 1//
//using System;
//class Program
//{
//    static void Main()
//    {
//        double x = 0.5;
//        double epsilon = 0.0001;
//        double sum = 0;
//        double term = 1;
//        double n = 1;

//        while (Math.Abs(term) < epsilon)
//        {
//            sum += term;
//            n++;
//            term = Math.Cos(n * x) / (n * n);
//        }

//        Console.WriteLine("Сумма ряда: " + sum);
//    }
//}

// Второй уровень номер 2//
//using System;
//class Program
//{
//    static void Main()
//    {
//        int L = 30000;
//        int n = 1;
//        int p = 1;

//        while (p <= L)
//        {
//            n++;
//            p *= n;
//        }
//        n--;
//        Console.WriteLine("Наибольшее значение n: " + n);
//    }
//}

////Второй уровень номер 3//
////using System;
////class Program
////{
////    static void Main()
////    {
////        int s = 0, n = 0, m;
////        const int a = 2, h = 3, p = 41;
////        while (s <= p)
////        {
////            m = a + n * h;
////            s = s + m;
////            n = n + 1;
////        }
////        n--;
////        Console.WriteLine($"{n:d}");
////    }
////}

// Второй уровень номер 4//
//using System;
//class Program
//{
//    static void Main()
//    {
//        double sum = 0;
//        double x = 0.9;
//        double last_sum = 0;
//        for (int n = 1; n <= 10000; n++)
//        {
//            sum += Math.Pow(x, n * 2);
//            if (Math.Pow(x, n * 2) >= 0.0001)
//            {
//                last_sum = sum;
//            }

//            if (Math.Pow(x, n * 2) < 0.0001)
//            {
//                Console.WriteLine(last_sum);
//                break;
//            }
//        }

//    }
//} 

// Второй уровень номер 5
//using System;

//double res = 0;
//int n = Convert.ToInt32(Console.ReadLine());
//int m = Convert.ToInt32(Console.ReadLine());

//while (n >= m)
//{
//    res += 1;
//    n -= m;
//}
//Console.WriteLine($"частное: {res}");
//if (n < m)
//{
//    if (n > 0)
//    {
//        Console.WriteLine($"остаток:{n}");
//    }
//    if (n == 0)
//    {
//        Console.WriteLine("остаток: 0");
//    }
//}

//Второй уровень номер 6
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 1; 
//        int time = 0; 
//        while (n != 105) 
//        {
//            time++; 
//            n += n;
//            if (n > 105)
//            {
//                n = 105;
//            }
//        }
//        Console.WriteLine("Время: " + time);
//        Console.ReadLine();
//    }
//}

// Второй уровень номер 7.1
//double r = 10;
//double sum = 10;
//for (int kolvo = 1; kolvo < 7; kolvo++)
//{
//    r = r + r * 0.1;
//    sum += r;
//}
//Console.WriteLine(sum);

//Второй уровень номер 7.2
//using System;
//double r = 10;
//double sum = 10;
//int kolvo = 1;
//for (kolvo = 1; sum < 100;)
//{
//    r = r + r * 0.1;
//    sum += r;
//    kolvo += 1;
//}
//Console.WriteLine(kolvo);

////Второй уровень номер 7.3
//using System;
//double r = 10;
//double sum = 10;
//int kolvo = 1;
//for (kolvo = 1; r <= 20;)
//{
//    r = r + r * 0.1;
//    kolvo += 1;
//}
//Console.WriteLine(kolvo);

//Второй уровень номер 8//
//using System;
//class Program
//{
//    static void Main()
//    {
//        double s = 10000;
//        int d = 0;
//        double r = 0.08;
//        double s1 = s * 2;
//        while (s < s1)
//        {
//            s += s * r;
//            d++;
//        }
//        Console.WriteLine($"Сумма удвоится через {d} месяцев.");

//    }
//}

// Второй уровень номер 14\\
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 8; 
//        int first = 1; 
//        int second = 1;
//        Console.Write(first + " " + second + " "); 
//        for (int i = 3; i <= n; i++)
//        {
//            int next = first + second; 
//            Console.Write(next + " "); 

//            first = second; 
//            second = next; 
//        }
//        Console.ReadKey();
//    }
//}

using System;

//// Первый уровень номер 1//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int sum = 0;
//            for (int i = 2; i < 38; i += 3)
//            {
//                sum = sum + i;
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}

//// Первый уровень номер 2//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double sum = 0;
//            for (double i = 1; i <= 10; i += 1)
//                sum = sum + (1 / i);
//            Console.WriteLine(sum);
//        }
//    }
//}

//// Первый уровень номер 3//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double sum = 0;
//            for (double i = 1; i <= 113; i += 2)
//            {
//                sum += (i + 1) / (i + 2);
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}

//// Первый уровень номер 4//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double sum = 0;
//            int x = 10;
//            for (int i = 0; i <= 8; i += 1)
//            {
//                sum += Math.Cos((i + 1) * x) / Math.Pow(x, 0);
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}
// Первый уровень номер 5//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int p = 1;
//            int sum = 0;
//            for (int h = 0; h <= 9; h++)
//            {
//                int ph = p + h;
//                sum = (int)(sum + Math.Pow(ph, 2));
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}

// Первый уровень номер 6//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double number = 0;
//            for (double i = -4; i <= 4; i += 0.5)
//            {
//                number = (Math.Pow(0.5 * i, 2) - 7 * i);
//                Console.WriteLine($"{number} {i}");
//            }
//        }
//    }
//}

// Первый уровень номер 7//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int proizv = 1;
//            for (int i = 1; i <= 6; i++)
//            {
//                proizv = proizv * i;
//            }
//            Console.WriteLine(proizv);
//        }
//    }
//}

// Первый уровень номер 8//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int sum = 0;
//            int fact1 = 1;
//            for (int i = 1; i <= 6; i++)
//            {
//                fact1 = fact1 * i;
//                sum += fact1;
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}

//// Первый уровень номер 9//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int Factorial(int n)
//            {
//                if (n == 1) return 1;

//                return n * Factorial(n - 1);
//            }

//            int sum = 0;
//            int number = 0;

//            for (int i = 1; i <= 6; i++)
//            {
//                number = (int)(Math.Pow(-1, i) * Math.Pow(5, i) / Factorial(i));
//                sum += number;
//            }
//            Console.WriteLine(number);

//        }
//    }
//}

// Первый уровень номер 10//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int number = 1;
//            for (int i = 1; i <= 7; i++)
//            {
//                number *= 3;
//            }
//            Console.WriteLine(number);
//        }
//    }
//}

// Первый уровень номер 11//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int j = 6;
//            for (int i = 1; i < j; i++)
//            {
//                Console.Write(i + " ");
//            }
//            Console.Write($"{j},");
//            Console.WriteLine();
//            int b = 5;
//            for (int i = 0; i < b; i++)
//            {
//                Console.Write(b + " ");
//            }
//            Console.Write($"{b}.");
//            Console.WriteLine();
//        }
//    }
//}

// Первый уровень номер 12//
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double sum = 0;
//            int x = 2;
//            for (int i = 0; i <= 10; i++)
//            {
//                sum += 1 / Math.Pow(x, i);
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}
