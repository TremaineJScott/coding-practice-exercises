# NUMBER GUESSING GAME
Concepts: Control Flow and User Input

Task: Create an application that simulates a number guessing game.

## Application Behavior
- The application asks the user to enter a range (for example, between 1 and 100).
- If you have learned about exception handling, make sure the user can only enter valid numbers.
- The application then internally selects a number within this range (you can hardcode this number for simplicity).
- The user is prompted to guess the number.
- The application informs the user if the guess is too high, too low, or correct.
- After the correct guess, the application congratulates the user and displays the number of attempts taken.
- The application asks the user if they want to play again.

## Application Requirements:
1. **User Input for Range**: Ensure the application takes the range input correctly.
2. **Number Selection**: Create a method that accepts the range and returns a selected number within this range.
3. **User Guessing**: Create a method that processes the user's guess and returns feedback ("Too High", "Too Low", "Correct").
4. **Attempt Tracking**: The application should keep track of the number of attempts the user makes.
5. **Game Loop**: Application should allow the user to play again with a new number without restarting the application.

## Tips:
- You can use a fixed number to test the application's logic before implementing a random number generator.
- Utilize loops for handling user guesses and restarting the game.
- Implement input validation to ensure the user enters valid guesses.

## Challenge Yourself:
- Implement functionality to give the user a hint after every few incorrect guesses (e.g., "The number is even" or "The number is a multiple of 3").
- Add a difficulty setting that influences the range or the number of attempts the user has to guess the number.
