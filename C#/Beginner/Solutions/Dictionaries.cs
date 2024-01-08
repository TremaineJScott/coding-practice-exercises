
// Creating the phone book dictionary
Dictionary<string, string> phoneBook = new Dictionary<string, string>()
{
    {"Alice", "123-456-7890"},
    {"Bob", "234-567-8901"},
    {"Charlie", "345-678-9012"},
    {"David", "456-789-0123"},
    {"Eve", "567-890-1234"}
};

// Updating a number
phoneBook["Alice"] = "111-222-3333";

// Removing an entry
phoneBook.Remove("Eve");

// Printing out the entire phone book
foreach (var entry in phoneBook)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}

// Creating a dictionary to store product prices
Dictionary<string, double> productPrices = new Dictionary<string, double>()
{
    {"Bread", 2.99},
    {"Milk", 1.50},
    {"Eggs", 3.20},
    {"Cheese", 4.99},
    {"Butter", 1.49}
};

// Shopping list
List<string> shoppingList = new List<string> {"Bread", "Milk", "Eggs"};

// Calculating total price
double totalPrice = CalculateTotalPrice(shoppingList, productPrices);
Console.WriteLine("Total Price: $" + totalPrice);

// Example string
string exampleString = "hello world";

// Counting the frequency of each character
Dictionary<char, int> frequency = new Dictionary<char, int>();
foreach (char c in exampleString)
{
    if (!frequency.ContainsKey(c))
    {
        frequency[c] = 0;
    }
    frequency[c]++;
}

// Sorting and displaying the frequencies in descending order
foreach (var item in frequency.OrderByDescending(kvp => kvp.Value))
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}


static double CalculateTotalPrice(List<string> shoppingList, Dictionary<string, double> productPrices)
{
    double total = 0;
    foreach (string item in shoppingList)
    {
        if (productPrices.TryGetValue(item, out double price))
        {
            total += price;
        }
    }
    return total;
}
