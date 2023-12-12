using System;
using System.ComponentModel.DataAnnotations;
Console.WriteLine("lvl 3: ");
Console.WriteLine("Ex 3: ");
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
double[] mas = new double[n];
double[] max_mas = new double[n];
double max = 0;
int max_i = 0;
double temp;
for (int i = 0; i < n; i++)
{
    mas[i] = double.Parse(Console.ReadLine());
    if (mas[i] > max) { max = mas[i]; max_i = i; }
}
for(int i = 0; i < max_i; i += 2)
{
    temp = mas[i]; 
    mas[i] = mas[i + 1];
    mas[i + 1] = temp;
}
Console.WriteLine("Result: ");
for (int i = 0;i < n; i++) { Console.WriteLine(mas[i]); }
Console.WriteLine();

Console.WriteLine("Ex 5: ");
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
mas = new double[n];
double[] mas_ch = new double[n];
temp = 0;
for (int i = 0; i < n; i++)
{
    mas[i] = double.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        mas_ch[i] = mas[i];
    }
}
for (int i = 1; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mas_ch[i] > mas_ch[j])
        {
            temp = mas_ch[i]; mas_ch[i] = mas_ch[j]; mas_ch[j] = temp;
        }
    }
    
}
int j = 0;
for (int i = (n - 1); i > 0; i -= 2)
{
    mas[i] = mas_ch[j]; j++;
}
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(mas[i]);
}
