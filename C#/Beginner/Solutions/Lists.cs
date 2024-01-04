static void Main(string[] args)
{
    // Exercise Set 1: Creating and Adding Elements

    // Initialize a List
    List<int> intList = new List<int> { 1, 2, 3, 4, 5 };

    // Add Elements
    List<string> stringList = new List<string> { "Apple", "Banana" };
    stringList.AddRange(new string[] { "Cherry", "Date" });

    // Combine Two Lists
    List<double> doubleList1 = new List<double> { 1.1, 1.2 };
    List<double> doubleList2 = new List<double> { 2.1, 2.2 };
    List<double> combinedDoubleList = new List<double>(doubleList1);
    combinedDoubleList.AddRange(doubleList2);

    // Exercise Set 2: Removing Elements

    // Remove Specific Element
    stringList.Remove("Banana");

    // Remove at Index
    intList.RemoveAt(2); // Removes the element at index 2

    // Clear All Elements
    combinedDoubleList.Clear();

    // Exercise Set 3: Querying Lists

    // Find Elements
    intList.ForEach(i => { if (i > 3) Console.WriteLine(i); });

    // Check Existence
    Console.WriteLine(stringList.Contains("Apple"));

    // Aggregate Operations
    double sum = doubleList1.Sum();
    Console.WriteLine(sum);

    // Exercise Set 4: Manipulating Lists

    // Reverse a List
    intList.Reverse();

    // Sort a List
    stringList.Sort();

    // Copy Elements
    List<int> newList = intList.GetRange(1, 2); // Copies a range of 2 elements starting at index 1

    // Exercise Set 5: Advanced Operations

    // Convert Array to List
    char[] charArray = { 'a', 'b', 'c' };
    List<char> charList = new List<char>(charArray);

    // Filter Elements
    List<int> filteredList = intList.FindAll(i => i % 2 == 0); // Find all even numbers

    // Custom Sorting
    doubleList1.Sort((a, b) => b.CompareTo(a)); // Sorts in descending order
}
