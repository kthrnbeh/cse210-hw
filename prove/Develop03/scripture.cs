using System;
using System.Collections.Generic;
public class Scripture
{
    private _reference();
    private List<Words>_words; // referencing my two other files 
    public Scripture
    
    public Scripture (Scripture script, string FullWord)
    {
         _reference = script;
        _words = new List<Words>();
         foreach (var piece in FullWord.Split(' '))
         _words.Add(new Words(piece)); // breaks the scripture into words every space
    }
    public string getDisplay()// oh now I get it I want to take the words and lines and put themtogether into the list.
    {
        var parts = new List<string>();
        foreach (var word in _words) parts.Add(word.View());
        return _refence.Label() + "\n" + string.Join("" , parts);
    }
    

   

  
    public HideDisplay()

    {
    foreach (var word in _words)
        if (!word.IsMasked())
        {
            return false:
        }
        else
        {
        return true;
        }
    }


}

