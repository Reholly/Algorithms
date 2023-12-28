namespace Algorithms.Sorts;

public class RadixSort
{
    //sort.Sort(array, 0, array.Length - 1, 0, new string[array.Length] в самом начале.
    public void Sort(string[] array, int length, int currentBlockEndSortingIndex, int currentDigit, string[] tempArray)
    {
        if (length >= currentBlockEndSortingIndex)
        {
            return;
        }

        const int maxChar = 256;

        var count = new int[maxChar + 2];

        for (var i = length; i <= currentBlockEndSortingIndex; i++)
        {
            var j = Key(array[i]);
            count[j + 2]++;
        }

        for (var i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }
        
        for (var i = length; i <= currentBlockEndSortingIndex; i++)
        {
            var j = Key(array[i]);
            tempArray[count[j + 1]++] = array[i];
        }

        for (var i = length; i <= currentBlockEndSortingIndex; i++)
        {
            array[i] = tempArray[i - length];
        }


        for (var i = 0; i < maxChar; i++)
        {
            Sort(array, length + count[i], length + count[i + 1] - 1, currentDigit + 1, tempArray);
        }

        int Key(string s)
        {
            var temp = currentDigit >= s.Length ? -1 : s[currentDigit];
            return currentDigit >= s.Length ? -1 : s[currentDigit];
        }
    }
}