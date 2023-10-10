using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                #region // 1 уровень 1 задача
                double s = 0;
                for (int i = 2; i < 36; i = i + 3)
                {
                    s = s + i;
                }
                Console.WriteLine(s);
                Console.WriteLine("Конец 1 задачи");
                #endregion
                

                #region // 1 уровень 2 задача
                double su = 0;
                for (int i = 1; i < 11; i++)
                {
                    su = su + 1 / i;
                }
                Console.WriteLine(su);
                Console.WriteLine("Конец 2 задачи");
                #endregion


                #region // 1 уровень 3 задача
                double m = 3, sem = 0;
                for (double i = 2; i < 113; i = i + 2)
                {
                    sem = sem + i / m;
                    m = m + 2;
                }
                Console.WriteLine(sem);
                Console.WriteLine("Конец 3 задачи");
                #endregion

                #region // 1 уровень 4 задача
                double x = 2, del = 1, so = 0;
                for (int i = 1; i < 9; i++)
                {
                    so = so + Math.Cos(x * i) / del;
                    del = del * x;
                }
                Console.WriteLine(so);
                Console.WriteLine("Конец 4 задачи");
                #endregion


                #region // 1 уровень 5 задача
                int h = 5, p = 4;
                double si = 0;
                for (int i = 0; i < 10; i++)
                {
                    si = si + (p + i * h) * (p + i * h);
                }
                Console.WriteLine(si);
                Console.WriteLine("Конец 5 задачи");
                #endregion

                #region // 1 уровень 6 задача

                double y = 0;
                for (double x1 = -4; x1 <= 4; x1 += 0.5)
                {
                    y = 0.5 * x1 * x1 - 7 * x1;
                    Console.WriteLine("x={0:F3} | y={1:F3}", x1, y);
                }
                Console.WriteLine("Конец 6 задачи");
                #endregion

                #region // 1 уровень 7 задача
                int sum = 1;
                for (int i = 1; i < 7; i++)
                {
                    sum = sum * i;
                }
                Console.WriteLine(sum);
                Console.WriteLine("Конец 7 задачи");
                #endregion

                #region // 1 уровень 8 задача
                int f = 1;
                double sy = 0;
                for (int i = 1; i < 7; i++)
                {
                    f = f * i;
                    sy = sy + f;
                }
                Console.WriteLine(sy);
                Console.WriteLine("Конец 8 задачи");
                #endregion

                #region // 1 уровень 9 задача
                y = 1; sem = 0;
                double xy = -1, z = 5;
                for (int i = 1; i < 7; i++)
                {

                    sem = sem + x * z / y;
                    y = y * i;
                    z = z * 5;
                    xy = xy * -1;
                }
                Console.WriteLine(sem);
                Console.WriteLine("Конец 9 задачи");
                #endregion

                #region // 1 уровень 10 задача
                double sam = 1, t = 3;
                for (int i = 0; i < 8;)
                {
                    sam = t * sam;
                    i = i + 1;
                }
                Console.WriteLine(sam);
                Console.WriteLine("Конец 10 задачи");
                #endregion

                #region // 1 уровень 11a задача
                for (int i = 1; i < 7; i++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("Конец 11а задачи");
                #endregion

                #region // 1 уровень 11б задача
                t = 5;
                for (int i = 0; i < 7;)
                {
                    i = i + 1;
                    Console.Write(t);
                }
                Console.WriteLine("Конец 11б задачи");
                #endregion

                #region // 1 уровень 12 задача
                double xex = 7;
                for (double i = 0; i < 11; i++)
                {
                    sam = sam + 1 / xex;
                    xex = xex * 7;
                }
                Console.WriteLine(sam);
                Console.WriteLine("Конец 12 задачи");
                #endregion

                #region // 1 уровень 13 задача
                double ya = 0;
                for (double xe = -1.5; xe < 1.5; xe += 0.1)
                {
                    if (xe <= -1)
                    {
                        ya = 1;
                    }
                    else if (xe > 1)
                    {
                        ya = -1;
                    }
                    else
                    {
                        ya = -xe;
                    }

                    Console.WriteLine("x= {0:f3} ya={1:f3}", xe, ya);
                }
                Console.WriteLine("Конец 13 задачи");
                #endregion

                #region // 1 уровень 14 задача
                int perv = 1, vtor = 1, som = 0;
                Console.WriteLine(perv);
                Console.WriteLine(vtor);
                for (int i = 1; i < 7; i++)
                {
                    sum = perv + vtor;
                    Console.WriteLine(som);
                    perv = vtor;
                    vtor = som;
                }
                Console.WriteLine("Конец 14 задачи");
                #endregion

                #region // 1 уровень 15 задача
                int a = 1, b = 2, c = a + b, d = 1, e = 1, g = d + e;
                for (int i = 1; i <= 2; i++)
                {
                    a = b;
                    b = c;
                    c = a + b;
                    d = e;
                    e = g;
                    g = d + e;
                }
                Console.WriteLine(c * 1.0 / g);
                Console.WriteLine("Конец 15 задачи");
                #endregion
            }



        }
    }

}