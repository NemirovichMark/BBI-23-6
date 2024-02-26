using semester2.main.lab3.task9;

namespace semester2.main.lab3.task10;

public static class DecodingApplication
{
    public static void Run()
    {
        Encoding encoding = new Encoding(
            Console.ReadLine() ?? throw new ArgumentNullException()
        );
        Console.WriteLine(encoding.ToString());
        Console.WriteLine(
            new Decoding(
                encoding.GetTextEncoded(),
                encoding.GetDecodingDictionary()
            ).ToString()
        );
    }
}
