namespace semester2.main.lab3.task12;

public class FrequencyWordApplication
{
    public static void Run()
    {
        Dictionary<string, string> encoding = new Dictionary<string, string>();
        Console.WriteLine("Введите таблицу кодов в формате слово:код");
        Console.WriteLine("Введите END по окончании ввода таблицы");
        while (true)
        {
            string s = Console.ReadLine() ?? throw new ArgumentNullException();
            if (s.ToLower().Equals("end"))
            {
                break;
            }

            string[] ss = s.Split(':');
            encoding[ss[0]] = ss[1];
        }

        Console.WriteLine("Введите текст:");
        FrequencyWords frequencyWords =
            new FrequencyWords(
                Console.ReadLine() ?? throw new ArgumentNullException(),
                encoding
            );
        Console.WriteLine("Закодированный текст:");
        Console.WriteLine(frequencyWords.GetEncodedText());
        Console.WriteLine("Раскодированный текст");
        Console.WriteLine(frequencyWords.ToString());
    }
}
