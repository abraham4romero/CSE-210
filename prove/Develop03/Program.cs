using System;
using System.Resources;

class Program
{
    static void Main(string[] args)
    {
        Scripture s = new Scripture("", "", "", "");
        int reset = 1;
        while(reset == 1) {
            Console.WriteLine("Please select the scripture you would like to memorize:");
            Console.WriteLine("1. 2 Nephi 26:24\n2. Luke 9:24-25\n3. Doctrine & Covenants 88:118\n4. 1 Nephi 3:7\n5. Proverbs 3:5-6");
            int choice = int.Parse(Console.ReadLine());
            switch(choice) {
                case 1:
                    string passage1 = "He doeth not anything save it be for the benefit of the world; for he loveth the world, even that he layeth down his own life that he may draw all men unto him. Wherefore, he commandeth none that they shall not partake of his salvation.";
                    s = new Scripture("2 Nephi", "26", "24", passage1);
                    reset = 0;
                    break;
                case 2:
                    string passage2 = "For whosoever will save his life shall lose it: but whosoever will lose his life for my sake, the same shall save it. For what is a man advantaged, if he gain the whole world, and lose himself, or be cast away?";
                    s = new Scripture("Luke", "9", "24", "25", passage2);
                    reset = 0;
                    break;
                case 3:
                    string passage3 = "Organize yourselves; prepare every needful thing; and establish a house, even a house of prayer, a house of fasting, a house of faith, a house of learning, a house of glory, a house of order, a house of God;";
                    s = new Scripture("Doctrine & Covenants", "88", "119", passage3);
                    reset = 0;
                    break;
                case 4:
                    string passage4 = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
                    s = new Scripture("1 Nephi", "3", "7", passage4);
                    reset = 0;
                    break;
                case 5:
                    string passage5 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
                    s = new Scripture("Proverbs", "3", "5", "6", passage5);
                    reset = 0;
                    break;
                default:
                    Console.WriteLine("Please enter a valid option.");
                    Thread.Sleep(2000);
                    break;

            }
        }

        bool _quit = false;
        do {
            Console.Clear();
            Console.WriteLine(s.GetScripture());
            Console.WriteLine("Please hit enter to hide words or type 'quit' to exit the program:");
            s.HideWord();
            string end = Console.ReadLine().ToLower();
            if (end == "quit") {
                _quit = true;
            }
        } while ((!_quit) && (!s.GetState()));

    }
}