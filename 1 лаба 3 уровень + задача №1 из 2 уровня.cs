using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                #region // 2 уровень 1 задача
                double se = 0, n = 1, xe = 5;
                while ((Math.Cos(n * xe) / n * n) >= 0.0001)
                {
                    se = se + Math.Cos(n * xe) / n * n;
                    n = n + 1;
                }
                Console.WriteLine(se);
                Console.WriteLine("Конец 1 задачи");
                #endregion

                #region // 3 уровень 2 задача
                double a = 0.1;
                double b = 0.8;
                double h = 0.1;

                for (double x = a; x <= b; x += h)
                {
                    double s = 0;
                    double y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
                    double xi = x;
                    int i = 1;

                    while (Math.Abs(xi) >= 0.0001)
                    {
                        s += xi * Math.Sin(i * Math.PI / 4);
                        i++;
                        xi *= x;
                    }

                    Console.WriteLine("x = {0:F2}, s = {1:F3}, y = {2:F3}", x, s, y);
                }
                #endregion
            }
        }
    }
}