using System;
using System.Globalization;
Console.WriteLine("Lvl 1: ");
Console.WriteLine("Ex 1:");
int r = 2;
double[] sp_x = new double[4] {0, 1.5, 1, 3};
double[] sp_y = new double[4] { 2, 0.7, 1, 0 };
double x;
double y;
for (int i = 0; i < 4; i++)
{
    x = sp_x[i];
    y = sp_y[i];
    if (Math.Abs(x * x + y * y - r * r) <= 1 / 1000) Console.WriteLine("(" + x + "," + y + ")");
}
Console.WriteLine();

Console.WriteLine("Ex 4: ");
string str_a = Console.ReadLine();
string str_b = Console.ReadLine();
string str_c = Console.ReadLine();
double a = double.Parse(str_a);
double b = double.Parse(str_b);
double c = double.Parse(str_c);
double z = Math.Max(Math.Min(a, b), c);
Console.WriteLine(z);
Console.WriteLine();

Console.WriteLine("Ex 7: ");
string str_x = Console.ReadLine();
x = double.Parse(str_x);
if (Math.Abs(x) > 1) y = 1;
else y = Math.Abs(x); 
Console.WriteLine(y);
Console.WriteLine();


Console.WriteLine("Lvl 2: ");
Console.WriteLine("Ex 1: ");
Console.Write("n = ");
int s = 0;
string str_n = Console.ReadLine();
int n  = int.Parse(str_n);
for (int i = 0; i < n; i++)
{
    string str_p = Console.ReadLine();
    int p = int.Parse(str_p);
    s += p;
}
Console.WriteLine(s / n);
Console.WriteLine();


Console.WriteLine("Ex 4:");

Console.Write("n = ");
string str_n4 = Console.ReadLine();
n = int.Parse(str_n4);

Console.Write("r1 = ");
string str_r1 = Console.ReadLine();
int r1 = int.Parse(str_n4);

Console.Write("r2 = ");
string str_r2 = Console.ReadLine();
int r2 = int.Parse(str_n4);

for (int i = 0; i < n; i++)
{
    Console.Write("x = ");
    string str_x4 = Console.ReadLine();
    x = int.Parse(str_x4);
    Console.Write("y = ");
    string str_y4 = Console.ReadLine();
    y = int.Parse(str_y4);
    if ((Math.Abs(x * x + y * y - r1 * r1) <= 1 / 1000) | (Math.Abs(x * x + y * y - r2 * r2) <= 1 / 1000))
            Console.WriteLine("(" + x + "," + y + ")");
}
Console.WriteLine();


Console.WriteLine("Ex 7: ");
Console.Write("n = ");
string str_n7 = Console.ReadLine();
n = int.Parse(str_n4);

for (int i = 0; i < n; i++)
{
    Console.Write("x = ");
    string str_x7 = Console.ReadLine();
    x = int.Parse(str_x7);
    Console.Write("y = ");
    string str_y7 = Console.ReadLine();
    y = int.Parse(str_y7);

    if (x > 0 & y > 0) Console.WriteLine("tochka v 1 kvadrante");
    if (x < 0 & y < 0) Console.WriteLine("tochka v 3 kvadrante");
}



