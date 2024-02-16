namespace semester2.main.lab2.level1.task2.Crosses;

public class Cross500 : Cross
{
    public override void ReadCrossInfo()
    {
        Console.WriteLine("Забег на 500м:");
        ReadInfo();
    }

    public override void WriteCrossInfo()
    {
        Console.WriteLine("Результаты забега на 500м:");
        WriteParticipantsTable();
    }
}
