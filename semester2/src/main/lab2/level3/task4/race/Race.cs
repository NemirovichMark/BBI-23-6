namespace semester2.main.lab2.level3.task4.race;

using sportsman;

public class Race
{
    private readonly List<List<SkierMan>> _listGroupsSkierMen = new List<List<SkierMan>>();
    private readonly List<List<SkierWoman>> _listGroupsSkierWomen = new List<List<SkierWoman>>();
    private readonly List<SkierMan> _listAllSkierMen = new List<SkierMan>();
    private readonly List<SkierWoman> _listAllSkierWomen = new List<SkierWoman>();
    private readonly List<Sportsman> _allSportsmen = new List<Sportsman>();

    public void ReadGroupsSportsmen()
    {
        Console.WriteLine("Формат ввода информации об участниках:\n" +
                          "Фамилия участника Результат(m:ss:SSS)\n" +
                          "Например, Иванова 2:14:135"
        );
        Console.WriteLine("Количество женских групп:");
        int numberGroups = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("После ввода всех участников группы введите END");
        for (int i = 0; i < numberGroups; i++)
        {
            Console.WriteLine($"Женская группа номер {i + 1}:");
            int numberSkierWomen = 1;
            List<SkierWoman> skierWomen = new List<SkierWoman>();
            while (true)
            {
                Console.WriteLine($"Участник номер {numberSkierWomen++}:");
                string info = Console.ReadLine() ?? throw new ArgumentNullException();
                if (info.ToLower().Equals("end"))
                {
                    _listGroupsSkierWomen.Add(skierWomen);
                    break;
                }

                string[] parseInfo = info.Split();
                skierWomen.Add(new SkierWoman(parseInfo[0], Sportsman.ParseTime(parseInfo[1]), i + 1));
            }
        }

        Console.WriteLine("Количество мужских групп:");
        numberGroups = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("После ввода всех участников группы введите END");
        for (int i = 0; i < numberGroups; i++)
        {
            Console.WriteLine($"Мужская группа номер {i + 1}:");
            int numberSkierWomen = 1;
            List<SkierMan> skierMen = new List<SkierMan>();
            while (true)
            {
                Console.WriteLine($"Участник номер {numberSkierWomen++}:");
                string info = Console.ReadLine() ?? throw new ArgumentNullException();
                if (info.ToLower().Equals("end"))
                {
                    _listGroupsSkierMen.Add(skierMen);
                    break;
                }

                string[] parseInfo = info.Split();
                skierMen.Add(new SkierMan(parseInfo[0], Sportsman.ParseTime(parseInfo[1]), i + 1));
            }
        }

        SortGroupsSkierWomen();
        SortGroupsSkierMen();
        MergeGroupsSkierWomen();
        MergeGroupsSkierMen();
        MergeSportsmen();
    }

    private void SortGroupsSkierWomen()
    {
        foreach (var group in _listGroupsSkierWomen)
        {
            group.Sort(Sportsman.Compare);
        }
    }

    private void SortGroupsSkierMen()
    {
        foreach (var group in _listGroupsSkierMen)
        {
            group.Sort(Sportsman.Compare);
        }
    }

    private void MergeGroupsSkierWomen()
    {
        PriorityQueue<SkierWoman, long> priorityQueue =
            new PriorityQueue<SkierWoman, long>(new PriorityQueueComparer());
        int[] iterators = new int[_listGroupsSkierWomen.Count];
        foreach (var group in _listGroupsSkierWomen)
        {
            priorityQueue.Enqueue(group[0], group[0].ResultMilliseconds);
        }

        while (priorityQueue.Count > 0)
        {
            SkierWoman skierWoman = priorityQueue.Dequeue();
            _listAllSkierWomen.Add(skierWoman);
            int numberGroup = skierWoman.NumberGroup - 1;
            int itNow = ++iterators[numberGroup];
            if (itNow < _listGroupsSkierWomen[numberGroup].Count)
            {
                priorityQueue.Enqueue(
                    _listGroupsSkierWomen[numberGroup][itNow],
                    _listGroupsSkierWomen[numberGroup][itNow].ResultMilliseconds
                );
            }
        }
    }

