using System;
class HelloWorld
{
    static void Main()
    {
        double s = 0;
        double a = 0.1, b = 1, h = 0.1;
        double y;
        double eps = 0.0001;
        double now_elem;
        double fact;
        double stp = 1;
        for (double x = a; x <= b; x += h)
        {
            y = Math.Cos(x);
            int i = 0;
            while (true)
            {
                fact = 1;
                stp = 1;
                for (int j = 1; j <= 2 * i; j++)
                {
                    fact *= j;
                    stp *= x;
                }
                if (i % 2 == 0)
                {
                    now_elem = stp / fact;
                }
                else
                {
                    now_elem = -stp / fact;
                }

                if (Math.Abs(now_elem) < eps)
                {
                    break;
                }
                else
                {
                    s += now_elem;
                }
                i++;
            }
            Console.WriteLine(s + " " + y);
            Console.WriteLine();
            s = 0;
        }
        Console.ReadKey();
    }
}
