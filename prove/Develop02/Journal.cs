using System;

class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void Display() {
        foreach(Entry entry in Entries) {
            entry.Display();
        }
    }

    public void Save(string file) {
        using (StreamWriter File = new StreamWriter(file)) {
            foreach(Entry entry in Entries) {
                File.WriteLine(entry);
            }
        }
    }

    public void Load(string file) {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
            {
                Entries.Add(line);
            }
    }
}