public class Entry
{ 
  public string _date;
  public string _promptText;
  public string _entryText;

  public Entry(string date, string prompt, string text)
    {
        _date = date;
        _promptText = prompt;
        _entryText = text;
    }

  public void Display()
  {
    Console.WriteLine(_date);
    Console.WriteLine(_promptText);
    Console.WriteLine(_entryText);
    Console.WriteLine(new string('-', 40));
  }
  public string GetSaveFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}