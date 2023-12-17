using System;

////1.4

//int rows = 3;

//int columns = 6;
//    int[,] matrix = new int[rows, columns];
//    for (int i = 0; i < rows; i++)
//    {
//        for (int j = 0; j < columns; j++)
//        {
//            Console.Write($"Введите элемент матрицы [{i}, {j}]: ");
//            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//        }
//    }
//int minE = matrix[0, 0];
//int minR = 0;
//int minC = 0;
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        if (matrix[i, j] < minE)
//        {
//            minE = matrix[i, j];
//            minR = i;
//            minC = j;
//        }
//    }
//}

//Console.WriteLine($"Строка: {minR}, Столбец: {minC}");
//Console.ReadKey();

////1.8
//int rows = 4;
//int columns = 6;
//int[,] matrix = new int[rows, columns];
//double[] average_rows = new double[rows];
//int last_i = 0;
//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        Console.Write($"Введите элемент матрицы [{i}, {j}]: ");
//        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//        if (i == last_i)
//        {
//            average_rows[i] += matrix[i, j];
//        }
//        else
//        {
//            last_i++;
//            average_rows[i] += matrix[i, j];
//        }
//    }
//}

//for (int i = 0; i < average_rows.Length; i++)
//{
//    Console.Write($"{average_rows[i] / 3} ");
//}
//Console.ReadKey();

////1.12

//int rows = 6;

//int columns = 7;
//int[,] matrix = new int[6, 7];
//double max_e = -10000000000;
//int maxERow = 0, maxEColumn = 0;
//for (int i = 0; i < 6; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        Console.Write($"Введите элемент матрицы [{i}, {j}]: ");
//        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//        if (matrix[i, j] > max_e)
//        {
//            max_e = matrix[i, j];
//            maxERow = i;
//            maxEColumn = j;
//        }
//    }
//}

//int[,] newMatrix = new int[5,6];

//for (int i = 0, r = 0; i < rows; i++)
//{
//    if (i == maxERow) continue;

//    for (int j = 0, c = 0; j < 7; j++)
//    {
//        if (j == maxEColumn) continue;

//        newMatrix[r, c] = matrix[i, j];
//        c++;
//    }
//    if (i != maxERow) r++;
//}

//for (int i = 0; i < newMatrix.GetLength(0); i++)
//{
//    for (int j = 0; j < newMatrix.GetLength(1); j++)
//    {
//        Console.Write(newMatrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();

////1.16
//Console.WriteLine("Введите количество строк матрицы:");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов матрицы:");
//int columns = Convert.ToInt32(Console.ReadLine());
//int[,] matrix = new int[rows, columns];
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"Введите элемент матрицы [{i}, {j}]: ");
//        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//    }
//}

//for (int i = 0; i < rows; i++)
//{
//    double maxE = -10000000;
//    int imax = -1;
//    for (int j = 0; j < columns; j++)
//    {
//        if (matrix[i, j] > maxE)
//        {
//            maxE = matrix[i, j];
//            imax = j;
//        }
//    }
//    int p = 0;
//    for (int j = imax + 1; j < columns; j++)
//    {
//        p = matrix[i, j - 1];
//        matrix[i, j - 1] = matrix[i, j];
//        matrix[i, j] = p;
//    }

//}

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"{matrix[i, j]} ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();

////1.20
//Console.WriteLine("Введите количество строк матрицы:");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов матрицы:");
//int columns = Convert.ToInt32(Console.ReadLine());
//double[,] matrix = new double[rows, columns];
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"Введите элемент матрицы [{i}, {j}]: ");
//        matrix[i, j] = Convert.ToDouble(Console.ReadLine());
//    }
//}
//for (int i = 0; i < rows; i++)
//{
//    double maxE = -1000000;
//    int maxEindex = -1;
//    int first_index = 0;
//    int last_index = 0;
//    for (int j = 0; j < columns; j++)
//    {
//        if (matrix[i, j] < 0 && first_index == -1)
//        {
//            first_index = j;
//        }
//        if (matrix[i, j] < 0)
//        {
//            last_index = j;
//        }
//        if (matrix[i, j] > maxE)
//        {
//            maxE = matrix[i, j];
//            maxEindex = j;
//        }
//    }
//    matrix[i, maxEindex] = (matrix[i, first_index] + matrix[i, last_index]) / 2;
//}
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"{matrix[i, j]} ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();
////2.24
//Console.WriteLine("Введите количество строк матрицы:");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов матрицы:");
//int columns = Convert.ToInt32(Console.ReadLine());
//double[,] matrix = new double[rows, columns];
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"Введите элемент матрицы [{i}, {j}]: ");
//        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//    }
//}

