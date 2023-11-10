class Word
{
    private Boolean _status;
    private string _wordString;

    public Word(Boolean status, string word){
        this._status = status;
        this._wordString = word;
    }

    public Boolean GetStatus()
    {
        return this._status;
    }

    public void SetStatus(Boolean visible)
    {
        this._status = visible;
    }

    public string GetWordString()
    {
        return this._wordString;
    }

    public void SetWordString(string wordString)
    {
        this._wordString = wordString;
    }
}