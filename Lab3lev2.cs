using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // ввод массива дл€ любой задачи:
            Console.WriteLine("¬ведите n: ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"¬ведите {i + 1}-й элемент");
                a[i] = double.Parse(Console.ReadLine());
            }

# region1
            int min_id = -1;
            double min_elem = 10000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min_elem)
                {
                    min_id = i;
                    min_elem = a[i];
                }
            }
            a[min_id] = min_elem * 2;
#endregion

# region2
            int max_id = -1;
            double max_elem = -1000000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max_elem)
                {
                    max_id = i;
                    max_elem = a[i];
                }
            }
            double s = 0;
            for (int i = 0; i < max_id; i++)
            {
                s += a[i];
            }
            Console.WriteLine(s);
#endregion

# region3
            int min_id = -1;
            double min_elem = 10000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min_elem)
                {
                    min_id = i;
                    min_elem = a[i];
                }
            }
            for (int i = 0; i < min_id; i++)
            {
                a[i] = a[i] * 2;
            }
#endregion

# region4
            int max_id = -1;
            double max_elem = -1000000000000;
            double sr = 0;
            for (int i = 0; i < n; i++)
            {
                sr += a[i];
                if (a[i] > max_elem)
                {
                    max_id = i;
                    max_elem = a[i];
                }
            }
            sr = sr / n;
            double s = 0;
            for (int i = max_id + 1; i < n; i++)
            {
                a[i] = sr;
            }
#endregion

# region5
            int min_id = -1;
            double min_elem = 10000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min_elem)
                {
                    min_id = i;
                    min_elem = a[i];
                }
            }
            int max_id = -1;
            double max_elem = -1000000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max_elem)
                {
                    max_id = i;
                    max_elem = a[i];
                }
            }

            int left = Math.Min(min_elem, max_elem), right = Math.Max(min_elem, max_elem);
            int count_otr = 0;
            for (int i = left + 1; i < right; i++) {
                if (a[i] < 0) {
                    count_otr++;
                }
            }
            double[] b = new double[count_otr];
            int jj = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (a[i] < 0)
                {
                    b[jj] = a[i];
                    jj++;
                }
            }
#endregion

# region6
            Console.WriteLine("¬ведите n: ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n + 1];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"¬ведите {i + 1}-й элемент");
                a[i] = double.Parse(Console.ReadLine());
            }


            double p = double.Parse(Console.ReadLine());
            double sr = 0;
            for (int i = 0; i < n; i++)
            {
                sr += a[i];
            }
            sr = sr / n;
            double found = a[0];
            int ifound = 0;
            for (int i = 1; i < n; i++)
            {
                if (Math.Abs(a[i] - sr) < Math.Abs(found - sr))
                {
                    found = a[i];
                    ifound = i;
                }
            }

            for (int i = n - 1; i > ifound; i--)
            {
                a[i + 1] = a[i];
            }
            a[ifound + 1] = p;

            Console.WriteLine("{0}", string.Join(", ", a));
#endregion


# region7
            int max_id = -1;
            double max_elem = -1000000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max_elem)
                {
                    max_id = i;
                    max_elem = a[i];
                }
            }
            a[max_id + 1] = a[max_id + 1] * 2;
#endregion


# region8
            int max_id = -1;
            double max_elem = -1000000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max_elem)
                {
                    max_id = i;
                    max_elem = a[i];
                }
            }

            int min_id = -1;
            double min_elem = 10000000000;
            for (int i = max_id + 1; i < n; i++)
            {
                if (a[i] < min_elem)
                {
                    min_id = i;
                    min_elem = a[i];
                }
            }

            a[max_id] = min_elem;
            a[min_elem] = max_elem;
#endregion

# region9
            int min_id = -1;
            double min_elem = 10000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min_elem)
                {
                    min_id = i;
                    min_elem = a[i];
                }
            }
            int max_id = -1;
            double max_elem = -1000000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max_elem)
                {
                    max_id = i;
                    max_elem = a[i];
                }
            }

            int left = Math.Min(min_elem, max_elem), right = Math.Max(min_elem, max_elem);
            double srr = 0;
            for (int i = left + 1; i < right; i++)
            {
                srr += a[i];
            }
            srr = srr / (right - left - 1);
#endregion

# region10
            int min_id = -1;
            double min_elem = 10000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min_elem && a[i] > 0)
                {
                    min_id = i;
                    min_elem = a[i];
                }
            }

            for (int i = min_id; i < n; ++i)
            {
                a[i] = a[i + 1];
            }
            double[] c = new double[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                c[i] = a[i];
            }
            Console.WriteLine("{0}", string.Join(", ", c));
#endregion

# region11
            double p = double.Parse(Console.ReadLine());
            int id = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    id = i;
                }
            }

            double[] c = new double[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if (i <= id) { 
                c[i] = a[i];
                }
                else 
                {
                    if (i = id + 1)
                    {
                        c[i] = p;
                    }
                    else
                    {
                        c[i] = a[i - 1];
                    }
                }
            }

            Console.WriteLine("{0}", string.Join(", ", c));
