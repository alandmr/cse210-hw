using System;

public class Journal
{
    public string _date;
    public DateTime _theCurrentTime = DateTime.Now;
    public string _prompt;
    public string _answerPrompt;    

    public void WriteOption()
    {
        PromptsList pl = new PromptsList();
        
        _prompt = pl.DisplayPrompts();
        Console.Write($"{_prompt}: ");
        _answerPrompt = Console.ReadLine();
        _date = _theCurrentTime.ToShortDateString();        
    } 

    public void ReadOption(Journal j, string d, string p, string a)
    {
        j._date = d;
        j._prompt = p;
        j._answerPrompt = a;
    }
}