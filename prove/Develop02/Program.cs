using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> _promptList = new List<string>();
        Journal _journal = new Journal();
        _promptList.Add("If you could fly, where would you go first?");
        _promptList.Add("What is something you've done really well today?");
        _promptList.Add("If you could change one thing about today, what would it be?");
        _promptList.Add("If you could go back in time to watch one of your past experiences, what would you go back to see?");
        _promptList.Add("What was your favorite part of today?");
        _promptList.Add("Who is your best friend and why?");
        _promptList.Add("What is the most beautiful thing you've seen today?");
        _promptList.Add("Would you rather be a mouse or a dragon?");
        _promptList.Add("Do you prefer chocolate or peanut butter?");
        _promptList.Add("What was the name of your first pet?");
        _promptList.Add("If you had a pet rhino, what would you name it?");
        _promptList.Add("What would be the best way to spend the last day of your life?");
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
                Entry entry1 = Entry(_prompt);
                _journal.Entries.Add(entry1);
            } else if (_userChoice == 2) {
                _journal.Display();
            } else if (_userChoice == 3) {
                Load(_journal);
            } else if (_userChoice == 4) {
                Save(_journal);
            } else if (_userChoice == 5) {
                _quit = true;
            } else {
                Console.WriteLine("You entered an invalid response.\nTry again.");
            }
        }
        Console.WriteLine("Thanks for journaling today!");
    }

    static Entry Entry(string _prompt) {
        DateTime d = DateTime.Today;
        string date = d.ToString("MM-dd-yyyy");

        Entry entry1 = new Entry();
        entry1._prompt = _prompt;
        entry1._date = date;
        Console.WriteLine("What is today's weather?");
        entry1._weather = "Today\'s weather is: " + Console.ReadLine();
        Console.WriteLine(_prompt);
        entry1._response = Console.ReadLine();
        return entry1;
    }

    static void Load(Journal _journal) {
        Console.WriteLine("Which file would you like to load from?");
        string file = Console.ReadLine();

        _journal.Load(file);
        Console.WriteLine("Journal Loaded");
    }

    static void Save(Journal _journal) {
        Console.WriteLine("Which file would you like to save to?");
        string file = Console.ReadLine();
        //Console.WriteLine(file);
        using (StreamWriter File = new StreamWriter(file)) {
            foreach(Entry entry in _journal.Entries) {
                string a = entry.Stringify();
                File.WriteLine(a);
                //Console.WriteLine(a);
            }
        }
        //_journal.Save(file);

        Console.WriteLine("Journal Saved");
    }
}