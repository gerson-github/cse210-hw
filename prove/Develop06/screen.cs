using System;
public class Screen 
{
    public void ShowHeader(int score)
    {
        Console.Clear();
        Console.WriteLine($"Date: {DateTime.Now.ToShortDateString()}");

        // Using a verbatim string
        Console.WriteLine(@"


   _____      _                                                
  / ____|    | |                                               
 | (___   ___| |_                                              
  \___ \ / _ \ __|             _____  ____          _        _ 
  ____) |  __/ |_             / ____|/ __ \   /\   | |      | |
 |_____/ \___|\__|   _ _ __  | |  __| |  | | /  \  | |      | |
    | | | |/ _ \| | | | '__| | | |_ | |  | |/ /\ \ | |      | |
    | |_| | (_) | |_| | |    | |__| | |__| / ____ \| |____  |_|
     \__, |\___/ \__,_|_|     \_____|\____/_/    \_\______| (_)
      __/ |                                                    
     |___/   


         ");

        Console.WriteLine($"\nYou have {score} points.\n");
    
    }


}