int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
foreach (int index in array)

if (index < currentSmallest)
        currentSmallest = array[index];

Console.WriteLine(currentSmallest); 

// for this challenge you only had to modify some code in the book to convert it from a for loop into a foreach loop.