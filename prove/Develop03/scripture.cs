using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Words> _words; // referencing my two other files 

    public Scripture(Scripture script, string FullWord)
    {
        _reference = script;
        _words = new List<Words>();
        foreach (var piece in FullWord.Split(' '))
            _words.Add(new Words(piece)); // breaks the scripture into words every space
    }
    public string getDisplay()// oh now I get it I want to take the words and lines and put themtogether into the list.
    {
        var parts = new List<string>();
        foreach (var word in _words) parts.Add(word.Present());
        return _reference.Label() + "\n" + string.Join("", parts);
    }

    public HideDisplay(int gone, Random remain) //The one makes a certian number stay and the other makes them remain.
    {
        for (int g = 0; g < gone; g++) //loop funs how many times it counts
        {
            int index = remain.Next(0, _words.Count);
            _words[index].Hide(); // grabs the word sets it to true
        }


    }
    public bool HideScripture(); //check to see if scripture is fully gone
    {
        foreach (var in word in _words)
            if (! word in _words)
            {
                return false; 
            }
            else
            {
                return true;
            }
    }

    
}



