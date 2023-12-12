using System;
using System.Globalization;
Console.WriteLine("Lvl 1: ");
Console.WriteLine("Ex 1:");
double[] mas = new double[6];
double sum = 0;
for (int i = 0; i < 6; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas[i] = n;
    sum += n;
}
for (int i = 0; i < 6; i++)
{
    mas[i] = mas[i] / sum;
    Console.WriteLine(mas[i]);
}
Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Ex 2:");
double[] mas2 = new double[8];
double sum2 = 0;
int k = 0;
for (int i = 0; i < 8; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas2[i] = n;
    if (n > 0) sum2 += n; k += 1;
}
for (int i = 0; i < 8; i++)
{
    if (mas2[i] > 0) mas2[i] = sum2 / k;
    Console.WriteLine(mas2[i]);
}
Console.WriteLine();


Console.WriteLine("Ex 3:");
double[] mas_1 = new double[4];
double[] mas_2 = new double[4];
double[] sum_mas = new double[4];
double[] dif_mas = new double[4];

for (int i = 0; i < 4; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas_1[i] = n;
}

for (int i = 0; i < 4; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas_2[i] = n;
}

for (int i = 0; i < 4; i++)
{
    sum_mas[i] = mas_1[i] + mas_2[i];
    dif_mas[i] = mas_1[i] - mas_2[i];
}

for (int i = 0; i < 4; i++)
{
    Console.WriteLine(sum_mas[i]);
}

for (int i = 0; i < 4; i++)
{
    Console.WriteLine(dif_mas[i]);
}
Console.WriteLine();



Console.WriteLine("Ex 4:");
double[] mas4 = new double[5];
k = 0;
double sum4 = 0;
for (int i = 0; i < 5; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas4[i] = n; k += 1; sum4 += n;
}

for (int i = 0;i < 5; i++)
{
    mas4[i] -= sum4 / k;
    Console.WriteLine(mas4[i]);
}

Console.WriteLine();


Console.WriteLine("Ex 5:");
double[] mas5_1 = new double[4];
double[] mas5_2 = new double[4];
double sum5 = 0;
for (int i = 0; i < 4; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas5_1[i] = n;
}

for (int i = 0; i < 4; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas5_2[i] = n;
}

for (int i = 0; i < 4; i++)
{
    sum5 += mas5_1[i] * mas5_2[i];
}
Console.WriteLine(sum5);
Console.WriteLine();


Console.WriteLine("Ex 6:");
double[] mas6 = new double[6];
double sum6 = 0;
for (int i = 0; i < 6; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas6[i] = n;
    sum6 += n * n;
}
Console.WriteLine(Math.Sqrt(sum6));
Console.WriteLine();


Console.WriteLine("Ex 7:");
double[] mas7 = new double[7];
double sum7 = 0;
k = 7;
for (int i = 0; i < 7; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas7[i] = n; sum7 += n;
}

for (int i = 0; i < 7; i++)
{
    if (mas7[i] > sum7 / k) mas7[i] = 0;
    Console.WriteLine(mas7[i]);
}
Console.WriteLine();


Console.WriteLine("Ex 8:");
double[] mas8 = new double[6];
k = 0;
for(int i = 0; i < 6; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas8[i] = n;
    if (n < 0) k += 1;
}
Console.WriteLine(k);
Console.WriteLine();


Console.WriteLine("Ex 9:");
double[] mas9 = new double[8];
k = 0;
double sum9 = 0;
for (int i = 0; i < 8; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    sum9 += n;
}
Console.WriteLine();
for (int i = 0; i < 8; i++)
{
    if (mas9[i] > sum9 / 8) k += 1;
}
Console.WriteLine(k);
Console.WriteLine();


Console.WriteLine("Ex 10:");
double[] mas10 = new double[10];
string p_str = Console.ReadLine();
double p = double.Parse(p_str);
string q_str = Console.ReadLine();
double q = double.Parse(q_str);
k = 0;
for (int i = 0; i < 10; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas10[i] = n;
    if ((p < n) & (n < q)) k += 1;
}
Console.WriteLine(k);
Console.WriteLine();


Console.WriteLine("Ex 11:");
double[] mas11 = new double[10];
double[] new_mas = new double[10];
for (int i = 0; i < 10; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas11[i] = n;
    if (n > 0) new_mas[i] = n;
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(mas11[i] + "  " + new_mas[i]);
}
Console.WriteLine();


Console.WriteLine("Ex 12:");
double[] mas12 = new double[8];
for (int i = 0; i < 8; i++)
{
    if (mas12[8 - i] < 0) Console.WriteLine("num of massive: " + (8 - i) + ",  elem = " + mas12[8 - i]); break;
}
Console.WriteLine();


Console.WriteLine("Ex 13: ");
double[] mas13 = new double[10];
double[] mas13_1 = new double[10];
double[] mas13_2 = new double[10];

for (int i = 1; i <+ 10; i++)
{
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas13[i] = n;
    if (i % 2 == 0) mas13_1[i] = mas13[i];
    else mas13_2[i] = mas13[i];
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
    if (mas13_1[i] != 0) Console.WriteLine(mas13_1[i]);
for (int i = 0; i < 10; i++)
    if (mas13_2[i] != 0) Console.WriteLine(mas13_2[i]);
Console.WriteLine();



Console.WriteLine("Ex 14:");
double[] mas14 = new double[11];
double sum14 = 0;
for (int i = 0; i < 11; i++)
{  
    string n_str = Console.ReadLine();
    double n = double.Parse(n_str);
    mas14[i] = n;

}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    if (mas14[i] >= 0) sum14 += mas14[i] * mas14[i];
    else break;
}
Console.WriteLine(sum14);
Console.WriteLine();




Console.WriteLine("Ex 15:");
double[] mas15_x = new double[11];
double[] mas15_y = new double[11];
for (int i = 0; i < 11; i++)
{
    string n_str = Console.ReadLine();
    double n = Double.Parse(n_str);
    mas15_x[i] = n;
}
Console.WriteLine();
for (int i = 0; i < 11; i++)
{
    mas15_y[i] = (0.5 * Math.Log(mas15_x[i]));
    Console.WriteLine(mas15_x[i] + "  " + mas15_y[i]);

}
Console.WriteLine();

