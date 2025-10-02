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
        string book = "1 Nephi";
        int chapter = 1;
        int verse = 1;
        string text = "I, Nephi, having been born of goodly parents,";

        Console.WriteLine($"{book} {chapter}:{verse}");
        Console.WriteLine(text);
        var words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(string.Join(" ", words)); // should match text spacing
        HideOneWord(words, 0);
        Console.WriteLine(string.Join(" ", words));



    }
        static void HideOneWord(string[] words, int index)
        {
            if (index < 0 || index >= words.Length) return;
            words[index] = new string('_', words[index].Length);
        }

}
