namespace semester2.main.lab3.task15;

public class TextSumNumbersApplication
{
    public static void Run()
    {
        Console.WriteLine(
            new TextSumNumbers(
                Console.ReadLine() ?? throw new ArgumentNullException()
            ).ToString()
        );
    }
}
