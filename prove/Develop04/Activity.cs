using System;

class Activity
{
    protected string _activityName;
    protected int _activityDuration;
    protected string _description;
    private string _endMessage;

    public void DisplayStartMessage() {
        Console.WriteLine($"Welcome to the {_activityName} Activity!\n");
        Console.WriteLine(_description + "\n");
        Console.WriteLine("How long, in seconds, would you like your session to last?");
        _activityDuration = int.Parse(Console.ReadLine())*1000;

        Console.WriteLine("Perfect! Get ready...");
    }



    public void DisplayDescription() {
        Console.WriteLine("This activity will help you " +
        "relax by walking your through breathing in and out slowly. " +
        "Clear your mind and focus on your breathing.");
        Breathing a = new Breathing(60);
    }
}