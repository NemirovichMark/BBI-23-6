using System;
//lvl 3
double s = 0; double a = 0.1; double b = 1; double h = 0.1; 
double y; double lim = 0.0001; double sl;double fact;
for (double x = a; x <= b; x += h)
{
    y = Math.Cos(x);
    int i = 1;
    while (true)
    {
        fact = 1;
        for (int j = 1; j <= 2 * i; j ++)
        { 
            fact *= j;
        }

        sl = Math.Pow(-1, i) * (Math.Pow(x, 2 * i) / fact);

        if (Math.Abs(sl) < lim) break;
        else s += sl; i++;
    }
    Console.WriteLine("s = " + s + ", y = " + y);
    Console.WriteLine();
 }
  