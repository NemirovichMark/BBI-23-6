namespace semester2.main.lab3.task15;

public class TextSumNumbers : Task
{
    private long _sumNumbers;

    public TextSumNumbers(string text)
    {
        this.text = text;
        SumNumbers();
    }

    private void SumNumbers()
    {
        for (int i = 0; i < text.Length; i++)
        {
            string stringNumber = "";
            while (i < text.Length && Char.IsDigit(text[i]))
            {
                stringNumber += text[i++];
            }

            _sumNumbers += stringNumber.Equals("") ? 0 : long.Parse(stringNumber);
        }
    }

    public long GetSumNumbers()
    {
        return _sumNumbers;
    }

    public override string ToString()
    {
        return $"Сумма чисел в тексте: {_sumNumbers}";
    }
}