//for (int i = 0; i < rows; i++)
//{
//    double maxE = -10000000;
//    int max_index = -1;
//    double spn= 0;
//    int pnc = 0;
//    for (int j = 0; j < columns; j++)
//    {
//        if (matrix[i, j] > maxE)
//        {
//            maxE = matrix[i, j];
//            max_index = j;
//        }
//    }

//    for (int k = max_index + 1; k < columns; k++)
//    {
//        if (matrix[i, k] > 0)
//        {
//            spn += matrix[i, k];
//            pnc += 1;

//        }
//    }

//    if (pnc == 0)
//    {
//        for (int l = 0; l < columns; l++)
//        {
//            if (matrix[i, l] < 0)
//            {
//                matrix[i, l] = 0;

//            }
//        }
//    }
//    else
//    {
//        for (int l = 0; l < columns; l++)
//        {
//            if (matrix[i, l] < 0)
//            {
//                matrix[i, l] = spn / pnc;
//            }
//        }
//    }

//}
//for (int d = 0; d < rows; d++)
//{
//    for (int h = 0; h < columns; h++)
//    {
//        Console.Write($"{matrix[d, h]} ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();

////2.28
//Console.WriteLine("Введите количество строк матрицы:");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов матрицы:");
//int columns = Convert.ToInt32(Console.ReadLine());
//int[,] matrix = new int[rows, columns];
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"Введите элемент матрицы [{i}, {j}]: ");
//        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
//    }
//}
//int mpls = -10000000;
//int mpli = -1;

//for (int i = 0; i < rows; i++)
//{
//    int sum = 0;
//    for (int j = 0; j < columns; j++)
//    {
//        if (matrix[i, j] > 0)
//        {
//            sum += matrix[i, j];
//        }
//    }
//    if (sum > mpls)
//    {
//        mpls = sum;
//        mpli = i;
//    }
//}
//double[,] matrix2 = new double[rows - 1, columns];
//for (int i = 0; i < rows; i++)
//{
//    if (i < mpli)
//    {
//        for (int j = 0; j < columns; ++j)
//        {
//            matrix2[i, j] = matrix[i, j];
//        }
//    }
//    else if (i > mpli)
//    {
//        for (int j = 0; j < columns; ++j)
//        {
//            matrix2[i - 1, j] = matrix[i, j];
//        }
//    }
//}
//for (int d = 0; d < rows - 1; d++)
//{
//    for (int h = 0; h < columns; h++)
//    {
//        Console.Write($"{matrix[d, h]} ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();

////2.32
//Console.WriteLine("Введите количество строк матрицы:");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов матрицы:");
//int columns = Convert.ToInt32(Console.ReadLine());
//double[,] matrix = new double[rows, columns];
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"Введите элемент матрицы [{i}, {j}]: ");
//        matrix[i, j] = Convert.ToDouble(Console.ReadLine());
//    }
//}
//for (int i = 0; i < rows; i++)
//{
//    double sum = 0;
//    int pos_count = 0;
//    double maxE = -10000000;
//    int mei = -1;
//    for (int j = 0; j < columns; j++)
//    {
//        if (matrix[i, j] > 0)
//        {
//            sum += matrix[i, j];
//            pos_count++;
//        }
//        if (matrix[i, j] > maxE)
//        {
//            maxE = matrix[i, j];
//            mei = j;
//        }
//    }
//    if (pos_count != 0)
//    {
//        matrix[i, mei] = sum / pos_count;
//    }
//}

