// Уровень II
// Номер 1
//using System;
//using System.Collections.Immutable;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;

//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amin = a[0];
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] <= amin)
//            {
//                amin = a[i];
//            }
//        }
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] == amin)
//            {
//                a[i] = a[i] * a[i];
//            }
//        }
//        Console.WriteLine("Минимальный элемент массива");
//        Console.WriteLine(amin);
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }

//    }
//}

// Номер 2
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;

//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amax = a[0];
//        double sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] >= amax)
//            {
//                amax = a[i];

//            }
//        }
//        Console.WriteLine("Максимальный элемент");
//        Console.WriteLine(amax);
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i]==amax)
//            {
//                break;
//            }
//            else
//            {
//                sum = sum + a[i];
//            }
//        }
//        Console.WriteLine("Сумма массива до максимального элемента");
//        Console.WriteLine(sum);

//    }
//}

// Номер 3
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amin = a[0];
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] <= amin)
//            {
//                amin = a[i];

//            }
//        }
//        Console.WriteLine("Минимальный элемент");
//        Console.WriteLine(amin);
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] == amin)
//            {
//                break;
//            }
//            else
//            {
//                a[i] = a[i] * a[i];
//            }
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }

//    }
//}

// Номер 4
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;

//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amax = a[0];
//        double sum = 0;
//        int m = 0;
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] >= amax)
//            {
//                amax = a[i];
//                imax = i;

//            }
//        }
//        double sr = sum / m;
//        Console.WriteLine("Среднее арифметическое");
//        Console.WriteLine(sr);
//        Console.WriteLine("Максимальный элемент");
//        Console.WriteLine(amax);
//        for (int i = 0; i < n; i++)
//        {
//            if (i>=imax)
//            {
//                a[i] = sr;
//            }
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }

//    }
//}

// Номер 5
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        double[] b = new double[n];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amax = a[0];
//        int imax = 0;
//        double amin = a[0];
//        int imin = 0;
//        int m = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] >= amax)
//            {
//                amax = a[i];
//                imax = i;

//            }
//            if (a[i] <= amin)
//            {
//                amin = a[i];
//                imin = i;

//            }
//        }
//        Console.WriteLine("Минимальный элемент");
//        Console.WriteLine(amin);
//        Console.WriteLine("Максимальный элемент");
//        Console.WriteLine(amax);
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i]<0)
//            {
//                if (a[i]>amin && a[i]<amax)
//                {
//                    b[m] = a[i];
//                    m += 1;
//                }
//            }
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(b[i]);
//        }

//    }
//}

// Номер 6
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n+1];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        Console.WriteLine("Введите число P");
//        double P = Convert.ToDouble(Console.ReadLine());
//        double sr;
//        double sum = 0;
//        int m = 0;
//        double minR = 10000000000000000000;
//        double curD = 0;
//        int ind = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("Среднее арифметическое");
//        Console.WriteLine(sr);
//        for (int i = 0; i < n; i++)
//        {
//            curD = Math.Abs(sr - a[i]);
//            if (curD<minR)
//            {
//                minR = curD;
//                ind = i;
//            }
//        }
//        for (int i = n; i >= ind+2 ; i--)
//        {
//            a[i] = a[i - 1];
//        }
//        a[ind+1] = P;
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n+1; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// Номер 7
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (amax < a[i])
//            {
//                amax = a[i];
//                imax += i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент массива");
//        Console.WriteLine(amax);
//        a[imax + 1] = a[imax + 1] * a[imax+1];
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// Номер 8
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amax = a[0];
//        int imax = 0;

