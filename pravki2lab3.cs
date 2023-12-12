using System;
internal class Program
{
    private static void Main(string[] args)
    {
        {
            //2/7


            //Console.WriteLine("ведите количество элементов массива: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("введите массив: ");
            //int[] a = new int[n];
            //string s;
            //for (int i = 0; i < n; i++)
            //{
            //    s = Console.ReadLine();
            //    a[i] = int.Parse(s);
            //}
            //int amax = a[0];
            //int imax = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (a[i] > amax)
            //    {
            //        amax = a[i];
            //        imax = i;
            //    }
            //}

            //if (imax < n - 1)
            //{
            //    a[imax + 1] *= 2;
            //    Console.WriteLine("элемент, увеличенный в 2 раза: ");
            //    Console.WriteLine(a[imax + 1]);
            //}
            //else
            //{
            //    Console.WriteLine("максимальный элемент находится в последней позиции массива");
            //}


            ////2/9
            //Console.WriteLine("введите количество элементов массива");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double[] a = new double[n];
            //string k;
            //Console.WriteLine("введите массив a");
            //for (int i = 0; i < n; i++)
            //{
            //    k = Console.ReadLine();
            //    a[i] = double.Parse(k);
            //}
            //double amax = a[0];
            //int imax = 0;
            //double amin = a[0];
            //int imin = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (amax < a[i])
            //    {
            //        amax = a[i];
            //        imax = i;
            //    }
            //    if (a[i] < amin)
            //    {
            //        amin = a[i];
            //        imin = i;
            //    }
            //}

            //double sum = 0;
            //int m = 0;
            //double sr;
            //int min, max;
            //if (imin < imax)
            //{
            //    min = imin;
            //    max = imax;
            //}
            //else if (imin > imax)
            //{
            //    min = imax;
            //    max = imin;
            //}
            //else
            //{
            //    min = imax;
            //    max = imin;
            //}
            //for (int i = min + 1; i < max; i++)
            //{
            //    sum = sum + a[i];
            //    m = m + 1;
            //}
            //sr = sum / m;
            //Console.WriteLine("среднее арифметическое ");
            //Console.WriteLine(sr);
            //2//11
            Console.WriteLine("введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("введите число P: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("введите элементы массива:");
            int lastIndex = -1;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                a[i] = int.Parse(s);
                if (a[i] > 0)
                {
                    lastIndex = i;
                }
            }
            if (lastIndex >= 0)
            {
                int[] b = new int[n + 1];
                for (int i = 0; i <= lastIndex; i++)
                {
                    b[i] = a[i];
                }
                b[lastIndex + 1] = p;
                for (int i = lastIndex + 2; i < n + 1; i++)
                {
                    b[i] = a[i - 1];
                }
                a = b;
                n++;
                Console.WriteLine("полученный массив:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0} ", a[i]);
                }
            }
            else
            {
                Console.WriteLine("в массиве нет положительных элементов.");
            }
        }
    }

}

   
