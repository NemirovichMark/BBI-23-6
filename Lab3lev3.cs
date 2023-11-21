using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
# region3
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент");
                a[i] = double.Parse(Console.ReadLine());
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

            double now_el = 0;
            for (int i = 0;i < max_id; i+=2)
            {
                now_el = a[i];
                a[i] = a[i+1];
                a[i+1] = now_el;
            }
            Console.WriteLine("{0}", string.Join(", ", a));
#endregion

# region6
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент");
                a[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите n2: ");
            int n2 = int.Parse(Console.ReadLine());
            double[] a2 = new double[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент");
                a2[i] = double.Parse(Console.ReadLine());
            }

            double max_count = 0;
            double count = 0;
            int first = -1, last = -1;
            for (int i = 0; i < n; i++)
            {
                count = 1;
                double elem_now = a[i];
                first = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < elem_now)
                    {
                        count++;
                        elem_now = a[j];
                        if (count > max_count)
                        {
                            max_count = count;
                            last = j;
                        }
                    }
                    else
                    {
                        if (count > max_count)
                        {
                            max_count = count;
                            last = j;
                        }
                        break;
                    }
                }
            }

            double[] a_before = new double[max_count];
            int jj = 0;
            for (int i = first;i <= last; i++)
            {
                a_before[jj] = a[i];
                jj++;
            }


            //
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент");
                a[i] = double.Parse(Console.ReadLine());
            }
            int max_count = 0;
            int count = 0;
            int first = -1, last = -1;
            for (int i = 0; i < n; i++)
            {
                count = 1;
                double elem_now = a[i];

                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < elem_now)
                    {
                        count++;
                        elem_now = a[j];
                        if (count > max_count)
                        {
                            max_count = count;
                            first = i;
                            last = j;
                        }
                    }
                    else
                    {
                        if (count > max_count)
                        {
                            max_count = count;
                            first = i;
                            last = j;
                        }
                        break;
                    }
                }
            }
            double[] a_before = new double[max_count];
            int jj = 0;
            for (int i = first; i <= last; i++)
            {
                a_before[jj] = a[i];
                jj++;
            }


            Console.WriteLine("Введите n: ");
            int n2 = int.Parse(Console.ReadLine());
            double[] a2 = new double[n];
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент");
                a2[i] = double.Parse(Console.ReadLine());
            }
            int max_count2 = 0;
            int count2 = 0;
            int first2 = -1, last2 = -1;
            for (int i = 0; i < n2; i++)
            {
                count2 = 1;
                double elem_now2 = a2[i];

                for (int j = i + 1; j < n2; j++)
                {
                    if (a2[j] < elem_now2)
                    {
                        count2++;
                        elem_now2 = a2[j];
                        if (count2 > max_count2)
                        {
                            max_count2 = count2;
                            first2 = i;
                            last2 = j;
                        }
                    }
                    else
                    {
                        if (count2 > max_count2)
                        {
                            max_count2 = count2;
                            first2 = i;
                            last2 = j;
                        }
                        break;
                    }
                }
            }
            double[] a_before2 = new double[max_count2];
            int jj = 0;
            for (int i = first2; i <= last2; i++)
            {
                a_before2[jj] = a2[i];
                jj++;
            }


            double[] ans = new double[max_count2 + max_count];
            int j1 = 0, j2 = 0, jj = 0;
            while (true)
            {
                if (j1 == a_before.Lenght)
                {
                    for (int i = j2; i < a_before2.Lenght; i++)
                    {
                        ans[jj] = a_before2[i];
                        jj++;
                    }
                    break;
                }
                else if (j2 == a_before2.Lenght)
                {
                    for (int i = j1; i < a_before.Lenght; i++)
                    {
                        ans[jj] = a_before[i];
                        jj++;
                    }
                    break;
                }
                else
                {

                    if (a_before[j1] > a_before2[j2])
                    {
                        ans[jj] = a_before[j1];
                        j1++;
                    }
                    else
                    {
                        ans[jj] = a_before2[j2];
                        j2++;
                    }
                    jj++;
                }
            }

            //

#endregion
        }
    }
}