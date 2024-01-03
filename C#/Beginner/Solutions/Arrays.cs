static void Main(string[] args)
{
    // Exercise Set 1: Declaring and Initializing Arrays

    // 1. Create a Number Array
    int[] numberArray = { 10, 20, 30, 40, 50 };

    // 2. Days of the Week
    string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    // 3. Character Array
    char[] charArray = { 'A', 'B', 'C', 'D', 'E' };

    // Exercise Set 2: Looping through Arrays with FOR Loop

    // 1. Sum of Array Elements
    int sum = 0;
    for (int i = 0; i < numberArray.Length; i++)
    {
        sum += numberArray[i];
    }
    Console.WriteLine("Sum of array elements: " + sum);

    // 2. Print in Reverse
    Console.Write("Elements in reverse order: ");
    for (int i = daysOfWeek.Length - 1; i >= 0; i--)
    {
        Console.Write(daysOfWeek[i] + " ");
    }
    Console.WriteLine();

    // Exercise Set 3: Passing Arrays into Methods

    // 1. Find Maximum
    int maxNumber = FindMaximum(numberArray);
    Console.WriteLine("Maximum number: " + maxNumber);

    // 2. Average Value
    double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };
    double average = CalculateAverage(doubleArray);
    Console.WriteLine("Average value: " + average);
}

// Methods for Exercise Set 3

static int FindMaximum(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

static double CalculateAverage(double[] arr)
{
    double sum = 0;
    foreach (double value in arr)
    {
        sum += value;
    }
    return sum / arr.Length;
}
