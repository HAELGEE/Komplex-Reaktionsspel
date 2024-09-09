using Microsoft.VisualBasic;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Komplex_Reaktionsspel;

public class Program
{
    static void Main(string[] args)
    {        
        bool loop = true;
        while (loop)
        {
            int choice = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Program to check your respons time.");
            Console.WriteLine("Please make a choice");
            Console.WriteLine("1 - Start game");
            Console.WriteLine("2 - Highscore");
            Console.WriteLine("3 - Quit");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            } 
            catch
            {
                Console.WriteLine("You need to use letters, Try again!");
                Console.ReadKey();
            }            
            
            switch (choice)
            {
                case 1:
                    {
                        Game game = new Game();
                        game.Start();
                        break;
                    }


                case 2:
                    {
                        Game highscore = new Game();
                        highscore._Highscore();
                        break;
                    }

                    case 3:
                    {
                        Console.WriteLine("The program is now Ending, have a Nice day!");
                        loop = false;
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid choice.");
                        Console.ReadKey();
                        break;
                    }

            }
        }
    }
}
