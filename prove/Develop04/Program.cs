using System;

// Things that Exceeding Requirements

// 1.- I developed a block of code to make sure no random prompts/questions are selected until they have all been used 
// at least once in that session in the Reflecting Activity.

//2.- I added animation on the text in the Breathing Activity.

//3.- I used 3 text file named(breathing.txt, listing.txt and reflection.txt) to load the Starting Message, Description Activity, Finishing Message and Prompts


class Program
{
    static void Main(string[] args)
    {
        string option;

        MainOptions();
        do{            
            option = Console.ReadLine();
            if (CorrectOption(option))
            {
                if (option == "1")
                {
                    Breathing breaht = new Breathing();
                    breaht.StartBreathe();
                    
                }

                if (option == "2")
                {
                    Reflection reflection = new Reflection();
                    reflection.StartReflection();
                } 

                if (option == "3")
                {
                    Listing listing = new Listing();
                    listing.StartListing();
                } 
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid entry, please try again");
                Thread.Sleep(1000);
                MainOptions();
            }
            Console.Clear();
            MainOptions();
        }while(option != "4");        
    }

    private static void MainOptions()
    {
        Console.Clear();
        Console.WriteLine("Menu options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choise from the menu: ");
    }

    private static bool CorrectOption(string op)
    {
        List<string> opList = new List<string>
        {
            "1",
            "2",
            "3",
            "4"
        };

        foreach (string n in opList)
        {
            if (n == op)
            {
                return true;                
            }                
        }
        return false;
    }
} 