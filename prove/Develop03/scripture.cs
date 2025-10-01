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
    public completelyHidden()
    {

    }


}

