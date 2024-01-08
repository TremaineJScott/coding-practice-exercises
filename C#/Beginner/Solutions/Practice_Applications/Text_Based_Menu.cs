static void Main()
{
    // Dictionary to hold menu options and corresponding actions
    Dictionary<string, Action> menuOptions = new Dictionary<string, Action>
    {
        { "1", Option1 },
        { "2", Option2 },
        { "3", Option3 },
        { "4", Option4 },
        { "Exit", ExitProgram }
    };

    while (true)
    {
        DisplayMenu();
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        if (menuOptions.TryGetValue(choice, out Action action))
        {
            action();
        }
        else
        {
            Console.WriteLine("Invalid option, please try again.\n");
        }
    }
}

static void DisplayMenu()
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Option 1");
    Console.WriteLine("2. Option 2");
    Console.WriteLine("3. Option 3");
    Console.WriteLine("4. Option 4");
    Console.WriteLine("Exit. Exit Program");
    Console.WriteLine();
}

static void Option1()
{
    Console.WriteLine("Executing Option 1...\n");
    // Add the functionality for Option 1
}

static void Option2()
{
    Console.WriteLine("Executing Option 2...\n");
    // Add the functionality for Option 2
}

static void Option3()
{
    Console.WriteLine("Executing Option 3...\n");
    // Add the functionality for Option 3
}

static void Option4()
{
    Console.WriteLine("Executing Option 4...\n");
    // Add the functionality for Option 4
}

static void ExitProgram()
{
    Console.WriteLine("Exiting Program...");
    Environment.Exit(0);
}

