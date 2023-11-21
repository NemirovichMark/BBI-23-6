using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
# region3
            int n = int.Parse(Console.ReadLine());
            double[,] a = new double[n, n];
            double[] ans = new double[n * 2 - 1];



            Random k = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Math.Round(k.NextDouble() * 10);
                    ans[j - i + n - 1] += a[i, j];
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("{0}", string.Join(", ", ans));
#endregion

# region6
            int n = int.Parse(Console.ReadLine());
            double[,] a = new double[n, n];

            double[] ans_verh = new double[n * (n + 1) / 2];
            double[] ans_niz = new double[n * (n - 1) / 2];
            int id1 = 0, id2 = 0;

            Random k = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Math.Round(k.NextDouble() * 10);
                    if (j >= i)
                    {
                        ans_verh[id1] = a[i, j];
                        id1++;
                    }
                    else
                    {
                        ans_niz[id2] = a[i, j];
                        id2++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            int e1 = 0;
            for (int i = n; i > 0; i -= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(ans_verh[e1] + " ");
                    e1++;
                }
                Console.WriteLine();
            }

            int e = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(ans_niz[e] + " ");
                    e++;
                }
                Console.WriteLine();
            }
#endregion

# region10
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            double[,] a = new double[n, m];

            Random k = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Math.Round(k.NextDouble() * 10);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
            }

            //четные - по убыванию
            for (int i = 0; i < n; i+=2)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m - 1; j++)
                    {
                        if (a[i,j] < a[i,j + 1])
                        {
                            double d = a[i,j];
                            a[i,j] = a[i,j + 1];
                            a[i,j + 1] = d;
                        }
                    }
                }
            }

            //нечетные - возрастание
            for (int i = 1; i < n; i += 2)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m - 1; j++)
                    {
                        if (a[i, j] > a[i, j + 1])
                        {
                            double d = a[i, j];
                            a[i, j] = a[i, j + 1];
                            a[i, j + 1] = d;
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
            }

#endregion
        }
    }
}