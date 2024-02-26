namespace semester2.main.lab3.task10;

public class Decoding : Task
{
    private readonly Dictionary<char, string> _decoding;
    private string _textDecoding = "";

    public Decoding(string textEncoded, Dictionary<char, string> decoding)
    {
        text = textEncoded;
        _decoding = decoding;
    }

    private void DecodeText()
    {
        foreach (char symbol in text)
        {
            try
            {
                _textDecoding += _decoding[symbol];
            }
            catch
            {
                _textDecoding += symbol;
            }
        }
    }

    public override string ToString()
    {
        DecodeText();
        return _textDecoding;
    }
}
