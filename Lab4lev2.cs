using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
# region4
            int n = 7, m = 5;
            double[,] a = new double[n, m];

            Random k = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = k.NextDouble() * 10;
                }
            }

            double[] b = new double[m] { 1000, -3, 666, 9, 1 };

            for (int i = 0;i < m; i++) 
            {
                double max_elem = -10000000;
                int i_strok = -1;
                for (int j = 0;j < n; j++)
                {
                    if (a[j,i] > max_elem)
                    {
                        max_elem = a[j,i];
                        i_strok = j;
                    } 
                }
                if (b[i] > max_elem)
                {
                    a[i_strok, i] = b[i];
                }
            }
#endregion

# region8
            int n = 6, m = 6;
            double[,] a = new double[n, m];

            Random k = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = k.NextDouble() * 10;
                }
            }


            for (int i = 0; i < 6; i+=2)
            {
                double max_elem1 = -10000000;
                int i_max1 = -1;
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > max_elem1)
                    {
                        max_elem1 = a[i, j];
                        i_max1 = j;
                    }
                }

                double max_elem2 = -10000000;
                int i_max2 = -1;
                for (int j = 0; j < n; j++)
                {
                    if (a[i+1, j] > max_elem2)
                    {
                        max_elem2 = a[i+1, j];
                        i_max2 = j;
                    }
                }

                a[i, i_max1] = max_elem2;
                a[i+1, i_max2] = max_elem1;
            }
#endregion
        }
    }
}