using System;

class Program
{
 static List<Journal> journalsList = new List<Journal>();
    static Journal journal;
    static int option = 0;
    static string filename = "";
    static string[] lines;
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
            option = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            if (option == 1)
            {
                writeJournal();                                
            }
            else if (option == 2)
            { 
                displayJournal();                                       
            }
            else if (option == 3)
            {
                loadFile();                                                                 
            }
            else if (option == 4)
            {
                saveFile();                                                    
            }
        }while(option != 5);        
    }

    static void writeJournal()
    {
        journal = new Journal();
        journal.writeOption();
        journalsList.Add(journal);
    }

    static void displayJournal()
    {
        foreach (Journal j in journalsList)
        {
            Console.WriteLine($"Date: {j._date} - Prompt: {j._prompt}");
            Console.WriteLine($"{j._answerPrompt}");
            Console.WriteLine("");
        }
    }

    static void loadFile()
    {
        Console.Write("What is the file name? ");
        filename = Console.ReadLine(); 
        if (File.Exists(filename))
        { 
            lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                journal = new Journal();
                journal.readOption(journal, parts[0], parts[1], parts[2]);
                journalsList.Add(journal);                    
            }
            Console.WriteLine("File loaded successfully");
            Console.WriteLine("");                        
        }
        else
        {
            Console.WriteLine($"The file: {filename} no exist, please check your input and try again");
            Console.WriteLine("");                        
        }

    }

    static void saveFile()
    {
        string r = "";
        Console.Write("What is the file name? ");
        filename = Console.ReadLine();
        if (File.Exists(filename))
        {                    
            do
            {
                Console.Write($"The file: {filename} already exist. Do you want to overwrite it Y/N? ");
                r = Console.ReadLine();
                if ( r.ToLower() == "y")
                {
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {                   
                        foreach (Journal j in journalsList)
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
            using (StreamWriter outputFile = new StreamWriter(filename))
            {                   
                foreach (Journal j in journalsList)
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