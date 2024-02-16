namespace semester2.main.lab2.level1.task2.Crosses;

public class Cross100 : Cross
{
    public override void ReadCrossInfo()
    {
        Console.WriteLine("Забег на 100м:");
        ReadInfo();
    }

    public override void WriteCrossInfo()
    {
        Console.WriteLine("Результаты забега на 100м:");
        WriteParticipantsTable();
    }
}
