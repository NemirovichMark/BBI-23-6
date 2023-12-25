using System;



//1.8
//int n = int.Parse(Console.ReadLine());
//int m = int.Parse(Console.ReadLine());
//double[,] matrix = new double[n, m];
//Random k = new Random();
//double[] matrix1 = new double[n];
//for (int i = 0; i < 4; ++i)
//{
//    double sr = 0;
//    int kol = 0;
//    for (int j = 0; j < 6; ++j)
//    {
//        if ((matrix[i, j] > 0))
//        {
//            sr += matrix[i, j];
//            kol++;
//        }
//    }
//    if (kol > 0)
//    {
//        matrix1[i] = sr / kol;
//    }
//    else { matrix1[i] = 0; }
//}

////1.20
//Console.WriteLine("Введите количество строк матрицы:");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов матрицы:");
//int m = int.Parse(Console.ReadLine());
//double[,] matrix = new double[n, m];

//Random k = new Random();
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        matrix[i, j] = k.NextDouble() * 10;
//    }
//}

//for (int i = 0; i < n; i++)
//{
//    double maxE = -100000;
//    int i_max = -1;
//    int i_first = -1, i_last = -1;
//    for (int j = 0; j < m; j++)
//    {
//        if (matrix[i, j] < 0 && i_first != -1)
//        {
//            i_first = j;
//        }
//        if (matrix[i, j] < 0)
//        {
//            i_last = j;
//        }
//        if (matrix[i, j] > maxE)
//        {
//            maxE = matrix[i, j];
//            i_max = j;
//        }
//    }
//    matrix[i, i_max] = (matrix[i, i_first] + matrix[i, i_last] / 2);

//}

//1.24
//int n = 6, m = 5;
//double[,] f = new double[n, m];

//Random k = new Random();
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        f[i, j] = k.NextDouble() * k.Next(-10, 10);
//    }
//}

//for (int i = 0; i < n; i++)
//{
//    double maxE = -100000;
//    int i_max = -1;
//    int i_first = -1, i_last = -1;
//    for (int j = 0; j < m; j++)
//    {
//        if (f[i, j] > maxE)
//        {
//            maxE = f[i, j];
//            i_max = j;
//        }
//    }

//    double s = 0;
//    int kolvo = 0;
//    for (int j = i_max + 1; j < m; j++)
//    {
//        if (f[i, j] > 0)
//        {
//            kolvo++;
//            s += f[i, j];
//        }
//    }
//    s /= kolvo;

//    for (int j = 0; j < i_max; ++j)
//    {
//        if (f[i, j] < 0)
//        {
//            f[i, j] = s;
//        }
//    }
//}

////3.6
//Console.WriteLine("Введите количество строк и столбцов матрицы:");
//int n = int.Parse(Console.ReadLine());
//double[,] a = new double[n, n];

//double[] v = new double[n * (n + 1) / 2];
//double[] N = new double[n * (n - 1) / 2];
//int i1 = 0, i2 = 0;

//Random k = new Random();
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        a[i, j] = Math.Round(k.NextDouble() * 10);
//        if (j >= i)
//        {
//            v[i1] = a[i, j];
//            i1++;
//        }
//        else
//        {
//            N[i2] = a[i, j];
//            i2++;
//        }
//    }
//}

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write(a[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//int e1 = 0;
//for (int i = n; i > 0; i -= 1)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write(v[e1] + " ");
//        e1++;
//    }
//    Console.WriteLine();
//}

//int e = 0;
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write(N[e] + " ");
//        e++;
//    }
//    Console.WriteLine();
//}
////3.10
Console.WriteLine("Введите количество строк и столбцов матрицы:");

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
double[,] a = new double[n, m];

Random k = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        a[i, j] = Math.Round(k.NextDouble() * 10);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i1 = 0; i1 < n; i1 += 2)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m - 1; j++)
        {
            if (a[i1, j] < a[i1, j + 1])
            {
                double d = a[i1, j];
                a[i1, j] = a[i1, j + 1];
                a[i1, j + 1] = d;
            }
        }
    }
}


for (int i1 = 1; i1 < n; i1 += 2)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m - 1; j++)
        {
            if (a[i1, j] > a[i1, j + 1])
            {
                double d = a[i1, j];
                a[i1, j] = a[i1, j + 1];
                a[i1, j + 1] = d;
            }
        }
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}