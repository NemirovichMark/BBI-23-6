using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 уровень 15 задача
            
            int n = 5; // Номер члена последовательности, который нужно найти
            int ch = 1; // Числитель
            int zn = 1; // Знаменатель

            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    zn += ch; // Обновляем знаменатель
                }
                else
                {
                    ch += zn; // Обновляем числитель
                }
            }

            // Выводим результат для 5-го члена
            Console.WriteLine($"5-й член последовательности: {ch}/{zn}");
        }
    }
}

