/*
To exceed the requirements, I added a goal count at the top that
shows how many goals the user has completed!
*/

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Goals gols = new Goals();
        int _points = 0;
        int _goalsCompleted = 0;
        bool again = true;

        while (again) {
            string choice = "";
            Console.Clear();
            Console.WriteLine($"You have {_points} points.");
            Console.WriteLine($"You have completed {_goalsCompleted} goals.");
            Console.WriteLine();
            Console.WriteLine("Please select an option");
            Console.WriteLine("1. New Goal\n2. Display Goals\n3. Update Goal\n4. Load\n5. Save\n6. Quit");
            choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    gols.NewGoal();
                    break;
                case "2":
                    Console.Clear();
                    gols.DisplayGoals();
                    Console.WriteLine("Press \"enter\" to return to menu.");
                    Console.ReadLine();
                    break;
                case "3":
                    string response = gols.MarkComplete();
                    string[] splitted = response.Split(" | ");
                    _points += int.Parse(splitted[0]);
                    _goalsCompleted += int.Parse(splitted[1]);
                    break;
                case "4":
                    string ss = gols.LoadGoals();
                    string[] parts = ss.Split(" | ");
                    _points = int.Parse(parts[0]);
                    _goalsCompleted = int.Parse(parts[1]);
                    break;
                case "5":
                    gols.SaveGoals(_points);
                    break;
                case "6":
                    again = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Sorry, please try again.");
                    Thread.Sleep(1000);
                    break;
            }            
        }
    }
}