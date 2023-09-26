using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int Fac(int a)
        {
            int s = 1;
            for (int i = 1; i <= a; i++)
            {
                s *= i;
            }
            return s;
        }


        static void Main(string[] args)
        {

            double a = 0.1, b = 1, h = 0.05, minx = 0.0001, y = 0, s = 0;
            int i = 0;
            double x = a;
            while (x <= b)
            {
                double now = Math.Pow(x, 2 * i) / Fac(2 * i);
                if (Math.Abs(now) < minx)
                {
                    y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
                    break;
                }
                else
                {
                    s += now;
                }
                i++;
                x += h;
            }
            Console.WriteLine(s);
            Console.WriteLine(y);

        }
    }
}
