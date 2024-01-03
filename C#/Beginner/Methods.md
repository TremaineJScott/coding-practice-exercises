# Methods Exercises

This document contains exercises designed to practice creating and using methods in C#. The exercises cover various types of methods including those with different return types, parameter types, as well as method overloading and methods calling other methods.

## Exercise Set 1: Method Types

1. **Void Method, No Parameters**: Create a method named `DisplayGreeting` that prints "Hello, World!" to the console. This method should not return any value and should not take any parameters.
   
2. **Method with Return Type, No Parameters**: Write a method named `GetCurrentYear` that returns the current year as an integer. This method should not take any parameters.
   
3. **Void Method, Two Parameters**: Create a method named `PrintSum` that takes two integers as parameters and prints their sum. The method should not return any value.
   
4. **Method with Return Type, Two Parameters**: Write a method named `Multiply` that takes two integers as parameters and returns their product.

## Exercise Set 2: REF and OUT Parameters

1. **Method with REF Parameter**: Write a method named `DoubleNumber` that doubles the value of a number passed to it using a `ref` parameter.

2. **Method with OUT Parameter**: Create a method named `GetStringLength` that takes a string as input and uses an `out` parameter to return the length of the string.

## Exercise Set 3: Methods Calling Other Methods

1. **Call a Method Within Another**: Create two methods - `GreetUser` which takes a name and prints a greeting, and `AskForName` which asks the user for their name and then calls `GreetUser`.
   
2. **Chain Multiple Methods**: Write a method named `SquareOfSum` that takes two integers, calls a method to find their sum, and then returns the square of this sum.

## Exercise Set 4: Method Overloading

1. **Overload a Method**: Overload the `PrintSum` method to handle three cases - taking two integers, taking three integers, and taking two doubles.
   
2. **Overload with Different Parameter Types**: Create an overloaded method `Display` which takes either a string or an integer and prints it to the console.

