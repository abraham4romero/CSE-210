using System;

class Activity
{
    private string _activityName;
    private string _description;
    protected int _activityDuration;
    protected DateTime _startTime = DateTime.Now;

    public Activity(string name, string description) {
        _activityName = name;
        _description = description;
        _activityDuration = 30;
    }

    public void DisplayStartMessage() {
        Console.WriteLine($"Welcome to the {_activityName} Activity!\n");
        Console.WriteLine(_description + "\n");
        Console.WriteLine("About how long would you like your session to last (in seconds)?");
        _activityDuration = int.Parse(Console.ReadLine());

        Console.WriteLine("Perfect! Get ready...");
        Delay(1, 3);
        Console.Clear();
    }

    public void Delay(int option, int delayTime = 0) {
        switch (option) {
            case 1:
                //spinner
                DateTime end = DateTime.Now.AddSeconds(delayTime);
                List<string> spin = new List<string>();
                spin.Add("\\");
                spin.Add("|");
                spin.Add("/");
                spin.Add("—");
                while (DateTime.Now < end) {
                    foreach (string s in spin) {
                        Console.Write(s);
                        Thread.Sleep(100);
                        Console.Write("\b \b");
                    }
                }
                Console.WriteLine("");
                break;
            case 2:
                //disappearing dots
                string dots = "";
                for (int x = 0; x < delayTime; x++) {
                    dots = dots + ".";
                }
                Console.Write(dots);
                for (int x = 0; x < delayTime; x++) {
                    Console.Write("\b \b");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("");
                break;
            case 3:
                //"your wait is now over"
                break;
            case 4:
                //countdown                
                DateTime finish = DateTime.Now.AddSeconds(delayTime);
                for (int x = delayTime; x > 0; x--) {
                    if (x < 10) {
                        Console.Write(x);
                        Thread.Sleep(1000);
                        Console.Write("\b\b  \b\b");
                    } else {
                        Console.Write(x);
                        Thread.Sleep(1000);
                        Console.Write("\b\b\b   \b\b\b");
                    }
                }
                Console.WriteLine("");
                break;
        }
    }

    public void DisplayEndMessage(int actualTime) {
        Console.Clear();
        Console.WriteLine($"Congratulations!\nYou\'ve completed {actualTime} seconds of the {_activityName} Activity!");
        Delay(1, 2);
        Console.WriteLine("Thanks for participating!");
        Delay(1, 1);
        Console.WriteLine("Redirecting to main menu in ");
        Delay(4, 5);
        Console.Clear();
    }
}