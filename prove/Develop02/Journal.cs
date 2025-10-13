class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(Entry e)
    {
        // TODO: Entries.Add(e);
        // Make new entry
        Entries.Add(e);
    }

    public void DisplayAll()
    {
        // TODO: foreach (var e in Entries) e.Display();
        // If none, say "No entries yet."
        if (Entries.Count == 0)
        {
            Console.Write("No items to display"); // In case nothing is there
            return;
        }

        // Display all the entries
        foreach (var entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        // TODO: write each entry line as: date|prompt|response
        // using (var w = new StreamWriter(fileName)) { ... }
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in Entries)
            {
                // Add text to the file with the WriteLine method
                outputFile.WriteLine($"{entry._dateText}|{entry._prompt}|{entry._response}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        // TODO: clear list; read lines; split by '|'; create Entry; add
        // Guard for missing file: if (!File.Exists(fileName)) { message; return; }
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        Entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 3)
            {
                string _dateText = parts[0];
                string _prompt = parts[1];
                string _response = parts[2];

                Entry entry = new Entry(_dateText, _prompt, _response);
                Entries.Add(entry);
            }
        }
    }
}

