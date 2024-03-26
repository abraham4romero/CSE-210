using System;
using System.Reflection;

/*
To exceed requirements, I added a log
that tracks how many activities are completed.
I also used many different pauses or delays.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Activity a = new Activity("", "");
        int _activityCount = 0;
        bool again = true;
        while (again) {
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing\n2. Reflection\n3. Listing\n4. Quit");
            string choice = Console.ReadLine();
            Console.Clear();
            switch(choice) {
                case "1": 
                    Breathing _activityB = new Breathing();
                    _activityB.Run();
                    _activityCount += 1;
                    break;
                case "2":
                    Reflection _activityR = new Reflection();
                    _activityR.Run();
                    _activityCount += 1;
                    break;
                case "3":
                    Listing _activityL = new Listing();
                    _activityL.Run();
                    _activityCount += 1;
                    break;
                case "4":
                    again = false;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine($"You completed {_activityCount} activities today!");
        a.Delay(2, 4);
        Console.WriteLine("Goodbye!");
        a.Delay(1, 2);
    }
}