#endregion

# region12
            int max_id = -1;
            double max_elem = -1000000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max_elem)
                {
                    max_id = i;
                    max_elem = a[i];
                }
            }

            double sum_before_max = 0;
            for (int i = max_id+1; i < n; i++)
            {
                sum_before_max += a[i];
            }

            for (int i = 0; i < n; ++i)
            {
                if (a[i] < 0)
                {
                    a[i] = sum_before_max;
                    break;
                }
            }
            Console.WriteLine("{0}", string.Join(", ", a));
#endregion

# region13
            int max_id = -1;
            double max_elem = -1000000000000;
            for (int i = 0; i < n; i+=2)
            {
                if (a[i] > max_elem)
                {
                    max_id = i;
                    max_elem = a[i];
                }
            }

            a[max_id] = max_id;
#endregion

# region14
            int max_id = -1;
            double max_elem = -1000000000000;
            for (int i = 0; i < n; i += 2)
            {
                if (a[i] > max_elem)
                {
                    max_id = i;
                    max_elem = a[i];
                }
            }

            int id_first = -1;
            int elem_first = 1000000;
            for (int i = 0; i < n; ++i)
            {
                if (a[i] < 0)
                {
                    id_first = i;
                    elem_first = a[i];
                    break;
                }
            }

            a[max_id] = elem_first;
            a[id_first] = max_elem;
#endregion

# region15
            Console.WriteLine("¬ведите n: ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"¬ведите {i + 1}-й элемент");
                a[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("¬ведите m: ");
            int m = int.Parse(Console.ReadLine());
            double[] b = new double[m];
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"¬ведите {i + 1}-й элемент");
                b[i] = double.Parse(Console.ReadLine());
            }

            int k = int.Parse(Console.ReadLine());

            double[] c = new double[n+m];
            for (int i = 0;i <= k; i++)
            {
                c[i] = a[i];
            }
            for (int i = k + 1; i <= k+m ; i++)
            {
                c[i] = b[i-(k+1)];
            }
            for (int i = k+m+1; i < m+n; i++)
            {
                c[i] = a[i-m];
            }
#endregion

# region16
            double sr = 0;
            for (int i = 0; i < n; i++)
            {
                sr += a[i];
            }
            sr = sr / n;

            int count = 0;
            for (int i = 0; i<n ; i++)
            {
                if (a[i] < sr) { count++; }
            }

            double[] c = new double[count];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < sr) {
                    c[j] = i;
                    j++;
                }
            }
#endregion

# region17
            int min_id = -1;
            double min_elem = 10000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min_elem)
                {
                    min_id = i;
                    min_elem = a[i];
                }
            }
            int max_id = -1;
            double max_elem = -1000000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max_elem)
                {
                    max_id = i;
                    max_elem = a[i];
                }
            }

            double sr = 0;
            int count = 0;
            if (max_id < min_id)
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[i] > 0)
                    {
                        sr += a[i];
                        count++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (a[i] < 0)
                    {
                        sr += a[i];
                        count++;
                    }
                }
            }
            sr /= count;
#endregion

# region18
            int max_id_chet = -1;
            double max_elem_chet = -1000000000000;
            for (int i = 0; i < n; i+=2)
            {
                if (a[i] > max_elem_chet)
                {
                    max_id_chet = i;
                    max_elem_chet = a[i];
                }
            }


            int max_id_nechet = -1;
            double max_elem_nechet = -1000000000000;
            for (int i = 1; i < n; i += 2)
            {
                if (a[i] > max_elem_nechet)
                {
                    max_id_nechet = i;
                    max_elem_nechet = a[i];
                }
            }

            if (max_elem_chet > max_elem_nechet)
            {
                for (int i=0; i < n/2; i++)
                {
                    a[i] = 0;
                }
            }
            else
            {
                for (int i = n/2; i < n; i++)
                {
                    a[i] = 0;
                }
            }
#endregion

# region19
            int max_id = -1;
            double max_elem = -1000000000000;
            double s=0;
            for (int i = 0; i < n; i++)
            {
                s += a[i];
                if (a[i] > max_elem)
                {
                    max_id = i;
                    max_elem = a[i];
                }
            }

            if (max_elem > s)
            {
                a[max_id] = 0;
            }
            else
            {
                a[max_id] = a[max_id] * 2;
            }
#endregion

# region20
            int min_id = -1;
            double min_elem = 10000000000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min_elem)
                {
                    min_id = i;
                    min_elem = a[i];
                }
            }

            int first_otr = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    first_otr = i;
                    break;
                }
            }

            double s = 0;
            if (first_otr < min_id)
            {
                for (int i = 0; i < n; i += 2)
                {
                    s += a[i];
                }
            }
            else
            {
                for (int i = 1; i < n; i += 2)
                {
                    s += a[i];
                }
            }
#endregion
        }
    }
}