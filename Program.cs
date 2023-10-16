№1
using System;
class Program
{
    static void Main(  )
    {
        int s = 0;
        for(int i = 2; i <= 35; i += 3)
        {
            s += i;
        }

        Console.WriteLine(s);
    }
}


№2
using System;
class Program
{
    static void Main()
    {
        double s = 0;
        for (double i = 1; i <= 10; i++)
        {
            s += 1/ i;
        }

        Console.WriteLine(s);
    }
}


№3
using System;
class Program
{
    static void Main()
    {
        double s = 0;
        for (double i = 2; i <= 112; i += 2)
        {
            s += i / (i + 1);
        }

        Console.WriteLine(s);
    }
}

№4
using System;
class Program
{
    public static double pow(double x, int n)
    {
        double p = 1;
        for (int i = 1; i <= n; i++)
        {
            p = p * x;
        }
        return p;
    }
    static void Main()
    {
        
        double x = 1;
        double s = 0;
        for (int i = 0; i < 9; i++)

        {
            s += Math.Cos((i + 1) * x) / pow(x, i);
        }
        Console.WriteLine(s);
    }
}
№5
using System;
class Program
{
    static void Main()
    {
        double p = 2;
        double h = 3;
        double s=0;
        for (int i = 0; i < 10; i++)
        {
            s += ((p + i * h) * (p + i * h));
        }
        Console.WriteLine(s);
    }
}
№6
using System;
class Program
{
    public static void Main()
    {
        double y;
        for (double x = -4; x <= 4; x += 0.5)
        {
            y = 0.5 * x * x - 7 * x;
            Console.WriteLine(y);
        }
    }
}
№7
using System;
class Program
{
    static void Main()
    {
        int n = 6;
        int f = 1;

        for (int i = 1; i <= n; i++)
        {
            f*= i;
        }

        Console.WriteLine(f);
    }
}
№8
using System;
class Program
{
    static void Main()
    {
        int n = 6;
        int s = 0;

        for (int i = 1; i <= n; i++)
        {
            int f = 1;
            for (int j = 1; j <= i; j++)
            {
                f*= j;
            }
            s += f;
        }

        Console.WriteLine(s);
    }
}
№9
using System;
class Program
{
    static void Main()
    {
        double s = 0;
        double a = 0;
        for (int i = 1; i <= 6; i++)
        {
            a = (-1) * a * 5 / i;
            s = s + a;
        }
        Console.WriteLine(s);
    }
}
№10
using System;
class Program
{
    static void Main()
    {
        int x = 3;
        int y = 7;

        int result = 1;
        for (int i = 1; i <=y; i++)
        {
            result *= x;
        }

        Console.WriteLine(result);
    }
}


№11
а)
using System;
class Program
{
    static void Main()
    {
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
    }
}
б)
using System;
class Program
{
    static void Main()
    {
        int b = 5;
        for (int i = 0; i < 6; i++)
        {
            Console.Write(b + " ");
        }
        
    }
}

№12
using System;
class Program
{
    public static double pow(double x, int n)
    {
        double p = 1;
        for (int i = 1; i <= n; i++)
        {
            p = p * x;
        }
        return p;
    }

    static void Main()
    {
        double x = 2; 
        double s = 0;

        for (int i = 0; i <= 10; i++)
        {
            s += 1 / pow(x, i);
        }

        Console.WriteLine(s);
    }
}
№13
using System;
class Program
{
    static void Main()
    {
        for (double x = -1.5; x <= 1.5; x += 0.1)
        {
            if (x <= -1)
            {
                Console.WriteLine(1);
            }
            if (x > -1 && x <= 1)
            {
                Console.WriteLine(-x);
            }
            if (x > 1)
            {
                Console.WriteLine(-1);
            }
        }
    }
    
}
№14
using System;
class Program
{
    static void Main()
    {
        int n = 8; 
        int x1= 1;
        int x2= 1;

        Console.Write(x1 + " " + x2 + " ");

        for (int i = 3; i <= n; i++)
        {
            int xn = x1+ x2;
            Console.Write(xn + " ");

            x1 = x2;
            x2= xn;
        }
    }
}

