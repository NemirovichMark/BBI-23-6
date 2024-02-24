namespace semester2.main.lab3.task9;

public static class EncodingApplication
{
    public static void Run()
    {
        Console.WriteLine(
            new Encoding(
                Console.ReadLine() ?? throw new ArgumentNullException()
            ).ToString()
        );
    }
}
