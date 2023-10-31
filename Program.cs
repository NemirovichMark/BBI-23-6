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
using System.Runtime.CompilerServices;
using System.Diagnostics.SymbolStore;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return gcd(b, a % b);
        }

        public class Elem
        {
            private int x, y;
            public Elem(int x1, int y1) {
                int g = gcd(Math.Abs(x1), Math.Abs(y1));
                x = (x1 / g);
                y = (y1 / g);
            }

            public int X()
            {
                return x;
            }
            public int Y()
            {
                return y;
            }

            public void print()
            {
                Console.WriteLine(x + " " + y);
            }
        }

        public static double elemInNum(Elem a)
        {
            return (double)a.X() / a.Y();
        }

        public static Elem addition(Elem a, Elem b)
        {
            return new Elem(a.X() * b.Y() + a.Y() * b.X(), a.Y() * b.Y());
        }

        public static Elem negate(Elem a)
        {
            return new Elem(-a.X(), a.Y());
        }

        public static bool checkSign(Elem a)
        {
            return !(a.X() < 0 && a.Y() >= 0 || a.X() >= 0 && a.Y() < 0);
        }

        public static Elem reverse(Elem a)
        {
            int x = a.X(), y = a.Y();
            return new Elem(y, x);
        }
        public static Elem multiplication(Elem a, Elem b)
        {
            return new Elem(a.X() * b.X(), a.Y() * b.Y());
        }


        static void Main(string[] args)
        {
            // lvl 3 task 1
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            List<Tuple<int, int>> b = new List<Tuple<int, int>>();
            for(int i = 0; i < n; ++i)
            {
                int mini = a[i, 0];
                for(int j = 1; j < m; ++j)
                {
                   mini = Math.Min(mini, a[i, j]);
                }
                Tuple<int, int> tuple = new Tuple<int, int>(mini, i);
                b.Add(tuple);
            }
            b.Sort();
            for(int i = 0; i < n; ++i)
            {
                int p = b[i].Item2;
                for(int j = 0; j < m; ++j)
                {
                    Console.Write(a[p,j] + " ");
                }
                Console.WriteLine();
            }
            //lvl 3 task 2
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == n - 1 || j == 0 || j == m - 1 || i == 0) a[i, j] = 0;
                }
            }
            
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            // lvl 3 task 3
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            int[] b = new int[2 * n - 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    b[j - i + n - 1] += a[i, j];
                }
            }

            foreach(int i in b) {
                Console.WriteLine(i + " ");
            }
            

            //lvl 3 task 4
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    if ((i >= (n / 2)) && (i >= j)) a[i, j] = 1;
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            

            // lvl 3 task 5
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            int posi = 0, posj = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (Math.Abs(a[i, j]) > Math.Abs(a[posi, posj])) {
                        posi = i; posj = j;
                    }
                }
            }

            int[] b = new int[n];
            int[] c = new int[n];

            for(int i = 0; i < n; ++i)
            {
                b[i] = a[k, i];
            }
            for (int i = 0; i < n; ++i)
            {
                a[k, i] = a[posi, i];
            }
            for (int i = 0; i < n; ++i)
            {
                a[posi, i] = b[i];
            }
            for (int i = 0; i < n; ++i)
            {
                c[i] = a[i, k];
            }
            for (int i = 0; i < n; ++i)
            {
                a[i, k] = a[i, posj];
            }
            for (int i = 0; i < n; ++i)
            {
                a[i, posj] = c[i];
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            // 3 lvl 6 task
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            int[] top = new int[n * (n + 1) / 2];
            int[] bot = new int[n * (n - 1) / 2];
            int topPos = 0;
            int botPos = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i <= j) top[topPos++] = a[i, j];
                    else bot[botPos++] = a[i, j];
                }
            }

            foreach (int i in top)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (int i in bot)
            {
                Console.Write(i + " ");
            }

            // lvl 3 task 7 skip
            
            // lvl 3 task 8
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            List<Tuple<int, int>> b = new List<Tuple<int, int>>();
            for (int i = 0; i < n; ++i)
            {
                int cnt = 0;
                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] > 0) cnt++;
                }
                Tuple<int, int> tuple = new Tuple<int, int>(cnt, i);
                b.Add(tuple);
            }
            b.Sort();
            b.Reverse();
            for (int i = 0; i < n; ++i)
            {
                int p = b[i].Item2;
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(a[p, j] + " ");
                }
                Console.WriteLine();
            }
            

            //lvl 3 task 9
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            List<Tuple<int, int>> b = new List<Tuple<int, int>>();
            for (int i = 0; i < m; ++i)
            {
                int cnt = 0;
                for (int j = 0; j < n; ++j)
                {
                    if (a[j, i] < 0) cnt++;
                }
                Tuple<int, int> tuple = new Tuple<int, int>(cnt, i);
                b.Add(tuple);
            }
            b.Sort();
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    int p = b[j].Item2;
                    Console.Write(a[i, p] + " ");
                }
                Console.WriteLine();
            }
            
            // lvl 3 task 10
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            List<Tuple<List<Tuple<int, int>>, List<Tuple<int, int>>>> b = new List<Tuple<List<Tuple<int, int>>, List<Tuple<int, int>>>>();
            for (int i = 0; i < n; ++i)
            {
                List<Tuple<int, int>> p1 = new List<Tuple<int, int>>();
                List<Tuple<int, int>> p2 = new List<Tuple<int, int>>();
                for (int j = 0; j < m; ++j)
                {
                    Tuple<int, int> tuple = new Tuple<int, int>(a[i, j], j);
                    if (j % 2 == 0) p1.Add(tuple);
                    else p2.Add(tuple);
                }
                p1.Sort();
                p1.Reverse();
                p2.Sort();
                Tuple<List<Tuple<int, int>>, List<Tuple<int, int>>> now = new Tuple<List<Tuple<int, int>>, List<Tuple<int, int>>>(p1, p2);
                b.Add(now);
            }
            for (int i = 0; i < n; ++i)
            {
                int pos1 = 0, pos2 = 0;
                for (int j = 0; j < m; ++j)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(b[i].Item1[pos1++].Item1 + " ");
                    }
                    else
                    {
                        Console.Write(b[i].Item2[pos2++].Item1 + " ");
                    }
                }
                Console.WriteLine();
            }
            

            //lvl 3 task 11

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            List<int[]> b = new List<int[]>();
            for (int i = 0; i < n; ++i)
            {
                int[] c = new int[m];
                bool flag = true;
                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] == 0) { flag = false; break; }
                    c[j] = a[i, j];
                }
                if (flag)
                    b.Add(c);
            }
            n = b.Count;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(b[i][j] + " ");
                }
                Console.WriteLine();
            }
            */

            // lvl 3 task 12
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            List<List<Elem>> matrix = new List<List<Elem>>();
            for (int i = 0; i < n; i++)
            {
                List<Elem> list = new List<Elem>();
                for (int j = 0; j < m; j++)
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    list.Add(new Elem(x, 1));
                }
                matrix.Add(list);
            }
            for (int i = 1; i < n; i++)
            {
                for(int j = 0; j < i; ++j)
                {
                    Elem now = multiplication(matrix[i][j], reverse(matrix[j][j]));
                    for (int k = 0; k < m; ++k)
                    {
                        matrix[i][k] = multiplication(matrix[i][k], now);
                    }

                }
            }*/
            Console.ReadKey();
        }
    }
}