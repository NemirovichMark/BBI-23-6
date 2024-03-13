//1 уровень  4 задача 
//using System;
//struct Sportsmen
//{
//    private string famile;
//    private double rez1, rez2, rez;
//    private bool Dis = false;
//    public void Diss()
//    {
//        Dis = true;
//    }
//    public bool dis { get { return Dis; } }

//    public Double Rez { get { return rez; } }
//    public String Famile { get { return famile; } }
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
//            Console.WriteLine("Фамилия {0}\t Результат {1:f2}", sp[i].Famile, sp[i].Rez);
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
//            if (sp[i].dis == false)
//            {
//                Console.WriteLine("Фамилия {0}\t  Результат  {1:f2}", sp[i].Famile, sp[i].Rez);
//            }

//        }

//    }
//}




//2 уровень 1 задача
//using System;

//class Person
//{
//    protected string famile;
//    public string Famile { get { return famile; } }
//}

//class students : Person
//{
//    private double studticket;
//    private double rez1, rez2, rez3, rez4;
//    private double rez;

//    public double Rez { get { return rez; } }
//    public double Studticket { get { return studticket; } }

//    private double sr(double x, double y, double z, double w)
//    {
//        return (x + y + z + w) / 4;
//    }

//    public students(string famile1, double rezz1, double rezz2, double rezz3, double rezz4, double studticket1)
//    {
//        famile = famile1;
//        rez1 = rezz1;
//        rez2 = rezz2;
//        rez3 = rezz3;
//        rez4 = rezz4;
//        rez = sr(rez1, rez2, rez3, rez4);
//        studticket = studticket1;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        students[] os = new students[4];
//        os[0] = new students("Романов", 3.0, 5.0, 5.0, 4.0, 1);
//        os[1] = new students("Кузнецов", 4.0, 5.0, 4.0, 5.0, 2);
//        os[2] = new students("Печугин", 3.0, 3.0, 4.0, 3.0, 3);
//        os[3] = new students("Лавров", 5.0, 5.0, 5.0, 5.0, 4);

//        for (int i = 0; i < os.Length; i++)
//        {
//            Console.WriteLine("Фамилия {0}\t  Средний балл {1,4:f2}  Студенческий билет {2}", os[i].Famile, os[i].Rez, os[i].Studticket);
//        }

//        for (int i = 0; i < os.Length - 1; i++)
//        {
//            double amax = os[i].Rez;
//            int imax = i;

//            for (int j = i + 1; j < os.Length; j++)
//            {
//                if (os[j].Rez > amax)
//                {
//                    amax = os[j].Rez;
//                    imax = j;
//                }
//            }

//            students temp;
//            temp = os[imax];
//            os[imax] = os[i];
//            os[i] = temp;
//        }

//        Console.WriteLine();

//        for (int i = 0; i < os.Length; i++)
//        {
//            if (os[i].Rez >= 4)
//            {
//                Console.WriteLine("Фамилия {0}\t  Средний балл {1,4:f2}  Студенческий билет {2}", os[i].Famile, os[i].Rez, os[i].Studticket);
//            }
//        }
//        Console.ReadKey();
//    }
//}


//3 уровень 1 задача
//using Microsoft.VisualBasic;
//using System;
//using System.Dynamic;
//using System.Runtime.Intrinsics.X86;
//using System.Security.Cryptography.X509Certificates;

