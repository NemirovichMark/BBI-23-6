using System;

namespace ConsoleApp1
{
    internal class Program
    {
        # region1
        double x = 0.5;
        double epsilon = 0.0001;
        double sum = 0;
        double term = 1;
        double n = 1;

        while (Math.Abs(term) >= epsilon)
        {
            sum += term;
            n++;
            term = Math.Cos(n* x) / (n* n);
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
            double st = 1;
            for (int j = 1; j <= (n4*2); j++)
            {
                st *= x4
             }
            sum += st;
            if (st >= 0.0001)
            {
                last_sum4 = sum4;
            }

            if (st < 0.0001)
            {
                Console.WriteLine(last_sum4);
                break;
            }
        }
        #endregion

        # region5
        int n = Convert.ToInt32(Console.ReadLine()), m = Convert.ToInt32(Console.ReadLine());
        int rez = 0;
        while (n >= m)
        {
            rez += 1;
            n = n - m;
        }
        Console.WriteLine($"Частное: {rez}");
        Console.WriteLine($"Остаток: {n}");
        #endregion

        #region6
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

        Console.WriteLine(time);
        Console.ReadKey();
        #endregion


        # region7
        //a
        double s = 10, d = 10;
        for (int i = 2; i < 8; i++)
        {
            d = d * 1.1;
            s = s + d;

        }
        Console.WriteLine(s);


        //b
        double s2 = 10, d2 = 10, k = 1;
        while (s2 < 100)
        {
            d2 = d2 * 1.1;
            s2 = s2 + d2;
            k += 1;
        }
        Console.WriteLine(k);



        //c           
        double d3 = 10, k3 = 1;
        while (d3 < 20)
        {
            d3 = d3 * 1.1;
            Console.WriteLine(d3);
            k3 += 1;
        }
        Console.WriteLine(k3);
        #endregion

        # region8
        double s = 10000, m = 1;
        while (s < 20000)
        {
            s = s * 1.08;
            m += 1;
            Console.WriteLine(s);
        }
        Console.WriteLine(m);
        #endregion

    }
}
