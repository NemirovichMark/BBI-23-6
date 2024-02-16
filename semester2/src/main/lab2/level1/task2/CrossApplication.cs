using semester2.main.lab2.level1.task2.Crosses;

namespace semester2.main.lab2.level1.task2;

public static class CrossApplication
{
    public static void Run()
    {
        Cross100 cross100 = new Cross100();
        Cross500 cross500 = new Cross500();
        cross100.ReadCrossInfo();
        cross100.SortListParticipants();
        cross500.ReadCrossInfo();
        cross500.SortListParticipants();
        cross100.WriteCrossInfo();
        cross500.WriteCrossInfo();
    }
}
