namespace semester2.main.lab3.task8;

public static class TextSeparatorApplication
{
    public static void Run()
    {
        Console.WriteLine(
            new TextSeparator(
                Console.ReadLine() ?? throw new ArgumentNullException(),
                50
            ).ToString()
        );
    }
}
