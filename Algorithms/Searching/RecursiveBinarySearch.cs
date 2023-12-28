namespace Algorithms.Searching;

public class RecursiveBinarySearch
{
    public int Search(int[] array, int searchedValue, int left, int right)
    {
        //not found. но ообычно если значения нет стек падает ;)
        if (left > right)
            return -1;
        
        var middle = (left + right) / 2;

        if (array[middle] == searchedValue) 
            return array[middle];
        
        if (array[middle] > searchedValue)
            return Search(array, searchedValue, left, middle );
        
        return Search(array, searchedValue, middle + 1, right);
    }
}