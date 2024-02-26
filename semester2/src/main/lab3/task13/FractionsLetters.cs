using System.Text.RegularExpressions;

namespace semester2.main.lab3.task13;

public class FractionsLetters : Task
{
    private readonly Dictionary<char, int> _dictionaryLetters = new Dictionary<char, int>();
    private Regex _regex = new Regex("");
    private int _numberWords;

    public enum Lang
    {
        Ru,
        En
    }

    public FractionsLetters(string text, Lang lang)
    {
        this.text = text;
        InitDictionary(lang);
        CountLettersStartWords();
    }

    private void InitDictionary(Lang lang)
    {
        switch (lang)
        {
            case Lang.Ru:
                FillDictionary('а', 'я', 0);
                _regex = new Regex("[^а-я]+");
                break;
            case Lang.En:
                FillDictionary('a', 'z', 0);
                _regex = new Regex("[^a-z]+");
                break;
        }
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
            if (words[i] != "")
            {
                _dictionaryLetters[words[i][0]]++;
                _numberWords++;
            }
        }
    }

    private string[] SplitText()
    {
        return _regex.Split(text);
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
