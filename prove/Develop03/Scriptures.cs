using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words; // referencing my two other files 

    public Scripture(Reference reference, string fullText) //mixed up which program
    {
        _reference = reference;
        _words = new List<Word>();
        string[] pieces = fullText.Split(' ');// ah now it makes sense why it wasn't working.
        for (int i = 0; i < pieces.Length; i++)
        {
            if (pieces[i].Length > 0)
            {
                _words.Add(new Word(pieces[i]));
            }
        }// breaks the scripture into words every space
    }
    public string GetDisplay()// oh now I get it I want to take the words and lines and put themtogether into the list.
    {
        var parts = new List<string>();
        foreach (var word in _words)
            parts.Add(word.Present());

        return _reference.Bookinfo() + "\n" + string.Join(" ", parts);
    }
    public void HideRandomWords(int count, Random rng)// grabs the word sets it to true
    {
        if (_words.Count == 0)
        {
            return;
        }
        for (int i = 0; i < count; i++)
        {
            int index = rng.Next(0, _words.Count);
            _words[index].Hide();//loop runs how many times it counts
        }
    }

    public bool IsFullyHidden()//check to see if scripture is fully gone
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].isHidden())
            {
                return false;
            }
        }
        return true;
    }
}
   