    private void MergeGroupsSkierMen()
    {
        PriorityQueue<SkierMan, long> priorityQueue =
            new PriorityQueue<SkierMan, long>(new PriorityQueueComparer());
        int[] iterators = new int[_listGroupsSkierMen.Count];
        foreach (var group in _listGroupsSkierMen)
        {
            priorityQueue.Enqueue(group[0], group[0].ResultMilliseconds);
        }

        while (priorityQueue.Count > 0)
        {
            SkierMan skierMan = priorityQueue.Dequeue();
            _listAllSkierMen.Add(skierMan);
            int numberGroup = skierMan.NumberGroup - 1;
            int itNow = ++iterators[numberGroup];
            if (itNow < _listGroupsSkierMen[numberGroup].Count)
            {
                priorityQueue.Enqueue(
                    _listGroupsSkierMen[numberGroup][itNow],
                    _listGroupsSkierMen[numberGroup][itNow].ResultMilliseconds
                );
            }
        }
    }

    // merge list allSkierMen and allSkierWomen
    private void MergeSportsmen()
    {
        int iteratorAllSkierMen = 0;
        int iteratorAllSkierWomen = 0;
        while (iteratorAllSkierMen < _listAllSkierMen.Count || iteratorAllSkierWomen < _listAllSkierWomen.Count)
        {
            if (iteratorAllSkierMen < _listAllSkierMen.Count && iteratorAllSkierWomen < _listAllSkierWomen.Count)
            {
                if (_listAllSkierMen[iteratorAllSkierMen].ResultMilliseconds <=
                    _listAllSkierWomen[iteratorAllSkierWomen].ResultMilliseconds)
                {
                    _allSportsmen.Add(_listAllSkierMen[iteratorAllSkierMen++]);
                }
                else
                {
                    _allSportsmen.Add(_listAllSkierWomen[iteratorAllSkierWomen++]);
                }
            }
            else if (iteratorAllSkierMen >= _listAllSkierMen.Count)
            {
                _allSportsmen.Add(_listAllSkierWomen[iteratorAllSkierWomen++]);
            }
            else if (iteratorAllSkierWomen >= _listAllSkierWomen.Count)
            {
                _allSportsmen.Add(_listAllSkierMen[iteratorAllSkierMen++]);
            }
        }
    }

    public void WriteGroups()
    {
        Console.WriteLine("Женские группы:");
        int numberGroup = 1;
        foreach (var groupWomen in _listGroupsSkierWomen)
        {
            Console.WriteLine($"Группа номер {numberGroup++}:");
            Console.WriteLine($"{"Место",-7}{"Фамилия",-10}{"Результат",-10}");
            int place = 1;
            foreach (var woman in groupWomen)
            {
                Console.WriteLine($"{place++,-7}{woman.GetString()}");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Мужские группы:");
        numberGroup = 1;
        foreach (var groupMen in _listGroupsSkierMen)
        {
            Console.WriteLine($"Группа номер {numberGroup++}:");
            Console.WriteLine($"{"Место",-7}{"Фамилия",-10}{"Результат",-10}");
            int place = 1;
            foreach (var man in groupMen)
            {
                Console.WriteLine($"{place++,-7}{man.GetString()}");
            }

            Console.WriteLine();
        }
    }

    public void WriteAllSkierWomenRating()
    {
        Console.WriteLine("Женский общий рейтинг:");
        Console.WriteLine($"{"Место",-7}{"Фамилия",-10}{"Результат",-10}");
        int place = 1;
        foreach (var skierWoman in _listAllSkierWomen)
        {
            Console.WriteLine($"{place++,-7}{skierWoman.GetString()}");
        }
    }

    public void WriteAllSkierMenRating()
    {
        Console.WriteLine("Мужской общий рейтинг:");
        Console.WriteLine($"{"Место",-7}{"Фамилия",-10}{"Результат",-10}");
        int place = 1;
        foreach (var skierMan in _listAllSkierMen)
        {
            Console.WriteLine($"{place++,-7}{skierMan.GetString()}");
        }
    }

    public void WriteAllSportsmenRating()
    {
        Console.WriteLine("Общий рейтинг:");
        Console.WriteLine($"{"Место",-7}{"Фамилия",-10}{"Результат",-10}");
        int place = 1;
        foreach (var sportsman in _allSportsmen)
        {
            Console.WriteLine($"{place++,-7}{sportsman.GetString()}");
        }
    }

    private class PriorityQueueComparer : IComparer<long>
    {
        public int Compare(long x, long y)
        {
            return x.CompareTo(y);
        }
    }
}
