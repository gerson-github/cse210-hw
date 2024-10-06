/*
 * File: Resume.cs
 * Author: Gerson Martins de Oliveira
 * Date: Octuber 05, 2024
 * 
 * Lab: Abstraction Learning Activity
 *
 */

using System;
using System.Runtime.CompilerServices;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
        
                
    }
}