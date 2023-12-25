using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
class Programm
{
    static int[] QuickSort(int[] x, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return x;
        }
        int pivotIndex = GetPivotIndex(x, minIndex, maxIndex);
        QuickSort(x, minIndex, pivotIndex - 1);
        QuickSort(x, pivotIndex + 1, maxIndex);
        return x;
    }
    static int GetPivotIndex(int[] x, int minIndex, int maxIndex)
    {
        int pivot = minIndex;
        for (int i = minIndex; i < maxIndex; i++)
        {
            if (x[i] < x[maxIndex])
            {
                Swap(ref x[pivot], ref x[i]);
                pivot++;
            }
        }
        Swap(ref x[pivot], ref x[maxIndex]);
        return pivot;
    }
    static void Swap(ref int leftItem, ref int rightItem)
    {
        int temp = leftItem;
        leftItem = rightItem;
        rightItem = temp;
    }
    static void Main(string[] args)
    {
        int n, m;
        Console.WriteLine("Введите количество строк");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов");
        m = int.Parse(Console.ReadLine());
        if (n * m == 0)
        {
            Console.WriteLine(" Матрица пустая ");
            return;
        }
        int[][] a = new int[n][];
        for (int i = 0; i < n; i++)
        {
            a[i] = new int[m];
        }
        Console.WriteLine("Введите матрицу A");
        for (int i = 0; i < n; ++i)
        {
            Console.WriteLine($"Введите {i+1} строку");
            for (int j = 0; j < m; ++j)
            {
                a[i][j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Введенная матрица A");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; ++j)
            {
                Console.Write($"{a[i][j]} ");
            
}
        }
        Console.WriteLine();
        for (int i =0; i < n; i++)
        {
            QuickSort(a[i], 0, a.Length - 1);
        }
        Console.WriteLine("Отсортированная матрица");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{a[i]} ");
        }
    }
}