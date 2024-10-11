using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string userName = DisplayUserName();
        int userNumber = DisplayUserNumber();
        int squaredNumber = SquareOfNumber(userNumber);

        SquaredNumberMessage(userName,squaredNumber);
    }
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string DisplayUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int DisplayUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int SquareOfNumber(int number)
    {
        int square = number * number;

        return square;
    }
    static void SquaredNumberMessage(string name, int square )
    {
        string message = $"{name}, the square of your number is {square}";
        Console.WriteLine(message);
    }
}