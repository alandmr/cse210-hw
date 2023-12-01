using System;

class Breathing : Mindfulness
{  
    
    public Breathing()
    {        
        LoadBreathMessages();        
    } 
   
    public void StartBreathe(){
        int time = 0;

        Console.Clear();
        Console.WriteLine(GetIntroMessage());
        Console.WriteLine("");
        Console.WriteLine(GetDescriptionMessage());
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for you session? ");
        time = int.Parse(Console.ReadLine());
                    
        Console.Clear();
        Console.WriteLine("Get ready...");
        StartAnimation(4);                    
                    
        Console.WriteLine("");
        Console.WriteLine("");
                                        
        StartBreathingAnimation(time);                    
                    
        Console.WriteLine("");

        Console.WriteLine("Well done!!!");
        StartAnimation(4);

        Console.WriteLine("");

        Console.WriteLine(GetFinishingMessage());
        StartAnimation(5);
   }

   private void LoadBreathMessages()
   {     
      string []lines;
      lines = System.IO.File.ReadAllLines("breathing.txt");
      foreach (string line in lines)
      {
            string[] parts = line.Split(",");
            SetIntroMessage(parts[0]);                 
            SetDescriptionMessage(parts[1]);
            _fMessage.Add(parts[2]);
            _fMessage.Add(parts[3]);
      }                       
   }

   private void StartBreathingAnimation(int time)
   {
      SetFinishingMessage($"{_fMessage[0]} {time} seconds {_fMessage[1]}");
      
      List<string> breatheInList = new List<string>();
      List<string> breatheOutList = new List<string>();

      breatheInList.Add("B");
      breatheInList.Add("r");
      breatheInList.Add("e");
      breatheInList.Add("a");
      breatheInList.Add("t");
      breatheInList.Add("h");
      breatheInList.Add("e");
      breatheInList.Add(" ");
      breatheInList.Add("i");
      breatheInList.Add("n");
      breatheInList.Add(".");
      breatheInList.Add(".");
      breatheInList.Add(".");

      breatheOutList.Add("B");
      breatheOutList.Add("r");
      breatheOutList.Add("e");
      breatheOutList.Add("a");
      breatheOutList.Add("t");
      breatheOutList.Add("h");
      breatheOutList.Add("e");
      breatheOutList.Add(" ");
      breatheOutList.Add("o");
      breatheOutList.Add("u");
      breatheOutList.Add("t");
      breatheOutList.Add(".");
      breatheOutList.Add(".");
      breatheOutList.Add(".");
            
      
      Console.Write("Breathe in...");
      for (int j = 2; j>0; j--)
      {
         Console.Write($"{j}");
         Thread.Sleep(1000);         
         Console.Write("\b \b");

      }
      Console.WriteLine("");   

      Console.Write($"Now Breathe out...");
      for (int j = 3; j>0; j--)
      {
         Console.Write($"{j}");
         Thread.Sleep(1000);         
         Console.Write("\b \b");
      }

      Console.WriteLine("");      
      Console.WriteLine("");      

      int i = 0;
      
      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(time);
      
      while (DateTime.Now < endTime)
      {
         for (i = 0; i<breatheInList.Count;i++)
         {
            string s = breatheInList[i];
            Console.Write(s);
            Thread.Sleep(50); 
         }
                                
         for (int j = 4; j>0; j--)
         {
            Console.Write($"{j}");
            Thread.Sleep(1000);         
            Console.Write("\b \b");

         }
         Console.WriteLine("");         

         for (i = 0; i<breatheOutList.Count;i++)
         {
            string s = breatheOutList[i];
            Console.Write(s);
            Thread.Sleep(50); 
         }

         int t = 1000;
         
         for (int j = 5; j>0; j--)
         {
            t += 100;
            Console.Write($"{j}");
            Thread.Sleep(t);         
            Console.Write("\b \b");

         }
         Console.WriteLine("");      
         Console.WriteLine("");   
      }   
   }
}