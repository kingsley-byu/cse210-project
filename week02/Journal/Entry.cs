using system;

public class Entry
{
   public string _date;
   public string promptText;
   public string entryText;

   public void DisplayResult()
   { 
        Console.Writeline($"{_date} - {promptText}");
        Console.Writeline(_entryText);
        Console.Writeline(); 
    }
}