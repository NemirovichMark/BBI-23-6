using System;
/*
Console.WriteLine("Ex 5:");
int[,] a = new int[5, 4];
Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 4; j++)
    {
        a[i, j] = random.Next(-10, 10);
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
Console.Write("Введите номер столбца, начиная с 1. n = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    if (a[i, (n - 1)] < 0) { Console.WriteLine("Значение: " + a[i, (n-1)] + ", номер: " + (i + 1)); break; } 
}

 



     for (int j = 1; j < m; j += 2)
    {
        a[i, (m - j)] = ch[k];
        a[i, j] = nch[k];
        k++;
    }
 




Console.WriteLine("Ex 10, lvl 3 (для защиты)");
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
int[,] a = new int[n, m];
Random random = new Random();
Console.WriteLine("Исходная матрица: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        a[i, j] = random.Next(-10, 10);
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
static void swap(int elem1, int elem2)
{
    int t = elem1; elem1 = elem2; elem2 = t;
}


static int[] GnomeSort(int[] a)
{
    int index = 1; 
    int nextindex = 2;
    while(index < a.Length)
    {
        if (a[index - 1] < a[index]) 
        { 
            index = nextindex; 
            nextindex += 1; 
        }
        else 
        { 
            swap(a[index - 1], a[index]); 
            index -= 1;
            if (index == 0)
            {
                index = nextindex;
                nextindex += 1;
            }
        }
    }
    return a;
}


int m_nch = m / 2;
if (m % 2 != 0) { m_nch = (m / 2) + 1; }
int[] ch = new int[m_nch];
int[] nch = new int[m / 2];
for (int i = 0; i < n; i++)
{
    int ch_k = 0;
    int nch_k = 0;
    for (int j = 0; j < m; j++)
    {
        if (j % 2 == 0)
        {
            ch[ch_k] = a[i, j]; ch_k++;
        }
        else
        {
            nch[nch_k] = a[i, j]; nch_k++;
        }
    }
    GnomeSort(ch);
    GnomeSort(nch);
    ch_k = 0;
    nch_k = 0;
    for (int j = 0; j < m; j += 2)
        {
            a[i, j] = ch[ch_k];
            ch_k++;
        }
    for (int j = m; j < 1; j -= 2)
        {
            a[i, j] = nch[nch_k];
            nch_k++;
        }
}
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++) 
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
 */



