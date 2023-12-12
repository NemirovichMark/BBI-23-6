using System;
/*
Console.WriteLine("Ex 2:");
Random random = new Random();
double[] a = new double[9];
double[] b = new double[7];
double max_a = 0; int max_a_i = 0;
double max_b = 0; int max_b_i = 0;
double sum_a = 0; double sum_b = 0;
int k = 0;
for (int i = 0; i < 9; i++)
{
    a[i] = random.Next(100);
    if (a[i] > max_a) { max_a = a[i]; max_a_i = i; }
    Console.Write(a[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 7; i++)
{ 
    b[i] = random.Next(100);
    if (b[i] > max_b) { max_b = b[i]; max_b_i = i; }
    Console.Write(b[i] + " ");
}
Console.WriteLine();

if (max_a_i <= max_b_i) 
{
    if (max_a_i != 8)
    {
        for (int i = (max_a_i + 1); i < 9; i++)
        {
            sum_a += a[i]; k += 1;
        }
        a[max_a_i] = sum_a / k;
        b[max_b_i] = sum_a / k;
    }
}
else 
{
    if (max_b_i != 6)
    {
        for (int i = (max_b_i + 1); i < 7; i++)
        {
            sum_b += b[i]; k += 1;
        }
        a[max_a_i] = sum_b / k;
        b[max_b_i] = sum_b / k;
    }
}
Console.WriteLine();
Console.WriteLine("Result:");
for (int i = 0; i < 9; i++)
{
    Console.Write(a[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 7; i++)
{
    Console.Write(b[i] + " ");
}



Console.WriteLine("Ex 8");
Random random = new Random();
int[] a = new int[9];
int[] b = new int[11];
int max_a = 0; int max_a_i = 0;
int max_b = 0; int max_b_i = 0;
int sum_a = 0; int sum_b = 0;
int k = 0;
for (int i = 0; i < 9; i++)
{
    a[i] = random.Next(100);
    if (a[i] > max_a) { max_a = a[i]; max_a_i = i; }
    Console.Write(a[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 11; i++)
{
    b[i] = random.Next(100);
    if (b[i] > max_b) { max_b = b[i]; max_b_i = i; }
    Console.Write(b[i] + " ");
}
Console.WriteLine();
static int[] sort(int[] a, int max_a_i, int l)
{
    int t;
    for(int i = (max_a_i + 1); i < l; i++)
    {
        for (int j = i + 1; j < l; j++)
        {
            if (a[i] > a[j])
            {
                t = a[i];
                a[i] = a[j];
                a[j] = t;
            }
        }
    }
    return a;
}
sort(a, max_a_i, 9);
sort(b, max_b_i, 11);


Console.WriteLine("Result: ");
for (int i = 0; i < 9; i++)
{
    Console.Write(a[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 11; i++)
{
    Console.Write(b[i] + " ");
}
Console.WriteLine();




Console.WriteLine("Ex 14:");
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int[,] a = new int[n, n];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = random.Next(100);
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}

static int[,] sort(int[,] a, int n)
{
    int t;
    for (int k = 0; k < n; k++)
    {
        for (int i = 0; i < n; i++) 
        {
            for (int j = i + 1; j < n; j++) 
            {
                if (a[k, i] > a[k, j])
                {
                    t = a[k, i];
                    a[k, i] = a[k, j];
                    a[k, j] = t;
                }
            }
        }
    }
    return a;
}
sort(a, n);
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}




Console.WriteLine("Ex 20:");
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int[,] a = new int[n, n];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = random.Next(-5, 5);
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
int[,] b = new int[m, m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        b[i, j] = random.Next(-5, 5);
        Console.Write(b[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
static int[,] del(int[,] a, int n)
{
    int k; int ch = 0; int l = 0;
    for (int  i = 0; i < n; i++)
    {
        k = 0;
        for (int j = 0; j < n; j++)
        {
            if (a[j, i] == 0) { k += 1; }
        }
        if (k != 0) { ch += 1; }
    }

    int[,] res = new int[n, ch];
    for (int i = 0; i < n; i++)
    {
        k = 0;
        for (int j = 0; j < n; j++)
        {
            if (a[j, i] == 0) { k += 1; }
        }
        if (k != 0)
        {
            for (int j = 0; j < n; j++)
            {
                res[j, l] = a[j, i];
            }
            l += 1;
        }
    }
    return res; 
}
a = del(a, n);
b = del(b, m);
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < (a.Length / n); j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < (b.Length / m); j++)
    {
        Console.Write(b[i, j] + " ");
    }
    Console.WriteLine();
}




Console.WriteLine("Ex 26:");
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int[,] a = new int[n, n];
int[,] b = new int[n, n];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = random.Next(-100, 100);
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        b[i, j] = random.Next(-100, 100);
        Console.Write(b[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
static int kol_ot_elem(int i, int[,] a, int n)
{
    int k = 0;
    for(int j = 0; j < n; j++)
    {
        if (a[i, j] < 0) { k += 1; }
    }
    return k;
}
int max_a = 0; int max_a_i = 0;
int max_b = 0; int max_b_i = 0;
for (int i = 0; i < n; i++)
{
    if (kol_ot_elem(i, a, n) > max_a) { max_a = kol_ot_elem(i, a, n); max_a_i = i; }
    if (kol_ot_elem(i, b, n) > max_b) { max_b = kol_ot_elem(i, b, n); max_b_i = i; }
}
int t;
for(int j = 0; j < n; j++)
{
    t = a[max_a_i, j];
    a[max_a_i, j] = b[max_b_i, j];
    b[max_b_i, j] = t;
}

Console.WriteLine("Result: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(b[i, j] + " ");
    }
    Console.WriteLine();
}
*/