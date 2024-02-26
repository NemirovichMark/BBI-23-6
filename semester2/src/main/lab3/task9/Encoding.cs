namespace semester2.main.lab3.task9;

public class Encoding : Task
{
    private readonly Dictionary<string, int> _frequentCouple = new Dictionary<string, int>();
    private readonly Dictionary<char, int> _frequentCharacters = new Dictionary<char, int>();
    private readonly Dictionary<string, char> _encoding = new Dictionary<string, char>();
    private readonly Dictionary<char, string> _decoding = new Dictionary<char, string>();
    private string _textEncoded = "";

    public Encoding(string text)
    {
        this.text = text;
        InitDictionaries();
    }

    private void InitDictionaries()
    {
        for (var i = 0; i < text.Length - 1; i++)
        {
            try
            {
                _frequentCouple[text.Substring(i, 2)]++;
            }
            catch
            {
                _frequentCouple[text.Substring(i, 2)] = 1;
            }

            _frequentCharacters[text[i]] = 1;
        }

        MakeEncodingDictionary();
    }

    private void MakeEncodingDictionary()
    {
        foreach (var couple in _frequentCouple)
        {
            if (couple.Value > 1)
            {
                char randomCharacters = GetRandomCharacters();
                _decoding[randomCharacters] = couple.Key;
                _encoding[couple.Key] = randomCharacters;
                _frequentCharacters[randomCharacters] = 1;
            }
        }

        EncodeText();
    }

    private void EncodeText()
    {
        for (int i = 0; i < text.Length; i++)
        {
            try
            {
                _textEncoded += _encoding[text.Substring(i, 2)];
                ++i;
            }
            catch
            {
                _textEncoded += text[i];
            }
        }
    }

    private char GetRandomCharacters()
    {
        char res;
        bool flag;
        do
        {
            res = (char)new Random().Next('i', '}' + 1);
            try
            {
                flag = _frequentCharacters[res] == 1;
            }
            catch
            {
                flag = false;
                _frequentCharacters[res] = 1;
            }
        } while (flag);

        return res;
    }

    public override string ToString()
    {
        return _textEncoded + '\n' + GetDecodingTable();
    }

    private string GetDecodingTable()
    {
        string res = $"{"code", -10}decode";
        foreach (var decoding in _decoding)
        {
            res += $"\n{decoding.Key,-10}{decoding.Value}";
        }

        return res;
    }

    public Dictionary<char, string> GetDecodingDictionary()
    {
        return _decoding;
    }

    public string GetTextEncoded()
    {
        return _textEncoded;
    }
}
