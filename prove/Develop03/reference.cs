

public class Reference
{

    private string _book; // was instructed that I shouldn't have ()
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    //They weren't in my method! Don't forget to put same names in same method
    public Reference(string book, int chapter, int verse) //this one gets one verse 
    {
        _book = book;
        _chapter = chapter; // its a number. Duh
        _startVerse = verse;//relaes more than one 
        _endVerse = verse;
    }
    //this one gets multiple verses 
    public Reference(string book, int chapter, int startVerse, int endVerse)// I forgot the arg
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
public string Bookinfo()
{
    if (_startVerse == _endVerse)
    {
        return $"{_book} {_chapter} : {_startVerse}"; //wow now this is making even more sense when I wrote it. Ok. I see. 
    }
    else
    {
        return $"{_book} {_chapter} : {_startVerse} - {_endVerse}";
    }
}
// took me seeing it to reconize the error... so silly. 
}
//So if I follow the Encap. https://byui-cse.github.io/cse210-course-2023/unit03/prepare.html

//specifically constructors 

// ok I just learned this method will help the range of pages be correctly displayed

//wanting to understand. I need to get it so I can do my own codes in the future. 
//https://chatgpt.com/share/68dd6fa0-24c4-8002-9898-1a5c4e3381c4
// if I used to much help let me know and i will use less and ask it different kinds of 
// questions. I do actually want to understand and it not just to tell me answers. 