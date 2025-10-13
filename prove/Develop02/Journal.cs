class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(Entry e)
    {
        // TODO: Entries.Add(e);
        //make new entry
    }

    public void DisplayAll()
    {
        // TODO: foreach (var e in Entries) e.Display();
        // If none, say "No entries yet."
        //display all of the enteries
        //loops and lists 
    }

    public void SaveToFile(string fileName)
    {
        // TODO: write each entry line as: date|prompt|response
        // using (var w = new StreamWriter(fileName)) { ... }
        //loop through each file in entries and save it to a file
    }

    public void LoadFromFile(string fileName)
    {
        // TODO: clear list; read lines; split by '|'; create Entry; add
        // guard for missing file: if (!File.Exists(fileName)) { message; return; }
        //loop through each line in the file and create new entry objects to put in a list
    }
}

