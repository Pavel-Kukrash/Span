
int[] numbers = new int[]
{
    10, 12, 13, 14, 15, 11, 13, 15, 16, 17,
    18, 16, 15, 16, 17, 14,  9,  8, 10, 11,
    12, 14, 15, 15, 16, 15, 44, 12, 12, 28
};

// array
// we create two additional arrays to store firstFive and lastFive numbers, it leads to additional memory usage
int[] firstFive = new int[5];    
int[] lastFive = new int[5];     
Array.Copy(numbers, 0, firstFive, 0, 5);    
Array.Copy(numbers, 25, lastFive, 0, 5);

Array.ForEach(firstFive, num => Console.Write(num + " ") );
Console.WriteLine("\n -----------");
Array.ForEach(lastFive, num => Console.Write(num + " "));
Console.WriteLine("\n ***********");

// span
// we don't need an additional memory usage

Span<int> numbersSpan = numbers;

Span<int> firstFiveSpan = numbersSpan.Slice(0, 5);    
Span<int> lastFiveSpan = numbersSpan.Slice(25, 5);

foreach(int first in firstFiveSpan) Console.Write(first + " ");
Console.WriteLine("\n -----------");
foreach (int last in lastFiveSpan) Console.Write(last + " ");
Console.WriteLine("\n ***********");

// Additionally Span<T> provides a read-write access to a region of memory

firstFiveSpan[0] = 33; // changing the first element in firstFiveSpan
Console.WriteLine(firstFiveSpan[0]);//33

Console.ReadKey();