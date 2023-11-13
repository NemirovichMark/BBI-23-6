using System;
using System.Numerics;
Console.WriteLine("lvl 2: ");
Console.WriteLine("Ex 1: ");
int n = int.Parse(Console.ReadLine());
double min = 999999;
int min_i = 0;
double[] mas1 = new double[n];
for (int i = 0; i < n; i++)
{
    mas1[i] = Double.Parse(Console.ReadLine());
    if (mas1[i] < min)
    {
        min = mas1[i];
        min_i = i;
    }
}
mas1[min_i] = min * 2;
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(mas1[i]);

}
Console.WriteLine();



Console.WriteLine("Ex 2: ");
n = int.Parse(Console.ReadLine());
double[] mas2 = new double[n];
double max = 0;
int max_i = 0;
double sum2 = 0;
for (int i = 0; i < n; i++)
{
    mas2[i] = Double.Parse(Console.ReadLine());
    if (mas2[i] > max) max = mas2[i]; max_i = i;
}

for (int i = 0; i < max_i; i++)
{
    sum2 += mas2[i];

}
Console.WriteLine("Result: " + sum2);
Console.WriteLine();



Console.WriteLine("Ex 3: ");
double[] mas3 = new double[n];
n = int.Parse(Console.ReadLine());
min = 999999;
min_i = 0;
for(int i = 0; i < n; i++)
{
    mas3[i] = Double.Parse(Console.ReadLine());
    if (mas3[i] < min)
    {
        min = mas3[i];
        min_i = i;
    }
}
for (int i = 0; i < min_i; i++)
{
    mas3[i] *= 2;
}
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(mas3[i]);
}
Console.WriteLine();



Console.WriteLine("Ex 4: ");
n = int.Parse(Console.ReadLine());
double[] mas4 = new double[n];
max = 0;
max_i = 0;
double sum4 = 0;
for(int i = 0; i < n; i++)
{
    mas4[i] = Double.Parse(Console.ReadLine());
    sum4 += mas4[i];
    if (mas4[i] > max) {  max = mas4[i]; max_i = i; }

}
for(int i = (max_i + 1); i < n; i++)
{
    mas4[i] = sum4 / n;
}
Console.WriteLine("Result: ");
for(int i = 0; i < n; i++) { Console.WriteLine(mas4[i]); }
Console.WriteLine();



Console.WriteLine("Ex 5: ");
n = int.Parse(Console.ReadLine());
double[] mas5 = new double[n];
double[] new_mas5 = new double[n];
max = 0;
min = 9999999;
max_i = 0;
min_i = 0;
for (int i = 0; i < n; i++)
{
    mas5[i] = Double.Parse(Console.ReadLine());
    if (mas5[i] < min) { min = mas5[i]; min_i = i; }
    if (mas5[i] > max) { max = mas5[i]; max_i = i; }
}

if (min_i < max_i)
{
    for (int i = min_i; i < max_i; i++)
    {
        if (mas5[i] < 0) { new_mas5[i] = mas5[i]; }
    }
}
else 
{
    for (int i = max_i; i < min_i; i++)
    { if (mas5[i] < 0) { new_mas5[i] = mas5[i]; } }
}
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++)
{
    if (new_mas5[i] != 0) { Console.WriteLine(new_mas5[i]); }
}



Console.WriteLine("Ex 6: ");
n = int.Parse(Console.ReadLine());
double[] mas6 = new double[n];
double[] new_mas6 = new double[n + 1];
double p = double.Parse(Console.ReadLine());
double sum6 = 0;
for (int i = 0;i < n; i++)
{
    mas6[i] = double.Parse(Console.ReadLine());
    sum6 += mas6[i];
}
double mid = sum6 / n;
double min_mod = 99999;
min_i = 0;
for(int i = 0;i < n;i++)
{
    if (Math.Abs(mas6[i] - mid) < min_mod) { min_mod = Math.Abs(mas6[i] - mid); min_i = i; }
}
for (int i = 0; i < n; i++)
{
    if (i <= min_i) { new_mas6[i] = mas6[i]; }
    else { new_mas6[i] = p; break; }
}
for (int i = (min_i + 1); i < n; i++)
{
    new_mas6[i + 1] = mas6[i];
}
Console.WriteLine("Result: ");
for(int i = 0; i <= n; i ++) { Console.WriteLine(new_mas6[i]); }
Console.WriteLine();



Console.WriteLine("Ex 7: ");
n = int.Parse(Console.ReadLine());
double[] mas7 = new double[n];
max = 0;
max_i = 0;
for (int i = 0; i < n; i++)
{
    mas7[i] = Double.Parse(Console.ReadLine());
    if (mas7[i] > max) { max = mas7[i]; max_i = i; }
}
if (max_i != (n - 1)) { mas7[max_i + 1] *= 2; }
Console.WriteLine("Result: ");
for (int i = 0;i < n; i++) { Console.WriteLine(mas7[i]); }
Console.WriteLine();



