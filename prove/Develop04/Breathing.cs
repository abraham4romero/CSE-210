using System;

class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by\nwalking your through breathing in and out slowly.\nClear your mind and focus on your breathing.") {
        
    }

    public void Run() {
        DisplayStartMessage();
        _startTime = DateTime.Now;
        DateTime _currentTime = DateTime.Now;
        DateTime _endTime = _startTime.AddSeconds(_activityDuration);
        while (_currentTime < _endTime) {
            Console.WriteLine("Breathe in");
            Delay(2, 4);
            Console.WriteLine("Hold");
            Delay(2, 2);
            Console.WriteLine("Breathe out");
            Delay(2, 4);
            Console.WriteLine("Hold");
            Delay(2, 2);
            Console.Clear();
            _currentTime = DateTime.Now;
        }
        int _actualTime = (int)_currentTime.Subtract(_startTime).TotalSeconds;
        DisplayEndMessage(_actualTime);
    }
}