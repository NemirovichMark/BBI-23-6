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

            double max_count = 0;
            double count = 0;
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
                        max_count = Math.Max(max_count, count);
                    }
                    else
                    {
                        max_count = Math.Max(max_count, count);
                        break;
                    }
                }
            }
            Console.WriteLine(max_count);
#endregion
        }
    }
}