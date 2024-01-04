static void Main(string[] args)
{
    string[] employeeNames = { "Alice Johnson", "Bob Smith", "Charlie Davis" };
    string[] departments = { "Human Resources", "IT", "Marketing" };
    string[] jobTitles = { "HR Manager", "Software Developer", "Marketing Specialist" };

    bool continueLookup = true;
    while (continueLookup)
    {
        Console.WriteLine("Please enter the employee number (1 to " + employeeNames.Length + "):");
        int employeeNumber;
        bool isValidNumber = int.TryParse(Console.ReadLine(), out employeeNumber) && employeeNumber > 0 && employeeNumber <= employeeNames.Length;

        while (!isValidNumber)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and " + employeeNames.Length + ".");
            isValidNumber = int.TryParse(Console.ReadLine(), out employeeNumber) && employeeNumber > 0 && employeeNumber <= employeeNames.Length;
        }

        int employeeIndex = employeeNumber - 1;
        Console.WriteLine("Employee: " + employeeNames[employeeIndex]);

        Console.WriteLine("What information would you like to know? Type 'Department' or 'Job Title':");
        string infoChoice = Console.ReadLine().ToLower();

        while (infoChoice != "department" && infoChoice != "job title")
        {
            Console.WriteLine("Invalid input. Please type 'Department' or 'Job Title':");
            infoChoice = Console.ReadLine().ToLower();
        }

        if (infoChoice == "department")
        {
            Console.WriteLine("Department: " + departments[employeeIndex]);
        }
        else if (infoChoice == "job title")
        {
            Console.WriteLine("Job Title: " + jobTitles[employeeIndex]);
        }

        Console.WriteLine("Would you like to look up another employee? (yes/no)");
        continueLookup = Console.ReadLine().ToLower() == "yes";
    }
}
