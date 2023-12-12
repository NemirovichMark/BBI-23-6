using System;

/*
Console.WriteLine("lab 3, lvl 1, ex 10:");
int [] mas10 = new int[10];
Console.Write("P = ");
int p = int.Parse(Console.ReadLine());
Console.Write("Q = ");
int q = int.Parse(Console.ReadLine());
int k = 0;
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    mas10[i] = random.Next(100);
    if ((p < mas10[i]) & (mas10[i] < q)) { k += 1; }
}
for (int i = 0; i < 10; i++) { Console.Write(mas10[i] + " "); }
Console.WriteLine();
Console.WriteLine(k);
Console.WriteLine();


Console.WriteLine("lab 3, lvl 2, ex 10:");
Random random = new Random();
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int[] mas10 = new int[n];
int min = 999999;
int min_i = 0;
for (int i = 0; i < n; i++)
{
    mas10[i] = random.Next(-100, 100);
    if ((mas10[i] < min) && (mas10[i] > 0)) { min = mas10[i]; min_i = i; }

}
for (int i = 0; i < n; i++) { Console.Write(mas10[i] + " "); }
Console.WriteLine();
if (n != 0) { mas10[min_i] = 0; }
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++)
{
    if (mas10[i] != 0) { Console.WriteLine(mas10[i]); }
}
Console.WriteLine();




Console.WriteLine("Ex 11: ");
Console.Write("p = ");
int p = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int[] mas11 = new int[n];
int[] new_mas11 = new int[n + 1];
int pp_i = 0;
for (int i = 0; i < n; i++)
{
    mas11[i] = int.Parse(Console.ReadLine());
    if (mas11[i] > 0) { pp_i = i; }

}
for (int i = 0; i <= pp_i; i++) { new_mas11[i] = mas11[i]; }
if (pp_i > 0)
{
    new_mas11[pp_i + 1] = p;
    if (pp_i != n)
    {
        for (int i = (pp_i + 1); i < n; i++)
            new_mas11[i + 1] = mas11[i];
    }
    Console.WriteLine("Result: ");
    for (int i = 0; i < (n + 1); i++) { Console.WriteLine(new_mas11[i]); }
    Console.WriteLine();
}
else 
{
    Console.WriteLine("Result: ");
    for (int i = 0; i < n; i++) { Console.WriteLine(new_mas11[i]); } 
}




Console.WriteLine("Ex 12: ");
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int[] mas12 = new int[n];
int p = 0;
int max_i = 0;
int max = 0;
int sum12 = 0;
Random random = new Random();
for (int i = 0; i < n; i++)
{
    mas12[i] = random.Next(-100,100);
    if (mas12[i] > max) { max = mas12[i]; max_i = i; }
}
for (int i = 0; i < n; i++) { Console.Write(mas12[i] + " "); }
Console.WriteLine();
for (int i = (max_i + 1); i < n; i++)
{
    sum12 += mas12[i];
}
for (int i = 0; i < n; i++) { if (mas12[i] < 0) { mas12[i] = sum12; break; } }
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++) { Console.Write(mas12[i] + " "); }
Console.WriteLine();




Console.WriteLine("Ex 14: ");
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int[] mas14 = new int[n];
int max = 0;
int max_i = 0;
int p = 0;
int p_i = 0;
Random random = new Random();
for (int i = 0; i < n; i++)
{
    mas14[i] = random.Next(-100, 100);
    if (mas14[i] > max) { max = mas14[i]; max_i = i; }
}
for (int i = 0; i < n; i++) { Console.WriteLine(mas14[i]); }
for (int i = 0; i < n; i++)
{
    if (mas14[i] < 0) { p = mas14[i]; p_i = i; break; }
}
if (p < 0)
{
    mas14[max_i] = p;
    mas14[p_i] = max;
}
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++) { Console.WriteLine(mas14[i]); }
Console.WriteLine();


Не понимаю в чём заключается моя ошибка в задании 15, 
по условию k не должен привышать длинну массива A, 
а по вводу превышает, соответсвенно программа выдаёт ошибку.

То же самое в задании 17,
по условию задачи (Если максимальный элемент расположен до минимального,
то найти среднее арифметическое положительных элементов массива), 
моя программа не выдаёт ничего, так как нет положительных элемонтов,
соответсвенно и среднего арифметического положительных элементов также нет.
*/
