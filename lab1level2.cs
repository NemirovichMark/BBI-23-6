using System;

namespace ConsoleApp1
{
    internal class Program
    {
        #region1
        double x = 0.5;
        double epsilon = 0.0001;
        double sum = 0;
        double term = 1;
        double n = 1;

        while (Math.Abs(term) >= epsilon)
        {
            sum += term;
            n++;
            term = Math.Cos(n * x) / (n * n);
        }

        Console.WriteLine(sum);
        #endregion

        #region2
        int p = 1;
        for (int x = 1; x< 1000; x += 3)
        {
            if (p > 30000)
            {
                Console.WriteLine(x - 3);
                Console.WriteLine(p);
                Console.WriteLine(p / (x - 3));
                break;
            }
            else p = p * x;

        }
        Console.WriteLine(p);
        #endregion


        #region3
        int s3 = 0, n3 = 0, m3;
        const int a3 = 2, h3 = 3, p3 = 41;
        while (s3 <= p3)
        {
            m3 = a3 + n3 * h3;
            s3 = s3 + m3;
            n3 = n3 + 1;
        }
        n3--;
        Console.WriteLine($"{n3:d}");
        #endregion

        # region4
        double sum4 = 0;
        double x4 = 0.9;
        double last_sum4 = 0;
        for (int n4 = 1; n4 <= 10000; n4++)
        {
            sum += Math.Pow(x4, n4 * 2);
            if (Math.Pow(x4, n4 * 2) >= 0.0001)
            {
                last_sum4 = sum4;
            }

            if (Math.Pow(x4, n4 * 2) < 0.0001)
            {
                Console.WriteLine(last_sum4);
                break;
            }

        #endregion

        # region5
        double res = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());

        while (n >= m)
        {
            res += 1;
            n -= m;
        }
        Console.WriteLine($"частное: {res}");
        if (n < m)
        {
            if (n > 0)
            {
                Console.WriteLine($"остаток:{n}");
            }
            if (n == 0)
            {
                Console.WriteLine("остаток: 0");
            }
        #endregion

        #region 6            
        int n = 1;
        int time = 0;

        while (n != 105)
        {
            time++;


            n += n;


            if (n > 105)
            {
                n = 105;
            }
        }

        Console.WriteLine("¬рем€: " + time);
        Console.ReadKey();
        #endregion


        #region 7           
        double r = 10;
        double sum = 10;
        int kolvo = 1;
        for (kolvo = 1; sum < 100;)
        {
            r = r + r * 0.1;
            sum += r;
            kolvo += 1;
        }
        Console.WriteLine(kolvo);
        #endregion


        #region 8             
        double s = 10000;
        int d = 0;
        double r = 0.08;
        double s1 = s * 2;
        while (s < s1)
        {
            s += s * r;
            d++;
        }
        Console.WriteLine($"—умма удвоитс€ через {d} мес€цев.");
        #endregion

    }
}