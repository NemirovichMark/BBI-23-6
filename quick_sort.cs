using System;

public class Program
{
    public static int[] QuickSort(int[] array) {
        if (array.Length <= 1) {
            return array;
        }  // Базовый случай
        int pivot = array[array.Length/2]; // Получаем опорный элемент, средний элемент оптимально подходит
        int lesserLength = 0, greaterLength = 0; // Так как мы не работаем с листами, мы должны заранее знать длину массивов меньше и больше опорного элемента
        for (int i = 0; i < array.Length; ++i) {
            if (i == array.Length/2) continue;
            if (array[i] <= pivot) {
                lesserLength++;
            } else {
                greaterLength++;
            }
        }
        int[] lesser = new int[lesserLength];
        int[] greater = new int[greaterLength];
        
        int lesserIndex = 0;
        int greaterIndex = 0;
        for (int i = 0; i < array.Length; ++i) {
            if (i == array.Length/2) continue;
            if (array[i] <= pivot) {
                lesser[lesserIndex] = array[i];
                lesserIndex++; 
            } else {    // Если меньше опорного - идём в массив меньших, иначе в масиив больших
                greater[greaterIndex] = array[i];
                greaterIndex++;
            }
        }
        lesser = QuickSort(lesser);
        greater = QuickSort(greater);  // Рекурсивно сортируем массивы меньших и больших
        int[] outArray = new int[array.Length];
        for (int i=0;i<lesser.Length;++i) {
            outArray[i] = lesser[i];
        }
        outArray[lesser.Length] = pivot;  // Добавляем сначала массивы меньших, затем опорный элемент и после массив больших. И возвращаем осортированный массив
        for (int i=0;i<greater.Length;++i) {
            outArray[i + lesser.Length + 1] = greater[i];
        };
        return outArray;
    }
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int arrSize = 10;
        
        int[] randArray = new int[arrSize];
        for (int i=0;i<arrSize;++i) {
            randArray[i]= rnd.Next() % 1000;
            Console.Write(randArray[i].ToString() + " ");  // Создаем рандомный массив
        }
        Console.WriteLine();
        Console.WriteLine();
        randArray = QuickSort(randArray); // Сортируем и выводим
        for (int i=0;i<arrSize;++i) {
            Console.Write(randArray[i].ToString() + " "); 
        }

    }
}
