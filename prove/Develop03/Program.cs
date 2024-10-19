using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Formats.Asn1;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to the Scripture Memorizer Program");
        Console.Write("Please enter the reference book's reference:   ");
        string book = Console.ReadLine();
        Console.Write("Please enter the chapter: ");
        int chapter = int.Parse(Console.ReadLine());
        Console.Write("Please enter the intial verse: ");
        int initialVerse = int.Parse(Console.ReadLine());

        Reference reference = new Reference(book, chapter, initialVerse);

        Console.Write("Please enter the scripture: ");
        string text = Console.ReadLine();

        Scripture scripture = new Scripture(reference, text);

        Console.Clear();

        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string answer = Console.ReadLine();
            if (answer == "quit")
            {
                break;
            }
            else
                Console.Clear();
            scripture.HideRandomWords(3);
            scripture.GetDisplayText();
            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }

        }
        Console.Clear();
    }
}