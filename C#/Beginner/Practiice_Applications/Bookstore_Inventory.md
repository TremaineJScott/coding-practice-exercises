# Bookstore Inventory
Concepts: Generic Collections, Basic Data Aggregation

Task: Develop a bookstore inventory management application that uses collections to track books and their quantities.

## Appication Behavior
- Display a list of at least 10 book titles along with their prices and available quantities.
- Prompt the user to enter a book title.
- If the book exists, display the book title, price, and decrease the quantity available by 1.
- If the book doesn’t exist or is out of stock, display an error and re-prompt the user.
- After choosing a book, ask if the user wants to pick another. If so, repeat the process.
- When the user is done, display a summary of all chosen books with their prices.
- Display the total cost of all books selected.

## Application Requirements
- Application uses a `Dictionary<string, (decimal price, int quantity)>` to keep track of the inventory. Initialize it with book names as keys and price-quantity tuples as values.
- Use a `List<string>` to store the titles of the books the customer has picked.
- Application takes book title input and:
  - Responds if that book doesn’t exist or is out of stock.
  - Decreases the quantity in the inventory and adds the book title to the shopping list if available.
- Application asks the user if they want to continue or quit, and loops accordingly.
- Application displays a list of chosen books with their prices at the end.
- Application calculates and displays the total cost of all selected books.

## Challenge Yourself:
- Implement a menu system so the user can select books using numbers or short codes.
- Display the most popular book based on the number of times it was selected.
- Allow users to return a book, increasing its quantity in the inventory.
- Show a summary report of remaining inventory after the user is done.
