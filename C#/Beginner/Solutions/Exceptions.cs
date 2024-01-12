static void Main(string[] args)
{
    // Exercise 1: Basic Exception Handling
    try
    {
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        Console.WriteLine($"You entered: {number}");
    }
    catch (FormatException)
    {
        Console.WriteLine("That's not a valid number!");
    }

    // Exercise 2: Handling Multiple Exceptions
    try
    {
        Console.Write("Enter a large number: ");
        string largeNumberInput = Console.ReadLine();
        int largeNumber = int.Parse(largeNumberInput);
        Console.WriteLine($"You entered: {largeNumber}");
    }
    catch (FormatException)
    {
        Console.WriteLine("That's not a valid number!");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number is too large!");
    }

    // Exercise 3: Nested Try-Catch Blocks
    try
    {
        try
        {
            Console.Write("Enter dividend: ");
            int dividend = int.Parse(Console.ReadLine());
            Console.Write("Enter divisor: ");
            int divisor = int.Parse(Console.ReadLine());
            int result = dividend / divisor;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }

    // Exercise 4: Using `finally`
    StreamReader reader = null;
    try
    {
        reader = new StreamReader("example.txt");
        string fileContent = reader.ReadToEnd();
        Console.WriteLine(fileContent);
    }
    catch (IOException ex)
    {
        Console.WriteLine($"IO error: {ex.Message}");
    }
    finally
    {
        reader?.Close();
    }

    // Exercise 5: Specific vs General Exception Handling
    try
    {
        object obj = null;
        string str = obj.ToString(); // NullReferenceException
        int[] arr = new int[5];
        int arrElement = arr[10]; // IndexOutOfRangeException
    }
    catch (NullReferenceException)
    {
        Console.WriteLine("Null reference encountered!");
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Index out of range!");
    }
    catch (Exception)
    {
        Console.WriteLine("An unexpected exception occurred.");
    }

    // Exercise 6: Exception Re-throwing
    try
    {
        ExceptionRethrowFunction();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception caught in Main: {ex.Message}");
    }
}

static void ExceptionRethrowFunction()
{
    try
    {
        // Simulate an exception
        throw new InvalidOperationException("Invalid operation occurred.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception caught and rethrown: {ex.Message}");
        throw;
    }
}

