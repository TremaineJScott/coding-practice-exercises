// For Loop Exercises

// 1. Sum of Numbers
int sum = 0;
for (int i = 1; i <= 100; i++)
{
    sum += i;
}
Console.WriteLine("Sum of numbers from 1 to 100: " + sum);

// 2. Countdown
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("Liftoff!");

// 3. Alphabet Printing
for (char letter = 'A'; letter <= 'Z'; letter++)
{
    Console.Write(letter + " ");
}
Console.WriteLine();

// While Loop Exercises

// 1. Guess the Number
int targetNumber = 7; // Predetermined number
int guess;
do
{
    Console.Write("Guess the number: ");
    guess = int.Parse(Console.ReadLine());
} while (guess != targetNumber);
Console.WriteLine("Correct!");

// 2. Accumulate User Input
int total = 0, number;
do
{
    Console.Write("Enter a number (0 to stop): ");
    number = int.Parse(Console.ReadLine());
    total += number;
} while (number != 0);
Console.WriteLine("Total sum: " + total);

// 3. Factorial Calculation
Console.Write("Enter a number to calculate factorial: ");
int n = int.Parse(Console.ReadLine());
long factorial = 1;
while (n > 1)
{
    factorial *= n;
    n--;
}
Console.WriteLine("Factorial: " + factorial);

// Do While Loop Exercises

// 1. Input Validation
int positiveNumber;
do
{
    Console.Write("Enter a positive integer: ");
    positiveNumber = int.Parse(Console.ReadLine());
} while (positiveNumber <= 0);
Console.WriteLine("You entered: " + positiveNumber);

// 2. Post-Counting
int counter = 1;
do
{
    Console.WriteLine(counter);
    counter++;
} while (counter <= 5);

// 3. Reverse String
Console.Write("Enter a string to reverse: ");
string inputString = Console.ReadLine();
string reversedString = "";
int stringLength = inputString.Length - 1;
do
{
    reversedString += inputString[stringLength];
    stringLength--;
} while (stringLength >= 0);
Console.WriteLine("Reversed string: " + reversedString);

// Nested Loops Exercises

// 1. Multiplication Table
for (int row = 1; row <= 10; row++)
{
    for (int column = 1; column <= 10; column++)
    {
        Console.Write(row * column + "\t");
    }
    Console.WriteLine();
}

// 2. Pattern Printing
int rows = 5; // Number of rows for the pattern
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
