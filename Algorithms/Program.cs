using Algorithms.Sorts;

string[] array = {"sff", "apple", "banana"};

var sort = new RadixSort();

sort.Sort(array, 0, array.Length - 1, 0, new string[array.Length]);

foreach(var i in array)
{
    Console.Write($"{i} ");
}
