using System;

public class Course
{
    private string _name;
    public List<Subject> _subjects = new List<Subject>();

    public Course(string n) {
        _name = n;
    }

    public void List() {
        bool again = true;
        while(again) {
            Console.Clear();
            Console.WriteLine(_name);
            Console.WriteLine("");
            Console.WriteLine("Which subject would you like to access?");
            Console.WriteLine("1. New Subject\n2. Delete Subject");
            int x = 3;
            if (_subjects.Count() != 0) {
                foreach(Subject s in _subjects) {
                    Console.WriteLine($"{x}. " + s.Name());
                    x++;
                }
            }
            Console.WriteLine($"{x}. Go Back");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    NewSubject();
                    break;
                case "2":
                    RemoveSubject();
                    break;
                default:
                    if (!int.TryParse(choice, out int a)) {
                        choice = $"{a}";
                    }
                    if (int.Parse(choice) == x) {
                        again = false;
                    } else if ((int.Parse(choice) > 2) && (int.Parse(choice) <= _subjects.Count()+2)) {
                        _subjects[int.Parse(choice)-3].List();
                    } else {
                        Console.WriteLine("Sorry, your choice was invalid.\nPlease try again.");
                        Thread.Sleep(1500);
                    }
                    break;
            }
        }
    }

    public string Name() {
        return _name;
    }

    public void NewSubject() {
        Console.Clear();
        Console.WriteLine("What is the name of this subject?");
        string name = Console.ReadLine();
        Subject newCourse = new Subject(name);
        _subjects.Add(newCourse);
        Console.Clear();
        Console.WriteLine("Subject added.");
        Thread.Sleep(1000);
    }

    public void RemoveSubject() {
        Console.Clear();
        if (_subjects.Count() > 0) {
            Console.WriteLine("Which subject would you like to delete?");
            Console.WriteLine("");
            int x = 1;
            foreach (Subject s in _subjects) {
                Console.WriteLine($"{x}. " + s.Name());
                x++;
            }
            int input = int.Parse(Console.ReadLine());
            _subjects.RemoveAt(input-1);
            Console.Clear();
            Console.WriteLine("Subject deleted.");
        } else {
            Console.WriteLine("There are no subjects to delete.");
        }   
        Thread.Sleep(1500);
    }
}