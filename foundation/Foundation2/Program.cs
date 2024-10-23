using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering Program");
        Console.WriteLine("***************************************");

        Order firstOrder = new Order(new Customer("Anne Smith", new Address("St John 123", "Logan", "Utah", "USA")));
        firstOrder.AddProducts(new Product(1111, "Book of Mormon", 13.5, 2));
        firstOrder.AddProducts(new Product(2222, "Diary", 10.1, 1));
        firstOrder.AddProducts(new Product(3333, "Erasable highlighter", 2.5, 3));
        Console.WriteLine("Packing Label:");
        string packingLabel = firstOrder.GetPackingLabel();
        Console.WriteLine(packingLabel);
        Console.WriteLine("--------------------------");
        string shippingLabel = firstOrder.GetShippingLabel();
        Console.WriteLine(shippingLabel);
        Console.WriteLine("--------------------------");
        Console.WriteLine($"The total price of the order is {firstOrder.ComputeTotalPrice():F2}");
        Console.WriteLine("***************************************");

        Order secondOrder = new Order(new Customer("Christopher Porter", new Address("St John 123", "Logan", "London", "England")));
        secondOrder.AddProducts(new Product(4444, "Hymns", 10.5, 1));
        secondOrder.AddProducts(new Product(5555, "Triple Combination", 11.05, 3));
        secondOrder.AddProducts(new Product(6666, "Holy Bible", 32.5, 2));
        Console.WriteLine("Packing Label:");
        string secondPackingLabel = secondOrder.GetPackingLabel();
        Console.WriteLine(packingLabel);
        Console.WriteLine("--------------------------");
        string secondShippingLabel = secondOrder.GetShippingLabel();
        Console.WriteLine(secondShippingLabel);
        Console.WriteLine("--------------------------");
        Console.WriteLine($"The total price of the order is {secondOrder.ComputeTotalPrice():F2}");
        Console.WriteLine("***************************************");




    }
}