using System;
using System.ComponentModel;
using System.IO;

class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Display() {
        Console.WriteLine($"{_date}\n{_prompt}\n{_response}\n");
    }


    public string ToString() {
        string a = $"{_date}\n{_prompt}\n{_response}\n";
        return a;
    }
}