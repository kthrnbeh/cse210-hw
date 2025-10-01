using System.Collections.Concurrent;

public class Reference
{
    private string _book; // was instructed that I shouldn't have ()
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

}
//So if I follow the Encap. https://byui-cse.github.io/cse210-course-2023/unit03/prepare.html

//specifically constructors
public Reference (string book, string chapter, int startVerse,int endVerse)// I forgot the arg
{
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = endVerse;
}