using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    Entry _entry;
    public string _fileName = "";
    public string[] _lines;

    public void AddEntry()
    {
        _entry = new Entry();
        _entry.SetEntry();
        _entries.Add(_entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._answerPrompt}");
            Console.WriteLine("");
        }
    }

    public void LoadFile()
    {
        Console.Write("What is the file name? ");
        _fileName = Console.ReadLine(); 
        if (File.Exists(_fileName))
        { 
            _lines = System.IO.File.ReadAllLines(_fileName);
            foreach (string line in _lines)
            {
                string[] parts = line.Split(",");
                _entry = new Entry();
                _entry.GetEntry(parts[0], parts[1], parts[2]);
                _entries.Add(_entry);                    
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

    public void SaveFile()
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
                        foreach (Entry entry in _entries)
                        {                        
                            outputFile.Write($"{entry._date},");                        
                            outputFile.Write($"{entry._prompt},");
                            outputFile.WriteLine($"{entry._answerPrompt},");    
                            Console.WriteLine("");
                            Console.WriteLine("File saved successfully");
                            Console.WriteLine("");                            
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
                foreach (Entry entry in _entries)
                {                        
                    outputFile.Write($"{entry._date},");                        
                    outputFile.Write($"{entry._prompt},");
                    outputFile.WriteLine($"{entry._answerPrompt},");
                    Console.WriteLine("");
                    Console.WriteLine("File saved successfully");
                    Console.WriteLine("");
                }                     
            }
        }
    }
}