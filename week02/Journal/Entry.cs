using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void display() // Entry result display
    {
        Console.WriteLine($"Date; {_date}");
        Console.WriteLine($"Prompt; {_prompt}");
        Console.WriteLine($"Response; {_response}");
        Console.WriteLine(); // print an empty line in between entries output display
    }


}