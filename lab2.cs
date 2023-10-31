2
—————————
using System;

namespace ConsoleApp1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            double y = Int32.Parse(Console.ReadLine()), x = Int32.Parse(Console.ReadLine()); 
            if (y >= 0 && (y + Math.Abs(x)) <= 1)
            {
                Console.WriteLine("Vera_VnUTRI");
            }
            else Console.WriteLine("Vera_Snaruzi");


        }
    }
}
———————————
5
———————————
using System;

namespace ConsoleApp1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поместется ли квадратв круге ?");
            double krug = Double.Parse(Console.ReadLine());
            double kvadrat = Double.Parse(Console.ReadLine()); 
            if ((Math.Pow((krug / Math.PI), 0.5)) >= (Math.Pow(kvadrat, 0.5) * Math.Pow(2, 0.5) / 2))
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");


        }
    }
}
——————————
8
using System;

namespace ConsoleApp1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int y = Int32.Parse(Console.ReadLine()), x = Int32.Parse(Console.ReadLine());
            if (Math.Abs(x) >= 1)
            {
                y = 0;
            }
            else y = x * x - 1;

            Console.WriteLine("{0}\t{1}", x, y);
        }
    }
}
———————————
Lvl 2 ———
2
using System;

namespace ConsoleApp1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; ++i)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double d = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
                if (d <= r)
                {
                    count ++;
                }
                else continue;
            }
            Console.WriteLine(count);
        }
    }
}
——————————————
5
using System;

namespace ConsoleApp1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int N = 30;
            double norma = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                double result = Convert.ToDouble(Console.ReadLine());
                if (result >= norma)
                {
                    ++count;
                }
            }
            Console.WriteLine(count);
        }
    }
}
—————————
8
using System;

namespace ConsoleApp1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double number = Math.Pow(10.0, 9);
            int blizko = -1000;
            for (int i = 0; i < N; ++i)
            {
                double X = Convert.ToDouble(Console.ReadLine());
                double Y = Convert.ToDouble(Console.ReadLine());
                double ans_now = Math.Sqrt(X * X + Y * Y);
                if (ans_now < number)
                {
                    number = ans_now;
                    blizko = i + 1;
                }
            }
            Console.WriteLine(blizko);
            Console.WriteLine(number);
        }
    }
}
