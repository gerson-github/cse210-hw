using System;
using System.Net.NetworkInformation;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");

        Console.Clear();
        
        DisplayWelcome();
        string nome = PromptUserName();
        int nro =  PromptUserNumber();
        int square = SquareNumber(nro);
        DisplayResult(nome, square);

    }
    static void DisplayWelcome() 
    {
        Console.Write("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string nome = Console.ReadLine();
        return nome;
    }
    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number: ");
        int nro = int.Parse(Console.ReadLine());
        return nro;
    }
    static int SquareNumber(int nro)
    {
        int resultado = nro * nro;
        return resultado;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }

    
    // static void DisplayPersonalMessage(string userName){
    //     Console.WriteLine($"Hello {userName}");
    // }
    // static int AddNumbers (int first, int second) {
    //     int sum = first + second;
    //     return sum;
    // }

}