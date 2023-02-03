using ShoppingList;

Dictionary<string, decimal> prices = new Dictionary<string, decimal>()
    {
        { "apple", 0.99m },
        { "banana", 0.59m },
        { "milk", 2.99m },
        { "bread", 1.99m },
        { "cheese", 4.99m },
        { "chicken", 7.99m },
        { "eggs", 2.99m },
        { "potato", 0.89m }
    };

Console.WriteLine("Welcome to Schmalz's Market!\n");

Methods.DisplayGroceries(prices);


string response = "yes";
List<string> receipt = new List<string>();
while (response == "yes")
{
    Console.Write("\nEnter the name of the item you'd like to order: ");
    string item = Console.ReadLine();

    if (prices.ContainsKey(item))
    {
        receipt.Add(item);
        Console.WriteLine($"\nAdding {item} to cart at ${prices[item]}");
    }
    else
    {
        Console.WriteLine("\nSorry, we don't have those. Please try again.");
    }

    Console.Write("\nWould you like to order another item? (yes/no): ");
    response = Console.ReadLine();
}

decimal sum = 0;
Console.WriteLine("\nThanks for your order!");
Console.WriteLine("Here's what you got:");
Console.WriteLine("\nItem\tPrice");
Console.WriteLine("----------------");

foreach (string item in receipt)
{
    sum += prices[item];
    Console.WriteLine($"{item}\t${prices[item]}");
}

Console.WriteLine($"\nYour total is ${sum}");
Console.WriteLine("\nThank you for visiting Schmalz's Market!.");