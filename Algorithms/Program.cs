using Algorithms.Searching;
using Algorithms.Sorts;

int[] array = {1, 5 ,1 , 2 ,0, -1 , 20 , -194};

QuickSort sort = new QuickSort();

sort.Sort(array, 0, array.Length - 1);

foreach(var i in array)
{
    Console.Write($"{i} ");
}

Console.WriteLine();
var search = new RecursiveBinarySearch();
var result = search.Search(array, -100, 0, array.Length - 1);
Console.WriteLine(result);