//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        double amin = a[imax+1];
//        int imin = imax+1;
//        Console.WriteLine("Максимальный элемент массива");
//        Console.WriteLine(amax);
//        for (int i = imax+1 ; i < n ; i++)
//        {
//            if (a[i]<amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент массива");
//        Console.WriteLine(amin);
//        double v = amin;
//        a[imin] = amax;
//        a[imax] = v;
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// Номер 9
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amax = a[0];
//        int imax = 0;
//        double amin = a[0];
//        int imin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (amax < a[i])
//            {
//                amax = a[i];
//                imax = i;
//            }
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Максимальный элемент массива");
//        Console.WriteLine(amax);
//        Console.WriteLine("Минимальный элемент массива");
//        Console.WriteLine(amin);
//        double sum = 0;
//        int m = 0;
//        double sr;
//        int min, max;
//        if (imin < imax)
//        {
//            min = imin;
//            max = imax;
//        }
//        else if (imin > imax)
//        {
//            min = imax;
//            max = imin;
//        }
//        else
//        {
//            min = imax;
//            max = imin;
//        }
//        for (int i = min+1; i < max; i++)
//        {
//            sum = sum + a[i];
//            m = m + 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("Среднее арифметическое чисел между максимальным и минимальным элементами");
//        Console.WriteLine(sr);
//    }
//}

// Номер 10
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        double amin = a[0];
//        int imin = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > 0 && a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент массива");
//        Console.WriteLine(amin);
//        for (int i = imin; i < n-1; i++)
//        {
//            a[i] = a[i + 1];
//        }

//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n-1; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// Номер 11
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n+1];
//        string k;
//        Console.WriteLine("Введите число Р");
//        double P = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        int idx = 0;
//        for (int i = n-1; i >= 0; i--)
//        {
//            if (a[i] > 0)
//            {
//                idx = i;
//                break;
//            }
//        }
//        for (int i = n; i > idx+1; i--)
//        {
//            a[i] = a[i-1];
//        }
//        a[idx+1] = P;
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n + 1; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// Номер 12
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        int idx = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < 0)
//            {
//                idx = i;
//                break;
//            }
//        }
//        double amax = a[0];
//        int imax = 0;
//        double sum = 0;
//        for(int i=0; i<n; i++)
//        {
//            if (amax < a[i])
//            {
//                amax= a[i];
//                imax = i;
//            }
//        }
//        for (int i=imax+1; i<n; i++)
//        {
//            sum = sum + a[i];
//        }
//        Console.WriteLine("Сумма элементов после максимума");
//        Console.WriteLine(sum);
//        a[idx] = sum;
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// Номер 13
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        int idx = 0;
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i=i+2)
//        {
//            if (amax < a[i])
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        a[imax] = imax+1; //т.к. в жизни индексы с 1, а не с 0 как в массивах
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// Номер 14
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите кол-во элементов массива");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        string k;
//        double neg = 0;
//        Console.WriteLine("Введите массив a");
//        for (int i = 0; i < n; i++)
//        {
//            k = Console.ReadLine();
//            a[i] = double.Parse(k);
//        }
//        int idx = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < 0)
//            {
//                neg = a[i];
//                idx = i;
//                break;
//            }
//        }
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (amax < a[i])
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        a[imax] = neg;
//        a[idx] = amax;
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// Номер 15
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("Введите кол-во элементов массива B");
//        int m = Convert.ToInt32(Console.ReadLine());
//        double[] b = new double[m];
//        Console.WriteLine("Введите массив B");
//        for (int i = 0; i < m; i++)
//        {
//            p = Console.ReadLine();
//            b[i] = double.Parse(p);
//        }
//        Console.WriteLine("Введите кол-во элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n+m];
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        Console.WriteLine("Введите число k");
//        int k = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i <= n-k-1; i++)
//        {
//            a[k+m+i] = a[k+i];
//        }
//        for (int i = 0; i < m ; i++)
//        {
//            a[k + i] = b[i];
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < m + n; i++)
//        {
//            Console.Write($"{a[i]} ");
//        }

//    }
//}

// Номер 16
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("Введите кол-во элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        double[] b = new double[n];
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double sum = 0;
//        int m = 0;
//        double sr;
//        double minR = 10000000000000000000;
//        double curD = 0;
//        int ind = 0;
//        for (int i = 0; i < n; i++)
//        {
//            sum = sum + a[i];
//            m += 1;
//        }
//        sr = sum / m;
//        Console.WriteLine("Среднее арифметическое");
//        Console.WriteLine(sr);
//        int l = 0;
//        for (int i=0; i<n; i++)
//        {
//            if (a[i]<sr)
//            {
//                b[l] = i;
//                l+= 1;
//            }
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < l; i++)
//        {
//            Console.Write($"{b[i]} ");
//        }

