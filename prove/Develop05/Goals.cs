using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Goals
{
    public List<Goal> goals = new List<Goal>();

    public void DisplayGoals() {
        for (int x = 0; x < goals.Count(); x++) {
            Console.WriteLine($"Goal {x+1}:");
            goals[x].DisplayGoal();
            Console.WriteLine("");
            Thread.Sleep(2000);
        }
    }

    public int MarkComplete() {
        Console.Clear();
        Console.WriteLine("Which goal would you like to report on?");
        DisplayGoals();
        int selection = int.Parse(Console.ReadLine());
        int p = goals[selection-1].MarkComplete();
        return p;
    }

    public void NewGoal() {
        int pVal;
        string name;
        int comPval;
        string choice;
        int count;
        bool valid = true;
        Console.Clear();
        while (valid) {
            Console.WriteLine("What type of goal would you like to create?");
            Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
            choice = Console.ReadLine();
            
            Console.WriteLine("");
            switch (choice) {
                case "1":
                    name = GetName(1);
                    pVal = GetPoints();
                    Simple s = new Simple(pVal, name);
                    goals.Add(s);
                    valid = false;
                    break;
                case "2":
                    name = GetName(2);
                    pVal = 0;
                    comPval = GetStepPoints();
                    Eternal e = new Eternal(pVal, comPval, name);
                    goals.Add(e);
                    valid = false;
                    break;
                case "3":
                    name = GetName(3);
                    pVal = GetPoints();
                    comPval = GetStepPoints();
                    count = GetCount();
                    Checklist c = new Checklist(pVal, comPval, name, count);
                    goals.Add(c);
                    valid = false;
                    break;
                default:
                    Console.WriteLine("Sorry, please try again.");
                    break;
            }
            Console.WriteLine("Goal added.");
            Thread.Sleep(1500);
        }

        string GetName(int c) {
            string gName;
            string goa;
            if (c==1) {
                goa = "simple";
            } else if (c == 2) {
                goa = "eternal";
            } else if (c == 3) {
                goa = "checklist";
            } else {
                goa = "\b";
            }
            Console.WriteLine($"What is your {goa} goal?");
            gName = Console.ReadLine();
            return gName;
        }

        int GetPoints() {
            int pval;
            Console.WriteLine("How many points is this goal worth upon completion?");
            pval = int.Parse(Console.ReadLine());
            return pval;
        }

        int GetStepPoints() {
            int steppval;
            Console.WriteLine("How many points is this goal worth for each step completed?");
            steppval = int.Parse(Console.ReadLine());
            return steppval;
        }

        int GetCount() {
            Console.WriteLine("How many steps does this goal have?");
            int counnt = int.Parse(Console.ReadLine());
            return counnt;
        }
    }
}