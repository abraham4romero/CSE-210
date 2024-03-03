using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        bool list0 = false;
        int sum = 0;
        int avg = 0;
        int max = 0;
        List<int> numbers =  new List<int>();

        while(!list0) {
            Console.WriteLine("Enter number: ");
            int entry = int.Parse(Console.ReadLine());
            if (entry == 0){
                list0 = true;
            } else {
                numbers.Add(entry);
            }
        }

        foreach (int num in numbers) {
            if (num > max) {
                max = num;
            }
            sum += num;
        }

        avg = sum / numbers.Count;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Largest number: {max}");

    }
}