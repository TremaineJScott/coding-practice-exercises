// if...else Exercises

// Exercise 1
if (DateTime.Now.Hour < 12)
    Console.WriteLine("Good morning!");
else
    Console.WriteLine("Good afternoon!");

// Exercise 2
int number = 4; // Example number
if (number % 2 == 0)
    Console.WriteLine("Even");
else
    Console.WriteLine("Odd");

// Exercise 3
int age = 15; // Example age
if (age < 13)
    Console.WriteLine("Child");
else if (age >= 13 && age <= 19)
    Console.WriteLine("Teenager");
else
    Console.WriteLine("Adult");

// Exercise 4
int temperature = 32; // Example temperature
if (temperature > 30)
    Console.WriteLine("It's a hot day");
else
    Console.WriteLine("It's a pleasant day");

// Exercise 5
char character = 'a'; // Example character
if ("aeiouAEIOU".IndexOf(character) >= 0)
    Console.WriteLine("Vowel");
else
    Console.WriteLine("Consonant");

// if...else if...else Exercises

// Exercise 1
int grade = 85; // Example grade
if (grade < 60)
    Console.WriteLine("Failing");
else if (grade >= 60 && grade <= 70)
    Console.WriteLine("Passing");
else if (grade > 70 && grade <= 80)
    Console.WriteLine("Good");
else if (grade > 80 && grade <= 90)
    Console.WriteLine("Very Good");
else
    Console.WriteLine("Excellent");

// Exercise 2
char size = 'M'; // Example size
if (size == 'S')
{
    Console.WriteLine("Small");
}
else if (size == 'M')
{
    Console.WriteLine("Medium");
}
else if (size == 'L')
{
    Console.WriteLine("Large");
}
else if (size == 'X')
{
    Console.WriteLine("Extra Large");
}
else
{
    Console.WriteLine("Invalid size");
}

// Exercise 3
int birthYear = 1980; // Example birth year
if (birthYear >= 1997)
    Console.WriteLine("Gen Z");
else if (birthYear >= 1981)
    Console.WriteLine("Millennials");
else if (birthYear >= 1965)
    Console.WriteLine("Gen X");
else
    Console.WriteLine("Boomers");

// Exercise 4
// Reusing 'age' variable from previous example
if (age <= 2)
    Console.WriteLine("Infant");
else if (age <= 4)
    Console.WriteLine("Toddler");
else if (age <= 12)
    Console.WriteLine("Child");
else if (age <= 19)
    Console.WriteLine("Teenager");
else if (age <= 65)
    Console.WriteLine("Adult");
else
    Console.WriteLine("Elder");

// Exercise 5
string domain = "edu"; // Example domain
if (domain == "com")
{
    Console.WriteLine("Commercial");
}
else if (domain == "org")
{
    Console.WriteLine("Organization");
}
else if (domain == "net")
{
    Console.WriteLine("Network");
}
else if (domain == "edu")
{
    Console.WriteLine("Educational");
}
else
{
    Console.WriteLine("Unknown domain");
}

// Ternary Operator Exercises

// Exercise 1
bool isAdult = age >= 18 ? true : false;
Console.WriteLine("Is adult: " + isAdult);

// Exercise 2
int numberToCheck = -5; // Example number
string numberType = numberToCheck > 0 ? "Positive" : numberToCheck < 0 ? "Negative" : "Zero";
Console.WriteLine("Number is: " + numberType);

// Exercise 3
int testScore = 75; // Example score
string result = testScore >= 50 ? "Pass" : "Fail";
Console.WriteLine("Result: " + result);

// Exercise 4
int hoursSlept = 7; // Example hours
string wellRested = hoursSlept >= 8 ? "Yes" : "No";
Console.WriteLine("Well rested: " + wellRested);

// Exercise 5
bool isDaytime = DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 18; // Daytime check
string greeting = isDaytime ? "Good day" : "Good evening";
Console.WriteLine(greeting);

// Switch Statement Exercises

// Exercise 1
int month = 7; // Example month
switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Winter");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Spring");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Summer");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Fall");
        break;
}

// Exercise 2
int num1 = 10, num2 = 5; // Example numbers
char operation = '+'; // Example operation
switch (operation)
{
    case '+':
        Console.WriteLine($"Result: {num1 + num2}");
        break;
    case '-':
        Console.WriteLine($"Result: {num1 - num2}");
        break;
    case '*':
        Console.WriteLine($"Result: {num1 * num2}");
        break;
    case '/':
        Console.WriteLine($"Result: {num1 / num2}");
        break;
}

// Exercise 3
int statusCode = 404; // Example status code
switch (statusCode)
{
    case 200:
        Console.WriteLine("OK");
        break;
    case 404:
        Console.WriteLine("Not Found");
        break;
    case 500:
        Console.WriteLine("Internal Server Error");
        break;
}

// Exercise 4
char exampleChar = 'A'; // Example character
switch (char.IsUpper(exampleChar))
{
    case true:
        Console.WriteLine("Uppercase Letter");
        break;
    case false:
        if (char.IsLower(exampleChar))
            Console.WriteLine("Lowercase Letter");
        else if (char.IsDigit(exampleChar))
            Console.WriteLine("Digit");
        else
            Console.WriteLine("Special Character");
        break;
}

// Exercise 5
int dayNum = 3; // Example day number
switch (dayNum)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid day number");
        break;
}

