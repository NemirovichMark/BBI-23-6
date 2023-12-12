using System;
class HelloWorld
{
    static void Main()
    {
        // задание 5
        //static int findmax(int[,]a, int nomber)
        //{
        //    int maxi = 0;
        //    for (int i = 0; i < a.GetLength(0); i++)
        //    {
        //        if (a[i,nomber] > a[maxi, nomber])
        //        {
        //            maxi = i;
        //        }
        //    }
        //    return maxi;
        //}
        //static void Main(string[] args)
        //{
        //    int[,] a = new int[4,6];
        //    int[,] b = new int[6,6];
        //    Random random = new Random();
        //    for (int i = 0;i < a.GetLength(0);i++) 
        //    {
        //        for (int j = 0;j < a.GetLength(1); j++)
        //        {
        //            a[i,j] = random.Next(100);
        //        }
        //    }
        //    for (int i = 0; i < b.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < b.GetLength(1); j++)
        //        {
        //            b[i, j] = random.Next(100);
        //        }
        //    }
        //    Console.WriteLine("Матрица А до изменений");
        //    for (int i = 0; i < a.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < a.GetLength(1); j++)
        //        {
        //            Console.Write(a[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("Матрица В до изменений");
        //    for (int i = 0; i < b.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < b.GetLength(1); j++)
        //        {
        //            Console.Write(b[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //    int maxia = findmax(a, 0);
        //    int maxib = findmax(b, 0);
        //    for (int j = 0; j < a.GetLength(1); j++)
        //    {
        //        int help = a[maxia, j];
        //        a[maxia, j] = b[maxib, j];
        //        b[maxib, j] = help;
        //    }
        //    Console.WriteLine("Матрица A после изменений");
        //    for (int i = 0; i < a.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < a.GetLength(1); j++)
        //        {
        //            Console.Write(a[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("Матрица В после изменений");
        //    for (int i = 0; i < b.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < b.GetLength(1); j++)
        //        {
        //            Console.Write(b[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        // задание 11
        //static int findImax(int[,] a)
        //{
        //    int max = a[0,0];
        //    int ni = 0;
        //    for (int i = 0; i < a.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < a.GetLength(1); j++)
        //        {
        //            if (a[i,j] > max)
        //            {
        //                max = a[i,j]; ni = i;
        //            }
        //        }
        //    }
        //    return ni;
        //}
        //static int findJmax(int[,] a)
        //{
        //    int max = a[0, 0];
        //    int nj = 0;
        //    for (int i = 0; i < a.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < a.GetLength(1); j++)
        //        {
        //            if (a[i, j] > max)
        //            {
        //                max = a[i, j]; nj = j;
        //            }
        //        }
        //    }
        //    return nj;
        //}
        //static void Main(string[] args)
        //{
        //    int[,] a = new int[2, 2];
        //    int[,] b = new int[2, 2];
        //    Random random = new Random();
        //    for (int i = 0; i < a.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < a.GetLength(1); j++)
        //        {
        //            a[i, j] = random.Next(100);
        //        }
        //    }
        //    for (int i = 0; i < b.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < b.GetLength(1); j++)
        //        {
        //            b[i, j] = random.Next(100);
        //        }
        //    }
        //    Console.WriteLine("Матрица А до изменений");
        //    for (int i = 0; i < a.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < a.GetLength(1); j++)
        //        {
        //            Console.Write(a[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("Матрица В до изменений");
        //    for (int i = 0; i < b.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < b.GetLength(1); j++)
        //        {
        //            Console.Write(b[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }

        //    int help = a[findImax(a), findJmax(a)];
        //    a[findImax(a), findJmax(a)] = b[findImax(b), findJmax(b)];
        //    b[findImax(b), findJmax(b)] = help;
        //    Console.WriteLine("Матрица A после изменений");
        //    for (int i = 0; i < a.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < a.GetLength(1); j++)
        //        {
        //            Console.Write(a[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("Матрица В после изменений");
        //    for (int i = 0; i < b.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < b.GetLength(1); j++)
        //        {
        //            Console.Write(b[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        // задание 17
        //static void Main()
        //{

        //    int[,] A = new int[4, 6]
        //        {
        //    { 1,2,3,4,5,6},
        //    { 7,8,9,10,11,12},
        //    { 13,14,15,16,17,18},
        //    { 19,20,21,22,23,24}
        //        };
        //    int[,] B = new int[6, 6]
        //    {
        //    { 1,2,3,4,5,6},
        //    { 7,8,9,10,11,12},
        //    { 13,14,15,16,17,18},
        //    { 19,20,21,22,23,24},
        //    { 25,26,27,28,29,30},
        //    { 31,32,33,34,35,36}
        //    };


        //    Sort(ref A);
        //    Sort(ref B);

        //    Console.WriteLine("матрица А:");
        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            Console.Write(A[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("матрица В:");
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            Console.Write(B[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static void Sort(ref int[,] C)
        //{
        //    int rows = C.GetLength(0);
        //    int cols = C.GetLength(1);

        //    for (int i = 0; i < rows; i++)
        //    {
        //        int maxi_r = i;
        //        int max = C[i, 0];
        //        for (int j = 1; j < cols; j++)
        //        {
        //            if (C[i, j] > max)
        //            {
        //                max = C[i, j];
        //            }
        //        }

        //        for (int k = i + 1; k < rows; k++)
        //        {
        //            int maxcur = C[k, 0];
        //            for (int j = 1; j < cols; j++)
        //            {
        //                if (C[k, j] > maxcur)
        //                {
        //                    maxcur = C[k, j];
        //                }
        //            }

        //            if (maxcur > max)
        //            {
        //                max = maxcur;
        //                maxi_r = k;
        //            }
        //        }

        //        if (maxi_r != i)
        //        {
        //            for (int j = 0; j < cols; j++)
        //            {
        //                int t = C[i, j];
        //                C[i, j] = C[maxi_r, j];
        //                C[maxi_r, j] = t;
        //            }
        //        }
        //    }
        //}

        // задание 23
        static void Main()
        {
            int[,] A = new int[4, 6]
            {
        { 1,2,3,40,5,6},
        { 7,8,9,100,11,12},
        { 13,14,15,16,17,18},
        { 19,20,21,22,23,24}
            };
            int[,] B = new int[6, 6]
            {
        { 1,2,3,4,5,6},
        { 7,8,9,10,11,12},
        { 13,14,15,16,17,18},
        { 199,20,221,22,23,24},
        { 25,26,27,28,29,30},
        { 31,32,33,34,35,36 }
            };


            fivemax(A);
            fivemax(B);
        }

        static void fivemax(int[,] C)
        {
            int[] largestel = new int[5];
            for (int i = 0; i < 5; i++)
            {
                largestel[i] = int.MinValue;
            }

            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    int el = C[i, j];
                    for (int k = 0; k < 5; k++)
                    {
                        if (el > largestel[k])
                        {
                            for (int l = 4; l > k; l--)
                            {
                                largestel[l] = largestel[l - 1];
                            }
                            largestel[k] = el;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("пять наибольших элементов матрицы:");
            foreach (int element in largestel)
            {
                Console.WriteLine(element);
            }

            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    if (Array.IndexOf(largestel, C[i, j]) != -1)
                    {
                        C[i, j] *= 2;
                    }
                    else
                    {
                        C[i, j] /= 2;
                    }


                }
            }
            Console.WriteLine("преобразовавнная матрица:");
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}