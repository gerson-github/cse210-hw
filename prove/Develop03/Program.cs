using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Develop03 World!");

        Screen screen = new Screen();
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        screen.ShowHeader();
        Console.WriteLine("Enter a number between 1 and 5 to randomly hide words (default is 3) :");
        string input = Console.ReadLine();
        
        int hideRandomWords = (!int.TryParse(input, out hideRandomWords)) ? 3: (hideRandomWords < 1 || hideRandomWords > 5 ? 3: hideRandomWords) ;

        string verse = "Trust in the Lord with all thine heart and lean not unto thine own understanding";

        Scripture scripture = new Scripture(reference, verse);

        // Hide random words until the scripture is completely hidden
        do 
        {
            screen.ShowHeader();
            // Console.Clear();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type 'Quit' to exit...");
            Console.ResetColor();
            Console.WriteLine();
           
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continuer or type 'quit' to finish:");
            string userText = Console.ReadLine();
            
            Console.WriteLine();
            

            if (userText?.ToLower() == "quit")
            {
                Console.WriteLine("Bye ! Bye...");
                Console.WriteLine();
                break; 
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Scripture is completely hidden!");
                Console.WriteLine();
                break;
            }

            scripture.HideRandomWords(hideRandomWords);
        } while (true); //(!scripture.IsCompletelyHidden());

        
        
        // Reference singleVerseRef = new Reference("John",3,16);
        // Console.WriteLine(singleVerseRef.GetDisplayText());

        // Reference rangeRef = new Reference("Proverbs",3,5,6);
        // Console.WriteLine(rangeRef.GetDisplayText());

    }
}