Console.WriteLine("Ex 8: ");
n = int.Parse(Console.ReadLine());
double[] mas8 = new double[n];
max = 0;
max_i = 0;
min = 999999;
min_i = 0;
for (int i = 0; i < n; i++)
{
    mas8[i] = Double.Parse(Console.ReadLine());
    if (mas8[i] > max) { max = mas8[i]; max_i = i; }
}
for (int i = max_i; i < n; i++)
{
    if (mas8[i] < min) { min = mas8[i]; min_i = i; }
}
mas8[max_i] = min;
mas8[min_i] = max;
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++) { Console.WriteLine(mas8[i]); }
Console.WriteLine();



Console.WriteLine("Ex 9: ");
n = int.Parse(Console.ReadLine());
double[] mas9 = new double[n];
max = 0;
max_i = 0;
min = 999999;
min_i = 0;
double sum9 = 0;
int k = 0;
for (int i = 0; i < n; i++)
{
    mas9[i] = double.Parse(Console.ReadLine());
    if (mas9[i] > max) { max = mas9[i]; max_i = i; }
    if (mas9[i] < min) { min = mas9[i]; min_i = i; }
}
if (min_i < max_i)
{
    for (int i = (min_i + 1); i < max_i; i++)
    { sum9 += mas9[i]; k += 1; }
    Console.WriteLine("Result: ");
    Console.WriteLine(sum9 / k);
}
if (min_i > max_i)
{
    for (int i = (max_i + 1); i < min_i; i++)
    { sum9 += mas9[i]; k += 1; }
    Console.WriteLine("Result: ");
    Console.WriteLine(sum9 / k);
}
if (min_i == max_i) { Console.WriteLine("Result: 0"); }
Console.WriteLine();



Console.WriteLine("Ex 10: ");
n =int.Parse(Console.ReadLine());
double[] mas10 = new double[n];
min = 999999;
min_i = 0;
for (int i = 0; i < n; i++)
{
    mas10[i] = double.Parse(Console.ReadLine());
    if ((mas10[i] < min) & (mas10[i] > 0)) { min = mas10[i]; min_i = i; }
     
}
mas10[min_i] = 0;
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++)
{
    if (mas10[i] != 0) { Console.WriteLine(mas10[i]); }
}
Console.WriteLine();




Console.WriteLine("Ex 11: ");
Console.Write("p = ");
p = double.Parse(Console.ReadLine());
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
double[] mas11 = new double[n];
double[] new_mas11 = new double[n + 1];
int pp_i = 0;
for (int i = 0;i < n; i++)
{
    mas11[i] = double.Parse(Console.ReadLine());
    if (mas11[i] > 0) { pp_i = i; }

}
for (int i = 0; i <= pp_i; i++) { new_mas11[i] = mas11[i]; }
new_mas11[pp_i + 1] = p;
if (pp_i != n)
{
    for (int i = (pp_i + 1); i < n; i++)
        new_mas11[i + 1] = mas11[i];
}
Console.WriteLine("Result: ");
for(int i = 0; i < (n + 1); i++) { Console.WriteLine(new_mas11[i]); }
Console.WriteLine();




Console.WriteLine("Ex 12: ");
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
double[] mas12 = new double[n];
p = 0;
max_i = 0;
max = 0;
double sum12 = 0;
for (int i = 0; i < n; i++)
{
    mas12[i] = double.Parse(Console.ReadLine());
    if (mas12[i] > max) { max = mas12[i]; max_i = i; }
}
for (int i = max_i; i < n; i++)
{
    sum12 += mas12[i];
}
for(int i = 0; i < n; i++) { if (mas12[i] < 0) { mas12[i] = sum9; break; } }
Console.WriteLine("Result: ");
for(int i = 0; i < n; i++) { Console.WriteLine(mas12[i]); }
Console.WriteLine();



Console.WriteLine("Ex 13: ");
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
double[] mas13 = new double[n];
max = 0;
max_i = 0;
for (int i = 0; i < n; i++)
{
    mas13[i] = double.Parse(Console.ReadLine());
    if ((i % 2 == 0) & (mas13[i] > max)) { max = mas13[i]; max_i = i; }
}
mas13[max_i] = max_i;
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++) { Console.WriteLine(mas13[i]); }
Console.WriteLine();




Console.WriteLine("Ex 14: ");
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
double[] mas14 = new double[n];
max = 0;
max_i = 0;
p = 0;
int p_i = 0;
for (int i = 0; i < n; i++)
{
    mas14[i] = double.Parse(Console.ReadLine());
    if (mas14[i] > max) { max = mas14[i]; max_i = i; }
}
for (int i = 0; i < n; i++) 
{ 
    if (mas14[i] < 0) { p = mas14[i]; p_i = i; break; } 
}
mas14[max_i] = p;
mas14[p_i] = max;
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++) { Console.WriteLine(mas14[i]); }
Console.WriteLine();




