using System.Collections.Generic;
using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using System.Xml.Schema;
using System.IO;
using System.Text;
using System.Xml;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Win32;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            //1 lvl
            //1 task
            
            int n = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[n];
            double s = 0;
            for (int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                s += a[i];
            }
            for(int i = 0; i < n; i++)
            {
                a[i] /= s;
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            //2 tast
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            s = 0;
            int k = 0;
            for(int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                if (a[i] > 0)
                {
                    k++;
                    s += a[i];
                }
            }
            double sr = s / k;
            for(int i = 0; i < n; ++i)
            {
                if (a[i] > 0) a[i] = sr;
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            // 3 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            double[] b = new double[n];
            for(int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < n; ++i) b[i] = Convert.ToDouble(Console.ReadLine());
            double[] c = new double[n];//сумма
            double[] d = new double[n];//разность
            for(int i = 0; i < n; ++i)
            {
                c[i] = a[i] + b[i];
                d[i] = a[i] - b[i];
            }
            foreach (double i in c) Console.Write(i + " ");
            Console.WriteLine();
            foreach (double i in d) Console.Write(i + " ");
            Console.WriteLine();

            //4 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            s = 0;
            for(int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                s += a[i];
            }
            for(int i = 0; i < n; ++i)
            {
                a[i] = s / n;
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            // 5 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            b = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < n; ++i) b[i] = Convert.ToDouble(Console.ReadLine());
            s = 0;
            for (int i = 0; i < n; ++i) s += a[i] * b[i];
            Console.WriteLine(s);

            // 6 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            s = 0;
            for(int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                s += a[i] * a[i];
            }
            Console.WriteLine(s);


            // 7 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            s = 0;
            for(int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                s += a[i];
            }
            for(int i = 0; i< n; ++i)
            {
                if (a[i] > s / n) a[i] = 0;
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            //8 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            k = 0;
            for(int i = 0; i< n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                k += (a[i] < 0 ? 1 : 0);
            }
            Console.WriteLine(k);


            //9 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            s = 0;
            for(int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                s += a[i];
            }
            k = 0;
            foreach (var i in a) k += (i > s / n ? 1 : 0);
            Console.WriteLine(k);

            //10 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            double p = Convert.ToDouble(Console.ReadLine());
            double q = Convert.ToDouble(Console.ReadLine());
            k = 0;
            for(int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                k += (a[i] >= p && a[i] <= q ? 1 : 0);
            }
            Console.WriteLine(k);

            //11 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            k = 0;
            for(int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                k += (a[i] > 0 ? 1 : 0);
            }
            b = new double[k];
            for(int i = 0, j = 0; i < n; ++i) if (a[i] > 0) b[j++] = a[i];
            foreach(var i in b) Console.Write(i + " ");
            Console.WriteLine();

            //12 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            int pos = -1;
            double val = -1;
            for(int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                val = (a[i] < 0 ? a[i] : val);
                pos = (a[i] < 0 ? i : pos);
            }
            Console.Write(val + " " + pos + "\n");

            // 13 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            b = new double[n / 2 + n % 2]; // чётные
            c = new double[n / 2]; // нечётные
            for(int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                if (i % 2 == 0) b[i / 2] = a[i];
                else c[i / 2] = a[i];
            }
            foreach(var i in b) Console.Write(i + " ");
            Console.WriteLine();
            foreach (var i in c) Console.Write(i + " ");
            Console.WriteLine();


            // 14 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            s = 0;
            bool flag = false;
            for(int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                if (a[i] < 0) flag = true;
                if (!flag) s += a[i] * a[i];
            }
            Console.WriteLine(s);

            //15 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            b = new double[n];
            for(int i = 0; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                b[i] = 0.5 * Math.Log(a[i], Math.E);
            }
            for(int i = 0; i < n; ++i) Console.WriteLine(a[i] + " " + b[i]);



            // 2 lvl
            // 1 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            pos = 0;
            for(int i = 1; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                pos = (a[i] < a[pos] ? i : pos);
            }
            a[pos] *= 2;
            foreach(var i in a) Console.Write(i + " ");
            Console.WriteLine();

            // 2 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            pos = 0;
            for(int i = 1; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                pos = (a[i] > a[pos] ? i : pos);
            }
            s = 0;
            for (int i = 0; i < pos; ++i) s += a[i];
            Console.WriteLine(s);

            // 3 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            pos = 0;
            for (int i = 1; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                pos = (a[i] < a[pos] ? i : pos);
            }
            for (int i = 0; i < n; ++i)
            {
                if (i < pos) a[i] *= 2;
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            // 4 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            pos = 0;
            s = 0;
            for (int i = 1; i < n; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                s += a[i];
                pos = (a[i] > a[pos] ? i : pos);
            }
            for(int i = 0; i < n; ++i)
            {
                if (i > pos)
                {
                    a[i] = s / n;
                }
                Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine();

            // 5 task

            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            int pmin = 0, pmax = 0;
            for(int i = 0; i < n; ++i)
            {
                if (a[i] > a[pmax])
                {
                    pmax = i;
                }
                if (a[i] < a[pmin])
                {
                    pmin = i;
                }
            }

            int l = Math.Min(pmin, pmax), r = Math.Max(pmin, pmax);
            int cnt = 0;
            for(int i = l + 1; i < r; ++i)
            {
                if (a[i] < 0) cnt++;
            }
            c = new double[cnt];
            int u = 0;
            for(int i = l + 1; i < r; ++i)
            {
                if (a[i] < 0)
                {
                    c[u++] = a[i];
                }
            }
            foreach(var i in c) Console.Write(i + " ");
            Console.WriteLine();
            

            // 6 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n + 1];
            for(int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            double P = Convert.ToDouble(Console.ReadLine());
            s = 0;
            for (int i = 0; i < n; ++i) s += a[i];
            sr = s / n;
            pos = 0;
            for(int i = 0; i < n; ++i)
            {
                if (Math.Abs(a[pos] - sr) > Math.Abs(a[i] - sr))
                {
                    pos = i;
                }
            }
            pos++;
            for(int i = n; i > pos; --i)
            {
                a[i] = a[i - 1];
            }
            a[pos] = P;
            foreach(var i in a) Console.Write(i + " "); Console.WriteLine();
            Console.WriteLine();

            // 7 task

            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n + 1];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            pmax = 0;
            for(int i = 0; i < n; ++i)
            {
                if (a[pmax] < a[i])
                {
                    pmax = i;
                }
            }
            if (pmax != n - 1)
            {
                a[pmax + 1] *= 2;
            }

            foreach (var i in a) Console.Write(i + " ");
            Console.WriteLine();

            // 8 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n + 1];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            pmax = 0;
            for (int i = 0; i < n; ++i)
            {
                if (a[pmax] < a[i])
                {
                    pmax = i;
                }
            }
            if (pmax != n - 1)
            {
                pmin = pmax + 1;
                for(int i = pmax + 2; i < n; ++i)
                {
                    if (a[i] < a[pmin]) pmin = i;
                }
                a[pmax] += a[pmin];
                a[pmin] = a[pmax] - a[pmin];
                a[pmax] -= a[pmin];
            }
            foreach (var i in a) Console.Write(i + " ");
            Console.WriteLine();

            // 9 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            pmin = 0; pmax = 0;
            for (int i = 0; i < n; ++i)
            {
                if (a[i] > a[pmax])
                {
                    pmax = i;
                }
                if (a[i] < a[pmin])
                {
                    pmin = i;
                }
            }
            l = Math.Min(pmin, pmax); r = Math.Max(pmin, pmax);
            s = 0;
            cnt = 0;
            for (int i = l + 1; i < r; ++i)
            {
                s += a[i];
                cnt++;
            }
            Console.WriteLine(s/cnt);

            // 10 task

            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            pmin = 0;
            for(int i = 0; i < n; ++i)
            {
                if (a[i] > 0 && a[pmin] > a[i]) pmin = i;
            }
            for(int i = pmin; i < n; ++i)
            {
                a[i] = a[i + 1];
            }
            c = new double[n - 1];
            for(int i = 0; i < n - 1; ++i)
            {
                c[i] = a[i];
            }
            foreach(var i in c) Console.Write(i + " ");
            Console.WriteLine();

            // 11 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            int last = 0;
            P = Convert.ToDouble(Console.ReadLine());
            c = new double[n + 1];
            for(int i = 0; i < n; ++i)
            {
                if (a[i] > 0) last = i;
            }
            for(int i = 0; i <= last; ++i)
            {
                c[i] = a[i];
            }
            c[last + 1] = P;
            for(int i = last + 2; i <= n; ++i)
            {
                c[i] = a[i - 1];
            }
            foreach (var i in c) Console.Write(i + " ");
            Console.WriteLine();

            //12 task

            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            int w = 0;
            pmax = 0;
            cnt = 0;
            int f = 0;
            for(int i = 0; i < n; ++i)
            {
                if (a[i] > a[pmax]) pmax = i;
                if (cnt == 0 && a[i] < 0) f = i;
                if (a[i] < 0) cnt++;
            }
            s = 0;
            for(int i = pmax + 1; i < n; ++i)
            {
                s += a[i];
            }
            if (cnt > 0)
            {
                a[f] = s;
            }
            foreach(var i in a) Console.WriteLine(i + " ");
            Console.WriteLine();


            // 13 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            pmax = 0;
            for (int i = 0; i < n; i += 2)
            {
                if (a[i] > a[pmax]) pmax = i;
            }
            a[pmax] = pmax;
            foreach (var i in a) Console.WriteLine(i + " ");
            Console.WriteLine();


            // 14 task

            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            pmax = 0;
            bool fl = true;
            f = 0;
            for (int i = 0; i < n; i += 2)
            {
                if (a[i] > a[pmax]) pmax = i;
                if (fl && a[i] < 0)
                {
                    f = i;
                    fl = false;
                }
            }
            if (!flag)
            {
                double t = a[pmax];
                a[pmax] = a[f];
                a[f] = t;
            }
            foreach (var i in a) Console.Write(i + " ");
            Console.WriteLine();
            

            //15 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for(int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            b = new double[m];
            for (int i = 0; i < m; ++i) b[i] = Convert.ToDouble(Console.ReadLine());
            c = new double[m + n];
            k = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= k; ++i)
            {
                c[i] = a[i];
            }
            for(int i = 0; i < m; ++i)
            {
                c[i + k + 1] = b[i];
            }
            for(int i = k + 1; i < n; ++i)
            {
                c[i + m] = a[i];
            }
            foreach (var i in c) Console.Write(i + " ");
            Console.WriteLine();

            //16 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            s = 0;
            for(int i = 0; i < n; ++i)
            {
                s += a[i];
            }
            sr = s / n;
            cnt = 0;
            for(int i = 0; i < n; ++i)
            {
                if (a[i] < sr) cnt++;
            }
            int[] g = new int[cnt];
            int z = 0;
            for(int i = 0; i < n; ++i)
            {
                if (a[i] < sr) g[z++] = i;
            }
            foreach(int i in g) Console.Write(i + " ");
            Console.WriteLine();

            // 17 task

            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            pmin = 0; pmax = 0;
            double sumpol = 0, sumotr = 0;
            int cntpol = 0, cntotr = 0;
            for (int i = 0; i < n; ++i)
            {
                if (a[i] > a[pmax])
                {
                    pmax = i;
                }
                if (a[i] < a[pmin])
                {
                    pmin = i;
                }
                if (a[i] > 0)
                {
                    sumpol += a[i];
                    cntpol++;
                }
                else if (a[i] < 0)
                {
                    sumotr += a[i];
                    cntotr++;
                }
            }
            if (pmax < pmin)
            {
                Console.WriteLine(sumpol / cntpol);
            }
            else
            {
                Console.WriteLine(sumotr/cntotr);
            }

            // 18 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            int pmax0 = 0, pmax1 = 0;

            for (int i = 0; i < n; ++i)
            {
                if (i % 2 == 0 && a[i] > a[pmax0])
                {
                    pmax0 = i;
                }
                if (i % 2 == 1 && a[i] > a[pmax1])
                {
                    pmax1 = i;
                }
            }

            if (a[pmax0] > a[pmax1])
            {
                for(int i = 0; i < n/2; ++i)
                {
                    a[i] = 0;
                }
            }
            else
            {
                for(int i = n/2 + 1; i < n; ++i)
                {
                    a[i] = 0;
                }
            }
            foreach(var i in a) Console.Write(i + " ");
            Console.WriteLine();

            // 19 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            pmax = 0;
            s = 0;
            for (int i = 0; i < n; ++i)
            {
                s += a[i];
                if (a[i] > a[pmax])
                {
                    pmax = i;
                }
            }
            if (s < a[pmax])
            {
                a[pmax] = 0;
            }
            else
            {
                a[pmax] *= 2;
            }
            foreach (var i in a) Console.Write(i + " ");
            Console.WriteLine();
            // 20 task
            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            pmin = 0;
            double s0 = 0, s1 = 0;
            fl = true;
            pos = 0;
            for (int i = 0; i < n; ++i)
            {
                s0 += (i % 2 == 0 ? a[i] : 0);
                s1 += (i % 2 == 1 ? a[i] : 0);
                if (a[i] < a[pmin])
                {
                    pmin = i;
                }
                if (fl && a[i] < 0)
                {
                    fl = false;
                    pos = i;
                }
            }
            if (pos < pmin)
            {
                Console.WriteLine(s0);
            }
            else
            {
                Console.WriteLine(s1);
            }

            // 3 lvl 9 task

            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            int len_max = 0;
            for(int i = 0; i < n; ++i)
            {
                int len_now = 1;
                while (i < n - 1 && a[i] < a[i + 1])
                {
                    i++;
                    len_now++;
                }
                len_max = Math.Max(len_max, len_now);
            }
            Console.WriteLine(len_max);
            // task 10

            n = Convert.ToInt32(Console.ReadLine());
            a = new double[n];
            for (int i = 0; i < n; ++i) a[i] = Convert.ToDouble(Console.ReadLine());
            b = new double[2 * n];
            for(int i = 0, pp = 0; i < n; ++i)
            {
                b[pp++] = a[i];
                b[pp++] = a[i];
            }
            foreach(var i in b) Console.Write(i + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
