using System;
using System.Diagnostics.Metrics;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1/1
            double[] a = new double[6];
            double s11 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = double.Parse(Console.ReadLine());
                s11 += a[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0:f} ", a[i] / s11);
            }
            Console.WriteLine();
            //1/2 
            double[] a12 = new double[8] { 17, -1, 53, -5, 7, 8, 6, 4 };
            double s12 = 0;
            int m12 = 0;
            for (int i = 0; i < 8; i++)
            {
                if (a12[i] > 0)
                {
                    s12 = s12 + a12[i];
                    m12 += 1;
                }
            }
            double sr12 = s12 / m12;
            Console.WriteLine($"номер 1.2: {sr12}");
            //1 уровень 3 задача
            double[] a13 = new double[4];
            Console.WriteLine("%13 Введите массив 1: ");
            for (int i = 0; i < a13.Length; i++)
            {
                a13[i] = double.Parse(Console.ReadLine());
            }
            double[] A13 = new double[4];
            Console.WriteLine("Введите массив 2: ");
            for (int i = 0; i < a13.Length; i++)
            {
                A13[i] = double.Parse(Console.ReadLine());
            }
            double[] sum13 = new double[4];
            double[] r13 = new double[4];
            for (int i = 0; i < sum13.Length; i++)
            {
                sum13[i] = a13[i] + A13[i];
                r13[i] = a13[i] - A13[i];
            }
            for (int i = 0; i < sum13.Length; i++)
            {
                Console.WriteLine("{0:f} ", sum13[i] + " " + r13[i]);
            }
            //1/4 
            double sr14 = 0;
            double sum14 = 0;
            double[] a14 = new double[5];
            Console.WriteLine("14 Введите массив: ");
            for (int i = 0; i < a14.Length; i++)
            {
                a14[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a14.Length; i++)
            {
                sum14 += a14[i];
            }
            sr14 = sum14 / a14.Length;
            Console.WriteLine("№1_4");
            for (int i = 0; i < a14.Length; i++)
            {
                a14[i] -= sr14;
                Console.Write(a14[i] + " ");
            }
            Console.WriteLine();
            //1/5 
            double sum15 = 0;
            double[] a15 = new double[4];
            Console.WriteLine(" Введите массив 1: ");
            for (int i = 0; i < a15.Length; i++)
            {
                a15[i] = double.Parse(Console.ReadLine());
            }
            double[] A15 = new double[4];
            Console.WriteLine("Введите массив 2: ");
            for (int i = 0; i < A15.Length; i++)
            {
                A15[i] = double.Parse(Console.ReadLine());
            }
            double[] y = new double[4];
            for (int i = 0; i < y.Length; i++)
            {
                y[i] = a15[i] * A15[i];
                sum15 += y[i];
            }
            Console.WriteLine($"№15: {sum15}");
            //1/6 
            double sum16 = 0;
            double l = 0;
            double[] a16 = new double[5];
            Console.WriteLine("%16 Введите х-ы вектора: ");
            for (int i = 0; i < a16.Length; i++)
            {
                a16[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a16.Length; i++)
            {
                sum16 += a16[i] * a16[i];
            }
            l = Math.Sqrt(sum16);
            Console.WriteLine($"№16: {l}");
            //1/7 
            double sr17 = 0;
            double sum17 = 0;
            double[] a17 = new double[7];
            Console.WriteLine("%17 Введите массив: ");
            for (int i = 0; i < a17.Length; i++)
            {
                a17[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a17.Length; i++)
            {
                sum17 += a17[i];
            }
            sr17 = sum17 / a17.Length;
            Console.WriteLine("№17:");
            for (int i = 0; i < a17.Length; i++)
            {
                if (a17[i] > sr17)
                {
                    a17[i] = 0;
                }
                Console.Write(a17[i] + " ");
            }
            Console.WriteLine();
            //1 /8 
            double[] a18 = new double[6];
            string k18;
            int m18 = 0;
            Console.WriteLine("введите массив a");
            for (int i = 0; i < 6; i++)
            {
                k18 = Console.ReadLine();
                a[i] = double.Parse(k18);
            }
            for (int i = 0; i < 6; i++)
            {
                if (a18[i] < 0)
                {
                    m18 += 1;
                }
            }
            Console.WriteLine(m18);
            //1/ 9 
            double sr19 = 0;
            int count19 = 0;
            double summ19 = 0;
            double[] a19 = new double[8];
            Console.WriteLine("%19 Введите массив: ");
            for (int i = 0; i < a19.Length; i++)
            {
                a19[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a19.Length; i++)
            {
                summ19 += a19[i];
            }
            sr19 = summ19 / a19.Length;
            for (int i = 0; i < a19.Length; i++)
            {
                if (a19[i] > sr19)
                {
                    count19++;
                }
            }
            Console.WriteLine($"19: {count19}");
            //1.10 
            Console.WriteLine("Введите р: ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите q ");
            double q = Convert.ToDouble(Console.ReadLine());
            int count110 = 0;
            double[] a110 = new double[10];
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a110.Length; i++)
            {
                a110[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a110.Length; i++)
            {
                if (a110[i] > p & a110[i] < q)
                {
                    count110++;
                }
            }
            Console.WriteLine($"№110: {count110}");
            //1/11
            int[] array = new int[10];
            int[] a111 = new int[10];
            int m = 0;
            Console.WriteLine("№1_11 Введите массив: ");
            for (int i = 0; i < a111.Length; i++)
            {
                a111[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a111.Length; i++)
            {
                if (a111[i] > 0)
                {
                    array[m] = a111[i];
                    m++;
                }
            }
            for (int i = 0; i < m; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            //1/ 12 
            int number = 0;
            int cget1_12 = 0;
            int[] a1_12 = new int[8];
            Console.WriteLine("№1_12 Введите массив: ");
            for (int i = 0; i < a1_12.Length; i++)
            {
                a1_12[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_12.Length; i++)
            {
                if (a1_12[i] < 0)
                {
                    number = a1_12[i];
                    cget1_12 = i;

                }
            }
            Console.WriteLine(number + " " + cget1_12);
            //1/13 
            int[] a1_13 = new int[10];
            int[] chet1_13 = new int[10];
            int[] nechet1_13 = new int[10];
            int m1_13 = 0;
            int n1_13 = 0;
            Console.WriteLine("%1_13 Введите массив: ");
            for (int i = 0; i < a1_13.Length; i++)
            {
                a1_13[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_13.Length; i++)
            {
                if (i % 2 == 0)
                {
                    chet1_13[m1_13] = a1_13[i];
                    m1_13++;
                }
                else
                {
                    nechet1_13[n1_13] = a1_13[i];
                    n1_13++;
                }
            }
            for (int i = 0; i < m1_13; i++)
            {
                Console.Write($"{chet1_13[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < n1_13; i++)
            {
                Console.Write($"{nechet1_13[i]} ");
            }
            //1/ 14 
            int[] a1_14 = new int[11];
            int m1_14 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a1_14.Length; i++)
            {
                a1_14[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a1_14.Length; i++)
            {
                if (a1_14[i] >= 0)
                {
                    a1_14[i] = a1_14[i] + a1_14[i];
                    m1_14 += a1_14[i];
                }
                else { break; }
            }
            Console.WriteLine($"№1_14: {m1_14}");
            //1/ 15 
            double[] x = new double[10];
            double[] y1_15 = new double[10];
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = double.Parse(Console.ReadLine());
            }
            int j = 0;
            for (int i = 0; i < y1_15.Length; i++)
            {
                y1_15[i] = 0.5 * Math.Log(x[i]);
                j++;
            }
            Console.WriteLine("№1_15: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"{x[i]}    {y1_15[i]}");
            }
            //2/1 
            int min2_1 = 100000;
            int[] a2_1 = new int[5];
            int ni2_1 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_1.Length; i++)
            {
                a2_1[i] = int.Parse(Console.ReadLine());
                if (a2_1[i] < min2_1)
                {
                    min2_1 = a2_1[i];
                    ni2_1 = i;
                }
            }
            if (min2_1 >= 0)
            {
                min2_1 = min2_1 * 2;
            }
            else
            {
                min2_1 = min2_1 / 2;
            }
            Console.WriteLine(min2_1);
            //2/2 
            int[] a2_2 = new int[5];
            double max = -100000;
            int ni = 0;
            double sum2_1 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_2.Length; i++)
            {
                a2_2[i] = int.Parse(Console.ReadLine());
                if (a2_2[i] > max)
                {
                    max = a2_2[i];
                    ni = i;
                }
            }
            for (int i = 0; i < ni; i++)
            {
                sum2_1 += a2_2[i];
            }
            Console.WriteLine(sum2_1);
            //2 /3 
            int min2_3 = 100000;
            int[] a2_3 = new int[5];
            int ni2_3 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_3.Length; i++)
            {
                a2_3[i] = int.Parse(Console.ReadLine());
                if (a2_3[i] < min2_3)
                {
                    min2_3 = a2_3[i];
                    ni2_3 = i;
                }
            }
            for (int i = 0; i < ni2_3; i++)
            {
                a2_3[i] *= 2;
                Console.Write($"{a2_3[i]} ");
            }
            Console.WriteLine();
            //2 / 4 
            double[] a2_4 = new double[5];
            double max2_4 = -100000;
            int ni2_4 = 0;
            double sr2_4 = 0;
            double sum2_4 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_4.Length; i++)
            {
                a2_4[i] = double.Parse(Console.ReadLine());
                if (a2_4[i] > max2_4)
                {
                    max2_4 = a2_4[i];
                    ni2_4 = i;
                }
            }
            for (int i = 0; i < a2_4.Length; i++)
            {
                sum2_4 += a2_4[i];
            }
            sr2_4 = sum2_4 / a2_4.Length;
            for (int i = ni2_4; i < a2_4.Length; i++)
            {
                a2_4[i] = sr2_4;
            }
            for (int i = 0; i < a2_4.Length; i++)
            {
                Console.Write($"{a2_4[i]} ");
            }
            Console.WriteLine();
            //2 /5 
            int[] a2_5 = new int[7];
            int ni2_5 = 0;
            int nii2_5 = 0;
            int min2_5 = 100000;
            int max2_5 = -100000;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_5.Length; i++)
            {
                a2_5[i] = int.Parse(Console.ReadLine());
                if (a2_5[i] < min2_5)
                {
                    min2_5 = a2_5[i];
                    ni2_5 = i;
                }
                if (a2_5[i] > max2_5)
                {
                    max2_5 = a2_5[i];
                    nii2_5 = i;
                }
            }
            for (int i = nii2_5; i < ni2_5; i++)
            {
                if (a2_5[i] < 0)
                {
                    Console.Write($"{a2_5[i]} ");
                }
            }
            Console.WriteLine();
            //2/ 6 
            double[] a2_6 = new double[5];
            double P = 11;
            double sum2_6 = 0;
            int k2_6 = 0;
            int ni2_6 = 0;
            double maxb = 10000;
            for (int i = 0; i < a2_6.Length; i++)
            {
                a2_6[i] = double.Parse(Console.ReadLine());
                sum2_6 += a2_6[i];
                k2_6++;
            }
            double sr2_6 = sum2_6 / k2_6;
            for (int i = 0; i < a2_6.Length; i++)
            {
                if (Math.Abs(P - a2_6[i]) < maxb)
                {
                    maxb = Math.Abs(P - a2_6[i]);
                    ni2_6 = i;
                }
            }
            for (int i = ni2_6 + 1; i <= ni2_6 + 1; i++)
            {
                a2_6[i] = P;
            }
            for (int i = 0; i < a2_6.Length; i++)
            {
                Console.WriteLine("{0:f}", a2_6[i]);
            }
            Console.WriteLine();
            //2 /7 
            int[] a2_7 = new int[5];
            int max2_7 = -100000;
            int ni2_7 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_7.Length; i++)
            {
                a2_7[i] = int.Parse(Console.ReadLine());
                if (a2_7[i] > max2_7)
                {
                    max2_7 = a2_7[i];
                    ni2_7 = i;
                }
            }
            Console.WriteLine($"№2_7: {a2_7[ni2_7 + 1] * 2}");
            //2 /8 
            int[] a2_8 = new int[5];
            int max2_8 = -100000;
            int min2_8 = 100000;
            int nii2_8 = 0;
            int ni2_8 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_8.Length; i++)
            {
                a2_8[i] = int.Parse(Console.ReadLine());
                if (a2_8[i] > max2_8)
                {
                    max2_8 = a2_8[i];
                    ni2_8 = i;
                }
            }
            for (int i = ni2_8; i < a2_8.Length; i++)
            {
                if (a2_8[i] < min2_8)
                {
                    min2_8 = a2_8[i];
                    nii2_8 = i;
                }
            }
            for (int i = 0; i < a2_8.Length; i++)
            {
                a2_8[nii2_8] = max2_8;
                Console.Write($"{a2_8[i]} ");
            }
            Console.WriteLine();
            //2/9 
            int[] a2_9 = new int[7];
            int ni2_9 = 0;
            int nii2_9 = 0;
            int min2_9 = 100000;
            int max2_9 = -100000;
            double sum2_9 = 0;
            double sr2_9 = 0;
            double count2_9 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_9.Length; i++)
            {
                a2_9[i] = int.Parse(Console.ReadLine());
                if (a2_9[i] < min2_9)
                {
                    min2_9 = a2_9[i];
                    ni2_9 = i;
                }
                if (a2_9[i] > max2_9)
                {
                    max2_9 = a2_9[i];
                    nii2_9 = i;
                }
            }
            for (int i = ni2_9 + 1; i < nii2_9; i++)
            {
                sum2_9 += a2_9[i];
                count2_9++;
            }
            sr2_9 = sum2_9 / count2_9;
            Console.WriteLine($"№2_9: {sr2_9}");
            //2/10 

            Console.WriteLine("Введите кол-во элементов массива");
            int n210 = Convert.ToInt32(Console.ReadLine());
            double[] a210 = new double[n210];
            string k210;
            Console.WriteLine("Введите массив a");
            for (int i = 0; i < n210; i++)
            {
                k210 = Console.ReadLine();
                a210[i] = double.Parse(k210);
            }
            double a210min = a210[0];
            int i210min = 0;
            for (int i = 0; i < n210; i++)
            {
                if (a210[i] > 0 && a210[i] < a210min)
                {
                    a210min = a[i];
                    i210min = i;
                }
            }
            Console.WriteLine("Минимальный элемент массива");
            Console.WriteLine(a210min);
            for (int i = i210min; i < n210 - 1; i++)
            {
                a210[i] = a210[i + 1];
            }

            Console.WriteLine("Измененный массив");
            for (int i = 0; i < n210 - 1; i++)
            {
                Console.Write($"{a210[i]} ");
            }

            //2/11 
            Console.WriteLine("Введите кол-во элементов массива");
            int n211 = Convert.ToInt32(Console.ReadLine());
            double[] a211 = new double[n211 + 1];
            string k211;
            Console.WriteLine("Введите число Р");
            double P211 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите массив a");
            for (int i = 0; i < n211; i++)
            {
                k211 = Console.ReadLine();
                a211[i] = double.Parse(k211);
            }
            int idx = 0;
            for (int i = n211 - 1; i >= 0; i--)
            {
                if (a211[i] > 0)
                {
                    idx = i;
                    break;
                }
            }
            for (int i = n211; i > idx + 1; i--)
            {
                a211[i] = a211[i - 1];
            }
            a[idx + 1] = P;
            Console.WriteLine("Измененный массив");
            for (int i = 0; i < n211 + 1; i++)
            {
                Console.Write($"{a[i]} ");
            }
            //2/12 
            int[] a2_12 = new int[5];
            int ni2_12 = 0;
            int max2_12 = -1000000;
            int sum2_12 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_12.Length; i++)
            {
                a2_12[i] = int.Parse(Console.ReadLine());
                if (a2_12[i] > max2_12)
                {
                    max2_12 = a2_12[i];
                    ni2_12 = i;
                }
            }
            for (int i = ni2_12 + 1; i < a2_12.Length; i++)
            {
                sum2_12 += a2_12[i];
            }
            for (int i = 0; i < a2_12.Length; i++)
            {
                if (a2_12[i] < 0)
                {
                    a2_12[i] = sum2_12;
                    break;
                }
            }
            for (int i = 0; i < a2_12.Length; i++)
            {
                Console.Write($"{a2_12[i]} ");
            }
            Console.WriteLine();
            //2/13 
            int[] a2_13 = new int[7];
            int[] chet2_13 = new int[4];
            int m2_13 = 0;
            int max2_13 = -1000000;
            int ni2_14 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < a2_13.Length; i++)
            {
                a2_13[i] = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    chet2_13[m2_13] = a2_13[i];
                    m2_13++;
                }
            }
            for (int i = 0; i < chet2_13.Length; i++)
            {
                if (chet2_13[i] > max2_13)
                {
                    max2_13 = chet2_13[i];
                }
            }
            for (int i = 0; i < a2_13.Length; i++)
            {
                if (a2_13[i] == max2_13)
                {
                    Console.WriteLine($"%2_13: {i}");
                }
            }
            //2/14
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите массив: ");
            int[] a2_14 = new int[n];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                a2_14[i] = int.Parse(s);
            }
            int a2_14max = a2_14[0];
            int imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (a2_14[i] > a2_14max)
                {
                    a2_14max = a2_14[i];
                    imax = i;
                }
            }
            int k = -1;
            for (int i = 0; i < n; i++)
            {
                if (a2_14[i] < 0)
                {
                    k = i;
                    break;
                }
            }
            if (imax >= 0 && k >= 0)
            {
                int t = a2_14[imax];
                a2_14[imax] = a2_14[k];
                a2_14[k] = t;
                Console.WriteLine("Получившийся массив: ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a2_14[i]);
                }
            }
            else
            {
                Console.WriteLine("В массиве нет максимальных или отрицательных элементов.");
            }
            //2/ 15 
            Console.WriteLine("Введите количество элементов в массиве A: ");
            int n217 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите массив: ");
            int[] a217 = new int[n];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                a[i] = int.Parse(s);
            }
            Console.WriteLine("Введите количество элементов в массиве В: ");
            int m217 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите массив: ");
            int[] b = new int[m];
            for (int i = 0; i < m; i++)
            {
                string s1 = Console.ReadLine();
                b[i] = int.Parse(s1);
            }
            int[] c = new int[n + m];
            Console.WriteLine("Введите k: ");
            int k217 = int.Parse(Console.ReadLine());
            if (k >= a.Length)
            {
                Console.WriteLine("Не существует такого элемента в массиве А");
            }
            else
            {
                for (int i = 0; i <= k; i++)
                {
                    c[i] = a217[i];
                }
                for (int i = 0; i < m; i++)
                {
                    c[k + i + 1] = b[i];
                }
                for (int i = k + m + 1; i < m + n; i++)
                {
                    c[i] = a217[i - m];
                }
                for (int i = 0; i < m + n; i++)
                {
                    Console.WriteLine(c[i]);
                }
            }
            //2/16
            int[] a2_16 = new int[7];
            double sr2_16 = 0;
            double sum2_16 = 0;
            int t2_16 = 0;
            Console.WriteLine("Введите массив: ");
            for (int i = 0; i < 7; i++)
            {
                a2_16[i] = int.Parse(Console.ReadLine());
                sum2_16 += a2_16[i];
            }
            sr2_16 = sum2_16 / 7;
            for (int i = 0; i < 7; i++)
            {
                if (a2_16[i] < sr2_16)
                {
                    t2_16++;
                }
            }
            int[] A2_16 = new int[t2_16];
            int j2_16 = 0;
            for (int i = 0; i < 7; i++)
            {
                if (a2_16[i] < sr2_16)
                {
                    A2_16[j2_16] = i;
                    Console.Write(A2_16[j2_16] + " ");
                    j2_16++;
                }
            }
            Console.WriteLine();
            //2/17 
            double[] a2_17 = new double[5];
            double sr = 0;
            int k217 = 0;
            double sum = 0;
            double max217 = -10000;
            double min = 100000;
            int ni1 = 0;
            int ni2 = 0;
            for (int i = 0; i < a2_17.Length; i++)
            {
                a2_17[i] = double.Parse(Console.ReadLine());
                if (a2_17[i] > max)
                {
                    max = a2_17[i];
                    ni1 = i;
                }
                if (a2_17[i] < min)
                {
                    min = a2_17[i];
                    ni2 = i;
                }
            }
            if (ni1 < ni2)
            {
                for (int i = 0; i < a2_17.Length; ++i)
                {
                    if (a2_17[i] > 0)
                    {
                        sum += a2_17[i];
                        k++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < a2_17.Length; ++i)
                {
                    if (a2_17[i] < 0)
                    {
                        sum += a2_17[i];
                        k217++;
                    }
                }
            }
            if (k == 0)
            {
                Console.WriteLine("Нет положительных или отрицательных элементов");
            }
            else
            {
                sr = sum / k;
                Console.WriteLine(sr);
                //2/18 
                Console.Write("Введите количество элементов в массиве: ");
                int N = Int32.Parse(Console.ReadLine());
                double[] a2_18 = new double[N];
                double max1 = -10000000;
                double max2 = -10000000;
                int start, end;
                Console.WriteLine("Введите элементы массива: ");
                for (int i = 0; i < N; i++)
                {
                    a2_18[i] = double.Parse(Console.ReadLine());
                    if (i % 2 == 0 & a2_18[i] > max1) max1 = a2_18[i];
                    if (i % 2 == 1 & a2_18[i] > max2) max2 = a2_18[i];
                }
                if (max1 > max2)
                {
                    start = 0;
                    end = (N - N % 2) / 2;
                }
                else
                {
                    start = (N - N % 2) / 2;
                    end = N;
                }

                for (int i = start; i < end; i++)
                {
                    a2_18[i] = 0;
                }
                for (int i = 0; i < N; i++)
                {
                    Console.Write(a2_18[i] + " ");
                }
                Console.WriteLine();
                //2/ 19 
                int sum2_19 = 0;
                int ni2_19 = 0;
                int max2_19 = -10000000;
                int[] a2_19 = new int[7];
                Console.WriteLine("Введите массив: ");
                for (int i = 0; i < a2_19.Length; i++)
                {
                    a2_19[i] = int.Parse(Console.ReadLine());
                    if (a2_19[i] > max2_19)
                    {
                        max2_19 = a2_19[i];
                        ni2_19 = i;
                    }
                    sum2_19 += a2_19[i];
                }
                for (int i = 0; i < a2_19.Length; i++)
                {
                    if (max2_19 > sum2_19)
                    {
                        a2_19[ni2_19] = 0;
                    }
                    else
                    {
                        a2_19[ni2_19] = a2_19[ni2_19] * 2;
                    }
                }
                for (int i = 0; i < a2_19.Length; i++)
                {
                    Console.Write($"{a2_19[i]} ");
                }
                Console.WriteLine();
                //2/ 20 
                double[] a2_20 = new double[7];
                double min2_20 = 10000000;
                double sum2_20 = 0;
                int i11 = 0, i22 = 0;
                int start1 = -1;
                bool flag1 = true;
                Console.WriteLine("Введите элементы массива: ");
                for (int i = 0; i < 8; i++)
                {
                    a2_20[i] = double.Parse(Console.ReadLine());
                    if (a2_20[i] < min2_20)
                    {
                        min2_20 = a2_20[i];
                        i11 = i;
                    }
                    if (a2_20[i] < 0 & flag1 == true)
                    {
                        i22 = i;
                        flag1 = false;
                    }
                }
                if (i22 < i11) start1 = 0;
                else start1 = 1;
                for (int i = start1; i < 8; i += 2)
                {
                    sum2_20 += a2_20[i];
                }
                Console.Write(sum2_20);
                //3/ 2
                Console.WriteLine("Введите n: ");
                int n3_2 = int.Parse(Console.ReadLine());
                double[] a3_2 = new double[n3_2];
                double max3_2 = -1000000000;
                int ni3_2 = 0;
                Console.WriteLine("Введите массив: ");
                for (int i = 0; i < n3_2; i++)
                {
                    a3_2[i] = Convert.ToDouble(Console.ReadLine());
                    if (a3_2[i] > max3_2)
                    {
                        max3_2 = a3_2[i];
                        ni3_2 = i;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (a3_2[i] == max3_2)
                    {
                        a3_2[i] += ni3_2;
                        ni3_2++;
                    }
                }
                for (int i = 0; i < n3_2; i++)
                {
                    Console.Write($"{a3_2[i]} ");
                }
                Console.WriteLine();
                ////3/3 
                int number1 = int.Parse(Console.ReadLine());
                double[] a3_3 = new double[number1];
                for (int i = 0; i < number1; i++)
                {
                    a3_3[i] = Convert.ToDouble(Console.ReadLine());
                }
                double max_number = 0;
                int max_number_index = 0;
                for (int i = 0; i < number1; i++)
                {
                    if (a3_3[i] > max_number)
                    {
                        max_number = a3_3[i];
                        max_number_index = i;
                    }
                }
                double number_nazad = 0;
                for (int i = 1; i < max_number_index; i += 2)
                {
                    number_nazad = a3_3[i];
                    a3_3[i] = a3_3[i - 1];
                    a3_3[i - 1] = number_nazad;
                }
                for (int i = 0; i < number1; i++)
                {
                    Console.Write($"{a3_3[i]} ");
                }
            }

        }
    }