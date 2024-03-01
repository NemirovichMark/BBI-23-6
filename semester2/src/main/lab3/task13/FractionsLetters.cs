using System.Text.RegularExpressions;

namespace semester2.main.lab3.task13;

public class FractionsLetters : Task
{
    private readonly Dictionary<char, int> _dictionaryLetters = new Dictionary<char, int>();
    private int _numberWords;

    public FractionsLetters(string text)
    {
        this.text = text;
        InitDictionary();
        CountLettersStartWords();
    }

    private void InitDictionary()
    {
        FillDictionary('a', 'z', 0);
    }

    private void FillDictionary(char left, char right, int value)
    {
        for (int i = left; i <= right; i++)
            _dictionaryLetters[(char)i] = value;
    }

    private void CountLettersStartWords()
    {
        string[] words = SplitText();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] != "" && words[i][0] >= 'a' && words[i][0] <= 'z')
            {
                _dictionaryLetters[words[i][0]]++;
                _numberWords++;
            }
        }
    }

    private string[] SplitText()
    {
        return text.Split();
    }

    /*
    public FractionsLetters(string text, params Lang[] lang)
    {
        this.text = text;
    }
    */

    private string GetPercentageShareString(int number, int allNumber, int precision)
    {
        return $"{Math.Round((double)number * 100 / allNumber, precision)}%";
    }

    public override string ToString()
    {
        string result = $"{"Буква",-10}Доля слов на эту букву";
        foreach (char lettersKey in _dictionaryLetters.Keys)
        {
            result += $"\n{lettersKey,-10}{GetPercentageShareString(_dictionaryLetters[lettersKey], _numberWords, 2)}";
        }

        return result;
    }
}
