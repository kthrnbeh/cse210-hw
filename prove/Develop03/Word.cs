public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    // Optional helper if you ever want to reveal a word again
    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string Present()
    {
        // If hidden → return underscores of same length; else the word
        if (_hidden)
            return new string('_', _text.Length);
        else
            return _text;
    }
}
