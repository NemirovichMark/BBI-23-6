//////уровень первый номер 1
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int s = 0;
//        for (int i = 2; i <= 35; i += 3)
//        {
//            s = s + i;
//        }
//        Console.WriteLine(s);
//    }
//}


////уровень первый номер 2
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        double s = 0;
//        int c = 1;  
//        int z = 1;
//        double d = c / z;
//        for (z = 1; z <= 10; z++)
//        {
//            s = s + d;
//        }
//        Console.WriteLine(s);
//    }
//}

//уровень первый номер 3
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        double s = 0;
//        for (int a = 3 ; a <= 113; a+=2)
//        {
//            s = s + a / (a + 1.0);
//        }
//        Console.WriteLine(s);
//    }
//}

//уровень первый номер 4
//using System;
//internal class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double s = 0;
//        double x = 0.5;
//        for (int a=1; a<=9; a++)
//        {
//            s = s + Math.Cos(a * x) / Math.Pow(x, a - 1);
//        }
//        Console.WriteLine(s)
//    }
//}

//уровень первый номер 5
//using System;
//internal class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double s = 0;
//        double p, h;
//        p=Convert.ToDouble(Console.ReadLine());
//        h=Convert.ToDouble(Console.ReadLine());
//        for (int i=0; i<10; i++)
//        {
//            double cur = (p + i*h) * (p + i*h);
//            s = s + cur;
//        }
//        Console.WriteLine(s);   
//    }
//}

//уровень первый номер 6
//using System;
//internal class Programm
//{
//    static void Main(string[] agrs)
//    {
//        const double xh = -4, xk = 4, h = 0.5;
//        double x, y;
//        int i, n;
//        n = (int)((xk - xh) / h + 1);
//        x = xh;
//        for (i = 1; i <= n; i = i + i)
//        {
//            y = Math.Pow(0.5*x, 2) - 7 * x;
//            Console.WriteLine("x={0:f2}/ty={1:f2}", x, y);
//            x = x + h;
//        }

//    }
//}

//уровень первый номер 7 
//using System;
//internal class Program
//{
//    static void Main(string[] agrs)
//    {
//        const int n = 6;
//        int p = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            p = p * i;
//        }
//        Console.WriteLine(p);
//    }
//}


//уровень первый номер 8
//using System;
//internal class Programm
//{
//    static void Main(string[] agrs)
//    {
//        int fact = 1;
//        int s = 0;
//        for(int i=1; i<=6; i++)
//        {
//            fact = fact * i;
//            s = s + fact;
//        }
//        Console.WriteLine(s);
//    }
//}

//уровень первый номер 9
//using System;
//using System.Diagnostics.CodeAnalysis;

//internal class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double s = 0;
//        double cur = 1;
//        for(int i=1; i<=6; i++)
//        {
//            cur = (-1) * cur * 5 / i;
//            s = s + cur;
//        }
//        Console.WriteLine(s);   
//    }
//}

//уровень первый номер 10
//using System;
//internal class Prigram
//{
//    static void Main(string[] agrs)
//    {
//        int a = 1;
//        int i;
//        for(i=1; i<=7; i++)
//        {
//            a = a * 3;
//        }
//        Console.WriteLine(a);
//    }
//}

//уровень первый номер 11а
//using System;
//internal class Programm
//{
//    static void Main(string[] args)
//    {
//        int a = 1;
//        Console.Write(a);
//        for (int i = 1; i < 6; i++)
//        {
//            a = a + 1;
//            Console.Write(" "+a);
//        }
//    }
//}

//уровень первый номер 11б
//using System;
//internal class Programm
//{
//    static void Main(string[] args)
//    {
//        int a = 5;
//        Console.Write(a);
//        for (int i = 1; i < 6; i++)
//        {
//            a = a;
//            Console.Write(" "+a);
//        }
//    }
//}

//уровень первый номер 12
//using System;
//internal class Programm
//{
//    static void Main(string[] args)
//    {
//        double s = 0;
//        double x=Convert.ToDouble(Console.ReadLine());
//        double cur = x;
//        for (int i=0; i<=10; i++)
//        {
//            cur = cur / x;
//            s = s + cur;
//        }
//        Console.WriteLine(s);
//    }
//}

//уровень первый номер 13
//using System;
//internal class Programm
//{
//    static void Main(string[] args)
//    {
//        double h = 0.1;
//        double min = -1.5;
//        double max = 1.5;
//        Console.WriteLine("   x | y ");
//        Console.WriteLine("___________");
//        double x = min;
//        while(x<=max)
//        {
//            string sx = string.Format("{0:f1}", x);
//            if (x>=0)
//            {
//                Console.Write(" ");
//            }
//            Console.Write(sx);
//            if (x <= -1)
//            {
//                Console.WriteLine($" | 1 ");
//            }
//            else if(x>-1 && x<=1)
//            {
//                string sy = string.Format("{0:f1}", -x);
//                Console.Write(" | ");
//                Console.WriteLine(sy);
//            }
//            else
//            {
//                Console.WriteLine($" | -1 ");
//            }
//            x = x + h;
//        }
//    }
//}

//уровень первый номер 14
//using System;
//internal class Programm
//{
//    static void Main(string[] agrs)
//    {
//        int a = 1;
//        int b = 1;
//        int c = a + b;
//        Console.Write("1 1 ");
//        for(int i=1; i<=6; i++)
//        {
//            Console.Write($"{c} ");
//            a = b;
//            b = c;
//            c = a + b;
//        }
//    }
//}

//уровень первый номер 15
using System;
internal class Programm
{
    static void Main(string[] agrs)
    {
        int a = 1;
        int b = 2;
        int c = a + b;
        int x = 1;
        int y = 1;
        int z = x + y;
        for (int i=1; i<=2; i++)
        {
            a = b;
            b = c;
            c = a + b;
            x = y;
            y = z;
            z = x + y;
        }
        Console.WriteLine(1.0*c / z);
    }
}

//уровень третий номер 1
using System;
class Program
{
    public static void Main()
    {
        double sum = 0;
        double a = 0.1;
        double b = 1;
        double h = 0.1;
        int i = 0;
        for (double x = a; x <= b; x += h, i++)
        {
            double cur;
            long fact = 1;
            double y = Math.Cos(x);
            for (int g = 2; g <= 2 * i; g++)
            {
                fact = fact * g;
            }
            if (i % 2 == 0)
            {
                cur = Math.Pow(x, 2 * i) / fact;
            }
            else
            {
                cur = -1 * Math.Pow(x, 2 * i) / fact;
            }
            if (Math.Abs(cur) < 0.0001)
            {
                break;
            }
            sum += cur;
            Console.WriteLine($"i = {i}, x = {x}, current element = {cur}, cos(x) = {y} \n\n");
        }
        Console.WriteLine($"sum = {sum}");
    }
}