using System;

// 2nd lvl

// Ex 1:
double e = 0.0001;
string str = Console.ReadLine();
double x = double.Parse(str);
double s1 = Math.Cos(x);
double k = 1;
int n = 2;
while (Math.Abs(k) < e)
{
    k = Math.Cos(n * x) / n * n;
    s1 += k;
    n += 1;
}
Console.WriteLine("Ex 1: " + s1);
Console.WriteLine();


//Ex 2:
int s2 = 1;
int j = 1;
while (s2 <= 30000)
{
    j += 3;
    s2 *= j;
}
Console.WriteLine("Ex 2: " + (j - 3));
Console.WriteLine();

// Ex 3:
Console.Write("p: ");
string str2 = Console.ReadLine();
double p = double.Parse(str2);

Console.Write("a: ");
string str3 = Console.ReadLine();
double a = double.Parse(str3);

Console.Write("h: ");
string str4 = Console.ReadLine();
double h = double.Parse(str4);

double s3 = a;
for (int i = 1; i <= p; i++)
{
    s3 += (a + h * i);
    if (s3 >= p)
        s3 -= (a + h * (i - 1)); Console.WriteLine("Ex 3: " + s3); break;
}
Console.WriteLine();

// Ex 4:
double s4 = 1;
x = 0.5;
int st = 2;
while (x >= 0.0001)
{
    for (int i = 2; i <= st; i++)
        x *= x;
    st += 2;
    s4 += x;
}
Console.WriteLine("Ex 4: " + s4);
Console.WriteLine();


// Ex 5: 
Console.Write("N: ");
string Nstr = Console.ReadLine();
int N = int.Parse(Nstr);

Console.Write("M: ");
string Mstr = Console.ReadLine();
int M = int.Parse(Mstr);
k = 0;
while (N > M)
{ 
    N -= M;
    k += 1;
}
Console.WriteLine("Quotient: " + k);
Console.WriteLine("Remainder: " + N);
Console.WriteLine();

// Ex 6: не нашла такой задачи

// Ex 7:
Console.WriteLine("Ex 7: ");
double v = 10;
double s = 0;
k = 0;
while (s < 100)
{
    s += v;
    v *= 1.1;
    k += 1;
    if (k == 7) Console.WriteLine("a) " + s);
}
Console.WriteLine("b) " + k);
k = 1;
v = 10;
while (v < 20)
    v *= 1.1; k += 1;
Console.WriteLine("c) " + k);
Console.WriteLine();

// Ex 8:
double vclad = 10000;
k = 0;
while (vclad < 20000)
{ vclad *= 1.08;
    k += 1;
}
Console.WriteLine("Ex 8: " + k);
Console.WriteLine();

