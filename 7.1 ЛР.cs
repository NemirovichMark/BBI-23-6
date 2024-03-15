//1 уровень 4 задача
//using System;
//class Sportsmen
//{
//    private string famile;
//    private double rez1, rez2, rez;
//    private bool dis = false;
//    public void Diss()
//    {
//        dis = true;
//    }
//    public Double Rez { get { return rez; } }
//    private double max(double x, double y)
//    {
//        if (x > y)
//        {
//            return x;
//        }
//        else
//        {
//            return y;
//        }
//    }
//    public Sportsmen(string famile1, double rezz1, double rezz2)
//    {
//        famile = famile1;
//        rez1 = rezz1;
//        rez2 = rezz2;
//        rez = max(rez1, rez2);
//    }
//    public void Print()
//    {
//        if (dis == false)
//        {
//            Console.WriteLine("Фамилия {0}\t  Результат  {1:f2}", famile, rez);
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Sportsmen[] sp = new Sportsmen[3];
//        sp[0] = new Sportsmen("Романов", 1.48, 1.52);
//        sp[1] = new Sportsmen("Кузнецов", 1.6, 1.55);
//        sp[2] = new Sportsmen("Лавров", 1.39, 1.35);
//        for (int i = 0; i < sp.Length; i++)
//        {
//            sp[i].Print();
//        }
//        for (int i = 0; i < sp.Length - 1; i++)
//        {
//            double amax = sp[i].Rez;
//            int imax = i;
//            for (int j = i + 1; j < sp.Length; j++)
//            {
//                if (sp[j].Rez > amax)
//                {
//                    amax = sp[j].Rez;
//                    imax = j;
//                }
//            }
//            Sportsmen temp;
//            temp = sp[imax];
//            sp[imax] = sp[i];
//            sp[i] = temp;
//        }
//        Console.WriteLine();
//        sp[0].Diss();
//        for (int i = 0; i < sp.Length; i++)
//        {
//            sp[i].Print();

//        }
//        Console.ReadKey();
//    }
//}


//2 уровень 1 задача
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
//}

//class students : Person
//{
//    protected readonly int studticket;
//    private double rez;

//    public double Rez { get { return rez; } }

//    public students(string famile, int studticket, double x, double y, double z, double w)
//    {
//        this.famile = famile;
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

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            students[] os = new students[4];
//            os[0] = new students("Романов", 7182, 3.0, 5.0, 5.0, 4.0);
//            os[1] = new students("Кузнецов", 1436, 4.0, 5.0, 4.0, 5.0);
//            os[2] = new students("Печугин", 0104, 3.0, 3.0, 4.0, 3.0);
//            os[3] = new students("Лавров", 0372, 5.0, 5.0, 5.0, 5.0);
//            Sort(os);
//            foreach (students students in os)
//            {
//                students.Print();
//            }
//            Console.ReadKey();
//        }
//        static void Sort(students[] a)
//        {
//            for (int i = 0; i < a.Length - 1; i++)
//            {
//                double amax = a[i].Rez;
//                int imax = i;
//                for (int j = i; j < a.Length; j++)
//                {
//                    if (a[i].Rez > amax)
//                    {
//                        amax = a[j].Rez;
//                        imax = j;
//                    }
//                }
//                students temp;
//                temp = a[imax];
//                a[imax] = a[i];
//                a[i] = temp;
//            }
//        }
//    }


//3 уровень 1 задача
//using System;
//class Group
//{
//    protected double srball;
//    public double sr(double[] a)
//    {
//        double sum = 0;
//        for (int i = 0; i < a.Length; i++)
//        {
//            sum += a[i];
//        }
//        sum = sum / a.Length;
//        return sum;
//    }
//    public double Srball { get { return srball; } }
//    public Group(double[] b1, double[] b2, double[] b3)
//    {
//        srball = (sr(b1) + sr(b2) + sr(b3)) / 3;
//    }
//    public void Print()
//    {
//        Console.WriteLine("cредний балл - " + Math.Round(srball, 2));
//    }
//}

//class BBI1_Group : Group
//{
//    public BBI1_Group(double[] informatic, double[] maths, double[] b1, double[] b2, double[] b3) : base(b1, b2, b3)
//    {
//        srball = (sr(b1) + sr(b2) + sr(b3) + sr(informatic) + sr(maths)) / 5;
//    }
//}
//class BBI2_Group : Group
//{
//    public BBI2_Group(double[] literature, double[] english, double[] b1, double[] b2, double[] b3) : base(b1, b2, b3)
//    {
//        srball = (sr(b1) + sr(b2) + sr(b3) + sr(literature) + sr(literature)) / 5;
//    }
//}
//class BBI3_Group : Group
//{
//    public BNTM_Group(double[] physics, double[] biology, double[] b1, double[] b2, double[] b3) : base(b1, b2, b3)
//    {
//        srball = (sr(b1) + sr(b2) + sr(b3) + sr(physics) + sr(biology)) / 5;
//    }
//}
//class Program
//{

//    static void Main(string[] args)
//    {
//        double[] informatic = new double[3] { 4.0, 3.0, 5.0 };
//        double[] maths = new double[3] { 4.0, 4.0, 3.0 };
//        double[] b1 = new double[3] { 5.0, 4.0, 4.0 };
//        double[] b2 = new double[3] { 5.0, 5.0, 3.0 };
//        double[] b3 = new double[3] { 3.0, 3.0, 3.0 };
//        BBI1_Group G23_6 = new BBI1_Group(informatic, maths, b1, b2, b3);

//        double[] literature = new double[3] { 5.0, 5.0, 5.0 };
//        double[] english = new double[3] { 4.0, 5.0, 5.0 };
//        double[] p1 = new double[3] { 3.0, 4.0, 5.0 };
//        double[] p2 = new double[3] { 4.0, 5.0, 3.0 };
//        double[] p3 = new double[3] { 3.0, 5.0, 5.0 };
//        BBI2_Group G23_5 = new BBI2_Group(literature, english, p1, p2, p3);

//        double[] physics = new double[3] { 4.0, 5.0, 5.0 };
//        double[] biology = new double[3] { 3.0, 3.0, 4.0 };
//        double[] m1 = new double[3] { 5.0, 4.0, 5.0 };
//        double[] m2 = new double[3] { 4.0, 3.0, 4.0 };
//        double[] m3 = new double[3] { 3.0, 5.0, 4.0 };
//        BBI3_Group G23_4 = new BBI3_Group(physics, biology, m1, m2, m3);

//        Group[] groups = new Group[3] { G23_6, G23_5, G23_4 };
//        for (int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 2; j++)
//            {
//                if (groups[j].Srball < groups[j+1].Srball)
//                {
//                    Group m = groups[j];
//                    groups[j] = groups[j+1];
//                    groups[j+1] = m;

//                }
//            }
//        }
//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write("Группа " + (i + 1) + "   ");
//            groups[i].Print();
//        }
//        Console.ReadKey();
//    }
//}