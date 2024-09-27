/*
 * File: Program.cs
 * Author: Gerson Martins de Oliveira
 * Date: September 21, 2024
  * 
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");

        Console.Clear();

        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {firstName}, {firstName} {lastName}.");

    }
}