static void Main(string[] args)
{
    bool playAgain;
    do
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");

        // User Input for Range
        Console.Write("Enter the minimum number for the range: ");
        int minRange = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the maximum number for the range: ");
        int maxRange = Convert.ToInt32(Console.ReadLine());

        // Number Selection
        int numberToGuess = SelectNumber(minRange, maxRange);
        int numberOfAttempts = 0;
        int userGuess;
        bool correctGuess = false;

        // Game Loop for Guessing
        do
        {
            Console.Write("Guess the number: ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            numberOfAttempts++;

            // User Guessing
            string feedback = ProcessGuess(userGuess, numberToGuess);
            Console.WriteLine(feedback);

            if (feedback == "Correct!")
            {
                correctGuess = true;
                Console.WriteLine($"Congratulations! You guessed the number in {numberOfAttempts} attempts.");
            }

        } while (!correctGuess);

        // Play Again
        Console.Write("Do you want to play again? (yes/no): ");
        playAgain = Console.ReadLine().ToLower() == "yes";

    } while (playAgain);

    Console.WriteLine("Thank you for playing!");
}

static int SelectNumber(int min, int max)
{
    // For simplicity, returning a hardcoded number.
    // This can be replaced with a random number generation logic.
    return 42; // Assuming 42 is within the range
}

static string ProcessGuess(int guess, int target)
{
    if (guess < target) return "Too Low";
    if (guess > target) return "Too High";
    return "Correct!";
}
