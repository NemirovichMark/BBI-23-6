using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            double a = 0.1, b = 1, h = 0.05, minx = 0.0001, y = 0, s = 0;
            int i = 0;
            double x = a;
            while (x <= b)
            {
                double ot = 1, st=1;
                for (j = 1; j <= (2 * i); ++j) {
                    ot *= j;
                    st *= x;
                }

                double now = st / ot;
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