//    }
//}

// Номер 17
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("Введите кол-во элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double sum = 0;
//        int m = 0;
//        double sr;
//        double amin = a[0];
//        int imin = 0;
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент");
//        Console.WriteLine(amin);
//        Console.WriteLine("Максимальный элемент");
//        Console.WriteLine(amax);
//        for (int i=0; i<n; i++)
//        {
//            if(imax<imin)
//            {
//                if (a[i]>0)
//                {
//                    sum = sum + a[i];
//                    m += 1;
//                }
//            }
//            else if(imax>imax)
//            {
//                if (a[i]<0)
//                {
//                    sum = sum + a[i];
//                    m += 1;
//                }
//            }
//        }
//        sr = sum / m;
//        Console.Write(sr);
//    }
//}

// Номер 18
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("Введите кол-во элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double amaxc = a[0];
//        int imaxc = 0;
//        double amaxn = a[0];
//        int imaxn = 0;
//        for (int i = 0; i < n; i=i+2)
//        {
//            if (a[i]>amaxc)
//            {
//                amaxc = a[i];
//                imaxc = i;
//            }
//        }
//        for (int i = 1; i < n; i = i + 2)
//        {
//            if (a[i] > amaxn)
//            {
//                amaxn = a[i];
//                imaxn = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент среди четных элементов");
//        Console.WriteLine(amaxc);
//        Console.WriteLine("Максимальный элемент среди нечетных элементов");
//        Console.WriteLine(amaxn);
//        for (int i = 0; i < n; i++)
//        {
//            if(amaxc>amaxn)
//            {
//                for (int h = 0; h < n/2; h++)
//                {
//                    a[h] = 0;
//                }
//            }
//            else
//            {
//                for (int l = n; l > n/2; l--)
//                {
//                    a[l] = 0;
//                }
//            }
//        }
//        Console.WriteLine("Измененный массив");
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}

// Номер 19
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("Введите кол-во элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double sum = 0;
//        int m = 0;
//        double amax = a[0];
//        int imax = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] > amax)
//            {
//                amax = a[i];
//                imax = i;
//            }
//            sum=sum+ a[i];
//        }
//        Console.WriteLine("Сумма");
//        Console.WriteLine(sum);
//        Console.WriteLine("Максимальный элемент");
//        Console.WriteLine(amax);
//        for (int i = 0; i < n; i++)
//        {
//            if (amax>sum)
//            {
//                a[imax] = 0;
//            }
//            else
//            {
//                a[imax] = amax * amax;
//            }
//        }
//        Console.WriteLine("");
//        for (int i=0; i<n; i++)
//        {
//            Console.WriteLine(a[i]);
//        }
//    }
//}

// Номер 20
//using System;

//class Programm
//{
//    static void Main(string[] args)
//    {
//        string p;
//        Console.WriteLine("Введите кол-во элементов массива A");
//        int n = Convert.ToInt32(Console.ReadLine());
//        double[] a = new double[n];
//        Console.WriteLine("Введите массив A");
//        for (int i = 0; i < n; i++)
//        {
//            p = Console.ReadLine();
//            a[i] = double.Parse(p);
//        }
//        double amin = a[0];
//        int imin = 0;
//        int ineg = 0;
//        double sum = 0;
//        double neg = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < amin)
//            {
//                amin = a[i];
//                imin = i;
//            }
//        }
//        Console.WriteLine("Минимальный элемент");
//        Console.WriteLine(amin);
//        for (int i = 0; i < n; i++)
//        {
//            if (a[i] < 0)
//            {
//                neg = a[i];
//                ineg = i;
//                break;
//            }
//        }
//        Console.WriteLine("Первый отрицательный элемент");
//        Console.WriteLine(neg);
//        for (int i = 0; i < n; i++)
//        {
//            if (ineg < imin)
//            {
//                sum = sum + a[i];
//                i = i + 1;
//            }
//            else
//            {
//                i = i + 1;
//                sum = sum + a[i];

//            }
//        }
//        Console.WriteLine("Сумма элементов");
//        Console.WriteLine(sum);
//    }
//}
