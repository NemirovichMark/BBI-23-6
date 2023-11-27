using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Лаба_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1.3
            //int[,] a = new int[4,4];
            //int s  = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        a[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    s += a[i, i];   
            //}
            //Console.WriteLine(s);

            //// 1.7
            //int[,] a = new int[3, 5];
            //int s = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //int[] b = new int[5];
            //for (int j = 0; j < 5; j++)
            //{
            //    int max = -100000;
            //    for (int i = 0; i < 3; i++)
            //    {
            //        if (a[i, j] > max)
            //        {
            //            max = a[i, j];
            //        }
            //    }
            //    b[j] = max;
            //}
            //for (int i = 0;i < 5; i++)
            //{
            //    Console.WriteLine("{0:d}", b[i]);
            //}

            //// 1.11
            //int[,] a = new int[5, 7];
            //int[,] b = new int[4, 7];
            //int ni = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //int min = 100000;
            //for (int j = 0; j < 1; j++)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (a[i, j] < min)
            //        {
            //            min = a[i, j];
            //            ni = i;
            //        }
            //    }
            //}
            //for (int i = 0; i < ni; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        b[i, j] = a[i, j];
            //    }
            //}
            //for (int i = ni+1; i < 5; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        b[i-1, j] = a[i, j];
            //    }
            //}
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        Console.WriteLine(b[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// 1.15
            //// a.GetLength(0); <-------
            //int[,] a = new int[5, 7];
            //int ni = 0;
            //int nj = 0;
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    int max = -100000;
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        if (a[i, j] > max)
            //        {
            //            max = a[i, j];
            //            ni = i;
            //            nj = j;
            //        }
            //        if (j+1 == a.GetLength(1)) 
            //        {
            //            a[ni,nj] *= (i+1);
            //        }
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// 1.19
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //double[,] a = new double[n, m];
            //int ni = 0;
            //int nj = 0;
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    double max = -1000000;
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        if (a[i, j] > max)
            //        {
            //            max = a[i, j];
            //            ni = i;
            //            nj = j;
            //        }
            //        if (j+1 == a.GetLength(1)) 
            //        {
            //            for (int k = ni; k < ni+1; k++)
            //            {
            //                for (int l = 0; l < a.GetLength(1); l++)
            //                {
            //                    if (a[k, l] < 0)
            //                    {
            //                        a[k, l] = (a[k, l] / max);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// 1.23
            //double[,] a = new double[2, 4];
            //int ni = 0;
            //int nj = 0;
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        if (j+1 == a.GetLength(1))
            //        {
            //            a[i, j] = 0;
            //        }
            //        else
            //        {
            //            a[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    double max = -1000000;
            //    for (int j = 0; j < a.GetLength(1)-1; j++)
            //    {
            //        if (a[i, j] > max)
            //        {
            //            max = a[i, j];
            //            ni = i;
            //            nj = j;
            //        }
            //        if (j + 1 == a.GetLength(1)-1)
            //        {
            //            for (int k = ni; k < a.GetLength(0); k++)
            //            {
            //                for (int s = a.GetLength(1)-1; s > nj+1; s--)
            //                {
            //                    a[k, s] = a[k, s-1];
            //                }
            //                a[ni,nj+1] = max;
            //                break;
            //            }
            //        }
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// 1.27
            //double[,] a = new double[5, 7];
            //int ni = 0;
            //int nj = 0;
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //double[] b = new double[a.GetLength(0)];
            //for (int i = a.GetLength(0)-1; i > -1; i--)
            //{
            //    double max = -100000;
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        if (a[i, j] > max)
            //        {
            //            max = a[i, j];
            //            ni = i; nj = j;
            //        }
            //        if (j+1 == a.GetLength(1))
            //        {
            //            b[i] = max;
            //        }
            //    }
            //}
            //double help = 0;
            //for (int i = 0; i < b.Length; i++)
            //{
            //    help = b[i];
            //    b[i] = b[b.Length - 1 - i];
            //    b[b.Length - 1 - i] = help;
            //}
            //for (int j = 3; j < 4; j++)
            //{
            //    for (int i = 0; i < a.GetLength(0); i++)
            //    {
            //        a[i, j] = b[i];
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// 1.31
            //double[,] a = new double[5, 8];
            //double[] b = new double[a.GetLength(0)];
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    b[i] = double.Parse(Console.ReadLine());
            //}
            //int ni = 0;
            //int nj = 0;
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1)-1; j++)
            //    {
            //        a[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = a.GetLength(0)-1; i < a.GetLength(0); i++)
            //{
            //    double min = 100000;
            //    for (int j = 0; j < a.GetLength(1) - 1; j++)
            //    {
            //        if (a[i, j] < min) 
            //        {
            //            min = a[i, j];
            //            nj = j;
            //        }
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = a.GetLength(1)-1; j > nj; j--)
            //    {
            //        a[i,j] = a[i,j-1];
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = nj+1; j < nj+2; j++)
            //    {
            //        a[i, j] = b[i];
            //    }
            //}

            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// 2.2
            //double[,] a = new double[7, 5];
            //int ni = 0;
            //int nj = 0;
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        a[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}
            //for (int j = 0; j < a.GetLength(1); j++)
            //{
            //    int kp = 0;
            //    int ko = 0;
            //    double max = -1000000;
            //    for (int i = 0; i < a.GetLength(0); i++)
            //    {
            //        if (a[i, j] > 0)
            //        {
            //            kp++;
            //        }
            //        else
            //        {
            //            ko++;
            //        }
            //        if (a[i, j] > max)
            //        {
            //            max = a[i, j];
            //            ni = i; nj = j;
            //        }
            //        if (i+1 == a.GetLength(0))
            //        {
            //            if (kp > ko)
            //            {
            //                a[ni,nj] = 0;
            //            }
            //            else if (ko > kp)
            //            {
            //                a[ni, nj] = ni;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// 2.6
            //int n = int.Parse(Console.ReadLine());
            //double[,] a = new double[n, 3 * n];
            //double[,] b = new double[n, n];
            //double[,] c = new double[n, n];
            //double[,] d = new double[n, n];
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        b[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < c.GetLength(0); i++)
            //{
            //    for (int j = 0; j < c.GetLength(1); j++)
            //    {
            //        c[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < d.GetLength(0); i++)
            //{
            //    for (int j = 0; j < d.GetLength(1); j++)
            //    {
            //        d[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < (a.GetLength(1)/3); j++)
            //    {
            //        a[i, j] = b[i, j];
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = (a.GetLength(1) / 3); j < (a.GetLength(1)/3*2); j++)
            //    {
            //        a[i, j] = c[i, j - (a.GetLength(1) / 3)];
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = (a.GetLength(1)/3*2); j < a.GetLength(1); j++)
            //    {
            //        a[i, j] = d[i, j-(a.GetLength(1) * 2 / 3)];
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// 3.1
            //double[,] a = new double[2, 3];
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        a[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}
            //double[] minValues = new double[a.GetLength(0)];
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    double min = a[i, 0];
            //    for (int j = 1; j < a.GetLength(1); j++)
            //    {
            //        if (a[i, j] < min)
            //        {
            //            min = a[i, j];
            //        }
            //    }
            //    minValues[i] = min;
            //}
            //for (int i = 0; i < a.GetLength(0) - 1; i++)
            //{
            //    for (int j = i + 1; j < a.GetLength(0); j++)
            //    {
            //        if (minValues[j] > minValues[i])
            //        {
            //            double temp = minValues[i];
            //            minValues[i] = minValues[j];
            //            minValues[j] = temp;
            //            for (int k = 0; k < a.GetLength(1); k++)
            //            {
            //                temp = a[i, k];
            //                a[i, k] = a[j, k];
            //                a[j, k] = temp;
            //            }
            //        }
            //    }
            //}
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.WriteLine(a[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //// 3.2
            //int n = int.Parse(Console.ReadLine());
            //int[,] a = new int[n, n];
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        a[i, j] = int.Parse(Console.ReadLine());
            //        if (i == n - 1 || j == 0 || j == n - 1 || i == 0)
            //        {
            //            a[i, j] = 0;
            //        }
            //    }
            //}

            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write(a[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
