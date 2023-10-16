using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region // контрольная работа вариант 10 №1
            int s = 0;
            for (int i = 3; i <= 21; i = i + 2)
            {
                s = s + (i / i + 1);
            }
            Console.WriteLine(s);
            Console.WriteLine("Конец 1 задачи");
            #endregion

            #region // контрольная работа вариант 10 №2
            double sum = 0, x = 0.5, t = 0, m;
            do
            {
                t = t + 2;
                m = Math.Pow(x, t);
                sum = sum + m;
            }
            while (m > 0.0001);
            Console.WriteLine(sum);
            Console.WriteLine("Конец 2 задачи");
            #endregion

            #region // контрольная работа вариант 10 №3
            double y = 0, pi=3.14;
            for (double xe = -2 * pi; xe <= 0; xe = xe + (pi / 5))
            {
                y = 2 * Math.Cos(xe + 2);

                Console.WriteLine("xe={0:F3} | y={1:F3}", xe, y);
            }
            Console.WriteLine("Конец 3 задачи");
            #endregion

            #region // контрольная работа вариант 10 №4
            double p = 1, n=2;
            while (p<=100000)
            {
                p = p * n;
                n = n + 2.5;
            }
            Console.WriteLine(n);
            Console.WriteLine("Конец 4 задачи");
            #endregion

            #region // контрольная работа вариант 10 №5
            double su=0,ne=4;
            for (int i = 2; i <= 12; i = i + 2)
            {
                su = su + ne;
                ne = ne * 2;
                su = su - ne;
                ne = ne * 2;
            }
            Console.WriteLine(su);
            Console.WriteLine("Конец 5 задачи");
            #endregion
        }
    }
}
