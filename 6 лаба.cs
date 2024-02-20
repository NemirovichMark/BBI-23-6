//1уровень 4задача
//using System;
//struct Sportsmen
//{
//    private string famile;
//    private double rez1, rez2, rez;
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
//        for (int i = 0; i < sp.Length; i++)
//        {
//            Console.WriteLine("Фамилия {0}\t  Результат  {1:f2}", sp[i].Famile, sp[i].Rez);
//        }
//    }
//}

//2уровень 1 задача
//using System;
//struct Students
//{
//    private string famile;
//    private double rez1, rez2, rez3, rez4;
//    private double rez;
//    public Double Rez { get { return rez; } }
//    public String Famile { get { return famile; } }
//    private double sr(double x, double y, double z, double w)
//    {
//        return (x + y + z + w) / 4;
//    }
//    public Students(string famile1, double rezz1, double rezz2, double rezz3, double rezz4)
//    {
//        famile = famile1;
//        rez1 = rezz1;
//        rez2 = rezz2;
//        rez3 = rezz3;
//        rez4 = rezz4;
//        rez = sr(rez1, rez2, rez3, rez4);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Students[] os = new Students[4];
//        os[0] = new Students("Романов", 3.0, 5.0, 5.0, 4.0);
//        os[1] = new Students("Кузнецов", 4.0, 5.0, 4.0, 5.0);
//        os[2] = new Students("Печугин", 3.0, 3.0, 4.0, 3.0);
//        os[3] = new Students("Лавров", 5.0, 5.0, 5.0, 5.0);
//        for (int i = 0; i < os.Length; i++)
//        {
//            Console.WriteLine("Фамилия {0}\t  Средний балл {1,4:f2}", os[i].Famile, os[i].Rez);
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
//            Students temp;
//            temp = os[imax];
//            os[imax] = os[i];
//            os[i] = temp;
//        }
//        Console.WriteLine();
//        for (int i = 0; i < os.Length; i++)
//        {
//            if (os[i].Rez >= 4)
//            {
//                Console.WriteLine("Фамилия {0}\t  Средний балл {1,4:f2}", os[i].Famile, os[i].Rez);
//            }
//        }
//    }
//}

//3уровень 1задача
//using System;
//using System.Dynamic;
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
//class Program
//{
//    static void Main(string[] args)
//    {
//        Student1[] os = new Student1[3];
//        os[0] = new Student1("Смирнов", 5.0, 4.0, 4.0, 5.0, 3.0);
//        os[1] = new Student1("Сидоров", 4.0, 3.0, 3.0, 4.0, 4.0);
//        os[2] = new Student1("Орлов", 5.0, 4.0, 5.0, 5.0, 4.0);

//        Student1[] cl = new Student1[3];
//        cl[0] = new Student1("Иванов", 5.0, 4.0, 3.0, 5.0, 4.0);
//        cl[1] = new Student1("Печугин", 5.0, 3.0, 4.0, 3.0, 3.0);
//        cl[2] = new Student1("Романов", 5.0, 3.0, 3.0, 3.0, 3.0);

//        Student1[] or = new Student1[3];
//        or[0] = new Student1("Воронин", 4.0, 4.0, 4.0, 4.0, 4.0);
//        or[1] = new Student1("Лавров", 5.0, 5.0, 5.0, 5.0, 5.0);
//        or[2] = new Student1("Петров", 4.0, 3.0, 4.0, 3.0, 4.0);


//        double sum1 = 0;
//        for(int i = 0; i < os.Length; i++)
//        {
//            sum1 += os[i].Rez;
//        }
//        double sr1 = sum1 / 3;
//        double sum2 = 0;
//        for(int i = 0; i < cl.Length; i++)
//        {
//            sum2 += cl[i].Rez;
//        }
//        double sr2 = sum2 / 3;
//        double sum3 = 0;
//        for(int i = 0; i < or.Length; i++)
//        {
//            sum3 += or[i].Rez;
//        }
//        double sr3 = sum3 / 3;

//        Student1[] Students = new Student1[9];
//        if(sr1 > sr2 && sr1 > sr3)
//        {
//            Console.WriteLine($"1 место 1я группа: {sr1}");
//            if(sr2 > sr3)
//            {
//                Console.WriteLine($"2 место 2я группа: {sr2}");
//                Console.WriteLine($"3 место 3я группа: {sr3}");
//            }
//            else
//            {
//                Console.WriteLine($"2 место 3я группа: {sr3}");
//                Console.WriteLine($"3 место 2я группа: {sr2}");
//            }
//        }
//        if(sr2 > sr1 && sr2 > sr3)
//        {
//            Console.WriteLine($"1 место 2я группа: {sr2}");
//            if(sr1 > sr3)
//            {
//                Console.WriteLine($"2 место 1я группа: {sr1}");
//                Console.WriteLine($"3 место 3я группа: {sr3}");
//            }
//            else
//            {
//                Console.WriteLine($"2 место 3я группа: {sr3}");
//                Console.WriteLine($"3 место 1я группа: {sr1}");
//            }
//        }
//        if(sr3 > sr1 && sr3 > sr2)
//        {
//            Console.WriteLine($"3 место 3я группа: {sr3}");
//            if(sr2 > sr1)
//            {
//                Console.WriteLine($"2 место 2я группа: {sr2}");
//                Console.WriteLine($"3 место 1я группа: {sr1}");
//            }
//            else
//            {
//                Console.WriteLine($"2 место 1я группа: {sr1}");
//                Console.WriteLine($"3 место 2я группа: {sr2}");
//            }
//        }

//    }


//}