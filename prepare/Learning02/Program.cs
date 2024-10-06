/*
 * File: Program.cs
 * Author: Gerson Martins de Oliveira
 * Date: Octuber 05, 2024
 * 
 * Lab: Abstraction Learning Activity
 *
 */
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.Clear();

        Job job1 = new Job();

        job1._jobTitle = "software engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2023;
        //job1.Display();

        Job job2 = new Job();
        
        job2._jobTitle = "software engineer";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2024;
        job2.Display();

        Resume resume = new Resume();
        
         resume._name = "Gerson Oliveira";
         resume._jobs.Add(job1);
         resume._jobs.Add(job2);

        //resume.Display();

        // Person person = new Person();

        // person._familyName = "oliveira";
        // person._givenName = "gerson";

        // person.ShowEasternName();
        // person.ShowWesternName();

    }

    // public class Person() 
    // {
    //     public string _givenName;
    //     public string _familyName;
    //     public void ShowEasternName()
    //     {
    //         Console.WriteLine($"{_familyName}, {_givenName}");
    //     }
    //     public void ShowWesternName() 
    //     {
    //         Console.WriteLine($"{_givenName} {_familyName} ");
    //     }
    // }

}