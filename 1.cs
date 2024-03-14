using System;
using System.Globalization;

abstract class student
{

    public student(string sur, int m, int s)
    {
        surname = sur;
        mark = m;
        skipped = s;
    }
    public int Mark
    {
        readonly get => mark;
        set => mark = value;
    }
    public int Skipped
    {
        readonly get => skipped;
        set => skipped = value;
    }
    public string Surname
    {
        readonly get => surname;
        set => surname = value;
    }
    private string surname;
    private int mark;
    private int skipped;
    protected int subject;
    public int Subject
    {
        get => subject;
        set => subject = value;
    }
}
class Mstudent : student
{
    public Mstudent(string sur, int m, int s)
    : base(sur, m, s)
    {
        Subject = 0;
    }
}
class Istudent : student
{
    public Istudent(string sur, int m, int s)
    : base(sur, m, s)
    {
        Subject = 1;
    }

}
class Program
{
    static void sort(student[] x, ref int len)
    {
        int index = 1;
        int nextInd = index + 1;

        while (index < len)
        {
            if (x[index].Skipped > x[index - 1].Skipped)
            {
                index = nextInd;
                nextInd++;
            }
            else
            {
                student temp = x[index - 1];
                x[index - 1] = x[index];
                x[index] = temp;
                index--;
                if (index == 0)
                {
                    index = nextInd;
                    nextInd++;
                }
            }
        }
    }

    static void Read(int n, student[] students, ref int cntBad, int subject)
    {
        for (int i = 0; i < n; i++)
        {
            int mark, skipped;
            string surname;
            Console.WriteLine($"Введите фамилию {i + 1}-го студента");
            surname = Console.ReadLine();
            Console.WriteLine($"Введите оценку {i + 1}-го студента");
            mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите количество занятий, пропущенных {i + 1}-м студентом");
            skipped = Convert.ToInt32(Console.ReadLine());

            if (subject == 0) students[i] = new Mstudent(surname, mark, skipped);
            else students[i] = new Istudent(surname, mark, skipped);

            if (mark == 2)
            {
                cntBad++;
            }
        }
    }
    static void MakeBad(ref int n, ref int cntBad, student[] BadStudents, student[] students)
    {
        int pos = 0;
        for (int i = 0; i < n; i++)
        {
            if (students[i].Mark == 2)
            {
                BadStudents[pos] = students[i];
                pos++;
            }
        }
        sort(BadStudents, ref cntBad);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество студентов по математике");
        int n = Convert.ToInt32(Console.ReadLine());
        student[] Mstudents = new student[n];
        int cntM = 0;
        Read(n, Mstudents, ref cntM, 0);

        Console.WriteLine("Введите количество студентов по информатике");
        int k = Convert.ToInt32(Console.ReadLine());
        student[] Istudents = new student[k];
        int cntI = 0;
        Read(k, Istudents, ref cntI, 1);

        student[] badMStudents = new Mstudent[cntM];

        MakeBad(ref n, ref cntM, badMStudents, Mstudents);

        Console.WriteLine("Студенты математики");
        for (int i = 0; i < cntM; i++)
        {
            Console.WriteLine($"{badMStudents[i].Surname}, кол-во пропущенных занятий: {badMStudents[i].Skipped}");
        }

        student[] badIStudents = new Istudent[cntI];

        MakeBad(ref k, ref cntI, badIStudents, Istudents);


        Console.WriteLine("Студенты информатики");
        for (int i = 0; i < cntI; i++)
        {
            Console.WriteLine($"{badIStudents[i].Surname}, кол-во пропущенных занятий: {badIStudents[i].Skipped}");
        }
    }
}