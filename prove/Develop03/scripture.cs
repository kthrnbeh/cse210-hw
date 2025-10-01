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
    public void HideRandomWords(int count, Random rng)// grabs the word sets it to true

    {
        for (int i = 0; i < count; i++)
        {
            int index = rng.Next(0, _words.Count);
            _words[index].Hide();//loop funs how many times it counts
        }
        public bool IsFullyHidden()//check to see if scripture is fully gone
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
    

  

    
}
   
    