№15
using System;
class Program
{
    static void Main()
    {
        int n = 5; 
        double ch = 2; 
        double zn= 1; 

        
        for (int i = 2; i < n; i++)
        {
            double x = ch; 
            ch += zn; 
            zn = x; 
        }

        Console.WriteLine($"{ch}/{zn}");
    }
}
Уровень 2
№1
using System;
class Program

{
    public static double pow(double x, int n)
    {
        double p = 1;
        for (int i = 1; i <= n; i++)
        {
            p = p * x;
        }
        return p;
    }

    public static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double eps = 0.0001;
        double s = Math.Cos(x);
        int n = 2;
        double sl = Math.Cos(n * x) / (pow(n, 2));

        while (Math.Abs(sl) > eps)
        {
            s += sl;
            sl = Math.Cos(n * x) / (pow(n, 2));
            n += 1;
        }

        Console.WriteLine(s);
    }
}
№2
using System;

class Program
{

    public static void Main()
    {
        int p = 1;
        int n = 4;
        int L = 30000;
        while (p < L)
        {
            p *= n;
            n += 3;
        }
        Console.WriteLine(n-3);
    }
}

№3
using System;

class Program
{

    public static void Main()
    {
        int a = 1, h = 1, n = 0;
        int p = Int32.Parse(Console.ReadLine());
        int s = 0;
        while (s < p)
        {
            s += a + n * h;
            n += 1;
        }
        Console.WriteLine(n);
    }
}
№4
using System;

class Program
{
    public static double pow(double x, int n)
    {
        double p = 1;
        for (int i = 1; i <= n; i++)
        {
            p = p * x;
        }
        return p;
    }

    public static void Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double eps = 0.0001;
        double s = 0;
        int n = 0;
        double sl = pow(x, 2 * n);
      

        while (sl >= eps)
        {
            s += sl;
            n += 1;
            sl = pow(x, 2 * n);
        }

        Console.WriteLine(s);
    }
}
№5
using System;
class Program
{
    
    static void Main()
    {
        
        int N = 10; 
        int M = 3; 

        int ch = 0; 
        int ost = N;

        while (ost >= M)
        {
            ost -= M;
            ch++;
        }

        Console.WriteLine("chastnoe: " + ch);
        Console.WriteLine("ostatok: " + ost);

    }
}
№7(а)
using System;

class Program
{

    public static void Main()
    {
        double x = 10;
        double s = 10;
        double k = 0.1;
        for (int i = 0; i < 7; i++)
        {
            x = x + x * k;
            s += x;
        }
        Console.WriteLine(s);
    }
}


№7(б)
using System;

class Program
{

    public static void Main()
    {
        double x = 10;
        double s = 10;
        double k = 0.1;
        int n = 0;
        while (s < 100)
        {
            x = x + x * k;
            s += x;
            n += 1;
        }
        Console.WriteLine(n);
    }
}

№7(в)
using System;

class Program
{

    public static void Main()
    {
        double x = 10;
        int n = 0;
        double k = 0.1;
        while (x <= 20)
        {
            x = x + x * k;
            n += 1;
        }
        Console.WriteLine(n);
    }
}

№8
using System;

class Program
{

    public static void Main()
    {
        double x = 10000;
        int n = 0;
        double s = 10000;
        double k = 0.08;
        while (s <= x*2)
        {
            s += s*k;
            n += 1;
        }
        Console.WriteLine(n);
    }
}
Урровень 3
№7
using System;

public class HelloWorld
{
    public static int factorial(int n)
    {
        if (n == 1 || n == 0)
        {
            return 1;
        }
        return n * factorial(n - 1);
    }
    public static double pow(double x, int n)
    {
        double p = 1;
        for (int i = 1; i <= n; i++)
        {
            p = p * x;
        }
        return p;
    }
    public static void Main()
    {
        ;
        double eps = 0.0001, a = 0.1, b = 1, h = 0.05;
        for (double x = a; x <= b; x += h)
        {
            int i = 0;
            double sl = pow(x, 2 * i) / factorial(2 * i), s;
            s = sl;
            while (sl > eps)
            {
                i += 1;
                sl = pow(x, 2 * i) / factorial(2 * i) ;
                s += sl;
            }
            Console.WriteLine(s);
            double y = (Math.Exp(x) + Math.Exp(-x)) / 2;
            Console.WriteLine(y);
            Console.WriteLine();
        }

