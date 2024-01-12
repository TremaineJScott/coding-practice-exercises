# C# Exception Handling Exercises

## Exercise 1: Basic Exception Handling
**Objective**: Familiarize with basic `try-catch` structure.
- **Task**: Write a program that asks the user to input a number and converts it to an integer using `int.Parse()`. Use a `try-catch` block to catch a `FormatException` if the user inputs a non-numeric string.

## Exercise 2: Handling Multiple Exceptions
**Objective**: Learn to handle different types of exceptions.
- **Task**: Expand the previous program to also catch an `OverflowException` that occurs if the user inputs a number too large for an integer. Provide different error messages for each exception type.

## Exercise 3: Nested Try-Catch Blocks
**Objective**: Understand the concept of nested `try-catch` blocks.
- **Task**: Create a nested `try-catch` block where the inner block handles a `DivideByZeroException` (e.g., dividing a number by zero) and the outer block handles any other exceptions.

## Exercise 4: Using `finally`
**Objective**: Practice using the `finally` block.
- **Task**: Write a program that opens and reads a file using `StreamReader`. Implement a `try-catch-finally` block to handle any IO exceptions and ensure the file is closed in the `finally` block.

## Exercise 5: Specific vs General Exception Handling
**Objective**: Distinguish between specific and general exception handling.
- **Task**: Create a program that generates different types of exceptions (e.g., `NullReferenceException`, `IndexOutOfRangeException`). Use multiple `catch` blocks to handle each specific exception and an additional general `catch` block to handle any unexpected exceptions.

## Exercise 6: Exception Re-throwing
**Objective**: Practice re-throwing exceptions.
- **Task**: Write a function that catches an exception, logs a message, and then re-throws the exception. Call this function within a `try` block in your `Main` method and handle the re-thrown exception there.
