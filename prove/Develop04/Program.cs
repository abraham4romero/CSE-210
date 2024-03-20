using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = int.Parse(Console.ReadLine());
        switch(choice) {
            case 1: 
                Breathing _activityB = new Breathing(1000);
                break;
            case 2:
                Reflection _activityR = new Reflection();
                break;
            case 3:
                Listing _activityL = new Listing();
                break;
            default:
                break;
        }
    }
}