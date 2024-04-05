//Created by Abraham Romero in CSE 210 at BYUI

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal _journal = new Journal();
        ToDo _toDo = new ToDo();
        QuickNotes _quickNotes = new QuickNotes();
        Courses _courses = new Courses();
        bool again = true;
        while(again) {
            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("");
            Console.WriteLine("What would you like to access?");
            Console.WriteLine("1. School Notes\n2. Journal\n3. To-Do List\n4. Quick Notes\n5. Quit");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    _courses.Menu();
                    break;
                case "2":
                    _journal.Menu();
                    break;
                case "3":
                    _toDo.Menu();
                    break;
                case "4":
                    _quickNotes.Menu();
                    break;
                case "5":
                    again = false;
                    break;
                default:
                    Console.WriteLine("Sorry, your choice was invalid.\nPlease try again.");
                    Thread.Sleep(1500);
                    break;
            }
        }
        Console.Clear();
        Console.WriteLine("Thanks for your time!\nCome back soon!");
        Thread.Sleep(1500);
    }
}