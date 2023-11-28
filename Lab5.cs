using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int MaxElemID(int n, double[,] m)
        {
            double max_elem = -10000000000;
            int id_max = -1;
            for (int i = 0; i < n - 1; i++)
            {
                if (m[i, i] > max_elem)
                {
                    id_max = i;
                    max_elem = m[i, i];
                }
            }
            return id_max;
        }

        public static double[,] Delete_Stolb(int n, int n2, double[,] m, int stolb)
        {
            double[,] a2 = new double[n, n2 - 1];
            for (int i = 0; i < n; i++)
            {
                int i2 = 0;
                for (int j = 0; j < n2; j++)
                {
                    if (j != stolb)
                    {
                        a2[i, i2] = m[i, j];
                        i2++;
                    }
                }
            }
            return a2;
        }

        public static double[] Count_otr_v_stroks(int n, int n2, double[,] m)
        {
            double[] a2 = new double[n];
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n2; j++)
                {
                    if (m[i, j] < 0)
                    {
                        count++;
                    }
                }
                a2[i] = count;
            }
            return a2;
        }

        public static double[] Max_otr_v_strolb(int n, int n2, double[,] m)
        {
            double[] a2 = new double[n2];
            for (int i = 0; i < n2; i++)
            {
                double maxel = -10000000000000000;
                for (int j = 0; j < n; j++)
                {
                    if (m[j, i] < 0 && m[j, i] > maxel)
                    {
                        maxel = m[j, i];
                    }
                }
                if (maxel == -10000000000000000)
                {
                    a2[i] = 0;
                }
                else
                {
                    a2[i] = maxel;
                }
            }
            return a2;
        }

        public static int Count_otr(double[] m)
        {
            int n = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] < 0) { n++; }
            }
            return n;
        }

        public static double[] Otrs(int n, double[] m)
        {
            double[] a = new double[n];
            int j = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] < 0)
                {
                    a[j] = m[i];
                    j++;
                }
            }
            return a;
        }

        public static double[] Id_otrs(int n, double[] m)
        {
            double[] a = new double[n];
            int j = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] < 0)
                {
                    a[j] = i;
                    j++;
                }
            }
            return a;
        }

        public static double[] Sort_otr_num(double[] m)
        {
            int n = Count_otr(m);
            double[] id_otrs = Id_otrs(n, m);
            double[] otrs = Otrs(n, m);


            for (int i1 = 0; i1 < n; i1++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (otrs[j] < otrs[j + 1])
                    {
                        double d = otrs[j];
                        otrs[j] = otrs[j + 1];
                        otrs[j + 1] = d;
                    }
                }
            }


            double[] a = new double[m.Length];
            int j2 = 0;
            for (int i = 0; i < m.Length; i++)
            {

                if (j2 >= id_otrs.Length || i != id_otrs[j2])
                {
                    a[i] = m[i];
                }
                else
                {
                    a[i] = otrs[j2];
                    j2++;
                }
            }
            return a;
        }

        static void Main(string[] args)
        {
            //# region4

            //            int n = 5;
            //            double[,] a = new double[n, n];
            //            double[,] b = new double[n, n];

            //            Random k = new Random();
            //            for (int i = 0; i < n; i++)
            //            {
            //                for (int j = 0; j < n; j++)
            //                {
            //                    a[i, j] = Math.Round(k.NextDouble() * 10);
            //                    b[i, j] = Math.Round(k.NextDouble() * 10);
            //                }
            //            }

            //            Console.WriteLine("Before A:");
            //            for (int i = 0; i < n; i++)
            //            {
            //                for (int j = 0; j < n; j++)
            //                {
            //                    Console.Write(a[i, j] + " ");
            //                }
            //                Console.WriteLine();
            //            }
            //            Console.WriteLine();

            //            Console.WriteLine("Before B:");
            //            for (int i = 0; i < n; i++)
            //            {
            //                for (int j = 0; j < n; j++)
            //                {
            //                    Console.Write(b[i, j] + " ");
            //                }
            //                Console.WriteLine();
            //            }
            //            Console.WriteLine();

            //            int id_stroka_a_maxelem = MaxElemID(5, a);
            //            int id_stolb_b_maxelem = MaxElemID(5, b);


            //            for (int i = 0; i < n; i++)
            //            {
            //                double z = a[id_stroka_a_maxelem, i];
            //                a[id_stroka_a_maxelem, i] = b[i, id_stolb_b_maxelem];
            //                b[i, id_stolb_b_maxelem] = z;
            //            }

            //            Console.WriteLine("After A:");
            //            for (int i = 0; i < n; i++)
            //            {
            //                for (int j = 0; j < n; j++)
            //                {
            //                    Console.Write(a[i, j] + " ");
            //                }
            //                Console.WriteLine();
            //            }
            //            Console.WriteLine();

            //            Console.WriteLine("After B:");
            //            for (int i = 0; i < n; i++)
            //            {
            //                for (int j = 0; j < n; j++)
            //                {
            //                    Console.Write(b[i, j] + " ");
            //                }
            //                Console.WriteLine();
            //            }
            //            Console.WriteLine();
            //#endregion

            //#region 10
            //int n = int.Parse(Console.ReadLine());
            //double[,] a = new double[n, n];

            ////Random k = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        a[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(a[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //int id_stolb_maxelem = -1;
            //double maxel = -100000000000;
            //int id_stolb_minelem = -1;
            //double minel = 100000000000;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j > i)
            //        {
            //            if (a[i, j] < minel)
            //            {
            //                minel = a[i, j];
            //                id_stolb_minelem = j;
            //            }
            //        }
            //        else
            //        {
            //            if (a[i, j] > maxel)
            //            {
            //                maxel = a[i, j];
            //                id_stolb_maxelem = j;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(id_stolb_maxelem);
            //Console.WriteLine(id_stolb_minelem);
            //Console.WriteLine();

            //a = Delete_Stolb(n, n, a, id_stolb_maxelem);

            //if (id_stolb_maxelem != id_stolb_minelem)
            //{
            //    a = Delete_Stolb(n, n - 1, a, id_stolb_minelem - 1);

            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n - 2; j++)
            //        {
            //            Console.Write(a[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n - 1; j++)
            //        {
            //            Console.Write(a[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}



            //#endregion

            //            #region 16
            //            Console.WriteLine("first m");
            //            int n = int.Parse(Console.ReadLine());
            //            double[] a = new double[n];

            //            for (int i = 0; i < n; i++)
            //            {
            //                a[i] = double.Parse(Console.ReadLine());
            //            }

            //            Console.WriteLine("second m");
            //            int n2 = int.Parse(Console.ReadLine());
            //            double[] a2 = new double[n2];

            //            for (int i = 0; i < n2; i++)
            //            {
            //                a2[i] = double.Parse(Console.ReadLine());
            //            }


            //            for (int i = 0; i < n; i++)
            //            {
            //                Console.Write(a[i] + " ");

            //            }
            //            Console.WriteLine();

            //            for (int i = 0; i < n2; i++)
            //            {
            //                Console.Write(a2[i] + " ");

            //            }
            //            Console.WriteLine();

            //            a = Sort_otr_num(a);
            //            a2 = Sort_otr_num(a2);

            //            for (int i = 0; i < n; i++)
            //            {
            //                Console.Write(a[i] + " ");

            //            }

            //            Console.WriteLine();
            //            for (int i = 0; i < n2; i++)
            //            {
            //                Console.Write(a2[i] + " ");

            //            }

            //            #endregion

            //# region 22
            //            int n = int.Parse(Console.ReadLine());
            //            int n2 = int.Parse(Console.ReadLine());
            //            double[,] a = new double[n, n2];


            //            for (int i = 0; i < n; i++)
            //            {
            //                for (int j = 0; j < n2; j++)
            //                {
            //                    a[i, j] = double.Parse(Console.ReadLine());
            //                }
            //            }

            //            for (int i = 0; i < n; i++)
            //            {
            //                for (int j = 0; j < n2; j++)
            //                {
            //                    Console.Write(a[i, j] + " ");
            //                }
            //                Console.WriteLine();
            //            }
            //            Console.WriteLine();

            //            double[] ans1 = Count_otr_v_stroks(n, n2, a);
            //            double[] ans2 = Max_otr_v_strolb(n, n2, a);

            //            for (int i = 0; i < n; i++)
            //            {
            //                Console.Write(ans1[i] + " ");
            //            }
            //            Console.WriteLine();

            //            for (int i = 0; i < n; i++)
            //            {
            //                Console.Write(ans2[i] + " ");
            //            }
            //            #endregion

        }
    }
}

