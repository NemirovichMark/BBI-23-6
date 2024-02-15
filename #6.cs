// Номер 5 Уровень 1
//using System;
//using System.Globalization;

//struct student
//{
//    public student(string sur, int m, int s)
//    {
//        surname = sur;
//        mark = m;
//        skipped = s;
//    }
//    public int getMark()
//    {
//        return mark;
//    }
//    public int getSkipped()
//    {
//        return skipped;
//    }
//    public string getSurname()
//    {
//        return surname;
//    }
//    private string surname;
//    private int mark;
//    private int skipped;
//}
//class Program
//{
//    static void sort(student[] x, ref int len)
//    {
//        for (int i = 0; i < len - 1; i++)
//        {
//            for (int k = 0; k < len - 1 - i; ++k)
//            {
//                if (x[k].getSkipped() < x[k+1].getSkipped())
//                {
//                    (x[k],x[k+1]) = (x[k + 1],x[k]);
//                }
//            }

//        }
//    }
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите количество студентов");
//        int n = Convert.ToInt32(Console.ReadLine());
//        student [] students = new student[n];
//        int cnt = 0;
//        for (int i = 0; i < n; i++)
//        {
//            int mark, skipped;
//            string surname;
//            Console.WriteLine($"Введите фамилию {i + 1}-го студента");
//            surname = Console.ReadLine();
//            Console.WriteLine($"Введите оценку {i + 1}-го студента");
//            mark = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine($"Введите количество занятий, пропущенных {i + 1}-м студентом");
//            skipped = Convert.ToInt32(Console.ReadLine());
//            students[i] = new(surname, mark, skipped);
//            if (mark == 2)
//            {
//                cnt++;
//            }
//        }
//        int pos = 0;
//        student[] badStudents = new student[cnt];
//        for (int i = 0; i < n; i++)
//        {
//            if (students[i].getMark() == 2)
//            {
//                badStudents[pos] = students[i];
//                pos++;
//            }
//        }
//        sort(badStudents, ref cnt);
//        for (int i = 0; i < cnt; i++)
//        {
//            Console.WriteLine($"{badStudents[i].getSurname()}, кол-во пропущенных занятий: {badStudents[i].getSkipped()}");
//        }
//    }
//}

// Номер 3 ур. 2
//using System;
//struct Sportsman
//{
//    public Sportsman(string s, double r1, double r2, double r3)
//    {
//        surname = s;
//        res1 = r1;
//        res2 = r2;
//        res3 = r3;
//    }
//    public double getMax()
//    {
//        if (res1 >= res2 && res1 >= res3)
//        {
//            return res1;
//        }
//        else if (res2 >= res1 && res2 >= res3)
//        {
//            return res2;
//        }
//        else
//        {
//            return res3;
//        }
//    }
//    public string getSurname()
//    {
//        return surname;
//    }
//    public double getFirst()
//    {
//        return res1;
//    }
//    public double getSecond()
//    {
//        return res2;
//    }
//    public double getThird()
//    {
//        return res3;
//    }
//    private string surname;
//    private double res1, res2, res3;
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите количество спортсменов");
//        int n = Convert.ToInt32(Console.ReadLine());
//        Sportsman[] sportsmen = new Sportsman[n];
//        for (int i = 0; i < n; i++)
//        {
//            double res1, res2, res3;
//            string surname;
//            Console.WriteLine($"Введите фамилию {i + 1}-го спортсмена");
//            surname = Console.ReadLine();
//            Console.WriteLine($"Введите первый результат {i + 1}-го спортсмена");
//            res1 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine($"Введите второй результат {i + 1}-го спортсмена");
//            res2 = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine($"Введите третий результат {i + 1}-го спортсмена");
//            res3 = Convert.ToDouble(Console.ReadLine());
//            sportsmen[i] = new Sportsman(surname, res1, res2, res3);
//        }
//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine($"{sportsmen[i].getSurname()}, лучший результат: {sportsmen[i].getMax()} м");
//        }
//    }
//}

// Номер 4 уровень 3
using System;
struct Skiers
{
    public Skiers(string s, double r)
    {
        surname = s;
        res = r;
    }
    public string getSurname()
    {
        return surname;
    }
    public double getRes()
    {
        return res;
    }
    private string surname;
    private double res;
}
class Program
{
    static void sort(Skiers[] x, ref int len)
    {
        for (int i = 0; i < len - 1; i++)
        {
            for (int k = 0; k < len - 1 - i; k++)
            {
                if (x[k].getRes() > x[k+1].getRes())
                {
                    (x[k], x[k + 1]) = (x[k + 1], x[k]);
                }
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество лыжников в 1-ой группе");
        int n = Convert.ToInt32(Console.ReadLine());
        Skiers[] gr1 = new Skiers[n];
        for (int i = 0; i < n; i++)
        {
            double res;
            string surname;
            Console.WriteLine($"Введите фамилию {i + 1}-го лыжника"); 
            surname = Console.ReadLine();
            Console.WriteLine($"Введите результат {i + 1}-го лыжника");
            res = Convert.ToDouble( Console.ReadLine());
            gr1[i] = new Skiers(surname, res);
        }
        Console.WriteLine("Введите количество лыжников в 2-ой группе");
        int k = Convert.ToInt32(Console.ReadLine());
        Skiers[] gr2 = new Skiers[k];
        for (int i = 0; i < k; i++)
        {
            double res;
            string surname;
            Console.WriteLine($"Введите фамилию {i + 1}-го лыжника");
            surname = Console.ReadLine();
            Console.WriteLine($"Введите результат {i + 1}-го лыжника");
            res = Convert.ToDouble(Console.ReadLine());
            gr2[i] = new Skiers(surname, res);
        }
        sort(gr1, ref n);
        sort(gr2, ref k);
        Skiers[] skiers = new Skiers[n + k];
        int pos1 = 0;
        int pos2 = 0;
        for (int i = 0; i < n + k; i++)
        {
            if (pos1 == n)
            {
                skiers[i] = gr2[pos2];
                pos2++;
                continue;
            }
            if (pos2 == k)
            {
                skiers[i] = gr1[pos1];
                pos1++;
                continue;
            }
            if (gr1[pos1].getRes() < gr2[pos2].getRes())
            {
                skiers[i] = gr1[pos1];
                pos1++;
            }
            else
            {
                skiers[i] = gr2[pos2];
                pos2++;
            }
        }
        Console.WriteLine("Таблица группы 1");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|  Место  |   Фамилия   |   Результат  |");
        Console.WriteLine("----------------------------------------");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"     {i + 1}         {gr1[i].getSurname()}          {gr1[i].getRes()} секунд ");
        }
        Console.WriteLine();
        Console.WriteLine("Таблица группы 2");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|  Место  |   Фамилия   |   Результат  |");
        Console.WriteLine("----------------------------------------");
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine($"     {i + 1}         {gr2[i].getSurname()}          {gr2[i].getRes()} секунд ");
        }
        Console.WriteLine();
        Console.WriteLine("Общий зачет");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|  Место  |   Фамилия   |   Результат  |");
        Console.WriteLine("----------------------------------------");
        for (int i = 0; i < n + k; i++)
        {
            Console.WriteLine($"     {i + 1}         {skiers[i].getSurname()}          {skiers[i].getRes()} секунд ");
        }
    }
}


