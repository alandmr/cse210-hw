using System;

class Program
{
 static List<Journal> _journalsList = new List<Journal>();
    static Journal _journal;
    static int _option = 0;
    static string _fileName = "";
    static string[] _lines;
    static void Main(string[] args)
    {
                
        Console.WriteLine("Welcome to the Journal Program!");
        do
        {            
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            _option = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            if (_option == 1)
            {
                WriteJournal();                                
            }
            else if (_option == 2)
            { 
                DisplayJournal();                                       
            }
            else if (_option == 3)
            {
                LoadFile();                                                                 
            }
            else if (_option == 4)
            {
                SaveFile();                                                    
            }
        }while(_option != 5);        
    }

    static void WriteJournal()
    {
        _journal = new Journal();
        _journal.WriteOption();
        _journalsList.Add(_journal);
    }

    static void DisplayJournal()
    {
        foreach (Journal j in _journalsList)
        {
            Console.WriteLine($"Date: {j._date} - Prompt: {j._prompt}");
            Console.WriteLine($"{j._answerPrompt}");
            Console.WriteLine("");
        }
    }

    static void LoadFile()
    {
        Console.Write("What is the file name? ");
        _fileName = Console.ReadLine(); 
        if (File.Exists(_fileName))
        { 
            _lines = System.IO.File.ReadAllLines(_fileName);
            foreach (string line in _lines)
            {
                string[] parts = line.Split(",");
                _journal = new Journal();
                _journal.ReadOption(_journal, parts[0], parts[1], parts[2]);
                _journalsList.Add(_journal);                    
            }
            Console.WriteLine("File loaded successfully");
            Console.WriteLine("");                        
        }
        else
        {
            Console.WriteLine($"The file: {_fileName} no exist, please check your input and try again");
            Console.WriteLine("");                        
        }

    }

    static void SaveFile()
    {
        string r = "";
        Console.Write("What is the file name? ");
        _fileName = Console.ReadLine();
        if (File.Exists(_fileName))
        {                    
            do
            {
                Console.Write($"The file: {_fileName} already exist. Do you want to overwrite it Y/N? ");
                r = Console.ReadLine();
                if ( r.ToLower() == "y")
                {
                    using (StreamWriter outputFile = new StreamWriter(_fileName))
                    {                   
                        foreach (Journal j in _journalsList)
                        {                        
                            outputFile.Write($"{j._date},");                        
                            outputFile.Write($"{j._prompt},");
                            outputFile.WriteLine($"{j._answerPrompt},");                                
                        } 
                        Console.WriteLine("");                    
                        break;
                    }
                }
                else if(r.ToLower() == "n")
                {
                    Console.WriteLine("Journal information no saved");  
                    Console.WriteLine("");  
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");  
                    Console.WriteLine("");  
                }

            }while( r.ToLower() != "n" || r.ToLower() != "y");
                    
        }
        else
        {                    
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {                   
                foreach (Journal j in _journalsList)
                {                        
                    outputFile.Write($"{j._date},");                        
                    outputFile.Write($"{j._prompt},");
                    outputFile.WriteLine($"{j._answerPrompt},");
                    Console.WriteLine("");
                    Console.WriteLine("File saved successfully");
                    Console.WriteLine("");
                }                     
            }
        }
    }
}