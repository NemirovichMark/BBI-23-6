using System;
using System.Diagnostics;

//protected 
namespace KR
{
    class Program
    {
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

        public static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];
            employees[0] = new Employee("Иван Иванов", 25, 2023, 50000);
            employees[1] = new Employee("Петр Смирнов", 30, 2021, 60000);
            employees[2] = new Employee("Елена Петрова", 28, 2017, 55000);
            employees[3] = new Employee("Дмитрий Соколов", 27, 2022, 52000);
            employees[4] = new Employee("Ольга Кузнецова", 32, 2018, 70000);

            var sortedEmployees = employees.OrderBy(e => e.Name.Split(' ')[1]).ToArray();
            foreach (var employee in sortedEmployees)
            {
                Employee.Print(employee);
            }
            Console.WriteLine(Employee.count);
        }
    }
}
