using System;
using System.Collections.Generic;
using System.IO; //reads files into an ary of strings and prints them. writting to not forget what this does.
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
        Console.WriteLine("Hello Develop03 World!");
        //showed the book, chapter, verse, words
        // string book = "1 Nephi";
        //int chapter = 1;
        //int verse = 1;
        //string text = "I, Nephi, having been born of goodly parents,";

        //Console.WriteLine($"{book} {chapter}:{verse}");
        // Console.WriteLine(text);
        /*
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

        // while loop to pick random until pushed continue
        while (true)
        {
            Console.Write("Press ENTER to hide a word (or type 'quit'): ");
            var input = Console.ReadLine();
            if (string.Equals(input, "quit", StringComparison.OrdinalIgnoreCase)) break;

            int idx2 = PickVisibleIndex(words, rng);
            if (idx2 == -1)
            {
                Console.WriteLine("All words hidden!");
                break;
            }
            HideOneWord(words, idx2);
            ShowVerse(book, chapter, verse, words);*/
        //uh this made them all repear not slowly disapear
        string path = "scriptures.txt";
        if (!File.Exists(path))
        {
            Console.WriteLine("Could not find " + path);
            return;
        }

        // read the first valid scripture from file

        var rng = new Random();
    
        Scripture s;

        // pick ONE random verse from scriptures.txt
        try
        {
            s = LoadRandomFromFile("scriptures.txt", rng);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        // interactive hide loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(s.GetDisplay());

            if (s.IsFullyHidden())
            {
                Console.WriteLine("\nAll words hidden. Nice work!");
                return;
            }

            Console.Write("\nPress Enter to hide 3 words, or type 'quit': ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) &&
                input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            s.HideRandomWords(3, rng);
        }

    }
        static Scripture LoadRandomFromFile(string path, Random rng)
    {
        if (!File.Exists(path))
            throw new FileNotFoundException($"File not found: {path}");

        var valid = new List<Scripture>();

        foreach (var raw in File.ReadAllLines(path))
        {
            var line = raw.Trim();
            if (line.Length == 0) continue;

            // Expect: Book|Chapter|Start|End|Text
            var parts = line.Split('|');
            if (parts.Length != 5) continue;

            string book = parts[0].Trim();
            if (!int.TryParse(parts[1], out int chapter)) continue;
            if (!int.TryParse(parts[2], out int start)) continue;

            int end = start;
            int.TryParse(parts[3], out end); // if parse fails, end == start

            string text = parts[4];

            var reference = (start == end)
                ? new Reference(book, chapter, start)
                : new Reference(book, chapter, start, end);

            valid.Add(new Scripture(reference, text));
        }

        if (valid.Count == 0)
            throw new InvalidOperationException("No valid scriptures found in file.");

        return valid[rng.Next(valid.Count)];
    }

            

    

        // Works with hideoneword in main
    /*static void HideOneWord(string[] words, int index)
    {
        if (index < 0 || index >= words.Length) return;
        words[index] = new string('_', words[index].Length);
    }
    static void ShowVerse(string book, int chapter, int verse, string[] words)
    {
        Console.WriteLine($"{book} {chapter}:{verse}");
        Console.WriteLine(string.Join(" ", words));
    }*/
    //Method to help pick a random word disappear
    /* static int PickVisibleIndex(string[] words, Random rng)
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
       //  return candidates[rng.Next(candidates.Count)];
    // }*/
}



