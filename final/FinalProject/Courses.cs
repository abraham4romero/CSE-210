using System;

public class Courses
{
    public List<Course> _classes = new List<Course>();

    public void Menu() {
        bool again = true;
        while(again) {
            Console.Clear();
            Console.WriteLine("Courses");
            Console.WriteLine("");
            Console.WriteLine("Which course would you like to access?");
            Console.WriteLine("1. New Course\n2. Delete Course");
            int x = 3;
            if (_classes.Count() != 0) {
                foreach(Course c in _classes) {
                    Console.WriteLine($"{x}. " + c.Name());
                    x++;
                }
            }
            Console.WriteLine($"{x}. Return to Main Menu");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    NewCourse();
                    break;
                case "2":
                    RemoveCourse();
                    break;
                default:
                    if (!int.TryParse(choice, out int a)) {
                        choice = $"{a}";
                    }
                    if (int.Parse(choice) == x) {
                        again = false;
                    } else if ((int.Parse(choice) > 2) && (int.Parse(choice) <= _classes.Count()+2)) {
                        _classes[int.Parse(choice)-3].List();
                    } else {
                        Console.WriteLine("Sorry, your choice was invalid.\nPlease try again.");
                        Thread.Sleep(1500);
                    }
                    break;
            }
        }
        
    }

    public void NewCourse() {
        Console.Clear();
        Console.WriteLine("What is the name of this course?");
        string name = Console.ReadLine();
        Course newCourse = new Course(name);
        _classes.Add(newCourse);
        Console.Clear();
        Console.WriteLine("Course added.");
        Thread.Sleep(1000);
    }

    public void RemoveCourse() {
        Console.Clear();
        if (_classes.Count() != 0) {
            int x = 1;
            Console.WriteLine("which course would you like to delete?");
            Console.WriteLine("");
            foreach(Course c in _classes) {
                Console.WriteLine($"{x}. " + c.Name());
                x++;
            }
            int toDelete = int.Parse(Console.ReadLine());
            _classes.RemoveAt(toDelete-1);
            Console.Clear();
            Console.WriteLine("Course deleted.");
        } else {
            Console.WriteLine("There are no courses to delete.");
        }
        Thread.Sleep(1000);
    }
}