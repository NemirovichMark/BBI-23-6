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
        public static void sortedList(int leftBorder, int rightBorder, int[] list)
        {
            int[] tempList = new int[rightBorder - leftBorder + 1];
            for (int i = leftBorder; i <= rightBorder; i++)
                tempList[i - leftBorder] = list[i];
            Array.Sort(tempList);
            for (int i = leftBorder; i <= rightBorder; i++)
                list[i] = tempList[i - leftBorder];
        }
        public static int findMaximumElementPosition(int[] list)
        {
            int maximumElementPosition = 0;
            int lengthList = list.Length;
            for (int i = 1; i < lengthList; i++) 
                if (list[i] > list[maximumElementPosition]) 
                    maximumElementPosition = i;
            return maximumElementPosition;
        }
        public static int findMaximumElementInLineMatrix(List<int> list)
        {
            int maximumElementPosition = list[0];
            int lengthList = list.Count;
            for (int i = 1; i < lengthList; i++)
                if (list[i] > maximumElementPosition)
                    maximumElementPosition = list[i];
            return maximumElementPosition;
        }
        public static List<Tuple<int, int>> makePairMaximimElementLineMatrixAndNumberLine(List<List<int>> matrix, int n, int m)
        {
            List<Tuple<int, int>> listTuples = new List<Tuple<int, int>>();
            for(int i = 0; i < n; i++)
                listTuples.Add(new Tuple<int, int>(findMaximumElementInLineMatrix(matrix[i]), i));
            listTuples.Sort();
            return listTuples;
        }

        public static List<List<int>> sortMatrixByMaximumElementInLine(List<List<int>> matrix, int n, int m)
        {
            List<Tuple<int, int>> listTuples = makePairMaximimElementLineMatrixAndNumberLine(matrix, n, m);
            List<List<int>> newMatrix = new List<List<int>>();
            listTuples.Reverse();
            for(int i = 0; i < n; ++i)
            {
                newMatrix.Add(matrix[listTuples[i].Item2]);
            }
            return newMatrix;
        }

        public static int numberNegativeElementsInList(List<int> list)
        {
            int n = list.Count;
            int result = 0;
            for (int i = 0; i < n; ++i)
            {
                result += list[i] < 0 ? 1 : 0;
            }
            return result;
        }

        public static List<int> findLineWithMaximumNumberNegativeElementsInMatrix(List<List<int>> matrix)
        {
            int n = matrix.Count;
            List<int> resultList = new List<int>();
            int nowMaximum = 0;
            for (int i = 0; i < n; ++i)
            {
                int temp = numberNegativeElementsInList(matrix[i]);
                if (nowMaximum < temp)
                {
                    resultList = matrix[i];
                    nowMaximum = temp;
                }
            }
            return resultList;
        }
        static void Main(string[] args)
        {
            //task4
            /*
            int lengthList = Convert.ToInt32(Console.ReadLine());
            int[] list = new int[lengthList];
            for (int i = 0; i < lengthList; i++) list[i] = Convert.ToInt32(Console.ReadLine());
            sortedList(findMaximumElementPosition(list) + 1, lengthList - 1, list);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }*/
            //task10
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            List<List<int>> matrix = new List<List<int>>();
            for (int i = 0; i < n; ++i)
            {
                matrix.Add(Array.ConvertAll(Console.ReadLine().Split(" "), Int32.Parse).ToList());
            }
            matrix = sortMatrixByMaximumElementInLine(matrix, n, m);
            foreach (var i in matrix)
            {
                foreach (var j in i)
                    Console.Write(j + " ");
                Console.WriteLine();
            }*/
            // task16
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            List<List<int>> matrix = new List<List<int>>();
            for (int i = 0; i < n; ++i)
            {
                matrix.Add(Array.ConvertAll(Console.ReadLine().Split(" "), Int32.Parse).ToList());
            }
            List<int> list = findLineWithMaximumNumberNegativeElementsInMatrix(matrix);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
        //task10

    }
}