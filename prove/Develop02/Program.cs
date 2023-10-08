using System;

class Program
{        
    static void Main(string[] args)
    {
        int _option = 0;
        Journal _journal = new Journal();
                
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
                _journal.AddEntry();                                
            }
            else if (_option == 2)
            { 
                _journal.DisplayEntries();
            }
            else if (_option == 3)
            {
                _journal.LoadFile();                                                                 
            }
            else if (_option == 4)
            {
                _journal.SaveFile();                                                    
            }
        }while(_option != 5);        
    }
    
}