using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    
    static void Main(string[] args)
    {
        Goals gols = new Goals();
        int _points = 0;
        bool again = true;

        while (again) {
            string choice = "";
            Console.Clear();
            Console.WriteLine($"You have {_points} points.");
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
                    _points += gols.MarkComplete();
                    break;
                case "4":
                    //gols.LoadGoals();
                    break;
                case "5":
                    //gols.SaveGoals();
                    break;
                case "6":
                    again = false;
                    break;
                default:
                    Console.WriteLine("Sorry, please try again.");
                    break;
            }            
        }
    }
}