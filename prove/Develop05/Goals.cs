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
            Thread.Sleep(100);
        }
    }

    public int MarkComplete() {
        Console.Clear();
        Console.WriteLine("Which goal would you like to report on?");
        DisplayGoals();
        int selection = int.Parse(Console.ReadLine());
        int p = goals[selection-1].MarkComplete();
        if (goals[selection-1].GetStatus() == true) {

        }
        Console.WriteLine("");
        Console.WriteLine("Goal updated!");
        Thread.Sleep(500);
        return p;
    }

    public int LoadGoals() {
        int j = goals.Count();
        for (int i = 1; i <= j; i++) {
            goals.RemoveAt(0);
        }
        int points = 0;
        Console.WriteLine("Which file would you like to pull from?");
        string file = Console.ReadLine();
        string[] text = System.IO.File.ReadAllLines(file);
        points = int.Parse(text[0]);
        int x = 0;
        foreach(string gol in text) {
            if (x != 0) {
                string[] variables = gol.Split(" | ");
                if (variables[0] == "s") {
                    Simple s = new Simple(int.Parse(variables[1]), variables[2]);
                    s.SetVars(bool.Parse(variables[3]), bool.Parse(variables[4]));
                    goals.Add(s);
                } else if (variables[0] == "e") {       
                    Eternal e = new Eternal(int.Parse(variables[1]), int.Parse(variables[5]), variables[2]);
                    e.SetVars(bool.Parse(variables[3]), bool.Parse(variables[4]), int.Parse(variables[6]));
                    goals.Add(e);
                } else if (variables[0] == "c") {
                    Checklist c = new Checklist(int.Parse(variables[1]), int.Parse(variables[5]), variables[2], int.Parse(variables[7]));
                    c.SetVars(bool.Parse(variables[3]), bool.Parse(variables[4]), int.Parse(variables[6]));
                    goals.Add(c);
                }
            }
            x++;
        }
        Console.WriteLine("");
        Console.WriteLine("Goals loaded.");
        Thread.Sleep(1500);
        return points;
    }

    public void SaveGoals(int points) {
        Console.WriteLine("Which file would you like to save to?");
        string file = Console.ReadLine();
        using (StreamWriter File = new StreamWriter(file)) {
            File.WriteLine(points);
            foreach(Goal goal in goals) {
                string a = goal.Stringify();
                File.WriteLine(a);
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Goals saved.");
        Thread.Sleep(1500);
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