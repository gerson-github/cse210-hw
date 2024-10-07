using System;
public class Screen 
{
    public void ShowHeader()
    {
        Console.Clear();
        //Console.WriteLine($"Date: {DateTime.Now.ToShortDateString()}");

        // Using a verbatim string
        Console.WriteLine(@"

███╗   ███╗██╗   ██╗                                        
████╗ ████║╚██╗ ██╔╝                                        
██╔████╔██║ ╚████╔╝                                         
██║╚██╔╝██║  ╚██╔╝                                          
██║ ╚═╝ ██║   ██║                                           
╚═╝     ╚═╝   ╚═╝                                           
                                                            
     ██╗ ██████╗ ██╗   ██╗██████╗ ███╗   ██╗ █████╗ ██╗     
     ██║██╔═══██╗██║   ██║██╔══██╗████╗  ██║██╔══██╗██║     
     ██║██║   ██║██║   ██║██████╔╝██╔██╗ ██║███████║██║     
██   ██║██║   ██║██║   ██║██╔══██╗██║╚██╗██║██╔══██║██║     
╚█████╔╝╚██████╔╝╚██████╔╝██║  ██║██║ ╚████║██║  ██║███████╗
 ╚════╝  ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝╚══════╝                                                                                                                                                                                 
         ");
        
        
        // Console.WriteLine("");
        // Console.WriteLine("Guess a number between 1-100. Type 'exit' to quit the game !!");
        // Console.WriteLine("");

    }
    public void ShowMenu()
    {

        string[] menu = {"Write","Display","Load","Save","Quit"};
        int selectedMenu = 0;

        ConsoleKey keyPressed;
        do
        {
            ShowHeader();
            Console.WriteLine("----------------------------------------------------------");
            DisplayMenu(menu, selectedMenu);
            Console.WriteLine("----------------------------------------------------------");

            keyPressed = Console.ReadKey().Key;

            //check arrow key
            if (keyPressed == ConsoleKey.RightArrow)
            {
                //right key pressed, if module of array lenght is 5, will return 0, the high light rotate at screen    
                selectedMenu = (selectedMenu + 1) % menu.Length;                    
            } 
            else if (keyPressed == ConsoleKey.LeftArrow)
            {
                selectedMenu = (selectedMenu - 1 + menu.Length) % menu.Length;
            }


        } while (keyPressed != ConsoleKey.Enter || selectedMenu != menu.Length -1);


    }

    static void DisplayMenu(string[] menu, int selectedMenu)
    {
        for(int i = 0; i < menu.Length; i++)       
        {
            if (i == selectedMenu)
            {
                //highlight
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                //get normal colors
                Console.ResetColor();        
            }
            //display menu horizontaly
            Console.Write(menu[i] + "      ");

        }

        Console.ResetColor();
        Console.WriteLine();

    }

}