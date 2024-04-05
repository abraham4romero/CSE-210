using System;

public class ToDo
{
    public List<Item> _toDoList = new List<Item>();
    public List<Item> _completedTasks = new List<Item>();

    public void Menu() {
        bool again = true;
        while(again) {
            Console.Clear();
            Console.WriteLine("Task Menu");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a Task\n2. Mark Complete\n3. Show To-Do List\n4. Show Completed Tasks\n5. Return to Main Menu");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    NewTask();
                    break;
                case "2":
                    CompleteTask();
                    break;
                case "3":
                    Display(_toDoList);
                    break;
                case "4":
                    Display(_completedTasks);
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
    }

    public void NewTask() {
        Console.Clear();
        Console.WriteLine("Write your task below:");
        string input = Console.ReadLine();
        Console.WriteLine("Does this task have a deadline? (yes, no)");
        string i = Console.ReadLine().ToLower();
        if (i == "yes") {
            Console.WriteLine("When is this due? (MM/DD/YYYY 00:00)");
            string dueTime = Console.ReadLine();
            string[] inputs = dueTime.Split(" ");
            string[] dates = inputs[0].Split("/");
            string[] times = inputs[1].Split(":");
            DateTime dueDate = new DateTime(int.Parse(dates[2]), int.Parse(dates[0]), int.Parse(dates[1]), int.Parse(times[0]), int.Parse(times[1]), 0);
            Item task = new Item(false, true, input, dueDate);
            _toDoList.Add(task);
        } else {
            Item task = new Item(false, input);
            _toDoList.Add(task);
        }
        Console.Clear();
        Console.WriteLine("Task created.");
        Thread.Sleep(850);
    }

    public void Display(List<Item> list) {
        Console.Clear();
        if (list.Count() == 0) {
            Console.WriteLine("Your list is empty.");
        } else {
            foreach (Item i in list) {
                i.Print();
                Console.WriteLine("");
                Thread.Sleep(150);
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Press \'enter\' to continue.");
        Console.ReadLine();
    }

    public void CompleteTask() {
        Console.Clear();
        int x = 1;
        if (_toDoList.Count() == 0) {
            Console.WriteLine("There aren't any tasks on your To-Do List.");
        } else {
            foreach (Item i in _toDoList) {
                Console.Write($"{x}. ");
                i.Print();
                x++;
                Console.WriteLine("");
                Thread.Sleep(150);
            }
            Console.WriteLine("Which task have you completed?");
            int input = int.Parse(Console.ReadLine());
            _toDoList[input-1].Complete();
            _completedTasks.Add(_toDoList[input-1]);
            _toDoList.RemoveAt(input-1);
            Console.Clear();
            Console.WriteLine("Task updated.");
        }
        Thread.Sleep(1500);
    }
}