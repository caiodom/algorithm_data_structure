using SortedArray;

var arrayOps = new SortedArrayOperations(1000000); // Creating a large array with capacity 1 million

// Insertion
for (int i = 0; i < 1000000; i++)
{
    arrayOps.Insert(i * 2); // Inserting even numbers from 0 to 1,999,998
}

// Display the first and last elements of the array
Console.WriteLine($"First element: {arrayOps.LinearSearch(0)}");
Console.WriteLine($"Last element: {arrayOps.LinearSearch(1999998)}");

// Linear search
int searchElement = 1000000;
int linearIndex = arrayOps.LinearSearch(searchElement);
if (linearIndex != -1)
{
    Console.WriteLine($"Element {searchElement} found at position {linearIndex} (Linear Search).");
}
else
{
    Console.WriteLine($"Element {searchElement} not found (Linear Search).");
}

// Binary search
searchElement = 500000;
int binaryIndex = arrayOps.BinarySearch(searchElement);
if (binaryIndex != -1)
{
    Console.WriteLine($"Element {searchElement} found at position {binaryIndex} (Binary Search).");
}
else
{
    Console.WriteLine($"Element {searchElement} not found (Binary Search).");
}

// Measure the execution time of linear and binary searches for a large array
long linearTime = arrayOps.MeasureSearchTime(arrayOps.LinearSearch, 1000000);
long binaryTime = arrayOps.MeasureSearchTime(arrayOps.BinarySearch, 500000);
Console.WriteLine($"Linear Search Time: {linearTime} ms");
Console.WriteLine($"Binary Search Time: {binaryTime} ms");