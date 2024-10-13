using System;
public class Screen 
{
    public void ShowHeader()
    {
        Console.Clear();
        //Console.WriteLine($"Date: {DateTime.Now.ToShortDateString()}");

        // Using a verbatim string
        Console.WriteLine(@"


     _______.  ______ .______       __  .______   .___________. __    __  .______       _______ 
    /       | /      ||   _  \     |  | |   _  \  |           ||  |  |  | |   _  \     |   ____|
   |   (----`|  ,----'|  |_)  |    |  | |  |_)  | `---|  |----`|  |  |  | |  |_)  |    |  |__   
    \   \    |  |     |      /     |  | |   ___/      |  |     |  |  |  | |      /     |   __|  
.----)   |   |  `----.|  |\  \----.|  | |  |          |  |     |  `--'  | |  |\  \----.|  |____ 
|_______/     \______|| _| `._____||__| | _|          |__|      \______/  | _| `._____||_______|
                                                                                                
.___  ___.  _______ .___  ___.   ______   .______       __   ________   _______ .______         
|   \/   | |   ____||   \/   |  /  __  \  |   _  \     |  | |       /  |   ____||   _  \        
|  \  /  | |  |__   |  \  /  | |  |  |  | |  |_)  |    |  | `---/  /   |  |__   |  |_)  |       
|  |\/|  | |   __|  |  |\/|  | |  |  |  | |      /     |  |    /  /    |   __|  |      /        
|  |  |  | |  |____ |  |  |  | |  `--'  | |  |\  \----.|  |   /  /----.|  |____ |  |\  \----.   
|__|  |__| |_______||__|  |__|  \______/  | _| `._____||__|  /________||_______|| _| `._____|   
                                                                                                
                                   _______      ___      .___  ___.  _______                    
                                  /  _____|    /   \     |   \/   | |   ____|                   
                                 |  |  __     /  ^  \    |  \  /  | |  |__                      
                                 |  | |_ |   /  /_\  \   |  |\/|  | |   __|                     
                                 |  |__| |  /  _____  \  |  |  |  | |  |____                    
                                  \______| /__/     \__\ |__|  |__| |_______| 


         ");
        
        
        //  Console.WriteLine();
        //  Console.WriteLine("Welcome to the Journal Program !");
        //  Console.ForegroundColor = ConsoleColor.Yellow;
        //  Console.WriteLine("Please select one of the following choices, using your Arrow Keys");
        //  Console.ResetColor();
        //  Console.WriteLine();

    }
    // public int ShowMenu()
    // {

    //     string[] menu = {"Write","Display","Load","Save", "Save Json","Quit"};
    //     int selectedMenu = 0;

    //     ConsoleKey keyPressed;
    //     do
    //     {
    //         ShowHeader();
    //         Console.WriteLine("-------------------------------------------------------------------");
    //         DisplayMenu(menu, selectedMenu);
    //         Console.WriteLine("-------------------------------------------------------------------");

    //         //journal.DisplayAll();
    //         keyPressed = Console.ReadKey().Key;

    //         //check arrow key
    //         if (keyPressed == ConsoleKey.RightArrow)
    //         {
    //             //right key pressed, if module of array lenght is 5, will return 0, the high light rotate at screen    
    //             selectedMenu = (selectedMenu + 1) % menu.Length;                    
    //         } 
    //         else if (keyPressed == ConsoleKey.LeftArrow)
    //         {
    //             selectedMenu = (selectedMenu - 1 + menu.Length) % menu.Length;
    //         }


    //     } while (keyPressed != ConsoleKey.Enter);

    //     return selectedMenu + 1;

    // }

    // static void DisplayMenu(string[] menu, int selectedMenu)
    // {
    //     for(int i = 0; i < menu.Length; i++)       
    //     {
    //         if (i == selectedMenu)
    //         {
    //             //highlight
    //             Console.BackgroundColor = ConsoleColor.DarkGray;
    //             Console.ForegroundColor = ConsoleColor.Yellow;
    //         }
    //         else
    //         {
    //             //get normal colors
    //             Console.ResetColor();        
    //         }
    //         //display menu horizontaly
    //         Console.Write(menu[i] + "      ");

    //     }

    //     Console.ResetColor();
    //     Console.WriteLine();

    // }

}