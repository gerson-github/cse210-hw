/*
 * File: Job.cs
 * Author: Gerson Martins de Oliveira
 * Date: Octuber 04, 2024
 * 
 * Lab: Abstraction Learning Activity
 *
 */

using System;
using System.Runtime.CompilerServices;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
        Console.WriteLine($" {_jobTitle} ({_company}) {_startYear}-{_endYear}");
        return;        

    }
}