//struct Student1
//{
//    private string famile;
//    private double rez1, rez2, rez3, rez4, rez5;
//    private double rez;
//    public String Famile { get { return famile; } }
//    public Double Rez
//    {
//        get { return rez; }
//    }
//    private double sr(double x, double y, double z, double w, double q)
//    {
//        return (x + y + z + w + q) / 5;
//    }
//    public Student1(string famile1, double rezz1, double rezz2, double rezz3, double rezz4, double rezz5)
//    {
//        famile = famile1;
//        rez1 = rezz1;
//        rez2 = rezz2;
//        rez3 = rezz3;
//        rez4 = rezz4;
//        rez5 = rezz5;
//        rez = sr(rez1, rez2, rez3, rez4, rez5);
//    }
//}
//class Group
//{
//    public double SRBALL(double[] a)
//    {
//        double sum = 0;
//        for(int i = 0; i < a.Length; i++)
//        {
//            sum += a[i];
//        }
//        sum = sum / a.Length;
//        return sum;
//    }
//    protected double[] b1 = new double[3];
//    protected double[] b2 = new double[3];
//    protected double[] b3 = new double[3];
//    protected double srball;
//    public Double Srball { get { return srball; } }
//    public Group(double[] b1, double[] b2, double[] b3)
//    {
//        this.b1 = b1;
//        this.b2 = b2;
//        this.b3 = b3;
//        srball = (SRBALL(b1) + SRBALL(b2) + SRBALL(b3)) / 3;

//    }

//}

//class osGroup : Group
//{
//    double[] informatic = new double[3];
//    double[] maths = new double[3];
//    public osGroup(double[] informatic, double[] maths, double[] b1, double[] b2, double[] b3): base(b1, b2, b3)
//    {
//        this.informatic = informatic;
//        this.maths = maths;
//        this.b1 = b1;
//        this.b2 = b2;
//        this.b3 = b3;
//        srball = (SRBALL(b1) + SRBALL(b2) + SRBALL(b3) + SRBALL(informatic) + SRBALL(maths)) / 5;
//    }
//}
//class clGroup : Group
//{
//    double[] literature = new double[3];
//    double[] english = new double[3];
//    public clGroup(double[] literature, double[] english, double[] b1, double[] b2, double[] b3) : base(b1, b2, b3)
//    {
//        this.literature = literature;
//        this.english = english;
//        this.b1 = b1;
//        this.b2 = b2;
//        this.b3 = b3;
//        srball = (SRBALL(b1) + SRBALL(b2) + SRBALL(b3) + SRBALL(literature) + SRBALL(literature)) / 5;
//    }
//}
//class orGroup : Group
//{
//    double[] physics = new double[3];
//    double[] biology = new double[3];
//    public orGroup(double[] physics, double[] biology, double[] b1, double[] b2, double[] b3) : base(b1, b2, b3)
//    {
//        this.physics = physics;
//        this.biology = biology;
//        this.b1 = b1;
//        this.b2 = b2;
//        this.b3 = b3;
//        srball = (SRBALL(b1) + SRBALL(b2) + SRBALL(b3) + SRBALL(physics) + SRBALL(biology)) / 5;
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
//        orGroup G1 = new orGroup( informatic, maths, b1, b2, b3);

//        double[] literature = new double[3] { 5.0, 5.0, 5.0 };
//        double[] english = new double[3] { 4.0, 5.0, 5.0 };
//        double[] p1 = new double[3] { 3.0, 4.0, 5.0 };
//        double[] p2 = new double[3] { 4.0, 5.0, 3.0 };
//        double[] p3 = new double[3] { 3.0, 5.0, 5.0 };
//        clGroup G2 = new clGroup(literature, english, p1, p2, p3);

//        double[] physics = new double[3] { 4.0, 5.0, 5.0 };
//        double[] biology = new double[3] { 3.0, 3.0, 4.0 };
//        double[] m1 = new double[3] { 5.0, 4.0, 5.0 };
//        double[] m2 = new double[3] { 4.0, 3.0, 4.0 };
//        double[] m3 = new double[3] { 3.0, 5.0, 4.0 };
//        osGroup G3 = new osGroup(physics, biology, m1, m2, m3);

//        Group[] Group4 = new Group[3] { G1, G2, G3 };
//        for(int i = 0; i < 3; i++)
//        {
//            for(int j = i+1; j < 2; j++)
//            {
//                if (Group4[j].Srball > Group4[i].Srball)
//                {
//                    Group m = Group4[j];
//                    Group4[j] = Group4[i];
//                    Group4[i] = m;

//                }
//            }
//        }
//        for(int i = 0; i < 3; i++)
//        {
//            Console.WriteLine("Группа: " + (i+1) +" " + Group4[i].Srball);
//        }



//    }


//}