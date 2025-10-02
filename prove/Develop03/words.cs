
public class Word
{
    private string _text;
    private bool _hidden;
    public Word(string text) //oh yeah need to make this same as top
    {
        _text = text;
        _hidden = false; // don't want the words to be invisable at first. That is why we put that as false. 
    }
    public void Hide()
    {
        _hidden = true; // makes the word hide
    }
    public bool Show()
    {
        return false;//Checks to see if the word is hidden
    }
    public bool isHidden()
    {
        return _hidden;
    }
    public string Present()
    {//https://byui-cse.github.io/cse210-course-2023/unit01/csharp-2.html
        if (!_hidden)
        {
            return new string('_',_text.Length); //ok this is making sense now if its not hidden then show the word. 
        }
        else
        {
            return _text; // the length key is what makes the __ the same length as the missing text
        }
    }

} // oh I mixed them up. 
