using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _3_лаба
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// номер 1.1
            //int[] a = new int[12];
            //int s = 0;
            //for (int i = 0; i < 12; i += 2)
            //{
            //    a[i] = Convert.ToDouble(Console.ReadLine());
            //    s += a[i];
            //}
            //for (int i = 1; i < 12; i += 2)
            //{
            //    a[i] = s;
            //}
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.Write("{0:d} ", a[i]);
            //}

            //// 1.2
            //double[] a = new double[8];
            //double sum = 0;
            //int k = 8;
            //double sr = 0;
            //for (int i = 0; i < 8; i += 1)
            //{
            //    a[i] = Convert.ToDouble(Console.ReadLine());
            //    if (a[i] > 0)
            //    {
            //        sum += a[i];
            //    }
            //}
            //sr = sum / k;
            //for (int i = 0; i < 8; i += 1)
            //{
            //    if (a[i] > 0)
            //    {
            //        a[i] = sr;
            //    }
            //}
            //for (int i = 0; i < 8; i += 1)
            //{
            //    Console.WriteLine("{0;f} ", a[i]);
            //}

            //// 1.3
            //int[] a = new int[4];
            //for (int i = 0; i < 4; i += 1)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //int[] b = new int[4];
            //for (int i = 0; i < 4; i += 1)
            //{
            //    b[i] = int.Parse(Console.ReadLine());
            //}
            //int[] c = new int[4];
            //for (int i = 0;i < 4; i += 1)
            //{
            //    c[i] = a[i] + b[i];
            //}
            //for (int i = 0; i <= 4; i += 1)
            //{
            //    Console.WriteLine("{0:d} ", c[i]);
            //}

            //// 1.4
            //double[] a = new double[5]{2.0, 3.0, 4.0, 5.0, 6.0};
            //double s = 0;
            //int k = 5;
            //double sr = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    //a[i] = double.Parse(Console.ReadLine());
            //    s += a[i];
            //}
            //sr = s / k;
            //for (int i = 0; i < 5; i++)
            //{
            //    a[i] -= sr;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("{0:f} ", a[i]);
            //}

            //// 1.5
            //int[] a = new int[4];
            //for (int i = 0; i < 4; i += 1)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //int[] b = new int[4];
            //for (int i = 0; i < 4; i += 1)
            //{
            //    b[i] = int.Parse(Console.ReadLine());
            //}
            //int s = 0;
            //for (int i = 0; i < 4; i += 1)
            //{
            //    s += a[i] * b[i];
            //}
            //Console.WriteLine(s);

            //// 1.6
            //int[] a = new int[5];
            //string s;
            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    s = Console.ReadLine();
            //    a[i] = int.Parse(s);
            //    sum += a[i] * a[i];
            //}
            //Console.WriteLine(Math.Sqrt(sum));

            //// 1.7
            //int[] a = new int[7];
            //string s;
            //int k = 7;
            //int sum = 0;
            //double sr = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    s = Console.ReadLine();
            //    a[i] = int.Parse(s);
            //    sum += a[i];
            //}
            //sr = sum / k;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] > sr)
            //    {
            //        a[i] = 0;
            //    }
            //}
            //for (int i = 0; i <= k; i++)
            //{
            //    Console.WriteLine("{0:f} ", a[i]);
            //}

            //// 1.8
            //int[] a = new int[6];
            //int k = 0;
            //string s;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    s = Console.ReadLine();
            //    a[i] = int.Parse(s);
            //    if (a[i] < 0)
            //    {
            //        k += 1;
            //    }
            //}
            //Console.WriteLine(k);

            //// 1.9
            //int[] a = new int[8];
            //int k = 0;
            //string s;
            //double sr;
            //int sum = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    s = Console.ReadLine();
            //    a[i] = int.Parse(s);
            //    sum += a[i];
            //}
            //sr = sum / a.Length;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] > sr)
            //    {
            //        k += 1;
            //    }
            //}
            //Console.WriteLine(k);

            //// 1.10
            //int[] a = new int[10];
            //int k = 0;
            //string s;
            //int P = 10;
            //int Q = 20;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    s = Console.ReadLine();
            //    a[i] = int.Parse(s);
            //    if (a[i] >= P)
            //    {
            //        if (a[i] <= Q)
            //        {
            //            k += 1;
            //        }
            //    }
            //}
            //Console.WriteLine(k);

            //// 1.11
            //int[] a = new int[10];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        a[i] *= -1;
            //    }
            //    Console.WriteLine("{0:d}", a[i]);
            //}

            //// 1.12
            //int[] a = new int[8];
            //int nomber = 0;
            //int b = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //    if (a[i] < 0)
            //    {
            //        nomber = i + 1;
            //        b = a[i];
            //    }
            //}
            //Console.WriteLine(b);
            //Console.WriteLine(nomber);

            //// 1.13
            //int[] a = new int[10];
            //int[] b = new int[5];
            //int[] c = new int[5];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //    if (i % 2 == 0)
            //    {
            //        b[i / 2] = a[i];
            //    }
            //    else
            //    {
            //        c[i / 2] = a[i];
            //    }
            //}
            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.WriteLine(b[i]);
            //}
            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.WriteLine(c[i]);
            //}

            //// 1.14
            //int[] a = new int[11];
            //int s = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //    if (a[i] < 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        s += a[i] * a[i];
            //    }
            //}
            //Console.WriteLine(s);

            //// 1.15
            //double[] x = new double[10];
            //double[] y = new double[10];
            //string s;
            //Console.WriteLine("Введите массив x");
            //for (int i = 0; i < 10; i++)
            //{
            //    s = Console.ReadLine();
            //    x[i] = double.Parse(s);
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    y[i] = 0.5 * Math.Log(x[i]);
            //}
            //Console.WriteLine(" ");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{x[i]} {y[i]}");
            //}

            //// 2.1
            //int[] a = new int[5];
            //int min = 100000;
            //for (int i = 0; i < 5; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //    if (a[i] < min)
            //    {
            //        min = a[i];
            //    }
            //}
            //if (min <= 0)
            //{
            //    min = min / 2;
            //}
            //else
            //{
            //    min *= 2;
            //}
            //Console.WriteLine(min);

            //// 2.2
            //int[] a = new int[5];
            //int sum = 0;
            //int max = -100000;
            //int ni = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //        ni = i;
            //    }
            //}
            //for (int i = 0; i < ni; i++)
            //{
            //    sum += a[i];
            //}
            //Console.WriteLine(sum);

            //// 2.3
            //int[] a = new int[5];
            //int min = 100000;
            //int ni = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //    if (a[i] < min)
            //    {
            //        min = a[i];
            //        ni = i;
            //    }
            //}
            //for (int i = 0; i < ni; i++)
            //{
            //    a[i] *= 2;
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("{0:d}", a[i]);
            //}

            //// 2.4
            //double[] a = new double[5];
            //double max = -100000;
            //int ni = 0;
            //int k = 0;
            //double sum = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    sum += a[i];
            //    k += 1;
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //        ni = i;
            //    }
            //}
            //double sr = 0;
            //sr = sum / k;
            //for (int i = ni+1; i < a.Length; i++)
            //{
            //    a[i] = sr;
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("{0:f}", a[i]);
            //}

            //// 2.5
            //double[] a = new double[5];
            //double max = -100000;
            //double min = 1000000;
            //int ni1 = 0;
            //int ni2 = 0;
            //int maxni = 0;
            //int minni = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //        ni1 = i;
            //    }
            //    if (a[i] < min)
            //    {
            //        min = a[i];
            //        ni2 = i;
            //    }
            //}
            //maxni = Math.Max(ni1, ni2);
            //minni = Math.Min(ni1, ni2);
            //for (int i = minni+1; i < maxni; i++)
            //{
            //    a[i] *= -1;
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //// 2.6
            //double[] a = new double[5];
            //double P = 11;
            //double sum = 0;
            //int k = 0;
            //int ni = 0;
            //double maxb = 10000;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    sum += a[i];
            //    k++;
            //}
            //double sr = sum / k;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (Math.Abs(P - a[i]) < maxb)
            //    {
            //        maxb = Math.Abs(P - a[i]);
            //        ni = i;
            //    }
            //}
            //for (int i = ni + 1; i <= ni + 1; i++)
            //{
            //    a[i] = P;
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("{0:f}", a[i]);
            //}

            //// 2.7
            //double[] a = new double[5];
            //double max = -1000000;
            //int ni = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //        ni = i;
            //    }
            //}
            //for (int i = ni+1; i <= ni+1; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        a[i] /= 2;
            //    }
            //    else
            //    {
            //        a[i] *= 2;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("{0:f}" , a[i]);
            //}

            //// 2.8
            //int[] a = new int[5];
            //int max = -1000000;
            //int min = 1000000;
            //int ni1 = 0;
            //int ni2 = 0;
            //int help = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //        ni1 = i;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (i > ni1)
            //    {
            //        if (a[i] < min)
            //        {
            //            min = a[i];
            //            ni2 = i;
            //        }
            //    }
            //}
            //for (int i = ni1; i <= ni2+1; i++)
            //{
            //    help = a[ni1];
            //    a[ni1] = a[ni2];
            //    a[ni2] = help;
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("{0:d}" , a[i]);
            //}

            //// 2.9
            //double[] a = new double[5];
            //double min = 100000;
            //double max = -100000;
            //int ni1 = 0;
            //int ni2 = 0;
            //int maxi = 0;
            //int mini = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    if (a[i] < min)
            //    {
            //        min = a[i];
            //        ni1 = i;
            //    }
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //        ni2 = i;
            //    }
            //}
            //int k = 0;
            //double sum = 0;
            //maxi = Math.Max(ni1, ni2);
            //mini = Math.Min(ni1, ni2);
            //for (int i = mini+1;  i < maxi; i++)
            //{
            //    sum += a[i];
            //    k += 1;
            //}
            //double sr = sum / k;
            //Console.WriteLine(sr);

            //// 2.10
            //double[] a = new double[5];
            //double[] b = new double[4];
            //double min = 100000;
            //int ni = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    if (a[i] < min & (a[i] > 0))
            //    {
            //        min = a[i];
            //        ni = i;
            //    }
            //}
            //for (int i = 0; i < ni; i++)
            //{
            //    b[i] = a[i];
            //}
            //for (int i = ni + 1; i < a.Length; i++)
            //{
            //    b[i - 1] = a[i];
            //}
            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.WriteLine("{0:f}", b[i]);
            //}

            //// 2.11
            //double[] a = new double[5];
            //double[] b = new double[6];
            //int ni = 0;
            //double P = double.Parse(Console.ReadLine());
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    if (a[i] > 0)
            //    {
            //        ni = i;
            //    }
            //}
            //for (int i = 0; i <= ni; i++)
            //{
            //    b[i] = a[i];
            //}
            //b[ni + 1] = P;
            //for (int i = ni+2; i < b.Length; i++)
            //{
            //    b[i] = a[i - 1];
            //}
            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.WriteLine("{0:f}", b[i]);
            //}

            //// 2.12
            //double[] a = new double[5];
            //double max = -100000;
            //int ni = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //        ni = i;
            //    }
            //}
            //double sum = 0;
            //for (int i = ni+1; i < a.Length; i++)
            //{
            //    sum += a[i];
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        a[i] = sum;
            //        break;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("{0:f}", a[i]);
            //}

            //// 2.13
            //double[] a = new double[5];
            //double max = -100000;
            //int ni = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    if (a[i] > max & i % 2 == 0)
            //    {
            //        max = a[i];
            //        ni = i;
            //    }
            //}
            //a[ni] = ni;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("{0:f}", a[i]);
            //}

            //// 2.14
            //int[] a = new int[5];
            //int max = -1000000;
            //int otr = 0;
            //int ni1 = 0;
            //int ni2 = 0;
            //int help = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //        ni1 = i;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        otr = a[i];
            //        ni2 = i;
            //        break;
            //    }
            //}
            //help = a[ni1];
            //a[ni1] = a[ni2];
            //a[ni2] = help;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("{0:d}", a[i]);
            //}

            //// 2.15
            //double[] a = new double[3];
            //double[] b = new double[4];
            //double[] c = new double[7];
            //int lenb = b.Length;
            //int k = int.Parse(Console.ReadLine());
            //int h = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < b.Length; i++)
            //{
            //    b[i] = double.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < c.Length; i++)
            //{
            //    if (i == k)
            //    {
            //        c[i] = a[i];
            //        for (int j = 0; j < b.Length; j++)
            //        {
            //            c[j + k + 1] = b[j];
            //            h = j + k + 1;
            //        }
            //        break;
            //    }
            //    c[i] = a[i];
            //}
            //for (int i = h + 1; i < c.Length; i++)
            //{
            //    c[i] = a[i - lenb];
            //}
            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.WriteLine("{0:f}", c[i]);
            //}

            //// 2.16
            //double[] a = new double[5];
            //double sr = 0;
            //double sum = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    sum += a[i];
            //}
            //sr = sum / a.Length;
            //int k = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] < sr)
            //    {
            //        k += 1;
            //    }
            //}
            //double[] b = new double[k];
            //int h = 0;
            //for (int i = 0; i < b.Length; i++)
            //{
            //    for (int j = h; j < a.Length; j++)
            //    {
            //        if (a[j] < sr)
            //        {
            //            b[i] = a[j];
            //            h = j+1;
            //            break;
            //        }
            //    }
            //}
            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.WriteLine("{0:f}", b[i]);
            //}

            //// 2.17
            //double[] a = new double[5];
            //double sr = 0;
            //int k = 0;
            //double sum = 0;
            //double max = -10000;
            //double min = 100000;
            //int ni1 = 0;
            //int ni2 = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //        ni1 = i;
            //    }
            //    if (a[i] < min)
            //    {
            //        min = a[i];
            //        ni2 = i;
            //    }
            //}
            //if (ni1 < ni2)
            //{
            //    for (int i = 0; i < a.Length; ++i)
            //    {
            //        if (a[i] > 0)
            //        {
            //            sum += a[i];
            //            k++;
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < a.Length; ++i)
            //    {
            //        if (a[i] < 0)
            //        {
            //            sum += a[i];
            //            k++;
            //        }
            //    }
            //}
            //sr = sum / k;
            //Console.WriteLine(sr);

            //// 2.18
            //double[] a = new double[6];
            //double max1 = -10000;
            //double max2 = -10000;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < a.Length - 1; i+=2)
            //{
            //    if (a[i] > max1)
            //    {
            //        max1 = a[i];
            //    }
            //    if (a[i + 1] > max2)
            //    {
            //        max2 = a[i + 1];
            //    }
            //}
            //if (max1 > max2)
            //{
            //    for (int i = 0; i < a.Length/2; i++)
            //    {
            //        a[i] = 0;
            //    }
            //}
            //else
            //{
            //    for (int i = a.Length/2; i < a.Length; i++)
            //    {
            //        a[i] = 0;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("{0:f}", a[i]);
            //}

            //// 2.19
            //double[] a = new double[6];
            //double max = -10000;
            //int ni = 0;
            //double sum = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    sum += a[i];
            //    if (a[i] > max)
            //    {
            //        max = a[i];
            //        ni = i;
            //    }
            //}
            //if (max > sum)
            //{
            //    a[ni] = 0;
            //}
            //else
            //{
            //    if (a[ni] > 0)
            //    {
            //        a[ni] *= 2;
            //    }
            //    else
            //    {
            //        a[ni] /= 2;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("{0:f}", a[i]);
            //}

            //// 2.20
            //double[] a = new double[5];
            //double min = 100000;
            //int ni = 0;
            //double sum1 = 0;
            //double sum2 = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = double.Parse(Console.ReadLine());
            //    if (a[i] < min)
            //    {
            //        min = a[i];
            //        ni = i;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (i == ni)
            //    {
            //        for (int j = 1; j < a.Length-1; j+=2)
            //        {
            //            sum1 += a[j];
            //        }
            //        Console.WriteLine(sum1);
            //        break;
            //    }
            //    else if (a[i] < 0) 
            //    {
            //        for (int j = 0; j < a.Length; j += 2)
            //        {
            //            sum2 += a[j];
            //        }
            //        Console.WriteLine(sum2);
            //        break;
            //    }
            //}

            //// 3.1
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //int[] im = new int[n];
            //int amax = 0;
            //int k = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] > amax)
            //    {
            //        amax = a[i];
            //        k = 0;
            //        im[k] = i;
            //    }
            //    else if (a[i] == amax)
            //    {
            //        k += 1;
            //        im[k] = i;
            //    }
            //}
            //for (int i = 0; i <= k; i++)
            //{
            //    Console.WriteLine("{0:d}", im[i]);
            //}

            //// 3.2
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //int amax = 0;
            //int imax = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] > amax)
            //    {
            //        amax = a[i];
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    if (a[i] == amax)
            //    {
            //        a[i] += i;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine("{0:f}", a[i]);
            //}
        }
    }
}
