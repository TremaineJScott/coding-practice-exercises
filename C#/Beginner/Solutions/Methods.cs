static void Main(string[] args)
{
    // Exercise Set 1: Method Types

    DisplayGreeting();

    int currentYear = GetCurrentYear();
    Console.WriteLine("Current Year: " + currentYear);

    PrintSum(5, 10);

    int product = Multiply(6, 7);
    Console.WriteLine("Product: " + product);

    // Exercise Set 2: REF and OUT Parameters

    int numberToDouble = 5;
    DoubleNumber(ref numberToDouble);
    Console.WriteLine("Doubled Number: " + numberToDouble);

    string testString = "Hello, World!";
    GetStringLength(testString, out int length);
    Console.WriteLine("Length of '" + testString + "': " + length);

    // Exercise Set 3: Methods Calling Other Methods

    AskForName();

    int squareOfSumResult = SquareOfSum(4, 3);
    Console.WriteLine("Square of Sum: " + squareOfSumResult);

    // Exercise Set 4: Method Overloading

    PrintSum(7, 8); // Two integers
    PrintSum(1, 2, 3); // Three integers
    PrintSum(2.5, 3.5); // Two doubles

    Display("Hello");
    Display(123);
}

// Exercise Set 1 Implementations

static void DisplayGreeting()
{
    Console.WriteLine("Hello, World!");
}

static int GetCurrentYear()
{
    return DateTime.Now.Year;
}

static void PrintSum(int a, int b)
{
    Console.WriteLine($"Sum: {a + b}");
}

static int Multiply(int a, int b)
{
    return a * b;
}

// Exercise Set 2 Implementations

static void DoubleNumber(ref int number)
{
    number *= 2;
}

static void GetStringLength(string str, out int length)
{
    length = str.Length;
}

// Exercise Set 3 Implementations

static void GreetUser(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

static void AskForName()
{
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
    GreetUser(name);
}

static int SquareOfSum(int a, int b)
{
    int sum = a + b;
    return sum * sum;
}

// Exercise Set 4 Implementations

static void PrintSum(int a, int b, int c)
{
    Console.WriteLine($"Sum: {a + b + c}");
}

static void PrintSum(double a, double b)
{
    Console.WriteLine($"Sum: {a + b}");
}

static void Display(string message)
{
    Console.WriteLine("String: " + message);
}

static void Display(int number)
{
    Console.WriteLine("Integer: " + number);
}
