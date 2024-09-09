using System.ComponentModel;
using System.Reflection.Emit;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace Komplex_Reaktionsspel;

public class Game
{

    public int result { get; set; }      
    public double seconds { get; set; }
    public string name { get; set; }
    public static List<int> highscores = new List<int>();
    public static List<string> names = new List<string>();   
    

    public void Start()
    {   
        Center center = new Center();        

        center._Center();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Random random = new Random();

        //Creates an interval between 3second and 10seconds
        int interval = random.Next(3000, 10000);
        
        

        Console.WriteLine("So are you ready?");
        center._Center();
        Console.WriteLine("Press any key to start.");
        

        Console.ReadKey();
        Console.Clear();
        center._Center();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("OK");

        center._Center();        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Thread.Sleep(interval);
        Console.WriteLine("Get ready....");

        Thread.Sleep(interval);        
        int start = Environment.TickCount;
        Console.Clear();
        center._Center();        
        Console.ForegroundColor = ConsoleColor.Green;
        
        Console.WriteLine("NOW");
        Console.ReadKey();
        int end = Environment.TickCount;

        Console.Clear();
        int centerX = Console.WindowWidth / 2;
        int centerY = Console.WindowHeight / 2;
        Console.SetCursorPosition(centerX - 30, centerY);
        Console.ForegroundColor = ConsoleColor.Magenta;
        this.result = end - start;
        this.seconds = this.result / 1000.0;
        Console.WriteLine($"Your respons time was: {this.result} milliseconds and {this.seconds} seconds");
        Console.ReadKey();

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Do you want to save this result? Y/N");
        string save = Console.ReadLine().ToUpper();
        

        while (true)
        {
            if (save == "Y")
            {
                Console.WriteLine("Do you want to add name after the result? Y/N");
                string save1 = Console.ReadLine().ToUpper();

                while (true)
                {
                    if (save1 == "Y")
                    {
                        Console.Write("What is the name u want to add to the score?: ");
                        names.Add(this.name = Console.ReadLine());                        
                        highscores.Add(this.result);
                        break;
                    }
                    else if (save1 == "N")
                    {
                        Console.WriteLine("The result saves without name.");
                        names.Add(this.name = Console.ReadLine());
                        highscores.Add(this.result);
                        break;
                    }                    
                    else
                    {
                        Console.WriteLine("Something went wrong, try again.");                        
                        save1 = Console.ReadLine().ToUpper();                        
                    }
                }
                break;
            }
            else if (save == "N")
            {
                Console.WriteLine("Your result will not save!");
                break;
            }
            else
            {
                Console.WriteLine("Something went wrong, try again.");               
                save = Console.ReadLine().ToUpper();                
            }
        }       
    }
    public void _Highscore()
    {
       


        Console.Clear();
        if (highscores.Count == 0)
        {
            Console.WriteLine("No highscores yet.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("========= ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("HIGHSCORE");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" =========\n");

            Console.ForegroundColor= ConsoleColor.Blue;
            for (int i = 0; i < highscores.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {highscores[i]} milliseconds, made by {names[i]}");
            }
        }
        Console.ReadKey();
    }

    //Game created by Christofer (HAELGE) Hägg
}