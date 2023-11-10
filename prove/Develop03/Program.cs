using System;

// THE PROGRAM EXCEED THE REQUIREMETS IN TO WAYS:
// 1ST THE PROGRAM ONLY HIDE THE WORDS THAT HAVE NOT BEEN HIDDEN

// 2ND I HAVE INCLUDED A TEXT FILE WITH SEVERAL SCRIPTURES NAMED TXTSPCRIPTURE.TXT, ONCE IT IS
// LOADED INTO THE SYSTEM IT ASKS TO THE USER WICH SCRIPTURE WANT TO MEMORIZE 
// AND DISPLAYS IT ON THE SCREEN. IF THE TEXT FILE IS NOT AVAILABLE, THE PROGRAM
// LOADS A DEFAULT SCRIPTURE TO MEMORIZE.

class Program
{
    static void Main(string[] args)
    {
        Scripture _bookScripture;
        Scripture loadedScripture = new Scripture();
        string stringOption = "";
        int option = 0;   
        bool validOption = false;

        do{
            // THIS LINE BLOCK CATCH THE SCRIPTURE TO DISPLAY             
            stringOption = Console.ReadLine();
            validOption = int.TryParse(stringOption, out option);

            if (!validOption){
                Console.WriteLine("Data entry no valid, please try again");
                Console.Write("Select one option: ");
            }                
            else{
                Console.WriteLine("");
                string[] dataScripture = loadedScripture.GetSelectedScripture(option);
                string[] verse = dataScripture[2].Split(" ");
                verse = verse.SkipLast(1).ToArray();
                string[] verseText = dataScripture[3].Split(" ");
                verseText = verseText.SkipLast(1).ToArray();                

                _bookScripture = new Scripture(dataScripture[0],dataScripture[1],verse,verseText);
                _bookScripture.PlayMemorizer();
            }

        }while(!validOption);                                    
    }    
}