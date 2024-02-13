namespace semester2.main.lab1.level3.task4;

public class Race
{
    private readonly List<List<Participant>> _listGroupsParticipants = new List<List<Participant>>();
    private readonly List<Participant> _allParticipants = new List<Participant>();

    public void ReadGroupsParticipants()
    {
        Console.WriteLine("Количество групп:");
        int numberGroups = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Формат ввода информации об участниках:\n" +
                          "Фамилия участника Результат(m:ss:SSS)\n" +
                          "Например, Иванова 2:14:135"
        );
        for (int i = 0; i < numberGroups; i++)
        {
            Console.WriteLine($"Группа номер {i + 1}:");
            int numberParticipant = 1;
            List<Participant> groupParticipants = new List<Participant>();
            while (true)
            {
                Console.WriteLine($"Участник номер {numberParticipant++}:");
                string info = Console.ReadLine() ?? throw new ArgumentNullException();
                if (info.ToLower().Equals("end"))
                {
                    _listGroupsParticipants.Add(groupParticipants);
                    break;
                }

                string[] parseInfo = info.Split();
                groupParticipants.Add(new Participant(parseInfo[0], parseInfo[1], i));
            }
        }
    }

    public void SortGroupsParticipants()
    {
        foreach (var groupParticipants in _listGroupsParticipants)
        {
            groupParticipants.Sort(Participant.Compare);
        }
    }

    public void MergeGroupsParticipants()
    {
        PriorityQueue<Participant, long> priorityQueue =
            new PriorityQueue<Participant, long>(new PriorityQueueComparer());
        int[] iterators = new int[_listGroupsParticipants.Count];
        foreach (var groupParticipants in _listGroupsParticipants)
        {
            priorityQueue.Enqueue(groupParticipants[0], groupParticipants[0].ResultMilliseconds);
        }

        while (priorityQueue.Count > 0)
        {
            Participant participant = priorityQueue.Dequeue();
            _allParticipants.Add(participant);
            int numberGroup = participant.NumberGroup;
            int itNow = ++iterators[numberGroup];
            if (itNow < _listGroupsParticipants[numberGroup].Count)
            {
                priorityQueue.Enqueue(
                    _listGroupsParticipants[numberGroup][itNow],
                    _listGroupsParticipants[numberGroup][itNow].ResultMilliseconds
                );
            }
        }
    }

    public void WriteGroups()
    {
        int numberGroup = 1;
        foreach (var groupParticipants in _listGroupsParticipants)
        {
            Console.WriteLine($"Группа номер {numberGroup++}:");
            Console.WriteLine($"{"Место", -7}{"Фамилия", -10}{"Результат", -10}");
            int place = 1;
            foreach (var participant in groupParticipants)
            {
                Console.WriteLine($"{place++, -7}{participant.GetString()}");
            }

            Console.WriteLine();
        }
    }

    public void WriteAllParticipantRating()
    {
        Console.WriteLine("Общий рейтинг:");
        Console.WriteLine($"{"Место", -7}{"Фамилия", -10}{"Результат", -10}");
        int place = 1;
        foreach (var participant in _allParticipants)
        {
            Console.WriteLine($"{place++, -7}{participant.GetString()}");
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
