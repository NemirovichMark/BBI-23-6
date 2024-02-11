namespace semester2.main.lab1.level1.task2;

public static class CrossApplication
{
    public static void Run()
    {
        var cross = new Cross();
        cross.ReadInfo();
        cross.SortListParticipants();
        cross.WriteParticipantsTable();
    }
}
