using System;

class Program
{
    static void Main(string[] args)
    {
        float score = 0;
        float cSign = 0;
        string grade = "";
        string letter = "";
        string sign = "";


        Console.Write("What is your grade percentage? ");
        grade = Console.ReadLine();

        score = float.Parse(grade);
        cSign = score % 10;

        if (cSign >= 7 && score <=97 && score >=60)
        {
            sign = "+";
        }
        else if (cSign < 3 && score >=60)
        {
            sign = "-";
        }
  

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >=80 && score < 90)
        {
            letter = "B";
        }
        else if (score >=70 && score < 80)
        {
            letter = "C";
        }
        else if (score >=60 && score < 70)
        {
            letter = "D";
        }
        else if (score < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}{sign}.");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations!!!, you did it. Well done.");
        }else
        {
            Console.WriteLine("Sorry, you can do it better. Keep trying.");
        }        
    }
}