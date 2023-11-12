using System;

class Listing : Mindfulness
{
    private List<string> _questionsList = new List<string>();    

    public Listing()
    {
        LoadListingMessages();
    }

    public void StartListing(){
        int time = 0;

        Console.Clear();
        Listing listing = new Listing();
        Console.WriteLine(listing.GetIntroMessage());
        Console.WriteLine("");
        Console.WriteLine(listing.GetDescriptionMessage());
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for you session? ");
        time = int.Parse(Console.ReadLine());
                    
        Console.Clear();
        Console.WriteLine("Get ready...");
        listing.StartAnimation(4);                    
                    
        Console.WriteLine("");
                                        
        listing.StartListingAnimation(time);           
                    
         Console.WriteLine("");

         Console.WriteLine("Well done!!!");
         listing.StartAnimation(4);

         Console.WriteLine("");

         Console.WriteLine(listing.GetFinishingMessage());
         listing.StartAnimation(5);
    }

    private void LoadListingMessages()
    {            
        string rline;
        StreamReader sReader = new StreamReader("listing.txt");
        int pivot = 1;

        try
        {
            rline = sReader.ReadLine();
            while (rline != null)
            {                
                                       
                if (pivot == 1)
                {
                    string[] parts = rline.Split(",");
                    SetIntroMessage(parts[0]);                 
                    SetDescriptionMessage(parts[1]);
                    _fMessage.Add(parts[2]);
                    _fMessage.Add(parts[3]);
                }

                if (pivot == 2)
                {
                    string[] parts = rline.Split(",");
                    for (int i = 0; i<5; i++)
                    {
                        _questionsList.Add(parts[i]);
                    }
                }
                
                pivot++;
                rline = sReader.ReadLine();                
            }


        }
        catch(Exception e)
        {
            Console.WriteLine($"Exception: {e}");
        }                                               
    }

    private void StartListingAnimation(int time)
    {
        SetFinishingMessage($"{_fMessage[0]} {time} seconds {_fMessage[1]}");
        
        Console.WriteLine("List as many responses you can to the following prompt:");

        Random rdm = new Random();
        int varRdm = 0;
        
        varRdm = rdm.Next(0,4);

        Console.WriteLine($"--- {_questionsList[varRdm]} ---");
        Console.Write("You may begin in:");
        for (int j = 3; j>0; j--)
        {
            Console.Write($"{j}");
            Thread.Sleep(1000);         
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
      
        Console.WriteLine("");

        int input = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            input++;
        }

        Console.WriteLine($"You listed {input} items");
        
    }

}