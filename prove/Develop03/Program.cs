using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        var scriptures = LoadScriptures("scriptures.txt");
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found. Check messages above and scriptures.txt format.");
            return;
        }

        var rng = new Random();
        var scripture = scriptures[rng.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplay());
            Console.WriteLine("\n(Press Enter to hide a few words, or type 'quit' to end)");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3, rng);

            if (scripture.IsFullyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplay());
                Console.WriteLine("\nAll words are hidden. Great job!");
                break;
            }
        }
    }

    // === Improved loader ===
    static List<Scripture> LoadScriptures(string filename)
    {
        var result = new List<Scripture>();

        // Try working dir first, then the app's output folder.
        string path1 = Path.GetFullPath(filename);
        string path2 = Path.Combine(AppContext.BaseDirectory, filename);
        string path = File.Exists(path1) ? path1 : (File.Exists(path2) ? path2 : path1);

        Console.WriteLine($"Reading file from: {path}");

        try
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File not found. Tip: in VS/VS Code, set 'Copy to Output Directory' on scriptures.txt.");
                return result;
            }

            int lineNum = 0;
            foreach (var raw in File.ReadAllLines(path))
            {
                lineNum++;
                var line = raw.Trim();
                if (line.Length == 0) { Console.WriteLine($"[skip line {lineNum}] empty"); continue; }

                var parts = line.Split('|');
                if (parts.Length < 5)
                {
                    Console.WriteLine($"[skip line {lineNum}] expected 5 fields, got {parts.Length}: {line}");
                    continue;
                }

                // Trim each field (and rejoin any extra pipes into text)
                string book = parts[0].Trim();
                string chStr = parts[1].Trim();
                string stStr = parts[2].Trim();
                string enStr = parts[3].Trim();
                string text = string.Join("|", parts, 4, parts.Length - 4).Trim();

                if (book.Length == 0) { Console.WriteLine($"[skip line {lineNum}] empty book"); continue; }
                if (!int.TryParse(chStr, out int chapter)) { Console.WriteLine($"[skip line {lineNum}] bad chapter: '{chStr}'"); continue; }
                if (!int.TryParse(stStr, out int start)) { Console.WriteLine($"[skip line {lineNum}] bad start verse: '{stStr}'"); continue; }
                if (!int.TryParse(enStr, out int end)) { Console.WriteLine($"[skip line {lineNum}] bad end verse: '{enStr}'"); continue; }
                if (text.Length == 0) { Console.WriteLine($"[skip line {lineNum}] empty text"); continue; }

                var reference = new Reference(book, chapter, start, end);
                var scripture = new Scripture(reference, text);
                result.Add(scripture);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        Console.WriteLine($"Loaded {result.Count} scripture(s).");
        return result;
    }
}
