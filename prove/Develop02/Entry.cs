using System;

class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public void Display() {
        Console.WriteLine($"{_date} - {_prompt} {_response}");
    }
}