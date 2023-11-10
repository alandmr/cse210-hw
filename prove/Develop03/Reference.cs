class Reference
{
    private string _bookName;
    private string _chapter;
    private string[] _verseReference;
    private List<Word> _verseText;

    public Reference(string bName, string chapter, string[] vReference, string[] text)
    {
        this._bookName = bName;
        this._chapter = chapter;
        this._verseReference = vReference;
        SetVerseText(text);
    }

    public string GetBookName()
    {
        return this._bookName;
    }

    public string GetChapter()
    {
        return this._chapter;
    }

    public string[] GetVerseRef()
    {
        return this._verseReference;
    }

    private void SetVerseText(string[] text)
    {
        this._verseText = new List<Word>();
        string[] arrText;
        Word vText; 

        if (text.Length <= 1){
            arrText = new string[text[0].Split(" ").Length];
            arrText = text[0].Split(" ");
            foreach(string t in arrText)
            {
                vText = new Word(true,t);
                this._verseText.Add(vText);
            } 
        }             
        else if (text.Length > 1){
            for (int i = 0; i < text.Length; i++){
                arrText = new string[text[i].Split(" ").Length];
                arrText = text[i].Split(" ");
                foreach(string t in arrText)
                {
                    vText = new Word(true,t);
                    this._verseText.Add(vText);
                } 
            }            
        }           
    }

    public List<Word> GetVerseText()
    {
        return this._verseText;
    }

}