using System;

class Program
{
    static void Main(string[] args)
    {                
        int magic_number;
        int number;
        string getNumber;
        string getMagicNumber;
        bool isNumeric;
        string answer = "";
        int trackingGuesses;

        answer = "yes";
        while (answer.ToLower() == "yes")
        {
            Console.Write("What is the magic number? ");
            getMagicNumber = Console.ReadLine();
            int.TryParse(getMagicNumber, out magic_number);
            number = 0;
            getNumber = "";
            isNumeric = false;
            trackingGuesses = 0;

            do
            {
                Console.Write("What is your guess? ");
                getNumber = Console.ReadLine();
                isNumeric = int.TryParse(getNumber, out number);
                if (isNumeric)
                {
                    trackingGuesses++;
                    if (number < magic_number)
                    {
                        Console.WriteLine("Higher");  
                    }
                    else if (number > magic_number)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"Tracking guesses: {trackingGuesses}");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("");
                }
            }while(magic_number != number);    

            Console.WriteLine("Do you want to play again? ");
            answer = Console.ReadLine();        
        }
    }
}