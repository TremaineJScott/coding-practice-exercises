static void Main(string[] args)
{
    Dictionary<string, (decimal price, int quantity)> inventory = new Dictionary<string, (decimal, int)>
    {
        ["Book A"] = (9.99m, 5),
        ["Book B"] = (12.99m, 3),
        ["Book C"] = (7.99m, 4),
        ["Book D"] = (15.99m, 2),
        ["Book E"] = (5.99m, 8),
        ["Book F"] = (17.99m, 1),
        ["Book G"] = (8.99m, 6),
        ["Book H"] = (10.99m, 2),
        ["Book I"] = (6.99m, 7),
        ["Book J"] = (14.99m, 3)
    };

    List<string> pickedBooks = new List<string>();
    decimal totalPrice = 0;

    bool continueShopping = true;
    while (continueShopping)
    {
        Console.WriteLine("\nAvailable Books:");
        foreach (var book in inventory)
        {
            Console.WriteLine($"{book.Key}: Price = {book.Value.price}, Quantity = {book.Value.quantity}");
        }

        Console.Write("\nEnter the name of the book you want to pick: ");
        string bookTitle = Console.ReadLine();

        if (inventory.ContainsKey(bookTitle) && inventory[bookTitle].quantity > 0)
        {
            inventory[bookTitle] = (inventory[bookTitle].price, inventory[bookTitle].quantity - 1);
            pickedBooks.Add(bookTitle);
            totalPrice += inventory[bookTitle].price;

            Console.WriteLine($"You picked {bookTitle}. Price: {inventory[bookTitle].price}");
        }
        else
        {
            Console.WriteLine("Book not available or out of stock.");
        }

        Console.Write("Do you want to pick another book? (yes/no): ");
        continueShopping = Console.ReadLine().ToLower() == "yes";
    }

    Console.WriteLine("\nBooks you picked:");
    foreach (string book in pickedBooks)
    {
        Console.WriteLine($"{book} - {inventory[book].price}");
    }

    Console.WriteLine($"Total cost: {totalPrice:C}");
}
