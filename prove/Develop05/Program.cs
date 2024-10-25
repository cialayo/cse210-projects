using System;
using System.ComponentModel.Design;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Menu();
            Console.Write("Select a choice from the menu: ");
            int chosenActivity = int.Parse(Console.ReadLine());
            Console.Clear();
            if (chosenActivity == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (chosenActivity == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (chosenActivity == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else
            {
                Console.Clear();
                break;
            }
        }

    }
    public static void Menu()
    {
        Console.WriteLine("Welcome to the Minfulness App!");
        Console.WriteLine("");
        Console.WriteLine("Menu Options");
        Console.WriteLine("  1.Start breathing activity");
        Console.WriteLine("  2.Start reflecting activity");
        Console.WriteLine("  3.Start listing activity");
        Console.WriteLine("  4.Quit");
    }
}