using System;

/*
Console.WriteLine("Ex 9:");
int[,] a = new int[5, 7];
int max; int max_i; int max_j; int t;
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        a[i, j] = random.Next(-10, 10);
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    max = -99999; max_i = 0; max_j = 0;
    for (int j = 0; j < 7; j++)
    {
        if (a[i, j] > max) { max = a[i, j]; max_i = i; max_j = j; }
    }
    t = a[max_i, max_j]; a[max_i, max_j] = a[i, 0]; a[i, 0] = t;
}
Console.WriteLine("Result: ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
        Console.Write(a[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine();



Console.WriteLine("Ex 13:");
int[,] a = new int[5, 5];
int max = -99999; int max_j = 0; int t;
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        a[i, j] = random.Next(-10, 0);
        if ((i == j) & (a[i, j] > max)) { max = a[i, j]; max_j = j; }
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < 5; i++)
{
    t = a[i, max_j]; a[i, max_j] = a[i, 3]; a[i, 3] = t;
}
Console.WriteLine("Result: ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
        Console.Write(a[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine();



Console.WriteLine("Ex 17:");
Random random = new Random();
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
int min = 99999; int min_i; int min_j; int t;

int[,] b = new int[n, m];
int[,] new_b = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        b[i, j] = random.Next(-10, 10);
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(b[i, j] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    min = 99999; min_i = 0; min_j = 0;
    for (int j = 0; j < m; j++)
    {
        if (b[i, j] < min) { min = b[i, j]; min_i = i; min_j = j; }
    }
    new_b[i, 0] = min;
    for (int j = 0; j < min_j; j++)
    {
        new_b[i, (j + 1)] = b[i, j];
    }
    for (int j = (min_j + 1); j < m; j++)
    {
        new_b[i, j] = b[i, j];
    }
}

Console.WriteLine("Result: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            Console.Write(new_b[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();




Console.WriteLine("Ex 21:");
int[,] h = new int[5, 7];
Random random = new Random();
int max; int max_i = 0; int max_j = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        h[i, j] = random.Next(-10, 10);
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        Console.Write(h[i, j] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < 5; i++)
{
    max = -99999;
    for (int j = 0; j < 6; j++)
    {
        if (h[i, j] > max) { max = h[i, j]; }
    }
    h[i, 6] = max;
}
Console.WriteLine("Result: ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
        Console.Write(h[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine();




Console.WriteLine("Ex 25:");
int[,] x = new int[6, 5];
int k_ot_el;
int max = 0;
int min = 10;
int max_i = 0;
int min_i = 0;
int t;
Random random = new Random();

for (int i = 0; i < 6; i++)
{
    k_ot_el = 0;
    for (int j = 0; j < 5; j++)
    {
        x[i, j] = random.Next(-10, 10);
        if (x[i, j] < 0) { k_ot_el += 1; }
    }
    if (k_ot_el < min) { min = k_ot_el; min_i = i; }
    if (k_ot_el > max) { max = k_ot_el; max_i = i; }
}
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(x[i, j] + " ");
    }
    Console.WriteLine();
}
for (int j = 0; j < 5; j++)
{
    t = x[min_i, j];
    x[min_i, j] = x[max_i, j];
    x[max_i, j] = t;
}
Console.WriteLine("Result: ");
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 5; j++)
        Console.Write(x[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine();




Console.WriteLine("lvl 2, Ex 6:");
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int[,] a = new int[n, 3 * n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < 3 * n; j++)
    {
        if ((j - n) == i) { a[i, j] = 1; }
        if (i == j) { a[i, j] = 1; }
        if ((j - 2 * n) == i) { a[i, j] = 1; }
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < 3 * n; j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}

*/


