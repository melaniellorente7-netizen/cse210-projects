public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"DATE: {_date}\n QUESTION: {_promptText}\n ENTRY: {_entryText}");
    }
}