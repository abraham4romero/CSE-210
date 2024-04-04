using System;

public class QuickNotes
{
    public List<Note> _notes = new List<Note>();

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

    }

    public void DisplayNotes() {
        Console.Clear();
        foreach (Note n in _notes) {
            n.Text();
        }
    }

    public void DeleteNote() {

    }
}