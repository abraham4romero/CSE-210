using System;

class Program
{
    static void Main(string[] args)
    {
        bool again = true;

        while (again) {
            Console.WriteLine("Which would you like?\n1. Default fraction\n2. Enter the nominator\n3. Enter the nominator and the denominator");
            int choice = int.Parse(Console.ReadLine());
            switch (choice) {
                case 1:
                    Fraction f1 = new Fraction();
                    Console.WriteLine("The default fraction is: ");
                    Console.Write(f1.GetFractionString() + " or " + f1.GetDecimalValue() + "\n");
                    break;
                case 2:
                    Console.WriteLine("Please enter a whole number: ");
                    int num = int.Parse(Console.ReadLine());
                    Fraction f2 = new Fraction(num);
                    Console.WriteLine("The fraction is: ");
                    Console.Write(f2.GetFractionString() + " or " + f2.GetDecimalValue() + "\n");
                    break;
                case 3:
                    Console.WriteLine("Please enter the nominator: ");
                    int num_top = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator: ");
                    int num_bottom = int.Parse(Console.ReadLine());
                    Fraction f3 = new Fraction(num_top, num_bottom);
                    Console.WriteLine("The fraction is: ");
                    Console.Write(f3.GetFractionString() + " or " + f3.GetDecimalValue() + "\n");
                    break;
            }
            Console.WriteLine("Would you like to view another fraction? (Yes or No)");
            string another = Console.ReadLine().ToLower();
            if (another != "yes") {
                again = false;
            } else {}
        }
    }
}