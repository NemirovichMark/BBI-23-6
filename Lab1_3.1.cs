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
        double a = Math.PI / 5;
        double b = Math.PI;
        double h = Math.PI / 25;
        double x = a;
        int i = 1;
        while (true)
        {
            if (Math.Abs(pow(-1, i) * Math.Cos(i * x) / pow(i, 2)) < 0.0001 || x > b)
            {
                break;
            }
            s += pow(-1, i) * Math.Cos(i * x) / pow(i, 2);
            Console.Write(s + " " + (3 * pow(x, 2) - pow(Math.PI, 2)) / 12);
            Console.WriteLine();
            x += h;
            ++i;
        }
        Console.ReadKey();
    }
}
