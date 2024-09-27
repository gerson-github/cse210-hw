/*
 * File: Program.cs
 * Author: Gerson Martins de Oliveira
 * Date: September 21, 2024
 * 
 * Lab: C# Prep 2 - Conditionals and Variables
 *
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Clear();

        Console.WriteLine("Enter your grade percentage: ");
        string valueFromUser = Console.ReadLine();

        int percentageFromUser = int.Parse(valueFromUser);
        string letter;
        

        if (percentageFromUser >= 90)
        {
            letter = "A";
        }
        else if (percentageFromUser >= 80)
        {
            letter = "B";
        }
        else if (percentageFromUser >= 70)
        {
            letter = "C";
        }
        else if (percentageFromUser >= 60)
        {
            letter = "D";
        }        
        else
        {
            letter = "F";
        }

        Console.WriteLine($"YOur grade is: {letter}");

        if (percentageFromUser >= 70)
        {
            Console.WriteLine("Congratulations, you are approved.");
        }
        else
        {
            Console.WriteLine($"You failed. Try again next year.");
        }
        

    }
}