//for (int d = 0; d < rows; d++)
//{
//    for (int h = 0; h < columns; h++)
//    {
//        Console.Write($"{matrix[d, h]} ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();
//2.4
//int rows = 7;
//int columns = 5;
//double[,] matrix = new double[rows, columns];
//double[] list = new double[] { 3, 367, 10, -1, 1000 };
//Random a = new Random();
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        matrix[i, j] = a.NextDouble() * 10;
//    }
//}

//for (int i = 0; i < columns; i++)
//{
//    double max_element = -1000000;
//    int index_i = -1;
//    for (int j = 0; j < rows; j++)
//    {
//        if (matrix[j, i] > max_element)
//        {
//            max_element = matrix[j, i];
//            index_i = j;
//        }
//    }
//    if (list[i] > max_element)
//    {
//        matrix[index_i, i] = list[i];
//    }
//}
//for (int d = 0; d < rows; d++)
//{
//    for (int h = 0; h < columns; h++)
//    {
//        Console.Write($"{matrix[d, h]} ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();


////2.8
//Console.WriteLine("Введите количество строк матрицы:");
//int rows = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов матрицы:");
//int columns = Convert.ToInt32(Console.ReadLine());
//double[,] matrix = new double[rows, columns];
//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write($"Введите элемент матрицы [{i}, {j}]: ");
//        matrix[i, j] = Convert.ToDouble(Console.ReadLine());
//    }
//}

//for (int i = 0; i < rows - (rows % 2); i += 2)
//{
//    double max_number_0 = -1000000000;
//    int max_number_0_index = -1;
//    double max_number_1 = -100000000;
//    int max_number_1_index = -1;
//    for (int j = 0; j < columns; j++)
//    {
//        if (matrix[i, j] > max_number_0)
//        {
//            max_number_0 = matrix[i, j];
//            max_number_0_index = j;
//        }
//        if (matrix[i + 1, j] > max_number_1)
//        {
//            max_number_1 = matrix[i + 1, j];
//            max_number_1_index = j;
//        }
//    }
//    double c = matrix[i, max_number_0_index];
//    matrix[i, max_number_0_index] = matrix[i + 1, max_number_1_index];
//    matrix[i + 1, max_number_1_index] = c;
//}

//for (int d = 0; d < rows; d++)
//{
//    for (int h = 0; h < columns; h++)
//    {
//        Console.Write($"{matrix[d, h]} ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();

//3.1
double[,] a = new double[2, 3];
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = double.Parse(Console.ReadLine());
    }
}
double[] minV = new double[a.GetLength(0)];
for (int i = 0; i < a.GetLength(0); i++)
{
    double min = a[i, 0];
    for (int j = 1; j < a.GetLength(1); j++)
    {
        if (a[i, j] < min)
        {
            min = a[i, j];
        }
    }
    minV[i] = min;
}
for (int i = 0; i < a.GetLength(0) - 1; i++)
{
    for (int j = i + 1; j < a.GetLength(0); j++)
    {
        if (minV[j] > minV[i])
        {
            double temp = minV[i];
            minV[i] = minV[j];
            minV[j] = temp;
            for (int k = 0; k < a.GetLength(1); k++)
            {
                temp = a[i, k];
                a[i, k] = a[j, k];
                a[j, k] = temp;
            }
        }
    }
}
Console.WriteLine("Матрица A после обработки:");
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write(a[i, j] + "\t");
    }
    Console.WriteLine();
}

//// 3.2
//int n = int.Parse(Console.ReadLine());
//if (n == 0)
//{
//    int[,] a = new int[n, n];
//    for (int i = 0; i < a.GetLength(0); i++)
//    {
//        for (int j = 0; j < a.GetLength(1); j++)
//        {
//            a[i, j] = int.Parse(Console.ReadLine());
//            if (i == n - 1 || j == 0 || j == n - 1 || i == 0)
//            {
//                a[i, j] = 0;
//            }
//        }
//    }

//    for (int i = 0; i < a.GetLength(0); i++)
//    {
//        for (int j = 0; j < a.GetLength(1); j++)
//        {
//            Console.Write(a[i, j] + "\t");
//        }
//        Console.WriteLine();
//    }
//}
//else
//{
//    Console.WriteLine("в матрице нет элементов");
//}