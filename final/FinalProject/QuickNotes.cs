using System;

public class QuickNotes
{
    private List<Note> _notes = new List<Note>();

    public void Menu() {
        bool again = true;
        while(again) {
            Console.Clear();
            Console.WriteLine("Quick Notes Menu");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. New Note\n2. See Notes\n3. Delete Note\n4. Return to Main Menu");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    NewNote();
                    break;
                case "2":
                    DisplayNotes();
                    Console.WriteLine("Press \"enter\" to go back:");
                    Console.ReadLine();
                    break;
                case "3":
                    DeleteNote();
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

    public void NewNote() {
        Console.Clear();
        Console.WriteLine("Please enter your note below and hit \"enter\" when done:");
        string input = Console.ReadLine();
        QuickNote n = new QuickNote(input);
        _notes.Add(n);
        Console.Clear();
        Console.WriteLine("Note saved.");
        Thread.Sleep(1000);
    }

    public void DisplayNotes() {
        Console.Clear();
        if (_notes.Count > 0) {
            int x = 1;
            foreach (Note n in _notes) {
                Console.Write($"{x}. ");
                n.Print();
                x++;
            }
        } else {
            Console.WriteLine("You have no notes.");
            Console.WriteLine("");
        }
    }

    public void DeleteNote() {
        DisplayNotes();
        if (_notes.Count > 0) {
            Console.WriteLine("");
            Console.WriteLine("Which note would you like to delete?");
            int deletionChoice = int.Parse(Console.ReadLine());
            _notes.RemoveAt(deletionChoice-1);
            Console.Clear();
            Console.WriteLine("Note deleted.");
        }
        Thread.Sleep(1000);
    }
}