Console.WriteLine("Ex 15: ");
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
double[] a = new double[n];
for (int i = 0;i < n; i++) { a[i] =  double.Parse(Console.ReadLine()); }

Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
double[] b = new double[m];
for (int i = 0; i < m; i++) { b[i] = double.Parse(Console.ReadLine()); }

Console.Write("k = ");
k = int.Parse(Console.ReadLine());

double[] mas15 = new double[(n + m)];
int j = 0;
for (int i = 0; i < k; i++) { mas15[i] = a[i]; }
for (int i = k; i < (k + m); i++)
{
    mas15[i] = b[j];
    j += 1;
}
j = 0;
for(int i = (k + m); i < (n + m); i++)
{
    mas15[i] = a[k + j]; 
    j += 1;
}
Console.WriteLine("Result: ");
for (int i = 0; i < (m + n); i++) { Console.WriteLine(mas15[i]); }
Console.WriteLine();




Console.WriteLine("Ex 16: ");
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
double[] mas16 = new double[n];
double sum16 = 0;
double[] mas_i = new double[n];
for(int i = 0; i < n; i++) { mas16[i] = double.Parse(Console.ReadLine()); sum16 += mas16[i]; }
p = sum16 / n;
for(int i = 0; i < n; i++)
{
    if (mas16[i] < p) { mas_i[i] = i; }
}
Console.WriteLine("Result: ");
for (int i = 0; i < n; i++) { if (mas_i[i] != 0) { Console.WriteLine(mas_i[i]); } }
Console.WriteLine();




Console.WriteLine("Ex 17: ");
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
double[] mas17 = new double[n];
double sum_p = 0;
double sum_ot = 0;
p = 0;
int ot = 0;
max = 0;
min = 9999999;
max_i = 0;
min_i = 0;
for (int i = 0; i < n; i++) 
{ 
    mas17[i] = double.Parse(Console.ReadLine()); 
    if (mas17[i] > max) { max = mas17[i]; max_i = i; }
    if (mas17[i] < min) { min = mas17[i]; min_i = i; }
}
if  (max_i < min_i)
{
    for (int i = 0; i < n; i++)
    {
        if (mas17[i] > 0) { sum_p += mas17[i]; p += 1; }
    }
    Console.WriteLine("Result: ",  (sum_p / p));
}
else
{
    for (int i = 0; i < n; i++)
    {
        if (mas17[i] < 0) { sum_ot += mas17[i]; ot += 1; }
    }
    Console.WriteLine("Result: ", (sum_ot / ot));
}
Console.WriteLine();




Console.WriteLine("Ex 18: ");
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
double[] mas18 = new double[n];
max = 0;
max_i = 0;
int new_n = n / 2;
for (int i = 0;i < n; i++) 
{ 
    mas18[i] = double.Parse(Console.ReadLine());
    if (mas18[i] > max) { max = mas18[i]; max_i = i; }
}
if (max_i % 2 == 0) 
{
    for(int i = 0; i < new_n; i++) { mas18[i] = 0; }
}
else { for(int i = new_n; i < n; i++) { mas18[i] = 0; } }
Console.WriteLine("Result: ");
for(int i = 0; i < n; i++) { Console.WriteLine(mas18[i]); }

Console.WriteLine();



Console.WriteLine("Ex 19: ");
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
double[] mas19 = new double[n];
max = 0;
max_i = 0;
double sum19 = 0;
for (int i = 0; i < n; i++)
{
    mas19[i] = double.Parse(Console.ReadLine());
    sum19 += mas19[i];
    if (mas19[i] > max) { max = mas19[i]; max_i = i; }
}
if (max > sum19) { mas19[max_i] = 0; }
else { mas19[max_i] *= 2; }
Console.WriteLine("Result: ");
for(int i = 0;i < n; i++) { Console.WriteLine(mas19[i]); }
Console.WriteLine();




Console.WriteLine("Ex 20: ");
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
double[] mas20 = new double[n];
double sum_ch = 0;
double sum_nch = 0;
min = 999999;
min_i = 0;
double sum20 = 0;
p_i = 0;
for (int i = 0; i < n; i++)
{
    mas20[i] = double.Parse(Console.ReadLine());
    sum20 += mas20[i];
    if (mas20[i] < min) { min = mas20[i]; min_i = i; }
}
for (int i = 0; i < n; i++)
{
    if (mas20[i] < 0) { p_i = 0; break; }
}
if (p_i < min_i) 
{
    for (int i = 0; i < n; i += 2)
    {
        sum_ch += mas20[i];
    }
    Console.WriteLine("Result: " + sum_ch);
}

else
{
    for(int i = 1; i < n; i += 2)
    {
        sum_nch += mas20[i];
    }
    Console.WriteLine("Result: " + sum_nch);
}
Console.WriteLine();
