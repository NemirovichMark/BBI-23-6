using Microsoft.VisualBasic;

namespace semester2.main.lab3.task12;

public class FrequencyWords : Task
{
    private readonly List<string> _listEncodedWords = new List<string>();
    private readonly List<string> _listDecodedWords = new List<string>();
    private readonly Dictionary<string, string> _encoding;
    private readonly Dictionary<string, string> _decoding = new Dictionary<string, string>();

    public FrequencyWords(string text, Dictionary<string, string> encoding)
    {
        this.text = text;
        _encoding = encoding;
        InitDecodingDictionary();
        MakeListEncodedWords();
    }

    private void InitDecodingDictionary()
    {
        foreach (var couple in _encoding)
        {
            _decoding[couple.Value] = couple.Key;
        }
    }

    private void MakeListEncodedWords()
    {
        foreach (var word in text.Split())
        {
            try
            {
                _listEncodedWords.Add(_encoding[word]);
            }
            catch
            {
                _listEncodedWords.Add(word);
            }
        }
    }

    private void DecodeWords()
    {
        foreach (var encodedWord in _listEncodedWords)
        {
            try
            {
                _listDecodedWords.Add(_decoding[encodedWord]);
            }
            catch
            {
                _listDecodedWords.Add(encodedWord);
            }
        }
    }

    public string GetEncodedText()
    {
        return Strings.Join(_listEncodedWords.ToArray(), " ");
    }

    public override string ToString()
    {
        DecodeWords();
        return Strings.Join(_listDecodedWords.ToArray(), " ");
    }
}
