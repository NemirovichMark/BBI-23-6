using System;
class Program
{
    static void Main( string [] args )
    {
        #region // 1 уровень 1 задча
        //double [] a = new double [6];//1 задача
        //double  s = 0;
        //for (int i = 0; i < 6; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    s = s + a[i];
        //}
        //for (int i = 0; i < 6; i++)
        //{
        //    a[i] = a[i] / s;
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region//1 уровень 2 задча
        //double[] b = new double[8];
        //double sr = 0;
        //int c=0;
        //for (int i = 0; i < 8; i++)
        //{
        //    b[i] = Int32.Parse(Console.ReadLine());
        //    if (b[i] > 0)
        //    {
        //        sr +=b[i];
        //        c++;
        //    }
        //}
        //sr = sr / c;
        //for (int i = 0; i < 8; i++)
        //{
        //    if (b[i] > 0)
        //    {
        //        b[i] = b[i] / sr;
        //        Console.WriteLine(b[i]);
        //    }
        //}
        #endregion

        #region//1 уровень 3задача
        //double[] b = new double[4];
        //double[] a = new double[4];
        //double[] c = new double[4];
        //double[] d = new double[4];
        //for (int i = 0; i < 4; i++)
        //{
        //    b[i] = Double.Parse(Console.ReadLine());
        //    a[i] = Double.Parse(Console.ReadLine());
        //}
        //Console.WriteLine();
        //for (int i = 0; i < 4; i++)
        //{
        //    c[i] = a[i] + b[i];
        //    Console.WriteLine(c[i]);
        //}
        //Console.WriteLine();
        //for (int i = 0; i < 4; i++)
        //{
        //    d[i] = b[i] - a[i];
        //    Console.WriteLine(d[i]);
        //}
        #endregion

        #region//1 уровень 4 задача
        //double[] a = new double[5];
        //double sr = 0;
        //int c = 0;
        //for (int i = 0; i < 5; i++)
        //{
        // a[i] = Int32.Parse(Console.ReadLine());
        // sr += a[i];
        // c++;
        //}
        //Console.WriteLine();
        //sr = sr / c;
        //for (int i = 0; i < 5; i++)
        //{
        //    a[i] = a[i]-sr;
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region//1 уровень 5 задача
        //double[] b = new double[4];
        //double[] a = new double[4];
        //double s = 0;
        //for (int i = 0; i < 4; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    b[i] = Double.Parse(Console.ReadLine());
        //    s += a[i] * b[i];
        //}
        //Console.WriteLine(s);
        #endregion

        #region//1 уровень 6 задача
        //double[] a = new double[5];
        //double L = 0;
        //for (int i = 0; i < 4; i++)
        //{
        // a[i] = Double.Parse(Console.ReadLine());
        // L +=Math.Pow(a[i], 2);
        //}
        //L=Math.Sqrt(L);
        //Console.WriteLine(L);
        #endregion

        #region//1 уровень 7 задача
        //double[] a = new double[7];
        //double sr = 0;
        //int c = 0;
        //for (int i = 0; i < 7; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    sr += a[i];
        //    c++;
        //}
        //Console.WriteLine();
        //sr = sr / c;
        //for (int i = 0; i < 7; i++)
        //{
        //    if (a[i] > sr)
        //    {
        //        a[i] = 0;
        //    }
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region//1 уровень 8 задача
        //double[] a = new double[6];
        //int c = 0;
        //for (int i = 0; i < 6; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] < 0)
        //    {
        //        c++;
        //    }
        //}
        //Console.WriteLine();
        //Console.WriteLine(c);
        #endregion

        #region//1 уровень 9 задача
        //double[] a = new double[8];
        //double sr = 0;
        //int c = 0, kol = 0;
        //for (int i = 0; i < 8; i++)
        //{
        // a[i] = Double.Parse(Console.ReadLine());
        //  sr += a[i];
        //  c++;
        //}
        //sr = sr / c;
        //for (int i = 0; i < 8; i++)
        //{
        //    if (a[i] > sr)
        //    {
        //     kol++;
        //    }
        //}
        //Console.WriteLine(kol);
        #endregion

        #region//1 уровень 10 задача
        //double[] a = new double[10];
        //int c = 0;
        //double P = Double.Parse(Console.ReadLine());
        //double Q = Double.Parse(Console.ReadLine());
        //Console.WriteLine();
        //for (int i = 0; i < 10; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] >= P && a[i] <= Q)
        //    {
        //        c++;
        //    }
        //}
        //Console.WriteLine();
        //Console.WriteLine(c);
        #endregion

        #region//1 уровень 11 задача
        //double[] a = new double[10];
        //double[] b = new double[10];
        //int k = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //}
        //Console.WriteLine();
        //for (int i = 0; i < 10; i++)
        //{
        //    if (a[i] >= 0)
        //    {
        //        b[k] = a[i];
        //        Console.WriteLine(b[k]);
        //    }
        //}
        #endregion

        #region//1 уровень 12 задача
        //double[] c = new double[8];
        //int index = 0;
        //double znach = 0;
        //for (int i = 0; i < 8; i++)
        //{
        //    c[i] = Double.Parse(Console.ReadLine());
        //    if (c[i] < 0)
        //    {
        //        znach = c[i];
        //        index = i;
        //    }
        //}
        //Console.WriteLine(znach);
        //Console.WriteLine(index);

        #endregion

        #region//1 уровень 13 задача
        //double[] a = new double[10];
        //double[] b = new double[5];
        //double[] c = new double[5];
        //for (int i = 0; i < 10; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //}
        //Console.WriteLine();
        //for (int i = 0; i < 10; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        b[i / 2] = a[i];
        //    }
        //    else
        //    {
        //        c[i / 2] = a[i];
        //    }
        //}
        //foreach (int num in b)
        //{
        //    Console.WriteLine(num);
        //}
        //Console.WriteLine();
        //foreach (int num in c)
        //{
        //    Console.WriteLine(num);
        //}

        #endregion

        #region//1 уровень 14 задача
        //double[] a = new double[11];
        //double s = 0;
        //for (int i = 0; i < 11; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //}
        //for (int i = 0; i < 11; i++)
        //{
        //    if (a[i] >= 0)
        //    {
        //        s += Math.Pow(a[i], 2);
        //    }
        //    else break;
        //}
        //Console.WriteLine(s);
        #endregion

        #region//1 уровень 15 задача
        //double[] a = new double[10];
        //double[] b = new double[10];

        //for (int i = 0; i < 10; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //}
        //Console.WriteLine();
        //for (int i = 0; i < 10; i++)
        //{
        //    b[i] = 0.5 * Math.Log(a[i]);
        //}
        //Console.WriteLine("x | y");
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("{0} | {1:F3}", a[i], b[i]);
        //}
        #endregion





        #region //2уровень 1 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] b = new double[n];
        //double min = 100000000;
        //int index=-1;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    b[i] = Double.Parse(Console.ReadLine());
        //    if (b[i]<min)
        //    {
        //        min = b[i];
        //        index = i;
        //    }
        //}
        //b[index] *= 2;
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(b[i]);
        //}
        #endregion

        #region //2уровень 2 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //double max = 0.0000000000001;
        //int index = -1;
        //double s = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        index = i;
        //    }
        //}
        //Console.WriteLine();
        //for (int i = 0; i < index; i++)
        //{
        //    s += a[i];
        //}
        //Console.WriteLine(s);
        #endregion

        #region //2уровень 3 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //double min = 100000000;
        //int index = -1;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] < min)
        //    {
        //        min = a[i];
        //        index = i;
        //    }
        //}
        //Console.WriteLine();
        //for (int i = 0; i < index; i++)
        //{
        //    a[i] = a[i] * 2;
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region //2уровень 4 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //double sr = 0;
        //int c = 0;
        //double max = 0.0000000000001;
        //int index = 0;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    sr += a[i];
        //    c++;
        //}
        //sr = sr / c;
        //Console.WriteLine();
        //Console.WriteLine(sr);
        //for (int i = 1; i < n; i++)
        //{
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        index = i;
        //    }
        //}
        //for (int i = index + 1; i < n; i++)
        //{
        //    a[i] = sr;
        //}
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region // 2 уровень 5 задча
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int indexmin = 0;
        //int indexmax = 0;
        //int start = 0, end = 0, count = 0;
        //double min = 1000000000000;
        //double max = -100000000;
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i]<min)
        //    {
        //        min = a[i];
        //        indexmin = i;
        //    }
        //    if (a[i]>max)
        //    {
        //        max = a[i];
        //        indexmax = i;
        //    }
        //}
        //if (indexmin>indexmax)
        //{
        //    start = indexmax;
        //    end = indexmin;
        //}
        //else
        //{
        //    start = indexmin;
        //    end = indexmax;
        //}
        //for (int i = start+1;i < end; i++)
        //{
        //    if (a[i]<0)
        //    {
        //        count++;
        //    }
        //}
        //double [] b=new double [count];
        //int g = 0;
        //for (int i = start + 1; i < end; i++)
        //{
        //    if (a[i] < 0)
        //    {
        //        b[g] = a[i];
        //        Console.WriteLine(b[g]);
        //        g++;               
        //    }

        //}
        #endregion

        #region//2 уровень 6 задача
        //double sr = 0;
        //int c = 0;
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //double P = Double.Parse(Console.ReadLine());
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    sr += a[i];
        //    c++;
        //}
        //sr = sr / c;
        //Console.WriteLine(sr);
        //int closestindex = -1;
        //double mindif = Math.Abs(a[0] - sr);
        //for (int i = 1; i < n; i++)
        //{
        //    double dif = Math.Abs(a[i] - sr);
        //    if (dif < mindif)
        //    {
        //        mindif = dif;
        //        closestindex = i;
        //    }
        //}
        //double[] b = new double[n + 1];
        //for (int i = 0, j = 0; i < n + 1; i++, j++)
        //{
        //    if (i == closestindex + 1)
        //    {
        //        b[i] = P;
        //        j--;
        //    }
        //    else
        //    {
        //        b[i] = a[j];
        //    }
        //}
        //Console.WriteLine("Исходный массив:");
        //foreach (int num in a)
        //{
        //    Console.Write(num + " ");
        //}
        //Console.WriteLine("Новый массив:");
        //foreach (int num in b)
        //{
        //    Console.Write(num + " ");
        //}
        #endregion

        #region //2уровень 7 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int indexmax = 0;
        //double max = -100000000;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        indexmax = i;
        //    }
        //}
        //a[indexmax + 1] *= 2;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}

        #endregion

        #region //2уровень 8 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int indexmin = 0;
        //int indexmax = 0;
        //double count = 0;
        //double min = 1000000000000;
        //double max = -100000000;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        indexmax = i;
        //    }
        //}
        //for (int i = indexmax + 1; i < n; i++)
        //{
        //    if (a[i] < min)
        //    {
        //        min = a[i];
        //        indexmin = i;
        //    }
        //}
        //Console.WriteLine();
        //count = max;
        //a[indexmax] = min;
        //a[indexmin] = count;
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region //2уровень 9 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int indexmin = 0;
        //int indexmax = 0;
        //int start = 0, end = 0, count = 0;
        //double min = 1000000000000;
        //double max = -100000000;
        //double s = 0, sr = 0;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] < min)
        //    {
        //        min = a[i];
        //        indexmin = i;
        //    }
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        indexmax = i;
        //    }
        //}
        //if (indexmin > indexmax)
        //{
        //    start = indexmax;
        //    end = indexmin;
        //}
        //else
        //{
        //    start = indexmin;
        //    end = indexmax;
        //}
        //for (int i = start + 1; i < end; i++)
        //{
        //    s += a[i];
        //    count++;
        //}
        //sr = s / count;
        //Console.Write(sr);

        #endregion

        #region //2уровень 10 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int indexmin = 0;
        //double min = 1000000000000;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] < min && a[i] > 0)
        //    {
        //        min = a[i];
        //        indexmin = i;
        //    }
        //}
        //for (int i = indexmin; i < n - 1; i++)
        //{
        //    a[i] = a[i + 1];
        //}
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region //2уровень 11 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n + 1];
        //int indexpoloz = 0;
        //double P = Double.Parse(Console.ReadLine());
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] > 0) indexpoloz = i;
        //}
        //for (int i = n; i >= indexpoloz + 1; i--)
        //{
        //    a[i] = a[i - 1];
        //}
        //a[indexpoloz + 1] = P;
        //Console.WriteLine();

        //for (int i = 0; i < n + 1; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region //2уровень 12 задача
        // int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int indexotriz = 0;
        //int indexmax = 0;
        //double otriz = 0;
        //double max = -100000000;
        //double s = 0;
        //int d = 1;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        indexmax = i;
        //    }
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    if (a[i] < 0 && d == 1)
        //    {
        //        otriz = a[i];
        //        indexotriz = i;
        //        d = 0;
        //    }
        //}
        //for (int i = indexmax + 1; i < n; i++)
        //{
        //    s += a[i];
        //}
        //a[indexotriz] = s;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region //2уровень 13 задача
        //    int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int indexmax = 0;
        //double max = -100000000;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] > max && i % 2 == 0)
        //    {
        //        max = a[i];
        //        indexmax = i;
        //    }
        //}
        //a[indexmax] = indexmax;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}

        #endregion

        #region //2уровень 14 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int indexotriz = 0;
        //int indexmax = 0;
        //double otriz = 0;
        //double max = -100000000;
        //double s = 0;
        //int d = 1;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        indexmax = i;
        //    }
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    if (a[i] < 0 && d == 1)
        //    {
        //        otriz = a[i];
        //        indexotriz = i;
        //        d = 0;
        //    }
        //}
        //s = max;
        //a[indexmax] = otriz;
        //a[indexotriz] = s;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region //2 уровень 15 задача
        //int n = Int32.Parse(Console.ReadLine());
        //int m = Int32.Parse(Console.ReadLine());
        //double[] A = new double[n];
        //double[] B = new double[m];
        //double[] C = new double[m+n];

        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    A[i] = Double.Parse(Console.ReadLine());
        //}
        // Console.WriteLine();
        //for (int i = 0; i < m; i++)
        //{
        //    B[i] = Double.Parse(Console.ReadLine());
        //}
        //int k = Int32.Parse(Console.ReadLine());

        //for (int i = 0; i < k; i++)
        //{
        //    C[i] = A[i];
        //}
        //for (int i = k; i < k + m; i++)
        //{ 
        //    C[i] = B[i - k];
        //}
        //for (int i = k+m; i < m+n ; i++)
        //{
        //    C[i] = A[i - m];
        //}
        //for (int i = 0; i < m+n; i++)
        //{
        //    Console.WriteLine(C[i]);
        // }
        #endregion

        #region //2уровень 16 задача
        //       int n = Int32.Parse(Console.ReadLine());
        //       double[] a = new double[n];
        //       double sr = 0;
        //       int c = 0;
        //       Console.WriteLine();
        //       for (int i = 0; i < n; i++)
        //       {
        //           a[i] = Double.Parse(Console.ReadLine());
        //           if (a[i] > 0)
        //           {
        //               sr += a[i];
        //               c++;
        //           }
        //       }
        //       sr = sr / c;
        //       Console.WriteLine();
        //       Console.WriteLine(sr);
        //       Console.WriteLine()
        //double[] b = new double[n];
        //       int index = 0;
        //       for (int i = 0; i < n; i++)
        //       {
        //           if (a[i] < sr)
        //           {
        //               b[index] = i;
        //               index++;
        //           }
        //       }
        //       for (int i = 0; i < index; i++)
        //       {
        //           Console.WriteLine(b[i]);
        //       }
        #endregion

        #region //2уровень 17 задача
        //    int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int indexmin = 0;
        //int indexmax = 0;
        //int count1 = 0, count2 = 0;
        //double min = 1000000000000;
        //double max = -100000000;
        //double s1 = 0, sr1 = 0, s2 = 0, sr2 = 0;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] < min)
        //    {
        //        min = a[i];
        //        indexmin = i;
        //    }
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        indexmax = i;
        //    }
        //}
        //Console.WriteLine();
        //Console.WriteLine(a[indexmax]);
        //Console.WriteLine(a[indexmin]);
        //if (indexmax < indexmin)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (a[i] > 0)
        //        {
        //            s1 += a[i];
        //            count1++;
        //        }
        //        sr1 = s1 / count1;
        //    }
        //    Console.WriteLine(sr1);
        //}
        //else
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (a[i] < 0)
        //        {
        //            s2 += a[i];
        //            count2++;
        //        }
        //    }
        //    sr2 = s2 / count2;
        //    Console.WriteLine(sr2);
        //}



        #endregion

        #region //2уровень 18 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //double max1 = -100000000;
        //double max2 = -100000000;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] > max1 && a[i] % 2 == 0)
        //    {
        //        max1 = a[i];
        //    }
        //    if (a[i] > max2 && a[i] % 2 != 0)
        //    {
        //        max2 = a[i];
        //    }
        //}
        //if (max1 > max2)
        //{
        //    for (int i = 0; i < n / 2; i++)
        //    {
        //        a[i] = 0;
        //    }
        //}
        //else
        //{
        //    for (int i = n / 2 + 1; i < n; i++)
        //    {
        //        a[i] = 0;
        //    }
        //}
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region //2уровень 19 задача
        //    int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //int indexmax = 0;
        //double max = -100000000;
        //double s = 0;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        indexmax = i;
        //    }
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    s += a[i];
        //}
        //Console.WriteLine();
        //Console.WriteLine(s);
        //if (max > s)
        //{
        //    a[indexmax] = 0;
        //}
        //else
        //{
        //    a[indexmax] *= 2;
        //}
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region//2 уровень 20 задача
        //int n = Int32.Parse(Console.ReadLine()); 
        //double[] b = new double[n];
        //double min = 100000000;
        //int index1 = -1;
        //int index2 = -1;
        //int d = 1;
        //double s = 0;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    b[i] = Double.Parse(Console.ReadLine());
        //    if (b[i]<min)
        //    {
        //        min= b[i];
        //        index1 = i;
        //    }
        //    if (b[i]<0 && d==1)
        //    {
        //        index2 = i;
        //        d = 0;
        //    }
        //}
        //if (index2<index1)
        //{
        //    for (int i = 0; i < n; i=i+2)
        //    {
        //        s += b[i];
        //    }
        //}
        //else
        //{
        //    for (int i = 0; i < n; i = i + 1)
        //    {
        //        s += b[i];
        //    }
        //}
        //Console.WriteLine(s);
        #endregion




        #region//3 уровень 1 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] b = new double[n];
        //int count = 1;
        //Console.WriteLine(); 
        //for (int i = 0; i < n; i++)
        //{
        //    b[i] = Double.Parse(Console.ReadLine());
        //}
        //double max = b[0];
        //for (int i = 0; i < n; i++)
        //{
        //    if (b[i] > max)
        //    {
        //        max = b[i];
        //        count = 1;
        //    }
        //    else if (b[i] == max)
        //    {
        //     count++;
        //    }
        //}
        //Console.WriteLine();
        //double[]a= new double[count];
        //int index = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    if (b[i]==max)
        //    {
        //        a[index] = i;
        //        index++;

        //    }
        //}
        //for (int i = 0; i < index; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region//3 уровень 2 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] b = new double[n];
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    b[i] = Double.Parse(Console.ReadLine());
        //}
        //double max = b[0];
        //for (int i = 1; i < n; i++)
        //{
        //    if (b[i] > max)
        //    {
        //        max = b[i];
        //    }
        //}
        //Console.WriteLine();
        //double k = 1;
        //for (int i = 0; i < n; i++)
        //{
        //    if (b[i] == max)
        //    {
        //        b[i] += k;
        //        k++;
        //    }
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(b[i]);
        //}
        #endregion

        #region//3 уровень 3 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //double max = 0.0000000000001;
        //int index = -1;
        //double k = 0;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //    if (a[i] > max)
        //    {
        //        max = a[i];
        //        index = i;
        //    }
        //}
        //Console.WriteLine();
        //for (int i = 0; i < index; i = i + 2)
        //{
        //    if (i + 1 == index) break;
        //    {
        //        k = a[i];
        //        a[i] = a[i + 1];
        //        a[i + 1] = k;
        //    }
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region//3 уровень 5 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] a = new double[n];
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Double.Parse(Console.ReadLine());
        //}
        //Console.WriteLine();
        //for (int i = 0; i < n; i += 2)
        //{
        //    for (int j = i + 2; j < n; j += 2)
        //    {
        //        if (a[i] > a[j])
        //        {
        //            double k = a[i];
        //            a[i] = a[j];
        //            a[j] = k;
        //        }
        //    }
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(a[i]);
        //}
        #endregion

        #region//3 уровень 6 задача
        //int n = Int32.Parse(Console.ReadLine());
        //double[] A = new double[n];
        //int dlina = 0;
        //int maxdlina = 0;
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    A[i] = Double.Parse(Console.ReadLine());
        //}
        //for (int i = 0; i < n - 1; i++)
        //{
        //    if (A[i] > A[i + 1])
        //    {
        //        dlina++;

        //        if (dlina > maxdlina)
        //        {
        //            maxdlina = dlina;
        //        }
        //    }
        //    else
        //    {
        //        dlina = 0;
        //    }
        //}
        //Console.WriteLine("Максимальная длина последовательности: " + maxdlina);
        #endregion

            Console.ReadKey();
    }
    
}
