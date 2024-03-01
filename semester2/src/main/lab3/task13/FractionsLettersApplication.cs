namespace semester2.main.lab3.task13;

public static class FractionsLettersApplication
{
    public static void Run()
    {
        Console.WriteLine(
            new FractionsLetters(
                Console.ReadLine() ?? throw new ArgumentNullException()
            ).ToString()
        );
    }
}
