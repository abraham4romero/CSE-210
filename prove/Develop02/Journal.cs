using System;

class Journal
{
    List<Entry> Entries = new List<Entry>();

    public void Display() {
        foreach(Entry entry in Entries) {
            entry.Display();
        }
    }
}