using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private int _count = 1;

    public void Menu() {
        bool again = true;
        while(again) {
            Console.Clear();
            Console.WriteLine("Journal Menu");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Make a new entry\n2. Display entries\n3. Edit an entry\n4. Return to Main Menu");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    NewEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    //EditEntry();
                    break;
                case "4":
                    again = false;
                    break;
                default:
                    Console.WriteLine("Sorry, your choice was invalid.\nPlease try again.");
                    Thread.Sleep(1500);
                    break;
            }
        }
        
    }

    public void NewEntry() {
        Console.Clear();
        DateTime today = DateTime.Now;
        Console.WriteLine("What is the weather like today?");
        string weather = Console.ReadLine();
        Console.WriteLine("Please add your entry:");
        string text = Console.ReadLine();
        Entry newEntry = new Entry(today, _count, weather, text);
        _entries.Add(newEntry);
        _count++;
    }

    public void DisplayEntries() {
        Console.Clear();
        foreach (Entry entry in _entries) {
            entry.Print();
            Console.WriteLine("");
            Thread.Sleep(100);
        }
        Console.WriteLine("");
        Console.WriteLine("Press \"enter\" to go back.");
        Console.ReadLine();
    }
}