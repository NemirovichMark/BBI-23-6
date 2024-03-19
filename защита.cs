//2 уровень
//using System;

//class Person
//{
//    protected string famile;
//    public string Famile { get { return famile; } }
//    public virtual void Print(string text = "Некорректная фамилия")
//    {
//        if (famile != null)
//        {
//            text = famile;
//        }
//        Console.WriteLine(text);
//    }
//    public Person(string famile)
//    {
//        this.famile = famile;
//    }
//}

//class students : Person 
//{
//    protected readonly int studticket;
//    private double rez;

//    public double Rez { get { return rez; } }

//    public students(string famile, int studticket, double x, double y, double z, double w) : base(famile)
//    {
//        rez = (x + y + z + w) / 4;
//        this.studticket = studticket;
//    }
//    public override void Print(string text = "Некорректная фамилия")
//    {
//        if (famile != null)
//        {
//            text = famile + "   " + "Средний балл" + " " + rez + "  " + "Студенский билет " + studticket;
//        }
//        if (rez >= 4)
//        {
//            Console.WriteLine(text);
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        students[] os = new students[4];
//        os[0] = new students("Романов", 7182, 3.0, 5.0, 5.0, 4.0);
//        os[1] = new students("Кузнецов", 1436, 4.0, 5.0, 4.0, 5.0);
//        os[2] = new students("Печугин", 0104, 3.0, 3.0, 4.0, 3.0);
//        os[3] = new students("Лавров", 0372, 5.0, 5.0, 5.0, 5.0);
//        Sort(os);
//        foreach (students students in os)
//        {
//            students.Print();
//        }
//        Console.ReadKey();
//    }
//    static void Sort(students[] a)
//    {
//        for (int i = 0; i < a.Length - 1; i++)
//        {
//            double amax = a[i].Rez;
//            int imax = i;
//            for (int j = i; j < a.Length; j++)
//            {
//                if (a[i].Rez > amax)
//                {
//                    amax = a[j].Rez;
//                    imax = j;
//                }
//            }
//            students temp;
//            temp = a[imax];
//            a[imax] = a[i];
//            a[i] = temp;
//        }
//    }
//}

