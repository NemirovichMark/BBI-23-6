double a = 0.1, b = 0.8, h = 0.1;
for (double x = a; x <= b; x += h)
{
    double s = 0;
    for (int i = 0; ; i++)
    {
        double k = Math.Pow(x, i)*Math.Sin(i*Math.PI/4);
        if (Math.Abs(k) < 0.0001)
        {
            break;
        }
        s += k;
    }
    Console.WriteLine("x = {0}, s = {1}, y = {2}", x, s, y(x));
}
    

    static double y(double x)
{
    return (x*Math.Sin(Math.PI/4))/(1-2*x*Math.Cos(Math.PI/4)+x*x);
}

static double fac(int n)
{
    double result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}
