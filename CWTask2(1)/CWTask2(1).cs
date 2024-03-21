using System;
using System.Diagnostics;

//protected 
namespace KR
{
    abstract class Company
    {
        private string companyName;
        private Employee[] employees;
        public Company(string companyName, Employee[] employees)
        {
            this.companyName = companyName;
            this.employees = employees;
        }

        public double AverageSalary()
        {
            double totalSalary = 0;
            foreach (var employee in employees)
            {
                totalSalary += employee.Zp;
            }
            return totalSalary / employees.Length;
        }
    public abstract bool AcceptEmployeeCriteria(Employee employee);
    }


    class It : Company
    {
        public It(string companyName, Employee[] employees) : base(companyName, employees) { }

        public override bool AcceptEmployeeCriteria(Employee employee)
        {
            return employee.Age >= 25;
        }
    }

    class Industrial : Company
    {
        public Industrial(string companyName, Employee[] employees) : base(companyName, employees) { }

        public override bool AcceptEmployeeCriteria(Employee employee)
        {
            return employee.Year <= 2020;
        }
    }

    struct Employee
    {
        private string name;
        private int age;
        private int year;
        private int zp;
        public static int count = 0;

        public Employee(string name, int age, int year, int zp) // нет id
        {
            this.name = name;
            this.age = age;
            this.year = year;
            this.zp = zp;
            if (year >= 2020) { count++; }
        }

        public string Name { get { return name; } }
        public int Year { get { return year; } }
        public int Age { get { return age; } }
        public int Zp { get { return zp; } }

        public static void Print(Employee e)
        {
            Console.WriteLine("Name: " + e.Name);
            Console.WriteLine("Age: " + e.Age);
            Console.WriteLine("Year: " + e.Year);
            Console.WriteLine("Zp : " + e.Zp);
            Console.WriteLine();
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            // 1 задание
            // random для второго задания
            Random rand = new Random();
            Employee[] employees = new Employee[5];
            employees[0] = new Employee("Иван Иванов", 25, 2023, rand.Next(50000, 100000));
            employees[1] = new Employee("Петр Смирнов", 30, 2021, rand.Next(50000, 100000));
            employees[2] = new Employee("Елена Петрова", 28, 2017, rand.Next(50000, 100000));
            employees[3] = new Employee("Дмитрий Соколов", 27, 2022, rand.Next(50000, 100000));
            employees[4] = new Employee("Ольга Кузнецова", 32, 2018, rand.Next(50000, 100000));

            var sortedEmployees = employees.OrderBy(e => e.Name.Split(' ')[1]).ToArray();
            foreach (var employee in sortedEmployees)
            {
                Employee.Print(employee);
            }
            Console.WriteLine(Employee.count);


            //2 задание

            It[] its = new It[5];
            Industrial[] industrials = new Industrial[5];
            for (int i = 0; i < 5; i++)
            {
                its[i] = new It("IT Company" + i, employees);
                industrials[i] = new Industrial("Industrial Company" + i, employees);
            }

            foreach (var employee in employees)
            {
                Employee.Print(employee);
            }
            // продолжение следует...

        }
    }
}
