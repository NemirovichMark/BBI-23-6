using System;
class Program
{
    static void Main(string[] args)
    {
        #region//1 уровень 1 задача
        //double[,] a = new double[5, 7];
        //double s = 0;
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        a[i, j] = double.Parse(Console.ReadLine());
        //        s += a[i, j];
        //    }
        //}
        //Console.WriteLine(s);

        #endregion

        #region//1 уровень 2 задача
        //double[,] a = new double[5, 3];
        //double s = 0, sr = 0;
        //double c = 0;
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        a[i, j] = double.Parse(Console.ReadLine());
        //        if (a[i, j] > 0)
        //        {
        //            s += a[i,j];
        //            c++;
        //        }
        //    }
        //}
        //sr = s / c;
        //Console.WriteLine();
        //Console.WriteLine(sr);
        #endregion

        #region//1 уровень 3 задача
        //double[,] a = new double[4, 4];
        //double s = 0;
        //double c = 0;
        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        a[i, j] = double.Parse(Console.ReadLine());

        //    }
        //    s += a[i, i];
        //}
        //Console.WriteLine();
        //Console.WriteLine(s);
        #endregion

        #region//1 уровень 7 задача
        //double[,] a = new double[3, 5];
        //double max = -100000000000000;
        //double[] b = new double[5];
        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        Console.WriteLine("["+i+","+ j +"]");
        //        a[i, j] = double.Parse(Console.ReadLine());
        //    }
        //}
        //Console.WriteLine();
        //for (int j = 0; j < 5; j++)
        //{

        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (a[i, j] > max)
        //        {
        //            max = a[i, j];
        //            b[j] = max;
        //        }
        //    }
        //    b[j] = max;
        //    max = -10000;
        //    Console.WriteLine(b[j]);
        //}
        #endregion

        #region//1 уровень 11 задача
        //double[,] a = new double[5, 7];
        //double[,] b = new double[4, 7];
        //double min = 10000000000000;
        //int indexmin = -1;
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.WriteLine("[" + i + "," + j + "]");
        //        a[i, j] = double.Parse(Console.ReadLine());
        //    }
        //}

        //for (int i = 0; i < 5; i++)
        //{
        //    if (a[i, 0] < min)
        //    {
        //        min = a[i, 0];
        //        indexmin = i;
        //    }
        //}
        //for (int i = 0; i < indexmin; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        b[i, j] = a[i, j];
        //    }
        //}
        //for (int i = indexmin + 1; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        b[i - 1, j] = a[i, j];
        //    }
        //}
        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.WriteLine(b[i, j]);
        //    }
        //} 
        #endregion

        #region//1 уровень 15 задача
        //double[,] a = new double[5, 7];
        //double max = -1000000000000000;
        //int indexmax = -1;
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.WriteLine("[" + i + "," + j + "]");
        //        a[i, j] = double.Parse(Console.ReadLine());
        //    }
        //}

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        if (a[i, j] > max)
        //        {
        //            max = a[i, j];
        //            indexmax = j;

        //        }
        //    }
        //    a[i, indexmax] *= i;
        //    max = 0;
        //}
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.Write(a[i, j]+ " ");

        //    }
        //    Console.WriteLine();    
        //}
        #endregion

        #region//1 уровень 19 задача
        //int n = Int32.Parse(Console.ReadLine());
        //int m = Int32.Parse(Console.ReadLine());
        //if (n <= 0 || m <= 0) { Console.WriteLine("Некорректно"); }
        //else
        //{
        //    double[,] a = new double[n, m];
        //    double max = -1000000000000000;
        //    int indexmax = -1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            Console.WriteLine("[" + i + "," + j + "]");
        //            a[i, j] = double.Parse(Console.ReadLine());
        //        }
        //    }
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            if (a[i, j] > max)
        //            {
        //                max = a[i, j];
        //                indexmax = j;
        //            }
        //        }
        //        for (int j = 0; j < indexmax; j++)
        //        {
        //            if (a[i, j] < 0)
        //            {
        //                a[i, j] = a[i, j] / max;
        //            }
        //        }
        //    }
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //        {
        //            Console.Write(a[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        #endregion

        #region//1 уровень 23 задача
        //double[,] a = new double[5, 7];
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.WriteLine("[" + i + "," + j + "]");
        //        a[i, j] = double.Parse(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < a.GetLength(0); i++)
        //{

        //    double max = a [i, 0];// Находим максимальный элемент в текущей строке
        //    for (int j = 1; j < 6; j++)
        //    {
        //        if (a[i, j] > max)
        //        {
        //            max = a[i, j];
        //        }
        //    }


        //    for (int j = 5; j >= 0; j--)// Дублируем максимальный элемент, располагая новый элемент правее
        //    {
        //        if (a[i, j] == max)
        //        {

        //            for (int k = 6; k > j + 1; k--)// Сдвигаем все элементы вправо, начиная с найденного максимального элемента
        //            {
        //                a[i, k] = a[i, k - 1];
        //            }
        //           a[i, j + 1] = max;
        //            break;
        //        }
        //    }
        //}

        //for (int i = 0; i < a.GetLength(0); i++)
        //{
        //    for (int j = 0; j < a.GetLength(1); j++)
        //    {
        //        Console.Write(a[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region//1 уровень 27 задача
        //double[,] a = new double[5, 7]
        //double[] b = new double[5];
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.WriteLine("[" + i + "," + j + "]");
        //        a[i, j] = double.Parse(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < a.GetLength(0); i++)
        //{

        //    double max = a[i, 0];// Находим максимальный элемент в текущей строке
        //    for (int j = 1; j < 6; j++)
        //    {
        //        if (a[i, j] > max)
        //        {
        //            max = a[i, j];
        //            b[i] = max;
        //        }
        //    }
        //}
        //for (int i = 0; i < a.GetLength(0); i++)
        //{
        //    a[i, 3] = b[4 - i];
        //}
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.Write(a[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region//1 уровень 31 задача
        //double[,] a = new double[5, 8]
        //double[] b = new double[5];
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 8; j++)
        //    {
        //        Console.WriteLine("[" + i + "," + j + "]");
        //        a[i, j] = double.Parse(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < 5; i++)
        //{
        //    b[i] = double.Parse(Console.ReadLine());
        //}
        //    double min = a[4, 0];//нахождение минимального элемента
        //int indexmin = 0;
        //for (int i = 1; i < 7; i++)
        //{
        //    if (a[4, i] < min)
        //    {
        //        min = a[4, i];
        //        indexmin = i;
        //    }
        //}
        //for (int i=0;i<5;i++)
        //{
        //    for (int j=7;j>indexmin;j--)
        //    {
        //        a[i, j] = a[i, j-1];
        //    }
        //}
        //for (int i=0;i<5; i++)
        //{
        //    a[i, indexmin + 1] = b[i];
        //}
        //for (int i = 0; i < a.GetLength(0); i++)
        //{
        //    for (int j = 0; j < a.GetLength(1); j++)
        //    {
        //        Console.Write(a[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region//2 уровень 3 задача
        //double[,] a = new double[10, 5];

        //for (int i = 0; i < 10; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        Console.WriteLine("[" + i + "," + j + "]");
        //        a[i, j] = double.Parse(Console.ReadLine());
        //    }
        //}

        //for (int j = 0; j < 5; j++)
        //{

        //    double max = -100000000000;// Находим максимальный элемент в текущей строке
        //    int index = 0;
        //    double s = 0;
        //    for (int i = 0; i < 10; i++)
        //    {
        //        if (a[i, j] > max)
        //        {
        //            max = a[i, j];
        //            index = i;
        //        }
        //    }

        //    if (index < 5)
        //    {
        //        for (int i = index + 1; i < 10; i++)
        //        {
        //            s += a[i, j];
        //        }
        //        a[0, j] = s;
        //    }
        //}
        //for (int i = 0; i < 10; i++)
        //{
        //    for (int k = 0; k < 5; k++)
        //    {
        //        Console.Write(a[i, k] + " ");
        //    }
        //    Console.WriteLine();
        //}

        #endregion

        #region//2 уровень 7 задача
        //double[,] a = new double[6, 6];
        //double max = -10000000000000;
        //int index = 0;
        //for (int i = 0; i < 6; i++)
        //{
        //    for (int j = 0; j < 6; j++)
        //    {
        //        Console.WriteLine("[" + i + "," + j + "]");
        //        a[i, j] = double.Parse(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < 6; i++)
        //{
        //    if (a[i, i] > max)
        //    {
        //        max = a[i, i];
        //        index = i;
        //    }
        //}
        //for (int i = 0; i < index; i++)
        //{
        //    a[i, i + 1] = 0;
        //}
        //for (int i = 0; i < a.GetLength(0); i++)
        //{
        //    for (int j = 0; j < a.GetLength(1); j++)
        //    {
        //        Console.Write(a[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region//3 уровень  задача

        #endregion

        #region//3 уровень  задача

        #endregion


        #region//3 уровень  задача

        #endregion
        Console.ReadKey();
    }
}