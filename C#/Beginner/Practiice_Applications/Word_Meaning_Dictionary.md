### Exercise: Word Meaning Dictionary

Write a program that takes words and their meanings as input from the user and stores them in a dictionary. Then, allow the user to input a word and display its meaning.

#### Objective
- To create a user-interactive C# console application.
- Practice using dictionaries to store and retrieve data.
- Enhance understanding of user input handling in C#.

#### Requirements
- Prompt the user to enter a set of words and their meanings.
- Store each word and its meaning in a dictionary.
- Allow the user to input a word and then display its meaning.
- Handle cases where the entered word is not in the dictionary.

#### Example Output
Enter a word and its meaning (or 'exit' to stop): Apple - A fruit
Enter a word and its meaning (or 'exit' to stop): Book - A set of printed pages
Enter a word and its meaning (or 'exit' to stop): exit

Enter a word to get its meaning: Apple
Meaning: A fruit

Enter a word to get its meaning: exit
Exiting the program.


#### Implementation Tips
- Use a loop to continuously prompt the user for words and meanings until they type 'exit'.
- Use a dictionary to store the word-meaning pairs.
- When the user enters a word to find its meaning, check if the word exists in the dictionary.
- If the word exists, display the meaning. If not, inform the user that the word was not found.
- Ensure to handle cases with appropriate messages for better user experience.
