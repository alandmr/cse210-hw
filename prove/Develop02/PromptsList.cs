using System;

public class PromptsList
{
    int _rdPrompts = 0;

    public string DisplayPrompts()
    {
        Random rd = new Random();
        string promptString = "";
        _rdPrompts = rd.Next(1,5);

        if (_rdPrompts == 1)
        {
            promptString = "Who was the most interesting person I interacted with today?";
        }
        else if (_rdPrompts == 2)
        {
            promptString = "What was the best part of my day?";
        }
        else if (_rdPrompts == 3)
        {
            promptString = "How did I see the hand of the Lord in my life today?";
        }
        else if (_rdPrompts == 4)
        {
            promptString = "What was the strongest emotion I felt today?";
        }
        else if (_rdPrompts == 5)
        {
            promptString = "If I had one thing I could do over today, what would it be?";
        }

        return promptString;
    }
}