using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _promptList = new List<string>();
        _promptList.Add("");
        _promptList.Add("");
        _promptList.Add("");
        _promptList.Add("");
        _promptList.Add("");
        _promptList.Add("");
        _promptList.Add("");
        _promptList.Add("");
        _promptList.Add("");
        _promptList.Add("");
        _promptList.Add("");
        _promptList.Add("");
        var random = new Random();

        Console.WriteLine("Welcome to the Journal Program!");
        bool _quit = false;
        while(_quit == false) {
            int _userChoice = 0;
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            _userChoice = int.Parse(Console.ReadLine());

            if (_userChoice == 1) {
                int _promptIndex = random.Next(_promptList.Count);
                string _prompt = _promptList[_promptIndex];
                Entry(_prompt);
            } else if (_userChoice == 2) {
                Display();
            } else if (_userChoice == 3) {
                Load();
            } else if (_userChoice == 4) {
                Save();
            } else if (_userChoice == 5) {
                _quit = true;
            } else {
                Console.WriteLine("You entered an invalid response.\nTry again.");
            }
        }
        Console.WriteLine("Thanks for journaling today!");
    }

    static void Entry(string _prompt) {
        DateTime d = DateTime.Today;
        string date = d.ToString("yyyyMMdd");

        Entry entry1 = new Entry();
        entry1._prompt = _prompt;
        entry1._date = date;

        Console.WriteLine(_prompt);
        entry1._response = Console.ReadLine();
    }
    
    static void Display() {

    }

    static void Load() {

    }

    static void Save() {

    }
}