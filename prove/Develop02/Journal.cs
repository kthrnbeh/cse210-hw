class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(Entry e)
    {
        // TODO: Entries.Add(e);
        //make new entry
        Entries.Add(e);
    }

    public void DisplayAll()
    {
        // TODO: foreach (var e in Entries) e.Display();
        // If none, say "No entries yet."
        //display all of the enteries
        //loops and lists 
        if (Entries.Count == 0)
        {
            Console.Write("No items to display"); // in case nothing is there
            return;
        }
        foreach (var e in Entries) e.Display();
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        // TODO: write each entry line as: date|prompt|response
        // using (var w = new StreamWriter(fileName)) { ... }
        //loop through each file in entries and save it to a file
        //https://byui-cse.github.io/cse210-course-2023/unit02/develop.html
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(var entry in Entries) 
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{entry._dateText}|{entry._prompt}|{entry._response}");

            }

        }
    }

    public void LoadFromFile(string fileName)
    {
        // TODO: clear list; read lines; split by '|'; create Entry; add
        // guard for missing file: if (!File.Exists(fileName)) { message; return; }
        //loop through each line in the file and create new entry objects to put in a list
    }
}

