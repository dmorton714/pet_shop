using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Please follow the steps to enter items!");
        
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");

        
        while (true)
        {
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "exit")
                break;

            if (userInput == "1")
            {
                Console.WriteLine("Enter product details:");

                CatFood catFood = new CatFood();

                Console.WriteLine("Enter weight in pounds:");
                catFood.WeightPounds = double.Parse(Console.ReadLine());

                Console.WriteLine("Is it kitten food? (true/false):");
                catFood.KittenFood = bool.Parse(Console.ReadLine());

                Console.WriteLine("Product added:");
                Console.WriteLine(JsonSerializer.Serialize(catFood));
            }
            Console.WriteLine("Press 1 to add another product or type 'exit' to quit");
        }
    }
}

class Product
{
    string Name { get; set; }
    decimal Price { get; set; }
    int Qty { get; set; }
    string Description { get; set; }
}

class CatFood
{
    public double WeightPounds { get; set; } 
    public bool KittenFood { get; set; } 
}

class DogLeash
{
    int LengthInches { get; set; }
    string Material { get; set; }
}
