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
       string path = "scriptures.txt";
        if (!File.Exists(path))
        {
            Console.WriteLine("Could not find " + path);
            return;
        }

        // read the first valid scripture from file
        Scripture s = null;

        foreach (var raw in File.ReadAllLines(path))
        {
            var line = raw.Trim();
            if (line.Length == 0) continue;

            // Expect: Book|Chapter|Start|End|Text  (exactly 5 parts)
            var parts = line.Split('|');
            if (parts.Length != 5) continue;

            string book = parts[0].Trim();

            int chapter;
            if (!int.TryParse(parts[1], out chapter)) continue;

            int start;
            if (!int.TryParse(parts[2], out start)) continue;

            int end;
            // allow blank/invalid end → treat as single verse
            if (!int.TryParse(parts[3], out end)) end = start;

            string text = parts[4];

            var reference = (start == end)
                ? new Reference(book, chapter, start)
                : new Reference(book, chapter, start, end);

            s = new Scripture(reference, text);
            break; // use the first valid one
        }

        if (s == null)
        {
            Console.WriteLine("No valid scriptures found in file.");
            return;
        }

        var rng = new Random();
        while (true)
        {
            Console.Clear();
            Console.WriteLine(s.GetDisplay());

            if (s.IsFullyHidden())   // if your method is named AllHidden(), change this call
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


}
