using Microsoft.VisualBasic;

namespace Komplex_Reaktionsspel;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int interval = random.Next(3000, 10000);

        //int start = Environment.TickCount;
        //int end = Environment.TickCount;

        Console.WriteLine("Program to check your respons time.");
        Console.WriteLine("So are you ready?");
        Console.WriteLine("Press any key to start.");
        Console.ReadKey();
        
        Console.WriteLine("Ok ");
        
        Thread.Sleep(interval);        
        Console.WriteLine("Get ready....");

        
        Thread.Sleep(interval);
        int start = Environment.TickCount;
        Console.WriteLine("NOW");
        Console.ReadKey();
        int end = Environment.TickCount;

        double result = end - start;

        double seconds = result / 1000;

        Console.WriteLine($"Your respons time was: {result} milliseconds and {seconds} seconds");
    }
}
