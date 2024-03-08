using System;
using System.IO;

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
                //string a = entry.ToString();
                File.WriteLine(entry);
                //Console.WriteLine(a);
            }
        }
    }

    public void Load(string file) {
        string[] lines = System.IO.File.ReadAllLines(file);
        int x = 0;
        foreach (string line in lines) {
            if (((x+1)%5) == 0) {
                Entry entry = new Entry();
                entry._date = lines[x-4];
                entry._weather = lines[x-3];
                entry._prompt = lines[x-2];
                entry._response = lines[x-1];
                Entries.Add(entry);
            }
            x++;
        }
    }
}