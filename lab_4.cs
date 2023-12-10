using System;
using System.Globalization;

/*
Console.WriteLine("lvl 1");
Console.WriteLine("Ex 1:");
int sum = 0;
int[,] a = new int[5, 7];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        Console.Write("a (" + i + "," + j + ") = ");
        string s = Console.ReadLine();
        a[i, j] = int.Parse(s);
        sum += a[i, j];
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
        Console.Write(a[i, j]);
    Console.WriteLine();
}
Console.WriteLine("Result: " + sum);
Console.WriteLine();




Console.WriteLine("Ex 5:");
int[,] a = new int[5, 4];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("a (" + i + "," + j + ") = ");
        a[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.Write("vvidite stolbik: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < 5; i++)
{
    if (a[i, n] < 0) { Console.WriteLine("Result: znachenie:" + a[i, n] + ", nomer: " + i); break; }
}
Console.WriteLine();




Console.WriteLine("Ex 9:");
int[,] a = new int[5, 7];
int max; int max_i; int max_j; int t;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        Console.Write("a (" + i + "," + j + ") = ");
        a[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 5; i++)
{
    max = 0; max_i = 0; max_j = 0;
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
int max = 0; int max_j = 0; int t;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write("a (" + i + "," + j + ") = ");
        a[i, j] = int.Parse(Console.ReadLine());
        if ((i == j) & (a[i, j] > max)) { max = a[i, j]; max_j = j; }
    }
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
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
int min = 99999; int min_i; int min_j; int t;
int[,] b = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write("b (" + i + "," + j + ") = ");
        b[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < n; i++)
{
    min = 99999; min_i = 0; min_j = 0;
    for (int j = 0; j < m; j++)
    {
        if (b[i, j] < min) { min = b[i, j]; min_i = i; min_j = j; }
    }
    t = b[min_i, min_j]; b[min_i, min_j] = b[i, 0]; b[i, 0] = t;
}
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(b[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine();




Console.WriteLine("Ex 21:");
int[,] h = new int[5, 7];
int max;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write("h (" + i + "," + j + ") = ");
        h[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 5; i++)
{
    max = 0;
    for (int j = 0; j < 6; j++)
    {
        if (h[i, j] > max) { max = h[i, j]; }
    }
    h[i, 6] = h[i, 5]; h[i, 5] = max;
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
int max = -99999999;
int max_i = 0;
int min = 0;
int min_i = 0;
int t = 0;

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write("x (" + i + "," + j + ") = ");
        x[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if ((x[i, j] > max) && (x[i, j] < 0))
        {
            max = x[i, j];
            max_i = i;
        }
        if ((x[i, j] < min) && (x[i, j] < 0))
        {
            min = x[i, j];
            min_i = i;
        }
    }
}

for (int j = 0; j < 5; j++)
{
    t = x[min_i, j]; x[min_i, j] = x[max_i, j]; x[max_i, j] = t;
}
Console.WriteLine("Result: ");
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 5; j++)
        Console.Write(x[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine();



Console.WriteLine("Ex 29:");
int[,] f = new int[5, 7];
int[,] res = new int[5, 6];
int min = 9999999; int min_j = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        Console.Write("f (" + i + "," + j + ") = ");
        f[i, j] = int.Parse(Console.ReadLine());
        if ((i == 1) && (Math.Abs(f[i, j]) < min)) { min = f[i, j]; min_j = j; }
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j <= min_j; j++)
    {
        res[i, j] = f[i, j];
    }
}
if (min_j + 2 < 7)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = (min_j + 2); j < 7; j++)
        {
            res[i, j - 1] = f[i, j];
        }
    }
}
Console.WriteLine("Result: ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
        Console.Write(res[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine();




Console.WriteLine("Ex 33:");
int[,] a = new int[5, 7];
int k = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        Console.Write("a (" + i + "," + j + ") = ");
        a[i, j] = int.Parse(Console.ReadLine());
        if (a[i, j] < 0) { k += 1; }
    }
}
int[] mas = new int[k];
int n = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (a[i, j] < 0) { mas[n] = a[i, j]; n += 1; }
    }
}
Console.WriteLine("Result: ");
for (int i = 0; i < k; i++)
{
    Console.WriteLine(mas[i]);
}




Console.WriteLine("lvl 2: ");
Console.WriteLine("Ex 2: ");
int[,] a = new int[7, 5];
int k_p = 0;
int k_ot = 0;
int max = 0;
int max_i = 0;
int max_j = 0;
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write("a (" + i + "," + j + ") = ");
        a[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 5; j++)
        Console.Write(a[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < 5; j++)
{
    for (int i = 0; i < 7; i++)
    {
        if (a[i, j] > 0) { k_p += 1; }
        if (a[i, j] < 0) { k_ot += 1; }
        if (a[i, j] > max) { max = a[i, j]; max_i = i; max_j = j; }
    }
    if (k_p > k_ot) { a[max_i, max_j] = 0; }
    else { a[max_i, max_j] = max_i; }
    max = 0; k_p = 0; k_ot = 0;
}
Console.WriteLine("Result: ");
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 5; j++)
        Console.Write(a[i, j] + " ");
    Console.WriteLine();
}
Console.WriteLine();




Console.WriteLine("Ex 6:");
Console.WriteLine("n = ");
int n = int.Parse(Console.ReadLine());
n = 2;
int[,] a = new int[n, 3 * n];
int[,] b = new int[n, n];
for (int k = 0; k < n; k++)
{
    b[k, k] = 1;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < 3; j++)
    {

    }
}




Console.WriteLine("lvl 3:");
Console.WriteLine("Ex 1: ");
int[,] a = new int[7, 5];
Random random = new Random();
Console.WriteLine("Исходная матрица: ");
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 5; j++)
    {
        a[i, j] = random.Next(100);
        Console.Write(a[i, j] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[] min_elems = new int[7];
int[] min_sort = new int[7];
int min;
for (int i = 0; i < 7; i++)
{
    min = 9999999;
    for (int j = 0; j < 5; j++)
    {
        if (a[i, j] < min) { min = a[i, j]; }
    }
    min_elems[i] = min; 
    min_sort[i] = min;
}

int t;
for (int i = 0; i < 7; i ++)
{
    for (int j = i + 1; j < 7; j++)
    {
        if (min_sort[i] < min_sort[j])
        {
            t = min_sort[i];
            min_sort[i] = min_sort[j];
            min_sort[j] = t;

            for (int k = 0; k < 5; k++)
            {
                t = a[i, k];
                a[i, k] = a[j, k];
                a[j, k] = t;
            }
        }
    }
}

Console.WriteLine();
for (int k = 0; k < 7; k++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(a[k, j] + "  ");
    }
    Console.WriteLine();
}




Console.WriteLine("Ex 10: ");
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
int [,] a = new int[n, m];
Random random = new Random();
Console.WriteLine("Исходная матрица: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        a[i, j] = random.Next(100);
        Console.Write(a[i, j] + "  ");
    }
    Console.WriteLine();
}

int t;
for (int k = 0; k < n; k++)
{
    for (int i = 0; i < m; i += 2)
    {
        for (int j = i + 2; j < m; j += 2)
        {
            if (a[k, i] < a[k, j])
            {
                t = a[k, i];
                a[k, i] = a[k, j];
                a[k, j] = t;
            }
        }
    }
    for (int i = 1; i < m; i += 2)
    {
        for (int j = i + 2; j < m; j += 2)
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
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "  ");
    }
    Console.WriteLine();
}

*/