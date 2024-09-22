using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();

        int numberListed = -1;

        while (numberListed != 0)
        {
            Console.Write("Enter number: ");
            string numberEntered = Console.ReadLine();
            numberListed = int.Parse(numberEntered);

            if (numberListed != 0){
                numbers.Add(numberListed);
            }
        }
        
        int sum =0;
        
        foreach (int number in numbers)
        {
            sum += sum; 
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float) sum) / numbers.Count; 
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");        
    }
}