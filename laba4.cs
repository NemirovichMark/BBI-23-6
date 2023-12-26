
using System;

namespace ConsoleApp1
{
    internal class Program1
    {
//                 1.4.
//                 using System;
                
//                 class Program
//                 {
//                     static void Main(string[] args)
//                     {
//                         // Задать размеры матрицы
//                         int rows = 3;
//                         int cols = 6;
                        
//                         // Создать и заполнить матрицу случайными числами
//                         int[,] matrix = new int[rows, cols];
//                         Random rand = new Random();
                        
//                         for (int i = 0; i < rows; i++)
//                         {
//                             for (int j = 0; j < cols; j++)
//                             {
//                                 matrix[i, j] = rand.Next(100); // Заполнить матрицу случайным числом от 0 до 99
//                             }
//                         }
                        
//                         // Найти минимальный элемент и его индексы
//                         int min = Int32.MaxValue;
//                         int minRow = 0;
//                         int minCol = 0;
                        
//                         for (int i = 0; i < rows; i++)
//                         {
//                             for (int j = 0; j < cols; j++)
//                             {
//                                 if (matrix[i, j] < min)
//                                 {
//                                     min = matrix[i, j];
//                                     minRow = i;
//                                     minCol = j;
//                                 }
//                             }
//                         }
                        
//                         // Вывести исходную матрицу
//                         Console.WriteLine("Исходная матрица:");
//                         for (int i = 0; i < rows; i++)
//                         {
//                             for (int j = 0; j < cols; j++)
//                             {
//                                 Console.Write(matrix[i, j] + "\t");
//                             }
//                             Console.WriteLine();
//                         }
                        
//                         // Вывести результат
//                         Console.WriteLine("Минимальный элемент: " + min);
//                         Console.WriteLine("Номер строки: " + (minRow + 1));
//                         Console.WriteLine("Номер столбца: " + (minCol + 1));
//                     }
//                 }
                
//                 1.8 
//                 using System;
                
//                 class Program
//                 {
//                     static void Main()
//                     {
//                         int[,] matrix = new int[4, 6]
//                         {
//                             { 1, -2, 3, 4, -5, 6 },
//                             { -7, 8, 9, -10, 11, 12 },
//                             { 13, -14, 15, 16, -17, 18 },
//                             { -19, 20, -21, 22, 23, -24 }
//                         };
                
//                         int rowCount = matrix.GetLength(0);
//                         int colCount = matrix.GetLength(1);
                
//                         double[] averageValues = new double[rowCount];
                
//                         // Вычисляем средние значения для каждой строки матрицы
//                         for (int i = 0; i < rowCount; i++)
//                         {
//                             int sum = 0;
//                             int count = 0;
                            
//                             for (int j = 0; j < colCount; j++)
//                             {
//                                 if (matrix[i, j] > 0)
//                                 {
//                                     sum += matrix[i, j];
//                                     count++;
//                                 }
//                             }
                            
//                             if (count > 0)
//                                 averageValues[i] = (double)sum / count;
//                             else
//                                 averageValues[i] = 0;
//                         }
                
//                         // Выводим исходную матрицу
//                         Console.WriteLine("Исходная матрица:");
//                         for (int i = 0; i < rowCount; i++)
//                         {
//                             for (int j = 0; j < colCount; j++)
//                             {
//                                 Console.Write(matrix[i, j] + " ");
//                             }
//                             Console.WriteLine();
//                         }
//                         Console.WriteLine();
                
//                         // Выводим средние значения
//                         Console.WriteLine("Средние значения для каждой строки матрицы:");
//                         for (int i = 0; i < rowCount; i++)
//                         {
//                             Console.WriteLine("Среднее значение строки " + i + ": " + averageValues[i]);
//                         }
//                         Console.WriteLine();
//                     }
//                 }
                
//                 1.12 
//                 using System;
                
//                 class Program
//                 {
//                     static void Main(string[] args)
//                     {
//                         int[,] matrix = {
//                             { 1, 2, 3, 4, 5, 9, 7 },
//                             { 6, 7, 8, 9, 10, 11, 12 },
//                             { 13, 14, 15, 16, 17, 18, 19 },
//                             { 20, 21, 22, 23, 24, 25, 26 },
//                             { 27, 28, 29, 30, 31, 32, 33 },
//                             { 34, 35, 36, 37, 38, 39, 40 }
//                         };
                
//                         int rows = matrix.GetLength(0);
//                         int cols = matrix.GetLength(1);
                
//                         // Найти индексы максимального элемента
//                         int max = int.MinValue;
//                         int maxRowIndex = 0;
//                         int maxColIndex = 0;
                
//                         for (int i = 0; i < rows; i++)
//                         {
//                             for (int j = 0; j < cols; j++)
//                             {
//                                 if (matrix[i, j] > max)
//                                 {
//                                     max = matrix[i, j];
//                                     maxRowIndex = i;
//                                     maxColIndex = j;
//                                 }
//                             }
//                         }
                
//                         // Печать исходной матрицы
//                         Console.WriteLine("Исходная матрица:");
//                         for (int i = 0; i < rows; i++)
//                         {
//                             for (int j = 0; j < cols; j++)
//                             {
//                                 Console.Write(matrix[i, j] + " ");
//                             }
//                             Console.WriteLine();
//                         }
                
//                         // Создать новую матрицу без строки и столбца с максимальным элементом
//                         int[,] newMatrix = new int[rows - 1, cols - 1];
//                         int newRow = 0;
//                         int newCol = 0;
                
//                         for (int i = 0; i < rows; i++)
//                         {
//                             if (i != maxRowIndex)
//                             {
//                                 for (int j = 0; j < cols; j++)
//                                 {
//                                     if (j != maxColIndex)
//                                     {
//                                         newMatrix[newRow, newCol] = matrix[i, j];
//                                         newCol++;
//                                     }
//                                 }
//                                 newRow++;
//                                 newCol = 0;
//                             }
//                         }
                
//                         // Печать результата
//                         Console.WriteLine("\nРезультирующая матрица:");
//                         for (int i = 0; i < newMatrix.GetLength(0); i++)
//                         {
//                             for (int j = 0; j < newMatrix.GetLength(1); j++)
//                             {
//                                 Console.Write(newMatrix[i, j] + " ");
//                             }
//                             Console.WriteLine();
//                         }
                
//                         Console.WriteLine("\nМаксимальный элемент: " + max);
                
//                         Console.ReadLine();
//                     }
//                 }
                
//                 1.16 
//                 sing System;
                
//                 public class Program
//                 {
//                     public static void Main(string[] args)
//                     {
//                         // Введите размеры матрицы
//                         Console.Write("Введите количество строк: ");
//                         int n = int.Parse(Console.ReadLine());
                
//                         Console.Write("Введите количество столбцов: ");
//                         int m = int.Parse(Console.ReadLine());
                
//                         // Создаем и заполняем матрицу случайными числами
//                         int[,] matrix = GenerateMatrix(n, m);
                
//                         // Печатаем исходную матрицу
//                         Console.WriteLine("Исходная матрица:");
//                         PrintMatrix(matrix);
                
//                         // Находим максимальный элемент в каждой строке и перемещаем его в конец строки
//                         for (int i = 0; i < n; i++)
//                         {
//                             int maxElement = matrix[i, 0]; // Предполагаем, что первый элемент в строке максимальный
//                             int maxIndex = 0;
                
//                             for (int j = 1; j < m; j++)
//                             {
//                                 if (matrix[i, j] > maxElement)
//                                 {
//                                     maxElement = matrix[i, j];
//                                     maxIndex = j;
//                                 }
//                             }
                
//                             // Перемещаем максимальный элемент в конец строки
//                             for (int j = maxIndex; j < m - 1; j++)
//                             {
//                                 int temp = matrix[i, j];
//                                 matrix[i, j] = matrix[i, j + 1];
//                                 matrix[i, j + 1] = temp;
//                             }
//                         }
                
//                         // Печатаем результат
//                         Console.WriteLine("Результирующая матрица:");
//                         PrintMatrix(matrix);
//                     }
                
//                     // Генерация матрицы случайными числами
//                     public static int[,] GenerateMatrix(int n, int m)
//                     {
//                         Random rand = new Random();
//                         int[,] matrix = new int[n, m];
                
//                         for (int i = 0; i < n; i++)
//                         {
//                             for (int j = 0; j < m; j++)
//                             {
//                                 matrix[i, j] = rand.Next(1, 100);
//                             }
//                         }
                
//                         return matrix;
//                     }
                
//                     // Печать матрицы
//                     public static void PrintMatrix(int[,] matrix)
//                     {
//                         int n = matrix.GetLength(0);
//                         int m = matrix.GetLength(1);
                
//                         for (int i = 0; i < n; i++)
//                         {
//                             for (int j = 0; j < m; j++)
//                             {
//                                 Console.Write(matrix[i, j] + " ");
//                             }
//                             Console.WriteLine();
//                         }
                
//                         Console.WriteLine();
//                     }
//                 }
                
//                 1.20
//                 using System;
                
//                 class Program
//                 {
//                     static void Main(string[] args)
//                     {
//                         Console.Write("Введите количество строк матрицы: ");
//                         int n = Convert.ToInt32(Console.ReadLine());
                
//                         Console.Write("Введите количество столбцов матрицы: ");
//                         int m = Convert.ToInt32(Console.ReadLine());
                
//                         int[,] matrix = new int[n, m];
                
//                         // Ввод элементов матрицы
//                         Console.WriteLine("\nВведите элементы матрицы:");
//                         for (int i = 0; i < n; i++)
//                         {
//                             for (int j = 0; j < m; j++)
//                             {
//                                 Console.Write($"Элемент [{i}, {j}]: ");
//                                 matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//                             }
//                         }
                
//                         // Печать исходной матрицы
//                         Console.WriteLine("\nИсходная матрица:");
//                         PrintMatrix(matrix);
                
//                         // Замена максимальных элементов
//                         for (int i = 0; i < n; i++)
//                         {
//                             int maxElement = matrix[i, 0];
//                             int maxElementIndex = 0;
                
//                             // Поиск максимального элемента в строке
//                             for (int j = 1; j < m; j++)
//                             {
//                                 if (matrix[i, j] > maxElement)
//                                 {
//                                     maxElement = matrix[i, j];
//                                     maxElementIndex = j;
//                                 }
//                             }
                
//                             int firstNegative = -1;
//                             int lastNegative = -1;
                
//                             // Поиск первого и последнего отрицательного элемента в строке
//                             for (int j = 0; j < m; j++)
//                             {
//                                 if (matrix[i, j] < 0)
//                                 {
//                                     if (firstNegative == -1)
//                                     {
//                                         firstNegative = j;
//                                     }
//                                     lastNegative = j;
//                                 }
//                             }
                
//                             // Если есть отрицательные элементы, заменяем максимальный элемент
//                             if (firstNegative != -1)
//                             {
//                                 int halfSum = (matrix[i, firstNegative] + matrix[i, lastNegative]) / 2;
//                                 matrix[i, maxElementIndex] = halfSum;
//                             }
//                         }
                
//                         // Печать полученной матрицы
//                         Console.WriteLine("\nРезультирующая матрица:");
//                         PrintMatrix(matrix);
//                     }
                
//                     // Функция для печати матрицы
//                     static void PrintMatrix(int[,] matrix)
//                     {
//                         int n = matrix.GetLength(0);
//                         int m = matrix.GetLength(1);
                
//                         for (int i = 0; i < n; i++)
//                         {
//                             for (int j = 0; j < m; j++)
//                             {
//                                 Console.Write(matrix[i, j] + " ");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
//                 }
                
//                 1.24
//                 using System;
                
//                 class Program
//                 {
//                     static void Main(string[] args)
//                     {
//                         int rows = 6;
//                         int columns = 5;
                
//                         // Создаем исходную матрицу
//                         int[,] matrix = new int[rows, columns]
//                         {
//                             { -3, 4, -2, 7, 1 },
//                             { 2, 5, -1, -6, 3 },
//                             { 0, 9, 8, -4, -5 },
//                             { 6, -7, 12, 10, -8 },
//                             { -9, 11, 13, -14, 15 },
//                             { 16, -17, 18, -19, 20 },
//                         };
                
//                         Console.WriteLine("Исходная матрица:");
//                         PrintMatrix(matrix);
                
//                         // Обрабатываем матрицу
//                         ProcessMatrix(matrix);
                
//                         Console.WriteLine("Матрица после обработки:");
//                         PrintMatrix(matrix);
//                     }
                
//                     static void ProcessMatrix(int[,] matrix)
//                     {
//                         int rows = matrix.GetLength(0);
//                         int columns = matrix.GetLength(1);
                
//                         for (int i = 0; i < rows; i++)
//                         {
//                             int maxIndex = 0; // позиция максимального элемента
//                             int maxElement = matrix[i, 0]; // значение максимального элемента
                
//                             // Находим позицию максимального элемента
//                             for (int j = 1; j < columns; j++)
//                             {
//                                 if (matrix[i, j] > maxElement)
//                                 {
//                                     maxIndex = j;
//                                     maxElement = matrix[i, j];
//                                 }
//                             }
                
//                             // Заменяем отрицательные элементы перед максимальным
//                             for (int j = 0; j < maxIndex; j++)
//                             {
//                                 if (matrix[i, j] < 0)
//                                 {
//                                     int sum = 0; // сумма положительных элементов после максимального
//                                     int count = 0; // количество положительных элементов после максимального
                
//                                     // Находим сумму и количество положительных элементов после максимального
//                                     for (int k = maxIndex + 1; k < columns; k++)
//                                     {
//                                         if (matrix[i, k] > 0)
//                                         {
//                                             sum += matrix[i, k];
//                                             count++;
//                                         }
//                                     }
                
//                                     // Если есть положительные элементы, заменяем отрицательный элемент
//                                     if (count > 0)
//                                     {
//                                         matrix[i, j] = sum / count;
//                                     }
//                                 }
//                             }
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
                
//                 1.28 
//                 using System;
                
//                 class Program
//                 {
//                     static void Main(string[] args)
//                     {
//                         // Создание исходной матрицы
//                         int[,] matrix = {
//                             {1, -2, 3, -4, 5},
//                             {-6, 7, -8, 9, -10},
//                             {11, -12, 13, -14, 15},
//                             {-16, 17, -18, 19, -20},
//                             {21, -22, 23, -24, 25},
//                             {-26, 27, -28, 29, -30},
//                             {31, -32, 33, -34, 35}
//                         };
                
//                         Console.WriteLine("Исходная матрица:");
//                         PrintMatrix(matrix);
                
//                         // Поиск строки с максимальной суммой положительных элементов
//                         int maxRow = 0;
//                         int maxSum = int.MinValue;
//                         for (int i = 0; i < matrix.GetLength(0); i++)
//                         {
//                             int sum = 0;
//                             for (int j = 0; j < matrix.GetLength(1); j++)
//                             {
//                                 if (matrix[i,j] > 0)
//                                 {
//                                     sum += matrix[i,j];
//                                 }
//                             }
//                             if (sum > maxSum)
//                             {
//                                 maxSum = sum;
//                                 maxRow = i;
//                             }
//                         }
                
//                         // Удаление строки с максимальной суммой положительных элементов
//                         int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
//                         for (int i = 0, k = 0; i < matrix.GetLength(0); i++)
//                         {
//                             if (i != maxRow)
//                             {
//                                 for (int j = 0; j < matrix.GetLength(1); j++)
//                                 {
//                                     result[k,j] = matrix[i,j];
//                                 }
//                                 k++;
//                             }
//                         }
                
//                         Console.WriteLine();
//                         Console.WriteLine("Результат:");
//                         PrintMatrix(result);
//                     }
                
//                     // Метод для печати матрицы
//                     static void PrintMatrix(int[,] matrix)
//                     {
//                         for (int i = 0; i < matrix.GetLength(0); i++)
//                         {
//                             for (int j = 0; j < matrix.GetLength(1); j++)
//                             {
//                                 Console.Write($"{matrix[i,j]}\t");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
//                 }
                
//                 1.32.  
//                 using System;
                
//                 class Program
//                 {
//                     static void Main()
//                     {
//                         // Создаем матрицу размера 5x7
//                         int[,] matrix = new int[5, 7]
//                         {
//                             { 1, -2, 3, 4, -5, 6, -7 },
//                             { 8, -9, 10, -11, 12, 13, -14 },
//                             { -15, 16, -17, 18, 19, 20, -21 },
//                             { 22, -23, 24, 25, -26, 27, -28 },
//                             { -29, 30, -31, 32, -33, -34, -35 }
//                         };
                
//                         // Печатаем исходные данные
//                         Console.WriteLine("Исходная матрица:");
//                         PrintMatrix(matrix);
                
//                         // Проходим по каждой строке матрицы
//                         for (int i = 0; i < matrix.GetLength(0); i++)
//                         {
//                             int maxElement = int.MinValue;
//                             int sumPositive = 0;
//                             int countPositive = 0;
                            
//                             // Находим максимальный элемент и суммируем положительные элементы строки
//                             for (int j = 0; j < matrix.GetLength(1); j++)
//                             {
//                                 if (matrix[i, j] > maxElement)
//                                 {
//                                     maxElement = matrix[i, j];
//                                 }
                                
//                                 if (matrix[i, j] > 0)
//                                 {
//                                     sumPositive += matrix[i, j];
//                                     countPositive++;
//                                 }
//                             }
                            
//                             // Заменяем максимальный элемент средним среди положительных элементов
//                             if (countPositive > 0)
//                             {
//                                 int averagePositive = sumPositive / countPositive;
//                                 for (int j = 0; j < matrix.GetLength(1); j++)
//                                 {
//                                     if (matrix[i, j] == maxElement)
//                                     {
//                                         matrix[i, j] = averagePositive;
//                                     }
//                                 }
//                             }
//                         }
                        
//                         // Печатаем результат
//                         Console.WriteLine("Результат:");
//                         PrintMatrix(matrix);
//                     }
                
//                     static void PrintMatrix(int[,] matrix)
//                     {
//                         for (int i = 0; i < matrix.GetLength(0); i++)
//                         {
//                             for (int j = 0; j < matrix.GetLength(1); j++)
//                             {
//                                 Console.Write($"{matrix[i, j]} ");
//                             }
//                             Console.WriteLine();
//                         }
//                         Console.WriteLine();
//                     }
//                 }
                
//                 2.4 
//                 using System;
                
//                 class Program
//                 {
//                     static void Main()
//                     {
//                         Random rnd = new Random();
//                         int[,] A = new int[7, 5];
//                         int[] B = new int[5];
//                         // Заполнение A и B случайными числами
//                         for (int i = 0; i < 7; i++)
//                         {
//                             for (int j = 0; j < 5; j++)
//                             {
//                                 A[i, j] = rnd.Next(1, 101); // Генерация случайного числа от 1 до 100
//                             }
//                         }
//                         for (int j = 0; j < 5; j++)
//                         {
//                             B[j] = rnd.Next(1, 101); // Генерация случайного числа от 1 до 100
//                         }
                
//                         // Вывод исходных данных
//                         Console.WriteLine("Матрица A:");
//                         for (int i = 0; i < 7; i++)
//                         {
//                             for (int j = 0; j < 5; j++)
//                             {
//                                 Console.Write(A[i, j] + "\t");
//                             }
//                             Console.WriteLine();
//                         }
//                         Console.WriteLine("Массив B:");
//                         for (int j = 0; j < 5; j++)
//                         {
//                             Console.Write(B[j] + "\t");
//                         }
//                         Console.WriteLine("\n");
                
//                         // Обработка данных
//                         for (int j = 0; j < 5; j++)
//                         {
//                             int max = A[0, j];
//                             int maxIndex = 0;
//                             for (int i = 1; i < 7; i++)
//                             {
//                                 if (A[i, j] > max)
//                                 {
//                                     max = A[i, j];
//                                     maxIndex = i;
//                                 }
//                             }
//                             if (B[j] > max)
//                             {
//                                 A[maxIndex, j] = B[j];
//                             }
//                         }
                
//                         // Вывод результата
//                         Console.WriteLine("Результат:");
//                         for (int i = 0; i < 7; i++)
//                         {
//                             for (int j = 0; j < 5; j++)
//                             {
//                                 Console.Write(A[i, j] + "\t");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
//                 }
                
//                 2.8.  
                
                
//                 using System;
                
//                 namespace MatrixSwap
//                 {
//                     class Program
//                     {
//                         static void Main(string[] args)
//                         {
//                             int[,] matrix = new int[,] 
//                             { 
//                                 { 1, 2, 3, 4, 5, 6 }, 
//                                 { 7, 8, 9, 10, 11, 12 }, 
//                                 { 13, 14, 15, 16, 17, 18 }, 
//                                 { 19, 20, 21, 22, 23, 24 }, 
//                                 { 25, 26, 27, 28, 29, 30 }, 
//                                 { 31, 32, 33, 34, 35, 36 }
//                             };
                
//                             PrintMatrix("Initial matrix:", matrix);
//                             SwapMaxElements(matrix, 0, 1);
//                             SwapMaxElements(matrix, 2, 3);
//                             SwapMaxElements(matrix, 4, 5);
//                             PrintMatrix("Resulting matrix:", matrix);
//                         }
                
//                         static void PrintMatrix(string message, int[,] matrix)
//                         {
//                             Console.WriteLine(message);
//                             for (int i = 0; i < matrix.GetLength(0); i++)
//                             {
//                                 for (int j = 0; j < matrix.GetLength(1); j++)
//                                 {
//                                     Console.Write(matrix[i, j] + " ");
//                                 }
//                                 Console.WriteLine();
//                             }
//                             Console.WriteLine();
//                         }
                
//                         static void SwapMaxElements(int[,] matrix, int row1, int row2)
//                         {
//                             int max1 = matrix[row1, 0];
//                             int index1 = 0;
//                             for (int j = 1; j < matrix.GetLength(1); j++)
//                             {
//                                 if (matrix[row1, j] > max1)
//                                 {
//                                     max1 = matrix[row1, j];
//                                     index1 = j;
//                                 }
//                             }
                
//                             int max2 = matrix[row2, 0];
//                             int index2 = 0;
//                             for (int j = 1; j < matrix.GetLength(1); j++)
//                             {
//                                 if (matrix[row2, j] > max2)
//                                 {
//                                     max2 = matrix[row2, j];
//                                     index2 = j;
//                                 }
//                             }
                
//                             int temp = matrix[row1, index1];
//                             matrix[row1, index1] = matrix[row2, index2];
//                             matrix[row2, index2] = temp;
//                         }
//                     }
//                 }
                
//                 3.1 
//                 а) Вариант с использованием двумерного массива:
//                 using System;
                
//                 class Program
//                 {
//                     static void Main(string[] args)
//                     {
//                         int[,] matrix = {
//                             { 3, 9, 4, 2, 1 },
//                             { 8, 6, 7, 5, 3 },
//                             { 2, 9, 1, 4, 7 },
//                             { 5, 3, 9, 8, 2 },
//                             { 1, 7, 6, 4, 3 },
//                             { 8, 2, 4, 7, 6 },
//                             { 7, 4, 2, 3, 5 }
//                         };
                
//                         SortMatrixByMinValues(matrix);
                
//                         // Вывод отсортированной матрицы
//                         for (int i = 0; i < matrix.GetLength(0); i++) 
//                         {
//                             for (int j = 0; j < matrix.GetLength(1); j++) 
//                             {
//                                 Console.Write(matrix[i, j] + " ");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
                
//                     static void SortMatrixByMinValues(int[,] matrix)
//                     {
//                         int[] minValues = new int[matrix.GetLength(0)];
                
//                         // Находим минимальные элементы в каждой строке
//                         for (int i = 0; i < matrix.GetLength(0); i++) 
//                         {
//                             int min = int.MaxValue; 
//                             for (int j = 0; j < matrix.GetLength(1); j++) 
//                             {
//                                 if (matrix[i, j] < min) 
//                                 {
//                                     min = matrix[i, j];
//                                 }
//                             }
//                             minValues[i] = min;
//                         }
                
//                         // Сортируем массив минимальных элементов в порядке убывания
//                         Array.Sort(minValues);
//                         Array.Reverse(minValues);
                
//                         // Создаем временную матрицу, в которую будем записывать строки в нужном порядке
//                         int[,] tempMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)]; 
                
//                         for (int i = 0; i < matrix.GetLength(0); i++) 
//                         {
//                             int minIndex = Array.IndexOf(minValues, minValues[i]); 
//                             for (int j = 0; j < matrix.GetLength(1); j++) 
//                             {
//                                 tempMatrix[minIndex, j] = matrix[i, j];
//                             }
//                         }
                
//                         // Копируем временную матрицу обратно в исходную матрицу
//                         for (int i = 0; i < matrix.GetLength(0); i++) 
//                         {
//                             for (int j = 0; j < matrix.GetLength(1); j++) 
//                             {
//                                 matrix[i, j] = tempMatrix[i, j];
//                             }
//                         }
//                     }
//                 }
                
                
//                 б) Вариант с использованием одномерной последовательности:
//                 using System;
                
//                 class Program
//                 {
//                     static void Main(string[] args)
//                     {
//                         int[] matrix = {
//                             3, 9, 4, 2, 1,
//                             8, 6, 7, 5, 3,
//                             2, 9, 1, 4, 7,
//                             5, 3, 9, 8, 2,
//                             1, 7, 6, 4, 3,
//                             8, 2, 4, 7, 6,
//                             7, 4, 2, 3, 5
//                         };
                
//                         SortMatrixByMinValues(matrix, 7, 5);
                
//                         // Вывод отсортированной матрицы
//                         for (int i = 0; i < matrix.Length; i++) 
//                         {
//                             Console.Write(matrix[i] + " ");
//                             if ((i + 1) % 5 == 0)
//                             {
//                                 Console.WriteLine();
//                             }
//                         }
//                     }
                
//                     static void SortMatrixByMinValues(int[] matrix, int rows, int columns)
//                     {
//                         int[] minValues = new int[rows];
                
//                         // Находим минимальные элементы в каждой строке
//                         for (int i = 0; i < rows; i++) 
//                         {
//                             int min = int.MaxValue; 
//                             for (int j = 0; j < columns; j++) 
//                             {
//                                 if (matrix[i * columns + j] < min) 
//                                 {
//                                     min = matrix[i * columns + j];
//                                 }
//                             }
//                             minValues[i] = min;
//                         }
                
//                         // Сортируем массив минимальных элементов в порядке убывания
//                         Array.Sort(minValues);
//                         Array.Reverse(minValues);
                
//                         // Создаем временную матрицу, в которую будем записывать строки в нужном порядке
//                         int[] tempMatrix = new int[matrix.Length];
                
//                         for (int i = 0; i < rows; i++) 
//                         {
//                             int minIndex = Array.IndexOf(minValues, minValues[i]);
//                             for (int j = 0; j < columns; j++) 
//                             {
//                                 tempMatrix[minIndex * columns + j] = matrix[i * columns + j];
//                             }
//                         }
                
//                         // Копируем временную матрицу обратно в исходную матрицу
//                         Array.Copy(tempMatrix, matrix, matrix.Length);
//                     }
//                 }
                
//                 3.2. 
//                 a) В виде двумерного массива:
                
//                 static void Main(string[] args)
//                 {
//                     int n = 5; // размерность матрицы
//                     int[,] matrix = new int[n, n];
                
//                     for (int i = 0; i < n; i++)
//                     {
//                         for (int j = 0; j < n; j++)
//                         {
//                             if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
//                             {
//                                 matrix[i, j] = 0;
//                             }
//                             else
//                             {
//                                 matrix[i, j] = 1; // можно изменить значение на другое
//                             }
//                         }
//                     }
                
//                     // вывод матрицы
//                     for (int i = 0; i < n; i++)
//                     {
//                         for (int j = 0; j < n; j++)
//                         {
//                             Console.Write(matrix[i, j] + " ");
//                         }
//                         Console.WriteLine();
//                     }
//                 }
                
                
//                 b) В виде одномерной последовательности:
                
//                 static void Main(string[] args)
//                 {
//                     int n = 5; // размерность матрицы
//                     int[] matrix = new int[n * n];
                
//                     for (int i = 0; i < n * n; i++)
//                     {
//                         int row = i / n; // вычисляем номер строки
//                         int col = i % n; // вычисляем номер столбца
                
//                         if (row == 0 || row == n - 1 || col == 0 || col == n - 1)
//                         {
//                             matrix[i] = 0;
//                         }
//                         else
//                         {
//                             matrix[i] = 1; // можно изменить значение на другое
//                         }
//                     }
                
//                     // вывод матрицы
//                     for (int i = 0; i < n * n; i++)
//                     {
//                         Console.Write(matrix[i] + " ");
                
//                         if ((i + 1) % n == 0) // перенос строки после каждой n-ой ячейки
//                         {
//                             Console.WriteLine();
//                         }
//                     }
//                 }
    }
}
                
                
                
                
                
                
