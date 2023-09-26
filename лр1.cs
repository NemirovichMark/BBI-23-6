//using System;
//1 уровень 1 задача
//class Program
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



//using System;
//1 уровень 2 задача
//{

//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        double sum = 0;
//        for (double i = 1; i <= 10; i += 1)
//            sum = sum + (1 / i);
//        Console.WriteLine(sum);
//    }
//} 
//} 


//using System;
//1 уровень 3 задача
//using System;
//1 уровень 3 задача
//{

//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        double sum = 0;
//        for (double i = 1; i <= 113; i += 2)
//        {
//            sum += (i + 1) / (i + 2);
//        }
//        Console.WriteLine(sum);
//    }
//} 
//} 


//using System;
//1 уровень 4 задача
//{

//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        double sum = 0;
//        int x = 10;
//        for (int i = 0; i <= 8; i += 1)
//        {
//            sum += Math.Cos((i + 1) * x) / Math.Pow(x, 0);
//        }
//        Console.WriteLine(sum);
//    }
//} 
//} 


//using System;
//1 уровень 5 задача
//{

//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        int p = 1;
//        int sum = 0;
//        for (int h = 0; h <= 9; h++)
//        {
//            int ph = p + h;
//            sum = (int)(sum + Math.Pow(ph, 2));
//        }
//        Console.WriteLine(sum);
//    }
//} 
//} 

//using System;
//1 уровень 6 задача
//{

//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        double number = 0;
//        for (double i = -4; i <= 4; i += 0.5)
//        {
//            number = (Math.Pow(0.5 * i, 2) - 7 * i);
//            Console.WriteLine($"{number} {i}");
//        }
//    }
//} 
//} 


//using System;
//1 уровень 7 задача
//{

//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        int proizv = 1;
//        for (int i = 1; i <= 6; i++)
//        {
//            proizv = proizv * i;
//        }
//        Console.WriteLine(proizv);
//    }
//} 
//} 


//using System;
//1 уровень 8 задача
//{

//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        int sum = 0;
//        int fact1 = 1;
//        for (int i = 1; i <= 6; i++)
//        {
//            fact1 = fact1 * i;
//            sum += fact1;
//        }
//        Console.WriteLine(sum);
//    }
//} 
//} 


//using System;
//1 уровень 9 задача
//{

//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        int Factorial(int n)
//        {
//            if (n == 1) return 1;

//            return n * Factorial(n - 1);
//        }

//        int sum = 0;
//        int number = 0;

//        for (int i = 1; i <= 6; i++)
//        {
//            number = (int)(Math.Pow(-1, i) * Math.Pow(5, i) / Factorial(i));
//            sum += number;
//        }
//        Console.WriteLine(number);

//    }
//} 
//} 


//using System;
//1 уровень 10 задача
//{

//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        int number = 1;
//        for (int i = 1; i <= 7; i++)
//        {
//            number *= 3;
//        }
//        Console.WriteLine(number);
//    }
//} 
//} 

//using System;
//1 уровень 11 задача
//{

//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        int j = 6;
//        for (int i = 1; i < j; i++)
//        {
//            Console.Write(i + " ");
//        }
//        Console.Write($"{j},");
//        Console.WriteLine();
//        int b = 5;
//        for (int i = 0; i < b; i++)
//        {
//            Console.Write(b + " ");
//        }
//        Console.Write($"{b}.");
//        Console.WriteLine();
//    }
//} 
//} 


//using System;
//1 уровень 12 задача
//{

//    internal class Program
//{
//    static void Main(string[] args)
//    {
//        double sum = 0;
//        int x = 2;
//        for (int i = 0; i <= 10; i++)
//        {
//            sum += 1 / Math.Pow(x, i);
//        }
//        Console.WriteLine(sum);
//    }
//} 
//} 


//using System;
//2 уровень 1 задача
//{
//    static void Main()
//    {
//        double sum = 0;
//        int x = 1;
//        int n = Convert.ToInt32(Console.ReadLine());
//        for (int i = 1; i <= n; i++)
//        {
//            sum += Math.Cos(i * x) / Math.Pow(i, 2);
//            if (Math.Abs(Math.Cos(i * x) / Math.Pow(i, 2)) < 0.0001)
//            {
//                Console.WriteLine(sum);
//                break;
//            }
//        }
//    }
//}

//using System;
//2 уровень 2 задача
//class Program
//{
//    static void Main()
//    {
//        int sum = 1;
//        int last_sum = 0;

//        for (int i = 1; i <= 10000; i += 3)
//        {
//            sum *= i;
//            if (sum <= 30000)
//            {
//                last_sum = sum;
//            }
//            if (sum > 30000)
//            {
//                Console.WriteLine(last_sum);
//                break;
//            }
//        }
//    }
//}


//using System;
//2 уровень 4 задача
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

//using System;
//2 уровень 8 задача
//class Program
//{
//    static void Main()
//    {
//        double sum = 10000;
//        for (int i = 1; i <= 100; i++)
//        {
//            sum *= 1.08;
//            if (sum >= 20000)
//            {
//                Console.WriteLine(i);
//                break;
//            }
//        }
//    }
//}


//1 уровень 5 задача
//using System;
//class Program
//{
//    static void Main()
//    {
//        int N = Convert.ToInt32(Console.ReadLine());
//        int M = Convert.ToInt32(Console.ReadLine());
//        int K = 0;
//        while (N >= M)
//        {
//            K += 1;
//            N -= M;
//        }
//        Console.WriteLine(K);
//        Console.WriteLine(N);
//    }
//}

//using System;
//3 уровень 1 задача
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


//using System;
//2 уровень 6 задача

//class Program
//{
//    static void Main(string[] args)
//    {
//        int n = 1; // Начальное количество клеток
//        int time = 0; // Время

//        while (n != 105) // Пока количество клеток не достигнет 105
//        {
//            time++; // Увеличиваем время на 1

//            // Увеличиваем количество клеток на значение, равное текущему количеству клеток
//            n += n;

//            // Если количество клеток становится больше 105, то присваиваем значение 105
//            if (n > 105)
//            {
//                n = 105;
//            }
//        }

//        Console.WriteLine("Время: " + time);
//        Console.ReadKey();
//    }
//}


//using System;
//1 уровень 14 задача
//class Program
//{
//    int s = 1;
//    int p = 1;
//    int t = 0;
//    Console.WriteLine(1);
//Console.WriteLine(1);
//for (int i =1; i<=6; i++)
//{
//  t = s+p;
//  s = p;
//  p = t;
//  Console.WriteLine(з);
//}



















