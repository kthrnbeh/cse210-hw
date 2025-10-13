class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(Entry e)
    {
        // TODO: Entries.Add(e);
    }

    public void DisplayAll()
    {
        // TODO: foreach (var e in Entries) e.Display();
        // If none, say "No entries yet."
    }

    public void SaveToFile(string fileName)
    {
        // TODO: write each entry line as: date|prompt|response
        // using (var w = new StreamWriter(fileName)) { ... }
    }

    public void LoadFromFile(string fileName)
    {
        // TODO: clear list; read lines; split by '|'; create Entry; add
        // guard for missing file: if (!File.Exists(fileName)) { message; return; }
    }
}

