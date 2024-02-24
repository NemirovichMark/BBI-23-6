using System;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
/*
1) Составить программу для обработки результатов кросса на 500 м для женщин.  
Для каждой участницы ввести фамилию, группу, фамилию преподавателя,
результат. Получить результирующую таблицу, упорядоченную по результатам, в  
которой содержится также информация о выполнении норматива. Определить  
суммарное количество участниц, выполнивших норматив.
*/


namespace lab_6
{
    class Program
    {
        public struct Participant // объявление структуры
        {

            private string surname;
            private int group;
            private string surnameTeacher;
            private int result;
            private int norma;
            private bool pass;


            public Participant(string ssurname, int ggroup, string ssurnameTeacher, int rresult) //объявление конструктора
            {
                surname = ssurname;
                group = ggroup;
                surnameTeacher = ssurnameTeacher;
                result = rresult;
                norma = 90;
                pass = false;
                if (result <= norma) { pass = true; }
            }

            public int Result { get { return result; } }
            public bool Passed { get { return pass; } }
            public void Print(string text = "Некорректная информация", string add = "Норматив не выполнен")
            {
                if (pass) { add = "Норматив выполнен"; }
                if (surname != null && surnameTeacher != null && group > 0 && result > 0)
                { text = surname + " " + group + " " + surnameTeacher + " " + result + " - " + add; }
                Console.WriteLine(text);
            }


            static void Main(string[] args)
            {
                Console.Write("Введите количество участников кросса: ");
                int k = int.Parse(Console.ReadLine());
                Participant[] participants = new Participant[k];
                string surname, surnameTeacher;
                int group, result;
                int count = 0;

                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine("Введите следующие данные: фамилия, группа, фамилия преподавателя, результат кросса, отдельно на каждой строке:");
                    surname = Console.ReadLine();
                    group = int.Parse(Console.ReadLine());
                    surnameTeacher = Console.ReadLine();
                    result = int.Parse(Console.ReadLine());
                    participants[i] = new Participant(surname, group, surnameTeacher, result);
                    if (participants[i].Passed == true)
                    {
                        count++;
                    }
                }

                // gnomesort массива 
                Participant d;
                for (int i = 1; i < k; i++)
                {
                    for (int j = i; j > 0 && participants[j].Result < participants[j - 1].Result; j--)
                    {
                        d = participants[j];
                        participants[j] = participants[j - 1];
                        participants[j - 1] = d;
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < k; i++)
                {
                    participants[i].Print();
                }
                Console.WriteLine("Выполнило норматив: " + count);
                Console.ReadKey();

            }
        }
    }
}

/*

namespace Lessons
{
    class Program
    {
      
        // метод/функция 
        static int Foo(int value)
        {
            value = 5;
            return value;
        }
        static void Main(string[] args)
        {
            int a = 1;
            a = Foo(a);
            Console.WriteLine(a);
        }



    }
    
}

*/