using System;

class Program
{
    static void Main(string[] args)
    {
        Resume _resume = new Resume();
        _resume._name = "James Smith";

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Disney";
        job1._startYear = 2017;
        job1._endYear = 2020;

        _resume._jobs.Add(job1);

        Job job2 = new Job();
        job2._company = "Nintendo";
        job2._jobTitle = "Video Game Designer";
        job2._startYear = 2020;
        job2._endYear = 2023;

        _resume._jobs.Add(job2);

        _resume.Display();
    }
}