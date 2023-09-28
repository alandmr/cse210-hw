using System;

class Program
{
    static void Main(string[] args)
    {
        string userName = "";
        int scuare = 0;
        int number = 0;

        DisplayWelcome();
        userName = PromptUserName();
        number = PromptUserNumber();
        scuare = SquareNumber(number);
        DisplayResult(userName,scuare);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        string name = "";

        Console.Write("Please enter your name: ");
        name = Console.ReadLine();        
        return name;
    }

    static int PromptUserNumber()
    {
        int num = 0;
        
        Console.Write("Please enter your favorite number: ");
        num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}