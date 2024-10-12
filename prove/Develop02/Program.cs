using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();


        while (true)
        {
            Menu();
            Console.Write("What would you like to do? ");
            int number = int.Parse(Console.ReadLine());

            Entry entry1 = new Entry();

            if (number == 1)
            {
                PromptGenerator prompt1 = new PromptGenerator();
                string randomPrompt = prompt1.GetRandomPrompt();
                //Console.WriteLine(randomPrompt);
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry1._date = dateText;
                entry1._promptText = randomPrompt;
                Console.Write(entry1._promptText);
                Console.Write("\n> ");
                entry1._entryText = Console.ReadLine();
                entry1.Display();
                journal.AddEntry(entry1);
            }
            else if (number == 2)
            {
                journal.DisplayAll();
            }
            else if (number == 3)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (number == 4)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else
            {
                break;
            }
        }
    }

    public static void Menu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
}