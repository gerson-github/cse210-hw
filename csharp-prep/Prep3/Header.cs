/*
 * File: Program.cs
 * Author: Gerson Martins de Oliveira
 * Date: September 21, 2024
 * 
 * Lab: C# Prep 3 
 *
 */

using System;

public class Header
{
    public void ShowHeader()
    {
        
        Console.Clear();
        Console.WriteLine($"          Date: {DateTime.Now.ToShortDateString()}");

        // Using a verbatim string
        Console.WriteLine(@"
          _____                           __  __            _   _                 _                       _____                       
         / ____|                         |  \/  |          | \ | |               | |                ->   / ____|                       <-
        | |  __ _   _  ___  ___ ___      | \  / |_   _     |  \| |_   _ _ __ ___ | |__   ___ _ __   ->  | |  __  __ _ _ __ ___   ___   <-
        | | |_ | | | |/ _ \/ __/ __|     | |\/| | | | |    | . ` | | | | '_ ` _ \| '_ \ / _ \ '__|  ->  | | |_ |/ _` | '_ ` _ \ / _ \  <-
        | |__| | |_| |  __/\__ \__ \     | |  | | |_| |    | |\  | |_| | | | | | | |_) |  __/ |     ->  | |__| | (_| | | | | | |  __/  <-
         \_____|\__,_|\___||___/___/     |_|  |_|\__, |    |_| \_|\__,_|_| |_| |_|_.__/ \___|_|     ->   \_____|\__,_|_| |_| |_|\___|  <-
                                                  __/ |                                                                            
                                                 |___/                                                                             
        
        ");
        
        
        Console.WriteLine("");
        Console.WriteLine("Guess a number between 1-100. Type 'exit' to quit the game !!");
        Console.WriteLine("");

    }

}