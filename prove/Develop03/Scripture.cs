using System;

class Scripture
{
    private Reference _bookRefrence;
    private List<Reference> _listScripture;        

    public Scripture(string bName, string chapter, string[] vReference, string[] text)
    {        
        this._bookRefrence = new Reference(bName, chapter, vReference, text);        
    }

    public Scripture(){
        LoadFile();        
        string[] verseRef = null;        
        int i=1;
        
        foreach (Reference list in _listScripture){
            Console.Write($"{i}.- ");
            if (list.GetVerseRef().Length < 2){
                verseRef = list.GetVerseRef();
                Console.WriteLine($"{list.GetBookName()} {list.GetChapter()}:{verseRef[0]} ");
            }else if(list.GetVerseRef().Length > 1){
                verseRef = list.GetVerseRef();            
                Console.WriteLine($"{list.GetBookName()} {list.GetChapter()}:{verseRef[0]}-{verseRef[list.GetVerseRef().Length-1]}");
            } 
            i++;
        }

        Console.WriteLine("");
        Console.Write("Please select one option: ");
    }

    public string[] GetSelectedScripture(int option){

        string txt = "";
        string verse = "";       

        for (int i=0; i < _listScripture[option-1].GetVerseText().Count; i++){
            txt +=  _listScripture[option-1].GetVerseText()[i].GetWordString()+" ";
        }

        for (int i=0; i < _listScripture[option-1].GetVerseRef().Length; i++){
            verse +=  _listScripture[option-1].GetVerseRef()[i]+" ";
        }

        string[] dataScripture = {
            _listScripture[option-1].GetBookName(),_listScripture[option-1].GetChapter(),verse,txt};
        
        return dataScripture;

    }

    public List<Reference> GetListScripture(){
        return this._listScripture;
    }

    public void displayScriptureRef()
    {
        string[] verseRef = null;
        if (this._bookRefrence.GetVerseRef().Length < 2){
            verseRef = this._bookRefrence.GetVerseRef();
            Console.Write($"{this._bookRefrence.GetBookName()} {this._bookRefrence.GetChapter()}:{verseRef[0]} ");
        }else if(this._bookRefrence.GetVerseRef().Length > 1){
            verseRef = this._bookRefrence.GetVerseRef();            
            Console.Write($"{this._bookRefrence.GetBookName()} {this._bookRefrence.GetChapter()}:{verseRef[0]}-{verseRef[this._bookRefrence.GetVerseRef().Length-1]} ");
        }            
    }

    public void displayScriptureVerse()
    {
        foreach(Word text in _bookRefrence.GetVerseText())
        {
            Console.Write($"{text.GetWordString()} ");
        }
        Console.WriteLine("");
    }

    private void setBlankSpace()
    {
        Random rd = new Random();
        int varRd = 0;          
        string wordString = "";
        string newWord = "";

        // THIS IS THE BLOCK CODE TO EXCEEDING REQUIREMENTS
        // This block of code allow to select only those word that not have been hide
        do
        {
            varRd = rd.Next(1,_bookRefrence.GetVerseText().Count()+1);                
            if (_bookRefrence.GetVerseText()[varRd-1].GetStatus())
            {
                wordString = _bookRefrence.GetVerseText()[varRd-1].GetWordString();
                for(int i=0; i<wordString.Length;i++)
                {
                    newWord = newWord + "_";
                }
                _bookRefrence.GetVerseText()[varRd-1].SetWordString(newWord);
                _bookRefrence.GetVerseText()[varRd-1].SetStatus(false);
                break;
            }
        }while(!_bookRefrence.GetVerseText()[varRd-1].GetStatus() && isEnable());                
    }

    private Boolean isEnable()
    {
        int count = 0;
        for (int i = 0; i<_bookRefrence.GetVerseText().Count(); i++)
        {
            if (!_bookRefrence.GetVerseText()[i].GetStatus())
            {
                count += 1; 
            }
        }

        if (count < _bookRefrence.GetVerseText().Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void PlayMemorizer()
    {
        string userInput = "";
        Console.Clear();        
        displayScriptureRef();
        displayScriptureVerse();       
        do
        {            
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine().ToLower();
            if (userInput != "quit")
            {
                setBlankSpace();
                Console.Clear();
                displayScriptureRef();
                displayScriptureVerse();                
            } 
            else
            {
                break;
            }           
        }while(isEnable());
    }

    public void LoadFile()
    {        
        this._listScripture  = new List<Reference>();
        string fileName = "TxtScripture.txt"; 
        string[] lines = null;
        Reference scriptureRef;
        string bookName = "";
        string chapter = "";
        string[] verse;
        string [] scriptureText;

        if (File.Exists(fileName))
        { 
            Console.Clear();
            Console.WriteLine("A scripture reference file was found");
            lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {                
                string[] parts = line.Split("|");
                string[] parts2 = parts[0].Split(" ");                  
                verse = new string[0];
                scriptureText = new string[parts.Length-1];
                if (parts2.Length <= 3){
                    verse = new string[parts2.Length-2];
                    bookName = parts2[0];
                    chapter = parts2[1];  
                    verse[0] = parts2[2]; 
                    if (parts.Length <=2)
                        scriptureText[0] = parts[1];                    
                }else if(parts2.Length > 3){
                    int isNumeric = 0;
                    bool result = int.TryParse(parts2[0], out isNumeric);
                    if (result){
                        verse = new string[parts2.Length-3];
                        bookName = parts2[0]+" "+parts2[1];
                        chapter = parts2[2];  
                        verse[0] = parts2[3];                         
                    }else{
                        verse = new string[parts2.Length-2];
                        bookName = parts2[0];
                        chapter = parts2[1];  
                        verse[0] = parts2[2]; 
                        verse[1] = parts2[3];
                    }                    
                    if (parts.Length > 2){                         
                        for (int i = 1; i < parts.Length; i++){
                            scriptureText[i-1] = parts[i];
                        }                        
                    }else{
                       scriptureText[0] = parts[1]; 
                    }                        
                }

                scriptureRef = new Reference(bookName,chapter,verse,scriptureText);
                _listScripture.Add(scriptureRef);
            }
            Console.WriteLine($"File {fileName} loaded successfully");
            Console.WriteLine("");             
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Scripture reference file was not found, please select one scripture listed below");
            Console.WriteLine("");
            bookName = "Proverbs";
            chapter = "3";
            string[] v = {"5","6"};
            string[] t = {
                "Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding.",
                "In", "all", "thy", "ways", "acknowledge", "him,", "and", "he", "shall", "direct", "thy", "paths."
            };
            scriptureRef = new Reference(bookName,chapter,v,t);
            _listScripture.Add(scriptureRef);               
        }

    }    
}