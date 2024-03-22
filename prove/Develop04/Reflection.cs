using System;

class Reflection : Activity
{
    public Reflection() : base("Reflection", "This activity will help you reflect on times\nin your life when you have shown strength and resilience.\nThis will help you recognize the power you have\nand how you can use it in other aspects of your life.") {
        
    }

    public void Run() {
        DisplayStartMessage();

        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        List<string> resp = new List<string>();

        Random r = new Random();
        int p_index = r.Next(prompts.Count());
        string p = prompts[p_index];

        _startTime = DateTime.Now;
        DateTime _currentTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(_activityDuration);

        Console.WriteLine(p);
        Delay(1, 10);

        while (_currentTime < _endTime) {  
            int q_index = r.Next(questions.Count());
            string q = questions[q_index];
            Console.WriteLine(q);
            resp.Add(q);
            questions.RemoveAt(q_index);
            Delay(4, 15);
            _currentTime = DateTime.Now;
        }

        int sum = resp.Count();
        Console.WriteLine($"You answered a total of {sum} questions!");
        Delay(2, 7);

        int _actualTime = (int)_currentTime.Subtract(_startTime).TotalSeconds;

        DisplayEndMessage(_actualTime);
    }
}