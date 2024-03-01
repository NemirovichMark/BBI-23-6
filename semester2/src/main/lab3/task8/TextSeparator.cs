namespace semester2.main.lab3.task8;

public class TextSeparator : Task
{
    private string _result;

    public TextSeparator(string text, int numberSymbolsInLine)
    {
        this.text = text;
        _result = "";
        SeparateText(numberSymbolsInLine);
    }

    private void SeparateText(int numberSymbolsInLine)
    {
        string[] words = SplitText();
        for (int i = 0; i < words.Length; i++)
        {
            List<string> lineWords = new List<string>();
            int numberSymbols = 0;
            while (i < words.Length && numberSymbols + words[i].Length < numberSymbolsInLine)
            {
                lineWords.Add(words[i]);
                numberSymbols += words[i++].Length + 1;
            }

            --i;
            numberSymbols--;
            _result += AddSpaces(numberSymbols, numberSymbolsInLine, lineWords) + "\n";
        }
    }

    private string AddSpaces(int nowNumberSymbols, int numberSymbolsInLine, List<string> lineWords)
    {
        string line = "";
        int n = lineWords.Count;
        int numberSpaces = n > 1 ? (numberSymbolsInLine - nowNumberSymbols) / (n - 1) + 1 : 0;
        int numberWordsWithExtraSpace = n > 1 ? (numberSymbolsInLine - nowNumberSymbols) % (n - 1) : 0;
        for (int i = 0; i < n - 1; i++)
        {
            line += lineWords[i] + GetSpaces(numberSpaces + (numberWordsWithExtraSpace-- > 0 ? 1 : 0));
        }

        return line + lineWords[n - 1];
    }

    private string GetSpaces(int number)
    {
        return string.Join("", Enumerable.Repeat(" ", number));
    }

    private string[] SplitText()
    {
        return text.Split();
    }

    public override string ToString()
    {
        return _result;
    }
}
