using System;

public class Lab1.3.1
{
    static int fact(int n)
    {
        int f = 1;
        for (int i = 2; i <= n; ++i)
        {
            f *= i;
        }
        return f;
    }
    public static void Main(string[] args)

    {
        double s = 0;
        double eps = 0.0001;
        double a = 0.1;
        double b = 1;
        double h = 0.1;
        double x = a;
        int i = 0;
        double y;
        while (true)
        {
            double now = ((2 * i + 1) * Math.Pow(x, 2 * i) / fact(i));
            if (now < eps)
            {
                y = (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
                break;
            }
            else
            {
                s += now;
            }
            i++;
            x += h;
        }
        Console.WriteLine(y);
        Console.WriteLine(s);
    }
}
