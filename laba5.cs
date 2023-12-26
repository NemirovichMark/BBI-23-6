using System;

namespace ConsoleApp1
{
    internal class Program1
    {
//                 1.5 
//                 using System;
                
//                 class Program
//                 {
//                     static void Main(string[] args)
//                     {
//                         // Исходная матрица 4x6
//                         int[,] matrix4x6 = new int[,] { { 1, 2, 3, 4, 5, 6 },
//                                                         { 7, 8, 9, 10, 11, 12 },
//                                                         { 13, 14, 15, 16, 17, 18 },
//                                                         { 19, 20, 21, 22, 23, 24 } };
                
//                         // Найдем максимальный элемент в первом столбце матрицы 4x6
//                         int maxElement = FindMaxElementInColumn(matrix4x6, 0);
                
//                         // Создадим новую матрицу 6x6 и поменяем местами строки с максимальным элементом
//                         int[,] matrix6x6 = new int[6, 6];
//                         for (int i = 0; i < 6; i++)
//                         {
//                             for (int j = 0; j < 6; j++)
//                             {
//                                 if (i < 4)
//                                 {
//                                     matrix6x6[i, j] = matrix4x6[i, j];
//                                 }
//                                 else
//                                 {
//                                     matrix6x6[i, j] = matrix4x6[maxElement, j];
//                                 }
//                             }
//                         }
                
//                         // Выводим полученную матрицу 6x6 на экран
//                         for (int i = 0; i < 6; i++)
//                         {
//                             for (int j = 0; j < 6; j++)
//                             {
//                                 Console.Write(matrix6x6[i, j] + " ");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
                
//                     static int FindMaxElementInColumn(int[,] matrix, int column)
//                     {
//                         int maxElement = matrix[0, column];
//                         int maxElementRow = 0;
//                         for (int i = 1; i < matrix.GetLength(0); i++)
//                         {
//                             if (matrix[i, column] > maxElement)
//                             {
//                                 maxElement = matrix[i, column];
//                                 maxElementRow = i;
//                             }
//                         }
//                         return maxElementRow;
//                     }
//                 }
                
//                 1.11
//                 using System;
                
//                 class Program
//                 {
//                     static void Main(string[] args)
//                     {
//                         int[,] matrix1 = {
//                             { 1, 2, 3 },
//                             { 4, 5, 6 },
//                             { 7, 8, 9 }
//                         };
                
//                         int[,] matrix2 = {
//                             { 9, 8, 7 },
//                             { 6, 5, 4 },
//                             { 3, 2, 1 }
//                         };
                
//                         // Находим максимальные элементы каждой матрицы
//                         int max1 = FindMaxElement(matrix1);
//                         int max2 = FindMaxElement(matrix2);
                
//                         // Меняем местами максимальные элементы
//                         SwapMaxElements(matrix1, matrix2, max1, max2);
                
//                         // Выводим обновленные матрицы
//                         Console.WriteLine("Матрица 1:");
//                         PrintMatrix(matrix1);
//                         Console.WriteLine("Матрица 2:");
//                         PrintMatrix(matrix2);
//                     }
                
//                     // Метод для поиска максимального элемента в матрице
//                     static int FindMaxElement(int[,] matrix)
//                     {
//                         int max = matrix[0, 0];
                
//                         for (int i = 0; i < matrix.GetLength(0); i++)
//                         {
//                             for (int j = 0; j < matrix.GetLength(1); j++)
//                             {
//                                 if (matrix[i, j] > max)
//                                 {
//                                     max = matrix[i, j];
//                                 }
//                             }
//                         }
                
//                         return max;
//                     }
                
//                     // Метод для обмена максимальных элементов между матрицами
//                     static void SwapMaxElements(int[,] matrix1, int[,] matrix2, int max1, int max2)
//                     {
//                         int max1RowIndex = -1;
//                         int max1ColumnIndex = -1;
//                         int max2RowIndex = -1;
//                         int max2ColumnIndex = -1;
                
//                         // Находим индексы максимальных элементов в первой матрице
//                         for (int i = 0; i < matrix1.GetLength(0); i++)
//                         {
//                             for (int j = 0; j < matrix1.GetLength(1); j++)
//                             {
//                                 if (matrix1[i, j] == max1)
//                                 {
//                                     max1RowIndex = i;
//                                     max1ColumnIndex = j;
//                                     break;
//                                 }
//                             }
//                         }
                
//                         // Находим индексы максимальных элементов во второй матрице
//                         for (int i = 0; i < matrix2.GetLength(0); i++)
//                         {
//                             for (int j = 0; j < matrix2.GetLength(1); j++)
//                             {
//                                 if (matrix2[i, j] == max2)
//                                 {
//                                     max2RowIndex = i;
//                                     max2ColumnIndex = j;
//                                     break;
//                                 }
//                             }
//                         }
                
//                         // Меняем местами максимальные элементы между матрицами
//                         int temp = matrix1[max1RowIndex, max1ColumnIndex];
//                         matrix1[max1RowIndex, max1ColumnIndex] = matrix2[max2RowIndex, max2ColumnIndex];
//                         matrix2[max2RowIndex, max2ColumnIndex] = temp;
//                     }
                
//                     // Метод для вывода матрицы на экран
//                     static void PrintMatrix(int[,] matrix)
//                     {
//                         for (int i = 0; i < matrix.GetLength(0); i++)
//                         {
//                             for (int j = 0; j < matrix.GetLength(1); j++)
//                             {
//                                 Console.Write(matrix[i, j] + " ");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
//                 }
                
//                 1.17
//                 using System;
                
//                 class Program
//                 {
//                     static void Main(string[] args)
//                     {
//                         int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//                         int[,] matrix2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
                
//                         SortByMaxElement(matrix1);
//                         SortByMaxElement(matrix2);
                
//                         Console.WriteLine("Матрица 1:");
//                         PrintMatrix(matrix1);
                
//                         Console.WriteLine("Матрица 2:");
//                         PrintMatrix(matrix2);
//                     }
                
//                     static void SortByMaxElement(int[,] matrix)
//                     {
//                         int rows = matrix.GetLength(0);
//                         int columns = matrix.GetLength(1);
                
//                         for (int i = 0; i < rows; i++)
//                         {
//                             for (int j = i + 1; j < rows; j++)
//                             {
//                                 int maxI = FindMaxElement(matrix, i);
//                                 int maxJ = FindMaxElement(matrix, j);
                
//                                 if (maxI < maxJ)
//                                 {
//                                     SwapRows(matrix, i, j);
//                                 }
//                             }
//                         }
//                     }
                
//                     static int FindMaxElement(int[,] matrix, int row)
//                     {
//                         int columns = matrix.GetLength(1);
//                         int max = matrix[row, 0];
                
//                         for (int j = 1; j < columns; j++)
//                         {
//                             if (matrix[row, j] > max)
//                             {
//                                 max = matrix[row, j];
//                             }
//                         }
                
//                         return max;
//                     }
                
//                     static void SwapRows(int[,] matrix, int row1, int row2)
//                     {
//                         int columns = matrix.GetLength(1);
                
//                         for (int j = 0; j < columns; j++)
//                         {
//                             int temp = matrix[row1, j];
//                             matrix[row1, j] = matrix[row2, j];
//                             matrix[row2, j] = temp;
//                         }
//                     }
                
//                     static void PrintMatrix(int[,] matrix)
//                     {
//                         int rows = matrix.GetLength(0);
//                         int columns = matrix.GetLength(1);
                
//                         for (int i = 0; i < rows; i++)
//                         {
//                             for (int j = 0; j < columns; j++)
//                             {
//                                 Console.Write(matrix[i, j] + " ");
//                             }
                
//                             Console.WriteLine();
//                         }
                
//                         Console.WriteLine();
//                     }
//                 }
                
//                 1.23
//                 using System;
                
//                 class Program
//                 {
//                     static void Main(string[] args)
//                     {
//                         // Создаем две матрицы 5x5
//                         int[,] matrix1 = new int[,]
//                         {
//                             { 1, 2, 3, 4, 5 },
//                             { 6, 7, 8, 9, 10 },
//                             { 11, 12, 13, 14, 15 },
//                             { 16, 17, 18, 19, 20 },
//                             { 21, 22, 23, 24, 25 }
//                         };
                
//                         int[,] matrix2 = new int[,]
//                         {
//                             { 26, 27, 28, 29, 30 },
//                             { 31, 32, 33, 34, 35 },
//                             { 36, 37, 38, 39, 40 },
//                             { 41, 42, 43, 44, 45 },
//                             { 46, 47, 48, 49, 50 }
//                         };
                
//                         // Применяем преобразование к матрицам
//                         TransformMatrix(matrix1);
//                         TransformMatrix(matrix2);
                
//                         // Выводим результаты
//                         Console.WriteLine("Матрица 1:");
//                         PrintMatrix(matrix1);
                
//                         Console.WriteLine("Матрица 2:");
//                         PrintMatrix(matrix2);
                
//                         Console.ReadKey();
//                     }
                
//                     // Метод преобразования матрицы
//                     static void TransformMatrix(int[,] matrix)
//                     {
//                         int rows = matrix.GetLength(0);
//                         int cols = matrix.GetLength(1);
                
//                         // Создаем новую матрицу для хранения отсортированных элементов
//                         int[] sortedElements = new int[rows * cols];
//                         int index = 0;
                
//                         // Перебираем элементы матрицы и добавляем их в массив sortedElements
//                         for (int i = 0; i < rows; i++)
//                         {
//                             for (int j = 0; j < cols; j++)
//                             {
//                                 sortedElements[index] = matrix[i, j];
//                                 index++;
//                             }
//                         }
                
//                         // Сортируем массив sortedElements по убыванию
//                         Array.Sort(sortedElements);
//                         Array.Reverse(sortedElements);
                
//                         // Находим и изменяем пять наибольших элементов матрицы
//                         index = 0;
//                         for (int i = 0; i < rows; i++)
//                         {
//                             for (int j = 0; j < cols; j++)
//                             {
//                                 if (matrix[i, j] == sortedElements[index])
//                                 {
//                                     matrix[i, j] *= 2;
//                                     index++;
                
//                                     if (index == 5)
//                                     {
//                                         return;
//                                     }
//                                 }
//                             }
//                         }
//                     }
                
//                     // Метод для вывода матрицы на консоль
//                     static void PrintMatrix(int[,] matrix)
//                     {
//                         int rows = matrix.GetLength(0);
//                         int cols = matrix.GetLength(1);
                
//                         for (int i = 0; i < rows; i++)
//                         {
//                             for (int j = 0; j < cols; j++)
//                             {
//                                 Console.Write(matrix[i, j] + " ");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
//                 }
    }
}
                
