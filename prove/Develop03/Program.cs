using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices; //reads files into an ary of strings and prints them. writting to not forget what this does.

//team scripture code
//looking at the team code we used to get template

class Program // calling all the things
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        // list from the scripture.cs 
        List<Scripture> script = new List<Scripture>();
        List<Words> items = new List<Words>();
        string path = "scriptures.txt"; // specify your file name here
        if (File.Exists(path)) // prevents the file from crashing
        {
            foreach (var lineText in File.ReadAllLines(path))
            {
                var line = lineText.Trim();
                if (line.Length == 0) continue;

                var parts = line.Split('|');
                if (parts.Length != 5) continue;

                string book = parts[0];
                if (!int.TryParse(parts[1], out int chapter)) continue;
                if (!int.TryParse(parts[2], out int verseStart)) continue;
                if (!int.TryParse(parts[3], out int endVerse)) continue;
                string text = parts[4];

                var scriptureObj = new Scripture(book, chapter, verseStart, endVerse);
                items.Add(new Words(scriptureObj, text));
            }
        }

    }      // Define the Words class
            public class Words
    {
        public Scripture ScriptureObj { get; set; }
        public string Text { get; set; }

        public Words(Scripture scriptureObj, string text)
        {
            ScriptureObj = scriptureObj;
            Text = text;
        }
    }
            
            // Define the Scripture class
            public class Scripture
            {
                public string Book { get; set; }
                public int Chapter { get; set; }
                public int StartVerse { get; set; }
                public int EndVerse { get; set; }
            
                public Scripture(string book, int chapter, int startVerse, int endVerse)
                {
                    Book = book;
                    Chapter = chapter;
                    StartVerse = startVerse;
                    EndVerse = endVerse;
                }
            }
        }
        // Example usage of PickRandom to avoid unused function error
        
     
// Remove duplicate using statements and keep them at the top of the file



//https://byui-cse.github.io/cse210-course-2023/unit01/csharp-5.html