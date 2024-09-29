/*
 * File: Program.cs
 * Author: Gerson Martins de Oliveira
 * Date: September 21, 2024
 * 
 * Lab: C# Prep 3 
 *
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Header header = new Header();
        header.ShowHeader();

        Random random = new Random();
        int randonNumber = random.Next(1,101);

        string response = "yes";
        int countGuess = 0;

        do
        {
 
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.Write("Bye, Bye.. Game over!  ;- ) ");   
                break;
            }

            countGuess +=1;

            if (randonNumber > int.Parse(input))
            {
                Console.WriteLine("Higher");
            }
            else if (randonNumber < int.Parse(input))
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! You did it in {countGuess} rounds");
                Console.WriteLine("Do you want to continue playing, Yes or No ? ");
                response = Console.ReadLine();

                if (response.ToLower() == "no" )
                {
                    Console.Write("Bye, Bye.. Game over!  ;- ) ");   
                    break;                    
                } else
                {
                    header.ShowHeader();
                    randonNumber = random.Next(1,101);
                    countGuess = 0;
                }
                ;
            }
        } while (response.ToLower() == "yes");
    }
}