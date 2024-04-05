using System;

public class Subject
{
    private string _name;
    private List<StudyNote> _subjectNotes = new List<StudyNote>();

    public Subject(string n) {
        _name = n;
    }

    public string Name() {
        return _name;
    }

    public void List() {
        bool again = true;
        while(again) {
            Console.Clear();
            Console.WriteLine(_name);
            Console.WriteLine("");
            Console.WriteLine("Which note would you like to access?");
            Console.WriteLine("1. New Note");
            int x = 2;
            if (_subjectNotes.Count() != 0) {
                foreach(StudyNote s in _subjectNotes) {
                    Console.WriteLine($"{x}. " + s.Name());
                    x++;
                }
            }
            Console.WriteLine($"{x}. Go back");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    NewNote();
                    break;
                default:
                    if (!int.TryParse(choice, out int a)) {
                        choice = $"{a}";
                    }
                    if (int.Parse(choice) == x) {
                        again = false;
                    } else if ((int.Parse(choice) > 1) && (int.Parse(choice) <= _subjectNotes.Count()+1)) {
                        Menu(_subjectNotes[int.Parse(choice)-2]);
                    } else {
                        Console.WriteLine("Sorry, your choice was invalid.\nPlease try again.");
                        Thread.Sleep(1500);
                    }
                    break;
            }
        }
    }

    public void NewNote() {
        Console.Clear();
        Console.WriteLine("What is the name of this note?");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your note below and hit \"enter\" when done:");
        string input = Console.ReadLine();
        StudyNote n = new StudyNote(name, input);
        _subjectNotes.Add(n);
        Console.Clear();
        Console.WriteLine("Note saved.");
        Thread.Sleep(1000);
    }

    public void Menu(StudyNote s) {
        bool again = true;
        while(again) {
            Console.Clear();
            Console.WriteLine(s.Name());
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. See Note\n2. Edit Note\n3. Delete Note\n4. Go Back");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    Console.Clear();
                    s.Print();
                    Console.WriteLine("");
                    Console.WriteLine("Please press \"enter\" to go back:");
                    Console.ReadLine();
                    break;
                case "2":
                    s.Edit();
                    break;
                case "3":
                    _subjectNotes.Remove(s);
                    Console.Clear();
                    Console.WriteLine("Note deleted.");
                    Thread.Sleep(1000);
                    again = false;
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
}