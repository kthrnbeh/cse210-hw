using System;
using System.Collections.Generic;
using System.IO; //reads files into an ary of strings and prints them. writting to not forget what this does.
using System.IO;
using System.Runtime.CompilerServices; //reads files into an ary of strings and prints them. writting to not forget what this does.

//team scripture code
//looking at the team code we used to get template
/*  start minimum viable product 
Then have it hide a word and test that 
Then add the loop to hide multiple words 
Write one step at a time and test as you go. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        //showed the book, chapter, verse, words
        string book = "1 Nephi";
        int chapter = 1;
        int verse = 1;
        string text = "I, Nephi, having been born of goodly parents,";

        Console.WriteLine($"{book} {chapter}:{verse}");
        Console.WriteLine(text);
        //showed text in same spacing
        var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(string.Join(" ", words)); // should match text spacing
        //made words hide
        HideOneWord(words, 0);
        Console.WriteLine(string.Join(" ", words));
        // hides words as well
        ShowVerse(book, chapter, verse, words);
        HideOneWord(words, 0);
        ShowVerse(book, chapter, verse, words);
        //works with random word deleter method
        var rng = new Random();
        int idx = PickVisibleIndex(words, rng);
        if (idx != -1) HideOneWord(words, idx);
        ShowVerse(book, chapter, verse, words);



    }
    // Works with hideoneword in main
    static void HideOneWord(string[] words, int index)
    {
        if (index < 0 || index >= words.Length) return;
        words[index] = new string('_', words[index].Length);
    }
    static void ShowVerse(string book, int chapter, int verse, string[] words)
    {
        Console.WriteLine($"{book} {chapter}:{verse}");
        Console.WriteLine(string.Join(" ", words));
    }
    //Method to help pick a random word disappear
    static int PickVisibleIndex(string[] words, Random rng)
    {
        // simple scan for any word not already underscores
        var candidates = new List<int>();
        for (int i = 0; i < words.Length; i++)
        {
            bool allUnderscores = true;
            foreach (char c in words[i]) if (c != '_') { allUnderscores = false; break; }
            if (!allUnderscores) candidates.Add(i);
        }
        if (candidates.Count == 0) return -1;
        return candidates[rng.Next(candidates.Count)];
    }


}
