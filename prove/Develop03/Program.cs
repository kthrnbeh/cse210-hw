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
        Scripture script = new List<Scripture>();
        if (!File.Exists(path)) // prevents the file from crashing
        {
            return script;
            foreach (var text in FileReadAllLines(path))
            {
                var line = text.Trim();
                if (line.Length == 0) continue;

                var parts = line.Split('|');
                if (parts.Length != 5) continue;

                string  = parts[0]
                 if (!int.TryParse(parts[1], out int sect)) continue;
                if (!int.TryParse(parts[2], out int start)) continue;
                if (!int.TryParse(parts[3], out int end)) continue;
                string text = parts[4];

                var script = new Scripture(book, chapter, verseStart, endVerse);
                items.Add(new Words(script, text));
            }
        }
        return items;
    }
        
        public static Words PickRandom(List<Words> items) Random rng)
            
        
    }


}
//https://byui-cse.github.io/cse210-course-2023/unit01/csharp-5.html