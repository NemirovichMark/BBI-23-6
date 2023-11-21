using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
# region4
            double[,] a = new double[3, 6] { { 100, 5, 90.5, 1, 0.5, 8 }, { 4, 5, 6, 4, 5, 6 }, { 7, 8, 9, 8, 9, 7 } };
            double min_elem = 100000;
            int stroka = -1, stolb = -1;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    if (a[i, j] < min_elem)
                    {
                        min_elem = a[i, j];
                        stroka = i;
                        stolb = j;
                    }
                }
            }
            Console.WriteLine(stroka);
            Console.WriteLine(stolb);

#endregion

# region8
            double[,] a2 = new double[4, 6] { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 }, { 13, 14, 15, 16, 17, 18 }, { 19, 20, 21, 22, 23, 24 } };
            double[] b2 = new double[4];
            for (int i = 0; i < 4; ++i)
            {
                double sr = 0;
                int kol = 0;
                for (int j = 0; j < 6; ++j)
                {
                    if ((a2[i, j] > 0)) {
                        sr += a2[i, j];
                        kol++;
                    }
                }
                if (kol > 0)
                {
                    b2[i] = sr / kol;
                }
                else { b2[i] = 0; }
            }
#endregion

# region12
            double[,] a3 = new double[6, 7] { { }, { }, { }, { }, { }, { } };
            double[,] b3 = new double[5, 6];
            double max_elem = -10000000;
            int stroka = -1, stolb = -1;
            for (int i = 0; i < 6; ++i)
            {
                for (int j = 0; j < 7; ++j)
                {
                    if (a[i, j] > max_elem)
                    {
                        max_elem = a[i, j];
                        stroka = i;
                        stolb = j;
                    }
                }
            }
            for (int i = 0; i < 5; ++i)
            {
                if (i < stroka)
                {
                    for (j = 0; j < 6; ++i) {
                        b3[i, j] = a3[i, j];
                    }
                }
                else if (i > stroka)
                {
                    for (j = 0; j < 6; ++i)
                    {
                        b3[i - 1, j] = a3[i, j];
                    }
                }
            }

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("{0}", string.Join(", ", b3[i]));
            }
#endregion

# region16
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            double[,] a4 = new double[n, m];

            Random k = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a4[i, j] = k.NextDouble() * 100;
                }
            }

            for (int i = 0; i < n ; i++)
            {
                double max_elem = -100000;
                int i_max = -1;
                for (int j = 0; j<m; j++)
                {
                    if (a4[i,j] > max_elem)
                    {
                        max_elem = a4[i,j];
                        i_max = j;
                    }
                }
                double p = 0;
                for (int j = i_max+1; j < m; j++)
                {
                    p = a4[i, j - 1];
                    a4[i, j - 1] = a4[i, j];
                    a4[i, j] = p;
                }
        
            }
#endregion

# region20
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            double[,] f = new double[n, m];

            Random k = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    f[i, j] = k.NextDouble() * 10;
                }
            }

            for (int i = 0; i < n; i++)
            {
                double max_elem = -100000;
                int i_max = -1;
                int i_first_otr = -1, i_last_otr = -1;
                for (int j = 0; j < m; j++)
                {
                    if (f[i,j] < 0 && i_first_otr != -1)
                    {
                        i_first_otr = j;
                    }
                    if (f[i,j] < 0)
                    {
                        i_last_otr = j;
                    }
                    if (f[i, j] > max_elem)
                    {
                        max_elem = f[i, j];
                        i_max = j;
                    }
                }
                f[i, i_max] = (f[i, i_first_otr] + f[i, i_last_otr]) / 2;
            }
#endregion

# region24
            int n = 6, m = 5;
            double[,] f = new double[n, m];

            Random k = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    f[i, j] = k.NextDouble() * k.Next(-10,10);
                }
            }

            for (int i = 0; i < n; i++)
            {
                double max_elem = -100000;
                int i_max = -1;
                int i_first_otr = -1, i_last_otr = -1;
                for (int j = 0; j < m; j++)
                {
                    if (f[i, j] > max_elem)
                    {
                        max_elem = f[i, j];
                        i_max = j;
                    }
                }

                double sr = 0;
                int kolvo = 0;
                for (int j=i_max+1; j < m; j++)
                {
                    if (f[i, j] > 0)
                    {
                        kolvo++;
                        sr += f[i, j];
                    }
                }
                sr /= kolvo;

                for (int j=0; j < i_max; ++j)
                {
                    if (f[i, j] < 0)
                    {
                        f[i,j] = sr;
                    }
                }
            }
#endregion


# region28
            int n = 7, m = 5;
            double[,] aa = new double[n, m];

            Random k = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    aa[i, j] = k.NextDouble() * 10;
                }
            }

            int i_max_stroka = -1;
            double max_s = -100000;
            for (int i = 0; i < n; i++)
            {
                double s = 0;
                for (int j = 0;j < m; j++)
                {
                    if (aa[i, j] > 0)
                    {
                        s += aa[i, j];
                    }
                }
                if (s > max_s)
                {
                    max_s = s;
                    i_max_stroka = i;
                }
            }

            double[,] aa2 = new double[n - 1, m];
            for (int i = 0; i < n; i++)
            {
                if (i < i_max_stroka)
                {
                    for (int j = 0; j < m; ++j)
                    {
                        aa2[i, j] = aa[i, j];
                    }
                }
                else if (i > i_max_stroka)
                {
                    for (int j = 0; j < m; ++j)
                    {
                        aa2[i - 1, j] = aa[i, j];
                    }
                }
            }
#endregion

# region32
            int n = 5, m = 7;
            double[,] aa = new double[n, m];

            Random k = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    aa[i, j] = k.NextDouble() * 10;
                }
            }

            for (int i = 0; i < n; i++)
            {
                double max_elem = -100000;
                int i_max = -1;
                int kolvo = 0;
                double sr = 0;
                for (int j = 0; j < m; j++)
                {
                    if (aa[i, j] > max_elem)
                    {
                        max_elem = aa[i, j];
                        i_max = j;
                    }
                    if (aa[i,j] > 0)
                    {
                        sr += aa[i, j];
                        kolvo++;
                    }
                }
                aa[i,i_max] = sr/kolvo;
            }
#endregion

        }
    }
}
