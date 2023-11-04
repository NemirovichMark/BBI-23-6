using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
# region1
            double[] a = new double[6] { 1, 2, 3, 4, 5, 6 };
            double s = 0;
            for (int i=0; i <6; i++)
            {
                s += a[i];
            }
            for (int i = 0; i < 6; i++)
            {
                a[i] = a[i]/s;
            }
#endregion

# region2
            double[] a2 = new double[8] { 10, -9, 87, -10.234, 22, 76, -99, 234 };
            double s2 = 0,k2=0;
            for (int i = 0; i < 8; i++)
            {
                if (a2[i] > 0)
                {
                    s2 += a2[i];
                    k2++;
                }
                
            }
            double sr2 = s2 / k2;
            for (int i = 0; i < 8; i++)
            {
                if (a2[i] > 0)
                {
                    a2[i] = sr2;
                }
            }

#endregion

# region3
            double[] a3 = new double[4] { 10, 405, -123, 98};
            double[] b3 = new double[4] { 1, 2, 3, 4};
            double[] c3 = new double[4];
            double[] d3 = new double[4];
            for (int i = 0; i < 4; i++)
            {
                c3[i] = a3[i] + b3[i];
            }
            for (int i = 0; i < 4; i++)
            {
                d3[i] = a3[i] - b3[i];
            }
#endregion

# region4
            double[] a4 = new double[5] { 10, 405, -123, 98, 111 };
            double sr4 = 0;
            for (int i = 0; i < 5; i++)
            {
                sr4 += a4[i];
            }
            sr4 /= 5;
            for (int i = 0; i < 5; i++)
            {
                a4[i] = a4[i] - sr4;
            }
#endregion

# region5
            double[] vek1 = new double[4] { 10, 405, -12, 33};
            double[] vek2 = new double[4] { 0, 12, 1000, 34 };
            double s5 = 0;
            for (int i = 0; i < 4; i++)
            {
                s5 += vek1[i] * vek2[i];
            }
            Console.WriteLine(s5);
#endregion

# region6
            double[] a6 = new double[5] {1, 2, 3, 4, 5};
            double len6 = 0;
            for (int i = 0; i < 5; i++)
            {
                len6 += a6[i] * a6[i];
            }
            len6 = Math.Sqrt(len6);
            Console.WriteLine(len6);
#endregion

# region7
            double[] a7 = new double[7] { 1, 2, 3, 4, 5, 123, 1000};
            double sr7 = 0;
            for (int i = 0; i < 7; i++)
            {
                sr7 += a7[i];
            }
            sr7 = sr7 / 7;
            for (int i = 0; i < 7; i++)
            {
                if (a7[i] > sr7)
                {
                    a7[i] = 0;
                }
            }
#endregion

# region8
            double[] a8 = new double[6] { 1, 2, 3, 4, 5, 6};
            int k = 0;
            for (int i = 0; i < 6; i++)
            {
                if (a8[i] < 0)
                {
                    k++;
                }
            }
            Console.WriteLine(k);
#endregion

# region9
            double[] a9 = new double[8] {13, 1, 2, 3, 67, 4, 5, 6 };
            double sr9 = 0;
            for (int i = 0; i < 8; i++)
            {
                sr9 += a9[i];
            }
            sr9 = sr9 / 8;
            int k9 = 0;
            for (int i = 0; i < 8; i++)
            {
                if (a9[i] > sr9)
                {
                    k9++;
                }
            }
            Console.WriteLine(k9);
#endregion

# region10
            double[] a10 = new double[10] {1,2,3,4,5,6,7,8,9,11};
            double p10 = 2.5;
            double q10 = 6;

            int k10 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (a10[i] > p10 && a10[i] < q10)
                {
                    k10++;
                }
            }
            Console.WriteLine(k10);
#endregion

# region11
            double[] a11 = new double[10] { 1, 2, 3, -900, 5, -12, -7, 8, 9, -10 };
            int n11 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (a11[i] > 0)
                {
                    n11++;
                }
            }
            double[] b11 = new double[n11];
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                if (a11[i] > 0)
                {
                    b11[j] = a11[i];
                    j++;
                }
            }
#endregion

# region12
            double[] a12 = new double[8] { 1, 2, -5, 6, -99, 80, 77, 6 };
            double n12, el12;
            for (int i = 0; i < 8; i++)
            {
                if (a12[i] < 0)
                {
                    n12 = i;
                    el12 = a12[i];
                }
            }
            Console.WriteLine(n12);
            Console.WriteLine(el12);
#endregion

# region13
            double[] a13 = new double[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            double[] chet = new double[5];
            double[] nechet = new double[5];
            int j = 0;
            for (int i = 0; i <= 8; i += 2)
            {
                chet[j] = a13[i];
                nechet[j] = a13[i + 1];
                j++;
            }
            Console.WriteLine("{0}", string.Join(", ", chet));
            Console.WriteLine("{0}", string.Join(", ", nechet));
#endregion

# region14
            double[] a14 = new double[11] { 0, 1, 2, 3, -99, 4, 5, 6, 7, 8, 9 };
            double s14 = 0;
            for (int i = 0;i < 11; i++)
            {
                if (a14[i] < 0) { 
                    break; 
                }
                else
                {
                    s14 += a14[i] * a14[i];
                }
            }
            Console.WriteLine(s14);
#endregion

# region15
            double[] x15 = new double[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] y15 = new double[10];
            for (int i = 0; i < 10; i++)
            {
                y15[i] = 0.5 * Math.Log(x15[i]);
                Console.WriteLine($"{x15[i]}   {y15[i]}");
            }
#endregion

        }
    }
}