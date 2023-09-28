using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        int number = -1;        
        bool isNumeric;
        string getNumber = "";
               
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            getNumber = Console.ReadLine();
            isNumeric = int.TryParse(getNumber, out number);
            if (isNumeric)
            {
                if (number != 0)
                {
                    list.Add(number);
                }                
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid input");
                Console.WriteLine("");
            }
        }
       
        
        Console.WriteLine($"The sum is: {list.Sum()}");
        Console.WriteLine($"The average is: {list.Average()}");
        Console.WriteLine($"The largest number is: {list.Max()}");
        list.Sort();
                
        List<int> positiveNumList = new List<int>();
        foreach (int n in list)
        {
            if (n > 0)
            {
                positiveNumList.Add(n);
            }
        }
        
        Console.WriteLine($"The smallest positive number is: {positiveNumList.Min()}");        
        Console.WriteLine("The sorted list is:");
        foreach (int n in list)
        {
            Console.WriteLine(n);
        }

    }
}