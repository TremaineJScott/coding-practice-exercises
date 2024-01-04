# Employee Directory
Concepts: Storing Data in Arrays, Manipulating Strings

Task: Develop a program that manages basic information about employees in a company and allows users to retrieve this information in a user-friendly manner.

## Application Behavior:
- Create 3 arrays to store information about employees: one with their full names, one with their departments, and one with their job titles.
- Prompt the user to select an employee by number. Convert the input to an integer and use it as the index for the arrays to print the employee's name.
- Ask the user which category of information to display: "Department" or "Job Title". Display the corresponding information.
- After displaying the information, ask the user if they want to look up another employee.

## Application Requirements:
- Validate user input for employee number: Check if the number is within the valid range (1 to the length of the arrays). If not, display a polite error message and prompt for input again.
- Validate information category: Allow the user to enter either "Department" or "Job Title". If the input is invalid, show an error message and ask again. Consider allowing flexible input like just "Department" or the full phrase "Employee Department".
- Use array length: Utilize the Length property of the arrays in your validation logic instead of using hardcoded values.

## Tips:
- Ensure all arrays are of the same length.
- Adjust the user's input number to match array indexing (subtract 1 from the input number).
- To validate the category, you might first write a separate program to test string comparison with flexibility (case-insensitivity, partial matches) and then integrate this into your main program.
- Provide clear instructions to the user about how to use the application and what information is available.
- Use appropriate language and grammar in your user prompts to ensure clarity and politeness.

## Challenge Yourself:
- Implement a feature to display a list of all employees when requested.
- Allow searching for an employee by name. This might require additional string manipulation and search logic.
- Enhance the flexibility of the category input, allowing for variations in case and partial strings (e.g., accepting both "Title" and "Job Title").
