using System;
//1.8 
//    double[,] a = new double[4, 6]
//            { {-1,-2,3,-4,-5,-6},
//            { -1,-2,-3,-4,-5,-6},
//            {2,4,1,3,-3,-3 },
//                {-2,-4,-5,3,3,3 }
//            };
//double[] apoz = new double[4];
//for (int i = 0; i < 4; i++)
//{
//    double sum = 0;
//    double count = 0;
//    for (int j = 0; j < 6; j++)
//    {
//        if (a[i, j] > 0)
//        {
//            sum += a[i, j];
//            count++;
//        }
//    }
//    if (count > 0)
//    {
//        double sr = sum / count;
//        apoz[i] = sr;
//    }

//}
//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine($"{apoz[i]} ");
//}

//20
//int[,] matrixY = new int[6, 5]
//            { {-2,4,3,8,2},
//            {10,3,2,-4,3 },
//            {-3,4,3,-4,20},
//            {4,5,12,-4,-3 },
//                {3,-2,12,3,4 },
//                { 4,3,4,3,4}
//            };
//ProcessMatrix(matrixY);
//for (int i = 0; i < matrixY.GetLength(0); i++)
//{
//    for (int j = 0; j < matrixY.GetLength(1); j++)
//    {
//        Console.Write(matrixY[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//static void ProcessMatrix(int[,] matrix)
//{
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        int maxIndex = FindMaxIndex(matrix, i);
//        int sum = 0;
//        int count = 0;
//        for (int j = maxIndex + 1; j < matrix.GetLength(1); j++)
//        {
//            if (matrix[i, j] > 0)
//            {
//                sum += matrix[i, j];
//                count++;
//            }
//        }
//        double sr = count > 0 ? (double)sum / count : 0;
//        for (int j = 0; j < maxIndex; j++)
//        {
//            if (matrix[i, j] < 0)
//            {
//                matrix[i, j] = (int)Math.Round(sr);
//            }
//        }
//    }
//}
//static int FindMaxIndex(int[,] matrix, int i)
//{
//    int ni = 0;
//    int max = matrix[i, 0];
//    for (int j = 1; j < matrix.GetLength(1); j++)
//    {
//        if (matrix[i, j] > max)
//        {
//            max = matrix[i, j];
//            ni = j;
//        }
//    }
//    return ni;
//}
//3/10
int[,] a = new int[5, 3]
    {
        { 5, 11, 3 },
        { 4, 2, 10 },
        { 3, 7, 9 },
        { 9, 7, 3 },
        { 8, 1, 2 }
    };

for (int i = 0; i < 5; i++)
{
    if (i % 2 == 0)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = j + 1; k < 3; k++)
            {
                if (a[i, j] < a[i, k])
                {
                    int temp = a[i, j];
                    a[i, j] = a[i, k];
                    a[i, k] = temp;
                }
            }
        }
    }
    else
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = j + 1; k < 3; k++)
            {
                if (a[i, j] > a[i, k])
                {
                    int temp = a[i, j];
                    a[i, j] = a[i, k];
                    a[i, k] = temp;
                }
            }
        }
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
//24
int[,] matrixY = new int[6, 5]
            { {-2,4,3,8,2},
            {10,3,2,-4,3 },
            {-3,4,3,-4,20},
            {4,5,12,-4,-3 },
                {3,-2,12,3,4 },
                { 4,3,4,3,4}
            };
ProcessMatrix(matrixY);
for (int i = 0; i < matrixY.GetLength(0); i++)
{
    for (int j = 0; j < matrixY.GetLength(1); j++)
    {
        Console.Write(matrixY[i, j] + " ");
    }
    Console.WriteLine();
}
static void ProcessMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int maxIndex = FindMaxIndex(matrix, i);
        int sum = 0;
        int count = 0;
        for (int j = maxIndex + 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > 0)
            {
                sum += matrix[i, j];
                count++;
            }
        }
        double sr = count > 0 ? (double)sum / count : 0;
        for (int j = 0; j < maxIndex; j++)
        {
            if (matrix[i, j] < 0)
            {
                matrix[i, j] = (int)Math.Round(sr);
            }
        }
    }
}
static int FindMaxIndex(int[,] matrix, int i)
{
    int ni = 0;
    int max = matrix[i, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] > max)
        {
            max = matrix[i, j];
            ni = j;
        }
    }
    return ni;
}
