//Задача 6
//using System;


//class Program
//{

//    static int MaxElIndex(int[] x)
//    {
//        int imax = 0;
//        for (int i = 0; i < x.Length; i++)
//        {
//            if (x[i] > x[imax])
//            {
//                imax = i;
//            }
//        }
//        return imax;
//    }

//    static int[] RemoveMax(int[] arr, int index)
//    {
//        int[] arr1 = new int[arr.Length - 1];
//        for (int i = 0, j = 0; i < arr.Length; i++)
//        {
//            if (i != index)
//            {
//                arr1[j++] = arr[i];
//            }
//        }
//        return arr1;
//    }

//    static int[] Mix(int[] x1, int[] x2)
//    {
//        return x1.Concat(x2).ToArray();
//    }

//    static void Main()
//    {
//        int[] a = { 1, 5, 3, 2, 7, 6, 4 };
//        int[] b = { 8, 10, 9, 12, 11, 13, 15, 14 };

//        int iamax = MaxElIndex(a);
//        int ibmax = MaxElIndex(b);

//        a = RemoveMax(a, iamax);
//        b = RemoveMax(b, ibmax);

//        a = Mix(a, b);

//        Console.WriteLine("Итоговый массив:" + string.Join(", ", a));
//    }
//}
//Задача 12
//using System;
//class Program
//{
//    static int MaxEl(int[,] x)
//    {
//        int jmax = 0;
//        int max = 0;
//        for (int i = 0; i < x.GetLength(0); i++)
//        {
//            for (int j = 0; j < x.GetLength(1); j++)
//            {
//                if (x[i, j] > max)
//                {
//                    max = x[i, j];
//                    jmax = j;
//                }
//            }
//        }
//        return jmax;
//    }
//    static void Print(int[,] x)
//    {
//        for (int i = 0; i < x.GetLength(0); i++)
//        {
//            for (int j = 0; j < x.GetLength(1); j++)
//            {
//                Console.Write("{0,3:d} ", x[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//    static void Main()
//    {
//        int[,] a =
//        {
//            { 1, 2, 3 },
//            { 4, 5, 6 },
//            { 7, 8, 9 }
//        };

//        int[,] b =
//        {
//            { 9, 8, 7 },
//            { 6, 5, 4 },
//            { 3, 2, 1 }
//        };
//        int jamax;
//        int jbmax;
//        jamax = MaxEl(a);
//        jbmax = MaxEl(b);
//        for (int i = 0; i < a.GetLength(0); i++)
//        {
//            int p = a[i, jamax];
//            a[i, jamax] = b[i, jbmax];
//            b[i, jbmax] = p;
//        }
//        Console.WriteLine("Преобразованная матрица a");
//        Print(a);
//        Console.WriteLine("Преобразованная матрица b");
//        Print(b);
//    }
//}
//Задача 18
//using System;
//class Program
//{
//    static int[,] SortM(int[,] x)
//    {
//        for (int i = 0; i < x.GetLength(0) - 1; i++)
//        {
//            for (int j = i; j < x.GetLength(1) - 1; j++)
//            {
//                if (x[i, i] > x[j + 1, j + 1])
//                {
//                    int p = x[i, i];
//                    x[i, i] = x[j + 1, j + 1];
//                    x[j + 1, j + 1] = p;
//                }
//            }

//        }
//        return x;
//    }
//    static void Print(int[,] x)
//    {
//        for (int i = 0; i < x.GetLength(0); i++)
//        {
//            for (int j = 0; j < x.GetLength(1); j++)
//            {
//                Console.Write("{0,3:d} ", x[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//    static void Main()
//    {
//        int[,] a =
//        {
//            {9, 8, 7},
//            {6, 5, 4},
//            {3, 2, 1}
//        };
//        int[,] b =
//        {
//            { 19, 18, 17 },
//            { 16, 15, 14 },
//            { 13, 12, 11 }
//        };

//        a = SortM(a);
//        b = SortM(b);
//        Console.WriteLine("преобразованная матрица a");
//        Print(a);
//        Console.WriteLine("Преобразованная матрица b");
//        Print(b);
//    }
//}
//Задача 24
//using System;
//class Program
//{
//    static int MaxEl(int[,] x)
//    {
//        int jmax = 0;
//        int max = 0;
//        for (int i = 0; i < x.GetLength(0); i++)
//        {
//            for (int j = 0; j < x.GetLength(1); j++)
//            {
//                if (x[i, j] > max) ;
//                {
//                    max = x[i, j];
//                    jmax = j;
//                }
//            }
//        }
//        return jmax;
//    }
//    static void Exchange(int[,] x, int index)
//    {
//        for(int i = 0; i < x.GetLength(0); i++)
//        {
//            int p = x[i, index];
//            x[i, index] = x[i, i];
//            x[i, i] = p;
//        }
//    }
//    static void Print(int[,] x)
//    {
//        for (int i = 0; i < x.GetLength(0); i++)
//        {
//            for (int j = 0; j < x.GetLength(1); j++)
//            {
//                Console.Write("{0,3:d} ", x[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//    static void Main()
//    {
//        int[,] a =
//        {
//            { 9, 8, 7 },
//            { 6, 15, 4 },
//            { 3, 2, 1 }
//        };
//        int[,] b =
//        {
//            { 19, 18, 17 },
//            { 16, 5, 14 },
//            { 13, 12, 11 }
//        };
//        int amax;
//        int bmax;
//        amax = MaxEl(a);
//        bmax = MaxEl(b);
//        Exchange(a, amax);
//        Exchange(b, bmax);
//        Console.WriteLine("Преобразованная матрица a");
//        Print(a);
//        Console.WriteLine("Преобразованная матрица b");
//        Print(b);
//    }
//}

        

        





