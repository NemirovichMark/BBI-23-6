using System;

namespace ConsoleApp1
{
    internal class Program1
    {
            
                1.1 
                int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] /= sum;
                }

                1.2                 
                int[] array = new int[] { 1, -2, 3, -4, 5, 6, -7, 8 };
                int positiveSum = 0;
                int positiveCount = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        positiveSum += array[i];
                        positiveCount++;
                    }
                }
                int positiveAverage = positiveSum / positiveCount;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = positiveAverage;
                    }
                }
                
                
                1.3. 
                int[] array1 = new int[] { 1, 2, 3, 4 };
                int[] array2 = new int[] { 5, 6, 7, 8 };
                int[] sumArray = new int[array1.Length];
                int[] diffArray = new int[array1.Length];
                for (int i = 0; i < array1.Length; i++)
                {
                    sumArray[i] = array1[i] + array2[i];
                    diffArray[i] = array1[i] - array2[i];
                }
                
                
                1.4 
                int[] array = new int[] { 1, 2, 3, 4, 5 };
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                int average = sum / array.Length;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] -= average;
                }
                
                
                1.5 
                int[] vector1 = new int[] { 1, 2, 3, 4 };
                int[] vector2 = new int[] { 5, 6, 7, 8 };
                int scalarProduct = 0;
                for (int i = 0; i < vector1.Length; i++)
                {
                    scalarProduct += vector1[i] * vector2[i];
                }
                
                
                1.6 
                int[] vector = new int[] { 1, 2, 3, 4, 5 };
                double length = 0;
                for (int i = 0; i < vector.Length; i++)
                {
                    length += Math.Pow(vector[i], 2);
                }
                length = Math.Sqrt(length);
                
                
                1.7 
                int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                int average = sum / array.Length;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > average)
                    {
                        array[i] = 0;
                    }
                }
                
                
                1.8.
                int[] array = new int[] { 1, -2, 3, -4, 5, 6 };
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        count++;
                    }
                }
                
                
                1.9 
                int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                int average = sum / array.Length;
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > average)
                    {
                        count++;
                    }
                }
                
                
                1.10 
                int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int p = 3;
                int q = 8;
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > p && array[i] < q)
                    {
                        count++;
                    }
                }
                
                
                1.11
                int[] array = new int[] { 1, -2, 3, -4, 5, 6, -7, 8, 9, 10 };
                List<int> positiveElements = new List<int>();
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        positiveElements.Add(array[i]);
                    }
                }
                int[] positiveArray = positiveElements.ToArray();
                
                
                1.12 
                int[] array = new int[] { 1, -2, 3, -4, 5, 6, -7, 8 };
                int lastNegativeValue = 0;
                int lastNegativeIndex = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        lastNegativeValue = array[i];
                        lastNegativeIndex = i;
                    }
                }
                
                
               1.13
                int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] evenArray = new int[array.Length / 2];
                int[] oddArray = new int[array.Length - evenArray.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenArray[i / 2] = array[i];
                    }
                    else
                    {
                        oddArray[i / 2] = array[i];
                    }
                }
                
                
                1.14
                int[] array = new int[] { 1, -2, 3, -4, 5, 6, -7, 8, 9, 10, -11 };
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        break;
                    }
                    sum += array[i] * array[i];
                }
                
                
                1.15 
                int[] x = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                double[] y = new double[x.Length];
                for (int i = 0; i < x.Length; i++)
                {
                    y[i] = 0.5 * Math.Log(x[i]);
                }
 
                2.3
                int[] array = { 5, 10, 3, 7, 2 };
                
                int minIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[minIndex])
                    {
                        minIndex = i;
                    }
                }
                
                for (int i = 0; i < minIndex; i++)
                {
                    array[i] *= 2;
                }
                
                
                2.4
                int[] array = { 5, 10, 3, 7, 2 };
                
                int maxIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[maxIndex])
                    {
                        maxIndex = i;
                    }
                }
                
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                
                int avg = sum / array.Length;
                
                for (int i = maxIndex + 1; i < array.Length; i++)
                {
                    array[i] = avg;
                }
                
                
                2.5 
                int[] array = { 5, -10, 3, -7, 2, -4, 6, -8 };
                
                int maxIndex = 0;
                int minIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[maxIndex])
                    {
                        maxIndex = i;
                    }
                    if (array[i] < array[minIndex])
                    {
                        minIndex = i;
                    }
                }
                
                int start = Math.Min(maxIndex, minIndex);
                int end = Math.Max(maxIndex, minIndex);
                
                int[] result = new int[end - start - 1];
                int resultIndex = 0;
                
                for (int i = start + 1; i < end; i++)
                {
                    if (array[i] < 0)
                    {
                        result[resultIndex] = array[i];
                        resultIndex++;
                    }
                }
                
                int[] array = { 5, 8, 3, 2, 9, 1, 4, 7 };
                        int p = 6;
                
                2.6
                        int closestIndex = FindClosestIndex(array);
                        Array.Resize(ref array, array.Length + 1);
                        Array.Copy(array, closestIndex, array, closestIndex + 1, array.Length - closestIndex - 1);
                        array[closestIndex + 1] = p;
                
                       2.7
                        int maxIndex = Array.IndexOf(array, array.Max());
                        if (maxIndex < array.Length - 1)
                            array[maxIndex + 1] *= 2;
                
                        2.8
                
                        int minIndex = maxIndex + 1;
                        for (int i = maxIndex + 2; i < array.Length; i++)
                        {
                            if (array[i] < array[minIndex])
                                minIndex = i;
                        }
                        int temp = array[minIndex];
                        array[minIndex] = array[maxIndex];
                        array[maxIndex] = temp;
                
                        2.9
                        int startIndex = Math.Min(minIndex, maxIndex) + 1;
                        int endIndex = Math.Max(minIndex, maxIndex);
                        double sum = 0;
                        int count = 0;
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            sum += array[i];
                            count++;
                        }
                        double average = sum / count;
                
                        2.10
                int[] array = { 5, 10, 3, 7, 2 };
                        int minPositiveIndex = Array.IndexOf(array, array.Where(x => x > 0).Min());
                        array = array.Where((x, index) => index != minPositiveIndex).ToArray();
                    }
                
                    static int FindClosestIndex(int[] array)
                    {
                        int sum = 0;
                        foreach (int num in array)
                        {
                            sum += num;
                        }
                        double average = (double)sum / array.Length;
                
                        int closestIndex = 0;
                        int diff = Math.Abs(array[0] - average);
                        for (int i = 1; i < array.Length; i++)
                        {
                            int currentDiff = Math.Abs(array[i] - average);
                            if (currentDiff < diff)
                            {
                                diff = currentDiff;
                                closestIndex = i;
                            }
                        }
                
                        return closestIndex;
                2.11
                int[] array = { 5, 10, 3, 7, 2 };
                int lastPositiveIndex = -1;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] > 0)
                        {
                            lastPositiveIndex = i;
                        }
                    }
                    if (lastPositiveIndex != -1)
                    {
                        Array.Resize(ref array, array.Length + 1);
                        for (int i = array.Length - 1; i > lastPositiveIndex + 1; i--)
                        {
                            array[i] = array[i - 1];
                        }
                        array[lastPositiveIndex + 1] = p;
                    }
                
                
                2.12
                int[] array = { 5, 10, 3, 7, 2 };
                 int maxIndex = 0;
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i] > array[maxIndex])
                        {
                            maxIndex = i;
                        }
                    }
                    int sum = 0;
                    for (int i = maxIndex + 1; i < array.Length; i++)
                    {
                        sum += array[i];
                    }
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] < 0)
                        {
                            array[i] = sum;
                            break;
                        }
                    }
                
                2.13
                int[] array = { 5, 10, 3, 7, 2 };
                int maxIndex = -1;
                    int max = int.MinValue;
                    for (int i = 0; i < array.Length; i += 2)
                    {
                        if (array[i] > max)
                        {
                            maxIndex = i;
                            max = array[i];
                        }
                    }
                    if (maxIndex != -1)
                    {
                2.14
                int[] array = { 5, 10, 3, 7, 2 };
                int maxIndex = 0;
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i] > array[maxIndex])
                        {
                            maxIndex = i;
                        }
                    }
                    int firstNegativeIndex = -1;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] < 0)
                        {
                            firstNegativeIndex = i;
                            break;
                        }
                    }
                    if (firstNegativeIndex != -1)
                    {
                        int temp = array[maxIndex];
                        array[maxIndex] = array[firstNegativeIndex];
                        array[firstNegativeIndex] = temp;
                    }
                
                2.15
                int[] result = new int[a.Length + b.Length];
                    for (int i = 0; i <= k; i++)
                    {
                        result[i] = a[i];
                    }
                    for (int i = 0; i < b.Length; i++)
                    {
                        result[k + 1 + i] = b[i];
                    }
                    for (int i = k + 1; i < a.Length; i++)
                    {
                        result[b.Length + i] = a[i];
                    }
                    return result;
                
                2.16
                int[] array = { 5, 10, 3, 7, 2 };
                    double average = array.Average();
                    List<int> indexes = new List<int>();
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] < average)
                        {
                            indexes.Add(i);
                        }
                    }
                    return indexes.ToArray();
                
                2.17
                int[] array = { 5, 10, 3, 7, 2 };
                int maxIndex = Array.IndexOf(array, array.Max());
                int minIndex = Array.IndexOf(array, array.Min());
                
                if (maxIndex < minIndex)
                {
                    double sum = 0;
                    int count = 0;
                
                    foreach (int num in array)
                    {
                        if (num > 0)
                        {
                            sum += num;
                            count++;
                        }
                    }
                
                    double average = sum / count;
                    Console.WriteLine("Среднее арифметическое положительных элементов: " + average);
                }
                else
                {
                    double sum = 0;
                    int count = 0;
                
                    foreach (int num in array)
                    {
                        if (num < 0)
                        {
                            sum += num;
                            count++;
                        }
                    }
                
                    double average = sum / count;
                    Console.WriteLine("Среднее арифметическое отрицательных элементов: " + average);
                }
                
                2.18
                int[] array = { 5, 10, 3, 7, 2 };
                int maxEvenIndex = -1;
                int maxOddIndex = -1;
                
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0 && (maxEvenIndex == -1 || array[i] > array[maxEvenIndex]))
                    {
                        maxEvenIndex = i;
                    }
                    else if (i % 2 != 0 && (maxOddIndex == -1 || array[i] > array[maxOddIndex]))
                    {
                        maxOddIndex = i;
                    }
                }
                
                if (array[maxEvenIndex] > array[maxOddIndex])
                {
                    for (int i = 0; i < array.Length / 2; i++)
                    {
                        array[i] = 0;
                    }
                }
                else
                {
                    for (int i = array.Length / 2; i < array.Length; i++)
                    {
                        array[i] = 0;
                    }
                }
                
                2.19
                int[] array = { 5, 10, 3, 7, 2 };
                int max = array.Max();
                int sum = array.Sum();
                
                if (max > sum)
                {
                    int maxIndex = Array.IndexOf(array, max);
                    array[maxIndex] = 0;
                }
                else
                {
                    int maxIndex = Array.IndexOf(array, max);
                    array[maxIndex] *= 2;
                }
                
                2.20
                int[] array = { 5, 10, 3, 7, 2 };
                int firstNegativeIndex = Array.IndexOf(array, array.FirstOrDefault(num => num < 0));
                int minIndex = Array.IndexOf(array, array.Min());
                
                if (firstNegativeIndex < minIndex)
                {
                    int sum = 0;
                
                    for (int i = 0; i < array.Length; i += 2)
                    {
                        sum += array[i];
                    }
                
                    Console.WriteLine("Сумма элементов с четными индексами: " + sum);
                }
                else
                {
                    int sum = 0;
                
                    for (int i = 1; i < array.Length; i += 2)
                    {
                        sum += array[i];
                    }
                
                    Console.WriteLine("Сумма элементов с нечетными индексами: " + sum);
                }
                
 
                
                
                
                3.1
                using System;
                
                class Program
                {
                    static void Main()
                    {
                        int[] array = { 3, 7, 2, 7, 8, 2, 7, 4, 1, 8 }; // пример исходного массива
                
                        int max = int.MinValue;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] > max)
                            {
                                max = array[i];
                            }
                        }
                
                        int count = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == max)
                            {
                                count++;
                            }
                        }
                
                        int[] indexes = new int[count];
                        int index = 0;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == max)
                            {
                                indexes[index] = i;
                                index++;
                            }
                        }
                
                        Console.WriteLine("Исходный массив:");
                        PrintArray(array);
                
                        Console.WriteLine($"\nМаксимальные элементы ({max}) находятся по индексам:");
                        PrintArray(indexes);
                    }
                
                    static void PrintArray(int[] array)
                    {
                        foreach (int elem in array)
                        {
                            Console.Write(elem + " ");
                        }
                        Console.WriteLine();
                    }
                }
                
                

                3.5
                using System;
                
                class Program
                {
                    static void Main()
                    {
                        int[] arr = { 3, 6, 2, 8, 1, 5, 7, 4 };
                        Console.WriteLine("Исходный массив:");
                        PrintArray(arr);
                
                        SortEvenIndexedElements(arr);
                
                        Console.WriteLine("\nМассив с упорядоченными элементами на четных индексах:");
                        PrintArray(arr);
                    }
                
                    static void SortEvenIndexedElements(int[] arr)
                    {
                        for (int i = 0; i < arr.Length; i += 2)
                        {
                            for (int j = 0; j < arr.Length; j += 2)
                            {
                                if (arr[i] < arr[j] && i < j)
                                {
                                    int temp = arr[i];
                                    arr[i] = arr[j];
                                    arr[j] = temp;
                                }
                            }
                        }
                    }
                
                    static void PrintArray(int[] arr)
                    {
                        foreach (var item in arr)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }
                }
                
                
                Тесты:
                
                int[] arr1 = { 3, 6, 2, 8, 1, 5, 7, 4 };
                SortEvenIndexedElements(arr1);
                PrintArray(arr1); // Ожидаемый вывод: 2 6 1 8 3 5 4 7
                
                int[] arr2 = { 5, 3, 7, 9, 2, 6, 4, 8 };
                SortEvenIndexedElements(arr2);
                PrintArray(arr2); // Ожидаемый вывод: 2 3 4 9 5 7 6 8
     
      }
}

