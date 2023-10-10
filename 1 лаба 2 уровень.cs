using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                #region // 2 уровень 1 задача
                double s = 0, n = 1, x = 5;
                const double e = 0.0001;
                while ((Math.Cos(n * x) / n * n) >= e)
                {
                    s = s + Math.Cos(n * x) / n * n;
                    n = n + 1;
                }
                Console.WriteLine(s);
                Console.WriteLine("Конец 1 задачи");
                #endregion

                #region // 2 уровень 2 задача
                int so = 1, ne = 1;
                const int l = 30000;
                while (so <= l)
                {
                    so = so * ne;
                    ne = ne + 3;
                }
                Console.WriteLine("n={0:F3}", ne);
                Console.WriteLine("Конец 2 задачи");
                #endregion

                #region // 2 уровень 3 задача
                int si = 0, na = 0, m;
                const int a = 2, h = 3, p = 41;
                while (si <= p)
                {
                    m = a + na * h;
                    si = si + m;
                    na = na + 1;
                }
                Console.WriteLine("na={0:F3}", na);
                Console.WriteLine("Конец 3 задачи");
                #endregion

                #region // 2 уровень 4 задача
                double sum = 1, k = 1;
                x = Convert.ToDouble(Console.ReadLine());
                if (Math.Abs(x) >= 1)
                    Console.WriteLine("x>=1");
                else
                {
                    while (k > 0.0001)
                    {
                        sum = sum + k;
                        k = x * x * k;
                    }
                    Console.WriteLine("sum = {0}", sum);
                }               
                Console.WriteLine("Конец 4 задачи");
                #endregion

                #region // 2 уровень 5 задача
                double N, M, ch = 0, ost = 0, w = 0;
                N = Convert.ToDouble(Console.ReadLine());
                M = Convert.ToDouble(Console.ReadLine());
                while (N >= M)
                {
                    N = N - M;
                    w++;
                }
                    ch = w;
                    ost = N;
                Console.WriteLine("ch = " + ch + " ost = " + ost);
                Console.WriteLine("Конец 5 задачи");
                #endregion

                #region // 2 уровень 6 задача
                int time = 0, klet = 10;
                while (klet<100000)
                {
                    klet = klet * 2;
                    time=time+3;
                }
                Console.WriteLine(time);
                Console.WriteLine("Конец 6 задачи");
                #endregion

                #region // 2 уровень 7a задача
                double distance = 10;
                for (int day = 2; day <= 7; day++) // увеличение началось со второго дня
                {
                    distance *= 1.1; 
                    Console.WriteLine("В день {0} спортсмен пробежал {1}км", day, distance);
                }
                #endregion

                #region // 2 уровень 7b задача
                double ros = 10, ms = 0, dp = 1.1, ss = 0;
                while (s <= 100)
                {
                    ss += ros;
                    ros *= dp;
                    ms++;
                }
                Console.WriteLine(ms);
                Console.WriteLine("Конец 7b задачи");
                #endregion

                #region // 2 уровень 7c задача
                double Mes = 0, Dop = 0, Ras = 10;
                while (Dop < 20)
                {
                    Dop = Ras / 100 * 10;
                    Ras = Ras + Dop;
                    Mes = Mes + 1;
                }
                Console.WriteLine(Mes);
                Console.WriteLine("Конец 7c задачи");
                #endregion

                #region // 2 уровень 8 задача
                double den = 10000, mes = 0, percent = 1.08;
                while (den < 20000)
                {
                    den *= percent;
                    mes=mes+1;
                }
                Console.WriteLine(mes);
                Console.WriteLine("Конец 8 задачи");
                #endregion
            }

        }
    }
}
