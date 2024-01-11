static void Main()
{
    // Exercise Set 1: Basics of LINQ

    // 1. Create a Number List
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    var allNumbers = numbers.Select(n => n);
    Console.WriteLine("All Numbers: " + string.Join(", ", allNumbers));

    // 2. String Array to List
    string[] duplicatedStrings = { "apple", "banana", "apple", "cherry", "banana" };
    var distinctStrings = duplicatedStrings.Distinct().ToList();
    Console.WriteLine("Distinct Strings: " + string.Join(", ", distinctStrings));

    // 3. LINQ Over Character Array
    string sampleString = "hello world";
    var distinctChars = sampleString.ToCharArray().Distinct();
    Console.WriteLine("Distinct Characters: " + string.Join(", ", distinctChars));

    // Exercise Set 2: Querying with LINQ

    // 1. Sum with LINQ
    int[] integerArray = { 1, 2, 3, 4, 5 };
    var sum = integerArray.Sum();
    Console.WriteLine("Sum: " + sum);

    // 2. Sorting Array Elements
    string[] stringsToSort = { "banana", "cherry", "apple" };
    var sortedStrings = stringsToSort.OrderByDescending(s => s);
    Console.WriteLine("Sorted Strings: " + string.Join(", ", sortedStrings));

    // Exercise Set 3: Advanced LINQ Operations

    // 1. Finding Maximum with LINQ
    Console.WriteLine("Maximum Value: " + FindMaximum(numbers));

    // 2. Calculating Average
    double[] doubleArray = { 1.5, 2.3, 3.7, 4.6, 5.2 };
    Console.WriteLine("Average Value: " + CalculateAverage(doubleArray));

    // 3. Filtering Based on Condition
    var divisibleByTwo = FilterByCondition(integerArray, 2);
    Console.WriteLine("Divisible by 2: " + string.Join(", ", divisibleByTwo));

    // 4. Aggregating Data
    List<decimal> prices = new List<decimal> { 10.99m, 5.75m, 3.50m, 14.90m };
    Console.WriteLine("Total Price: " + prices.Sum());
    Console.WriteLine("Average Price: " + prices.Average());

    // 5. Grouping and Counting
    List<string> words = new List<string> { "apple", "banana", "apricot", "cherry", "blueberry" };
    var groupedWords = words
        .GroupBy(w => w[0])
        .Select(group => new { Letter = group.Key, Count = group.Count() });

    foreach (var group in groupedWords)
    {
        Console.WriteLine($"Words starting with '{group.Letter}': {group.Count}");
    }
}

static int FindMaximum(List<int> list)
{
    return list.Max();
}

static double CalculateAverage(double[] array)
{
    return array.Average();
}

static List<int> FilterByCondition(int[] array, int divisor)
{
    return array.Where(n => n % divisor == 0).ToList();
}
