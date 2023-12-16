using System;

class Mindfulness
{
    private string _introMessage;
    private string _finishingMessage;
    private string _descriptionMessage;
    private int _timeActivity;
    private List<string> _animationString = new List<string>();
    protected List<string> _fMessage = new List<string>();

    public string GetIntroMessage()
    {
        return this._introMessage;
    }

    public void SetIntroMessage(string introMessage)
    {
        this._introMessage = introMessage;
    }

    public string GetFinishingMessage()
    {
        return this._finishingMessage;
    }

    public void SetFinishingMessage(string finishingMessage)
    {
        this._finishingMessage = finishingMessage;
    }

    public string GetDescriptionMessage()
    {
        return this._descriptionMessage;
    }

    public void SetDescriptionMessage(string descriptionMessage)
    {
        this._descriptionMessage = descriptionMessage;
    }

    public int GetTimeActivity()
    {
        return this._timeActivity;
    }

    public void SetTimeActivity(int timeActivity)
    {
        this._timeActivity = timeActivity;
    }

    public void StartAnimation(int time)
    {
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = _animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i>=_animationString.Count)
            {
                i = 0;
            }
        }

    }

}