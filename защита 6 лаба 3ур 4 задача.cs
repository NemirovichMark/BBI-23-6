using System;
static class Hello
{
    //public struct Students
    //{
    //    string famile;
    //    string name;
    //    double rez1, rez2, rez3, rez;
    //    //public double GetRez1()
    //    //{
    //    //    return rez1;
    //    //}
    //    //public double GetRez2()
    //    //{
    //    //    return rez2;
    //    //}
    //    //public double GetRez3()
    //    //{
    //    //    return rez3;
    //    //}
    //    public double GetRez()
    //    {
    //        return rez;
    //    }
    //    public bool Results()
    //    {
    //        if (rez1 <= 2 || rez2 <= 2 || rez3 <= 2)
    //        {
    //            return true;
    //        }
    //        else return false;
    //    }
    //    public Students(string famile1, string name1, double rezz1, double rezz2, double rezz3)
    //    {
    //        famile = famile1; name = name1; rez1 = rezz1; rez2 = rezz2; rez3 = rezz3;
    //        rez = (rezz1 + rezz2 + rezz3) / 3;
    //    }
    //    public void Print()
    //    {
    //        Console.WriteLine($"{famile} {name} {rez}");
    //    }
    //}
    //static Students[] Sort(Students[] students)
    //{
    //    for (int i = 0; i < students.Length; i++)
    //    {
    //        for (int j = i; j < students.Length; j++)
    //        {
    //            if (students[i].GetRez() < students[j].GetRez())
    //            {
    //                Students student = students[j];
    //                students[j] = students[i];
    //                students[i] = student;
    //            }
    //        }
    //    }
    //    return students;
    //}

    //public static void Main()
    //{
    //    Students[] st = new Students[5];
    //    st[0] = new Students("Иванов", "Дмитрий", 3, 3, 4);
    //    st[1] = new Students("Дорогой", "Александр", 4, 4, 5);
    //    st[2] = new Students("Бруталов", "Фофан", 2, 3, 4);
    //    st[3] = new Students("Палец", "Безымянный", 3, 3, 3);
    //    st[4] = new Students("Просто", "Спортсмен", 5, 2, 4);
    //    st = Sort(st);
    //    for (int i = 0; i < st.Length; i++)
    //    {
    //        st[i].Print();
    //    }
    //    Console.WriteLine();
    //    for (int i = 0; i < st.Length; i++)
    //    {
    //        if (st[i].Results())
    //        {

    //        }
    //        else
    //        {
    //            st[i].Print();
    //        }
    //    }
    //}

    public class Program
    {
        struct Participant
        {
            string name;
            int result;
            public int Result()
            {
                return result;
            }
            public Participant(string name, int res)
            {
                this.name = name;
                result = res;
            }
            public void InfoP()
            {
                Console.WriteLine($"имя: {name} результат: {result} ");
            }
        }
        static Participant[] Sort(Participant[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = i; j < list.Length; j++)
                    if (list[i].Result() < list[j].Result())
                    {
                        Participant person_now = list[j]; // меняем игроков 
                        list[j] = list[i];
                        list[i] = person_now;
                    }
            }
            return list;
            //    //int index;
            //    //Participant CurrentNumber;
            //    //for (int i = 0; i < list.Length; i++)
            //    //{
            //    //    index = i;
            //    //    CurrentNumber = list[i];
            //    //    while (index > 0 & CurrentNumber.Result() < list[i - 1].Result())
            //    //    {
            //    //        list[i] = list[i - 1];
            //    //        index--;
            //    //    }
            //    //    list[i] = CurrentNumber;
            //    //}
            //    //return list;
        }

        static Participant[] MergeSort(Participant[] array)
        {
            if (array.Length < 2)
            {
                return array;
            }

            int mid = array.Length / 2;
            Participant[] left = new Participant[mid];
            Participant[] right = new Participant[array.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }
            for (int i = mid; i < array.Length; i++)
            {
                right[i - mid] = array[i];
            }
            MergeSort(left); MergeSort(right);
            Merge(array, left, right);
            return array;
        }

        static void Merge(Participant[] targetarray, Participant[] array1, Participant[] array2)
        {
            int array1minindex = 0;
            int array2minindex = 0;

            int targetarrayminindex = 0;

            while (array1minindex < array1.Length && array2minindex < array2.Length)
            {
                if (array1[array1minindex].Result() <= array2[array2minindex].Result())
                {
                    targetarray[targetarrayminindex] = array2[array2minindex];
                    array2minindex++;
                }
                else
                {
                    targetarray[targetarrayminindex] = array1[array1minindex];
                    array1minindex++;
                }
                targetarrayminindex++;
            }
            while (array1minindex < array1.Length)
            {
                targetarray[targetarrayminindex] = (array1[array1minindex]);
                array1minindex++;
                targetarrayminindex++;
            }

            while (array2minindex < array2.Length)
            {
                targetarray[targetarrayminindex] = (array2[array2minindex]);
                array2minindex++;
                targetarrayminindex++;
            }
        }

        public static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            Participant[] group1 = new Participant[n1];
            Participant[] group2 = new Participant[n2];
            Participant[] allgroup = new Participant[n2 + n1];

            for (int i = 0; i < n1; i++)
            {
                string name_ = Console.ReadLine();
                int result_ = int.Parse(Console.ReadLine());

                Participant Person = new Participant(name_, result_);

                group1[i] = Person;
                allgroup[i] = Person;
            }

            for (int i = 0; i < n2; i++)
            {
                string name_ = Console.ReadLine();
                int result_ = int.Parse(Console.ReadLine());

                Participant Person = new Participant(name_, result_);

                group2[i] = Person;
                allgroup[i + n1] = Person;
            }

            group1 = Sort(group1);
            group2 = Sort(group2);
            allgroup = MergeSort(allgroup);

            Console.WriteLine("1 группа:");
            for (int i = 0; i < n1; i++)
            {
                Console.Write($"{i + 1} место:"); ;
                group1[i].InfoP();
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("2 группа:");
            for (int i = 0; i < n2; i++)
            {
                Console.Write($"{i + 1} место:"); ;
                group2[i].InfoP();
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Все участники:");
            for (int i = 0; i < n1 + n2; i++)
            {
                Console.Write($"{i + 1} место:"); ;
                allgroup[i].InfoP();
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}