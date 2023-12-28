namespace Algorithms.Sorts;

public class QuickSort
{
    private void Swap(ref int x, ref int y)
    {
        var t = x;
        x = y;
        y = t;
    }
    private int Partition(int[] array, int minIndex, int maxIndex)
    {
        var pivot = minIndex - 1;
        for (int i = minIndex; i < maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                Swap(ref array[pivot], ref array[i]);
            }
        }


        pivot++;
        Swap(ref array[pivot], ref array[maxIndex]);
        return pivot;
    }
    
    //При первом запуске: sort.Sort(array, 0, array.Length - 1);
    public void Sort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
            return;
        
        var pivotIndex = Partition(array, minIndex, maxIndex);
        Sort(array, minIndex, pivotIndex - 1);
        Sort(array, pivotIndex + 1, maxIndex);
    }

}