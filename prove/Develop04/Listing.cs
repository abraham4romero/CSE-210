using System;

class Listing : Activity
{
    public Listing() : base("Listing", "This activity will help you reflect on the good things\nin your life by having you list as many\nthings as you can in a certain area.") {
        
    }

    public void Run() {
        DisplayStartMessage();

        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        List<string> inputs = new List<string>();

        Random r = new Random();
        int p_index = r.Next(prompts.Count());
        string p = prompts[p_index];

        _startTime = DateTime.Now;
        DateTime _currentTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(_activityDuration);

        Console.WriteLine("List as many responses as you can until the time is up.");
        Delay(1, 1);
        Console.WriteLine("The prompt is: ");
        Delay(1, 1);
        Console.WriteLine(p);
        Delay(2, 3);

        while(_currentTime < _endTime) {
            string i = Console.ReadLine();
            inputs.Add(i);
            _currentTime = DateTime.Now;
        }

        Console.WriteLine("Time's up!");
        int sum = inputs.Count();
        Console.WriteLine($"You wrote a total of {sum} responses!");
        Delay(2, 7);

        int _actualTime = (int)_currentTime.Subtract(_startTime).TotalSeconds;

        DisplayEndMessage(_actualTime);
    }
}