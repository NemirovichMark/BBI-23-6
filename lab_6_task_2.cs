using System;

/*
 2)Группа учащихся подготовительного отделения сдает выпускные экзамены по  
трем предметам (математика, физика, русский язык). Учащийся, получивший "2"  
сразу отчисляется. Вывести список учащихся, успешно сдавших экзамены, в  
порядке убывания полученного ими среднего балла по результатам трех экзаменов.
 */

namespace lab6_task2
{

    public struct Student
    {
        private string name;
        private int markMath;
        private int markRu;
        private int markPh;
        private bool pass;
        

        public Student(string name, int markMath, int markRu, int markPh)
        {
            this.name = name;
            this.markMath = markMath;
            this.markRu = markRu;
            this.markPh = markPh;
            pass = false;
            if (this.markMath > 2 && this.markRu > 2 && this.markPh > 2) { pass = true; }
        }

        public int Result { get { return (markMath + markRu + markPh) / 3; } }
        public bool Passed { get { return pass; } }
        public void Print(string text = "Некорректная информация")
        {
            if (pass && name != null) { text = name + ": " + Convert.ToInt32(Result); }
            if (pass == false && name != null && markMath > 0 && markPh > 0 && markRu > 0)
            { text = name + ": отчислен(а)" ; }
            Console.WriteLine(text);
        }

    }
    internal class Program
    {
        private string name;
        private int mark;

        private static void Main(string[] args)
        {
            Console.WriteLine("Введите количество учеников:");
            int k = int.Parse(Console.ReadLine());
            Student[] students = new Student[k];
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("Введите фамилию учащегося, на следующих строчках его оценки по 3 дисциплинам каждую по отдельности:");
                string name = Console.ReadLine();
                int markMath = int.Parse(Console.ReadLine());
                int markRu = int.Parse(Console.ReadLine());
                int markPh = int.Parse(Console.ReadLine());
                students[i] = new Student(name, markMath, markRu, markPh);
                
            }

            for (int i = 1; i < k; i++)
            {
                for (int j = i; j > 0 && students[j].Result < students[j - 1].Result; j--)
                {
                    Student temp = students[j];
                    students[j] = students[j - 1];
                    students[j - 1] = temp;

                }
            }
            Array.Reverse(students); 
            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                students[i].Print();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}