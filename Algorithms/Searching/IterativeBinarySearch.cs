namespace Algorithms.Searching;

public class IterativeBinarySearch
{
    public int Search(int[] array, int searchedValue, int left, int right)
    {
        while (left <= right)
        {
            var middle = (left + right) / 2;

            if (searchedValue == array[middle])
                return array[middle];
            
            if (searchedValue < array[middle])
                right = middle - 1;
            else
                left = middle + 1;
        }
        return -1;
    }

}