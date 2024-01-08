
static void Main()
{
    // Dictionary to store word-meaning pairs
    Dictionary<string, string> dictionary = new Dictionary<string, string>();

    Console.WriteLine("Word Meaning Dictionary");
    Console.WriteLine("Enter a word and its meaning (or 'exit' to stop):");

    // Input loop for words and meanings
    while (true)
    {
        string input = Console.ReadLine();

        if (input.ToLower() == "exit")
            break;

        string[] parts = input.Split(" - ");
        if (parts.Length != 2)
        {
            Console.WriteLine("Invalid format. Please enter in 'Word - Meaning' format.");
            continue;
        }

        string word = parts[0].Trim();
        string meaning = parts[1].Trim();

        if (!dictionary.ContainsKey(word))
        {
            dictionary.Add(word, meaning);
        }
        else
        {
            Console.WriteLine($"The word '{word}' is already in the dictionary.");
        }
    }

    Console.WriteLine("\nEnter a word to get its meaning (or 'exit' to stop):");

    // Query loop
    while (true)
    {
        string query = Console.ReadLine();

        if (query.ToLower() == "exit")
            break;

        if (dictionary.TryGetValue(query, out string meaning))
        {
            Console.WriteLine($"Meaning: {meaning}");
        }
        else
        {
            Console.WriteLine($"The word '{query}' was not found in the dictionary.");
        }

        Console.WriteLine("\nEnter another word to get its meaning (or 'exit' to stop):");
    }

    Console.WriteLine("Exiting the program.");
}

