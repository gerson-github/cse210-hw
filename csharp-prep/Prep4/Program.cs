using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        //Console.WriteLine("Hello Prep4 World!");
        Console.Clear();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input;
        int largest = 0;
        int smallest = int.MaxValue;
        List<int>  numbers = new List<int>();

        do
        {

            // Assuming you want to read input from the user
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0) 
            {
                numbers.Add(input);
                largest = (input > largest) ? input : largest;
                smallest = (input < smallest) ? input : smallest;
            }
            

        } while (input != 0);

        int total = 0;
        foreach(int n in numbers)
        {
            total += n;
        }

        Console.WriteLine($"The sum is: {total}");
        
        float media =  ((float)total / numbers.Count);
        Console.WriteLine($"The average is: {media}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");

        numbers.Sort();
        Console.WriteLine("The sorted is: ");
        foreach(int n in numbers)
        {
            Console.WriteLine(n);
        }

    //List<int> numbers = new List<int>();
    // List<int> numbers;
    // numbers = new List<int>();

    // numbers.Add(10);
    // numbers.Add(20);
    // numbers.Add(30);

    // Console.WriteLine(numbers.Count);

    // foreach(int listNum in numbers){
    //     Console.WriteLine(listNum);
    // }

    // Console.WriteLine("** inicio do For loop **");

    // for ( int i =0; i < numbers.Count; i++)
    // {
    //     Console.WriteLine(numbers[i]);
    // }


    //List<string> words;
    }
}